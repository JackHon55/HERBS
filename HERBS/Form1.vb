Imports System.Text.RegularExpressions
Imports System.IO

Public Class HERBS
    Public Medicine_type As String()
    Public Medicine_level As String()
    Public Medicine_steps As New Dictionary(Of String, Dictionary(Of String, Integer))
    Public Herb_library As New Dictionary(Of String, Classlib.Herb_type)
    Public Medicine_library As New Dictionary(Of String, Classlib.Medicine_info)
    Public Current_Herbs As New Dictionary(Of String, Integer)
    Public Temp_Herbs As New Dictionary(Of String, Integer)
    Public Current_Types As New Dictionary(Of String, Classlib.HerbstoragebyType)
    Public Temp_Types As New Dictionary(Of String, Classlib.HerbstoragebyType)
    Public Possible_Medicine_Recipe As New Dictionary(Of String, Classlib.CraftableMedicines)
    Public Temp_Medicine_Recipe As New Dictionary(Of String, Classlib.CraftableMedicines)
    Public Brewing_buttons As New List(Of Button)
    Public Crafting_labels As New List(Of Label)
    Public Crafting_vals As New List(Of NumericUpDown)
    Public Crafting_levels As New List(Of Button)
    Public Crafted_Medicine_box As New List(Of Classlib.Medicine_box)
    Public Medicine_stacksize As Integer = 0
    Public Shared Currently_crafting As String = ""
    Public save_file As String = ""
    Public LastExistingBox As Integer = 0

    Private Sub HERBS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args As String() = Environment.GetCommandLineArgs()
        If args.Count < 2 Then
            save_file = Application.StartupPath & "\dnd_stat.txt"
        Else
            save_file = args(1)
        End If

        Initialisations.Herb_Initialisation()

        Dim xcontent As String = ""
        Using reader As New System.IO.StreamReader(save_file)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                If line.StartsWith("HERBS") Then
                    xcontent = line.Split("|")(1)
                End If
                If line.StartsWith("Medicine Box") Then
                    LastExistingBox += 1
                End If
            End While
        End Using

        Dim pattern As String = "#(.*?)#"
        Dim regex As New Regex(pattern)
        Dim matches As MatchCollection = regex.Matches(xcontent)
        Dim xherbs As New List(Of String)
        For Each xstring In matches(0).Groups(1).Value.Split("^")
            If xstring <> "" Then
                xherbs.Add(xstring)
            End If
        Next


        Initialisations.Herb_Inventory(xherbs)
        Possible_Medicine_Recipe.Clear()
        Possible_Medicine_Recipe = Possible_Recipe_Calculator(Current_Types)
        PossibleMedicine_to_TabCounter()
        PossibleMedicine_to_PageButtonCounter()
        Initialisations.Medicine_Initialisation()
        Crafted_Medicine_box.Add(New Classlib.Medicine_box)
    End Sub

    Public Function Possible_Recipe_Calculator(Type_list As Dictionary(Of String, Classlib.HerbstoragebyType))
        Dim recipe_book As New Dictionary(Of String, Classlib.CraftableMedicines)
        For Each xobj In Type_list
            If xobj.Value.typeamount = 0 Then
                Continue For
            End If
            Dim potency = xobj.Key.Split("_")(0)
            For Each xstep In Medicine_steps(potency)
                Dim craftable_amount = Math.Floor(xobj.Value.typeamount / xstep.Value)
                If craftable_amount > 0 Then
                    Dim crafted_potency = xstep.Key
                    Dim crafted_type = xobj.Key.Split("_")(1)
                    Dim craftable_herbs = String.Join(",", xobj.Value.herbamount)

                    If recipe_book.Keys.Contains($"{crafted_potency} {crafted_type}") Then
                        recipe_book($"{crafted_potency} {crafted_type}").craftable_amount += craftable_amount
                        recipe_book($"{crafted_potency} {crafted_type}").Herbrecipe(potency).Add(craftable_herbs)
                    Else
                        Dim xx As New Classlib.CraftableMedicines With {
                        .craftable_amount = craftable_amount
                        }
                        xx.Herbrecipe(potency).Add(craftable_herbs)
                        recipe_book.Add($"{crafted_potency} {crafted_type}", xx)
                    End If
                End If
            Next
        Next
        Return recipe_book

    End Function

    Public Sub PossibleMedicine_to_TabCounter()
        For Each xmedicine In Medicine_type
            Dim xtab As TabPage = Me.Controls.Find($"{xmedicine}_page", True).FirstOrDefault
            Dim xcount = 0
            Dim medicine_key = Possible_Medicine_Recipe.Where(Function(pair) pair.Key.Contains(xmedicine)).Select(Function(pair) pair.Value)
            For Each xkey In medicine_key
                xcount += xkey.craftable_amount
            Next
            xtab.Text = $"{xmedicine} ({xcount})"
        Next
    End Sub

    Public Sub PossibleMedicine_to_PageButtonCounter()
        For Each xmedicine In Medicine_type
            For Each xlevel In Medicine_level
                Dim xbutton As Button = BrewingTabs.Controls.Find($"{xlevel}_{xmedicine}_button", True).FirstOrDefault
                If Not Possible_Medicine_Recipe.Keys.Contains($"{xlevel} {xmedicine}") Then
                    xbutton.Text = $"{xlevel} {xmedicine} (0)"
                    Continue For
                End If
                Dim xcount = Possible_Medicine_Recipe($"{xlevel} {xmedicine}").craftable_amount
                xbutton.Text = $"{xlevel} {xmedicine} ({xcount})"
            Next
        Next
    End Sub

    Public Shared Sub BrewingButton_to_Crafting(sender As Button, e As EventArgs)
        HerbSelect_Hide()
        CraftingLevels_Hide()
        If sender.Text.Split("(")(1).Replace(")", "") = "0" Or sender.BackColor <> SystemColors.Control Then
            sender.BackColor = SystemColors.Control
            Exit Sub
        End If

        For Each xobj In HERBS.Brewing_buttons
            xobj.BackColor = SystemColors.Control
        Next
        sender.BackColor = Color.LightGreen

        Dim potency = sender.Name.Split("_")(0)
        Dim xtype = sender.Name.Split("_")(1)
        Dim xrecipe = HERBS.Possible_Medicine_Recipe($"{potency} {xtype}")
        For Each craftable_level In xrecipe.Herbrecipe
            Dim xbutton = HERBS.CraftingPanel.Controls.Find($"{craftable_level.Key}_Herbs_button", False).FirstOrDefault
            If craftable_level.Value.Count = 0 Then
                xbutton.Enabled = False
                xbutton.Tag = ""
                Continue For
            End If
            xbutton.Enabled = True
            xbutton.Tag = String.Join(",", craftable_level.Value)
        Next
    End Sub

    Public Shared Sub CraftingLevel_to_HerbSelect(sender As Button, e As EventArgs)
        If sender.BackColor <> SystemColors.Control Then
            sender.BackColor = SystemColors.Control
            HerbSelect_Hide()
            Exit Sub
        End If
        For Each xobj In HERBS.Crafting_levels
            xobj.BackColor = SystemColors.Control
        Next
        sender.BackColor = Color.LightGreen

        Dim crafting_herbs As New List(Of String)
        For Each xstring In sender.Tag.Split(",")
            crafting_herbs.Add(xstring)
        Next

        HerbSelect_Hide()

        Dim herb_for_crafting = 0
        For i As Integer = 0 To crafting_herbs.Count - 1
            Dim herbname = crafting_herbs(i)
            Dim herbamount = HERBS.Current_Herbs(herbname)
            HERBS.Crafting_labels(i).Visible = True
            HERBS.Crafting_vals(i).Visible = True
            HERBS.Crafting_labels(i).Text = herbname
            HERBS.Crafting_vals(i).Maximum = herbamount
            herb_for_crafting += 1
        Next

        Dim crafting_potency = ""
        For Each xobj In HERBS.BrewingTabs.SelectedTab.Controls
            If xobj.BackColor = Color.LightGreen Then
                crafting_potency = xobj.Name.Split("_")(0)
            End If
        Next

        Dim herb_potency = sender.Name.Split("_")(0)
        HERBS.HerbSelect_label.Text = $"Choose {HERBS.Medicine_steps(herb_potency)(crafting_potency)} to make 1 Medicine"
        HERBS.HerbSelect_label.Tag = HERBS.Medicine_steps(herb_potency)(crafting_potency)

        If herb_for_crafting = 1 Then
            HERBS.Crafting_vals(0).Value = HERBS.Medicine_steps(herb_potency)(crafting_potency)
        End If
    End Sub

    Public Shared Sub HerbSelect_Hide()
        For i As Integer = 0 To HERBS.Crafting_labels.Count - 1
            HERBS.Crafting_labels(i).Visible = False
            HERBS.Crafting_vals(i).Visible = False
            HERBS.Crafting_vals(i).Maximum = 100
            HERBS.Crafting_vals(i).Value = 0
            HERBS.HerbSelect_label.Text = "Choose"
            HERBS.HerbSelect_label.Tag = 0
        Next
    End Sub

    Public Shared Sub CraftingLevels_Hide()
        For Each xobj In HERBS.Crafting_levels
            xobj.BackColor = SystemColors.Control
            xobj.Enabled = False
            xobj.Tag = ""
        Next
    End Sub

    Private Sub BrewingTabs_Selected(sender As Object, e As TabControlEventArgs) Handles BrewingTabs.Selected
        For Each xobj In Brewing_buttons
            xobj.BackColor = SystemColors.Control
        Next
        CraftingLevels_Hide()
        HerbSelect_Hide()
    End Sub

    Private Sub CraftConfirm_button_Click(sender As Object, e As EventArgs) Handles CraftConfirm_button.Click
        Dim medicine_to_craft = ""
        For Each xobj In BrewingTabs.SelectedTab.Controls
            If xobj.BackColor = Color.LightGreen Then
                medicine_to_craft = xobj.Text.Split("(")(0)
            End If
        Next

        Dim number_to_craft = sender.Tag
        sender.Tag = 0

        For i As Integer = 1 To number_to_craft
            If Crafted_Medicine_box(Crafted_Medicine_box.Count - 1).RemainingSlots = 0 Then
                Crafted_Medicine_box.Add(New Classlib.Medicine_box)
            End If

            If Crafted_Medicine_box(Crafted_Medicine_box.Count - 1).current_medicines.Keys.Contains(medicine_to_craft) Then
                Crafted_Medicine_box(Crafted_Medicine_box.Count - 1).current_medicines(medicine_to_craft) += 1
            Else
                Crafted_Medicine_box(Crafted_Medicine_box.Count - 1).current_medicines.Add(medicine_to_craft, 1)
            End If
        Next

        Dim xtemp1 As New Dictionary(Of String, Integer)(Temp_Herbs)
        Dim xtemp2 As New Dictionary(Of String, Classlib.HerbstoragebyType)(Temp_Types)
        Current_Herbs = xtemp1
        Current_Types = xtemp2

        HerbList.Items.Clear()
        For Each xherb In Current_Herbs
            Dim xname = xherb.Key
            Dim xquantity = xherb.Value
            Dim current_herb = Herb_library(xname)

            Dim xitem As New ListViewItem With {.Text = xname}
            xitem.SubItems.Add(xquantity)
            xitem.SubItems.Add(current_herb.type)
            xitem.SubItems.Add(current_herb.potency)

            HerbList.Items.Add(xitem)
        Next

        Possible_Medicine_Recipe = Possible_Recipe_Calculator(Temp_Types)
        PossibleMedicine_to_TabCounter()
        PossibleMedicine_to_PageButtonCounter()

        For Each xobj In Brewing_buttons
            xobj.BackColor = SystemColors.Control
        Next
        CraftingLevels_Hide()
        HerbSelect_Hide()


        CraftedMedicine_List.Items.Clear()
        Dim box_count = 0
        For Each xobj In Crafted_Medicine_box
            box_count += 1
            CraftedMedicine_List.Items.Add($"Medicine Box({box_count})")
            For Each xlist In xobj.current_medicines
                CraftedMedicine_List.Items.Add($"{xlist.Value}x {xlist.Key}")
            Next
        Next
        sender.Enabled = False
        sender.Text = "Craft!"
    End Sub

    Private Sub CraftConfirm_button_MouseEnter(sender As Button, e As EventArgs) Handles CraftConfirm_button.MouseEnter
        Temp_Herbs.Clear()
        Temp_Medicine_Recipe.Clear()
        Temp_Types.Clear()

        Dim xtemp1 As New Dictionary(Of String, Integer)(Current_Herbs)
        Dim xtemp2 As New Dictionary(Of String, Classlib.HerbstoragebyType)(Current_Types)
        Temp_Herbs = xtemp1
        Temp_Types = xtemp2
        For Each xobj In Temp_Types
            xobj.Value.typeamount = 0
            xobj.Value.herbamount.Clear()
        Next

        For i As Integer = 0 To Crafting_labels.Count - 1
            If Crafting_labels(i).Visible = False Then
                Continue For
            End If
            Dim herb_used = Crafting_labels(i).Text
            Dim amount_used = Crafting_vals(i).Value
            Temp_Herbs(herb_used) -= amount_used
        Next

        For Each xherb In Temp_Herbs
            Dim current_herb = Herb_library(xherb.Key)
            For Each xtype In Medicine_type
                If current_herb.Type_checker(xtype) Then
                    Dim oldval As Integer = Temp_Types(current_herb.potency & "_" & xtype).typeamount
                    oldval += xherb.Value
                    Temp_Types(current_herb.potency & "_" & xtype).typeamount = oldval
                    Temp_Types(current_herb.potency & "_" & xtype).herbamount.Add($"{xherb.Key}")
                End If
            Next
        Next

        Temp_Medicine_Recipe = Possible_Recipe_Calculator(Temp_Types)
        UpdatedMedicine_to_TabCounter()
        UpdatedMedicine_to_PageButtonCounter()

    End Sub

    Public Sub UpdatedMedicine_to_TabCounter()
        For Each xmedicine In Medicine_type
            Dim xtab As TabPage = Me.Controls.Find($"{xmedicine}_page", True).FirstOrDefault
            Dim xcount = 0
            Dim xcraft = 0
            Dim medicine_key = Possible_Medicine_Recipe.Where(Function(pair) pair.Key.Contains(xmedicine)).Select(Function(pair) pair.Value)
            Dim crafted_key = Temp_Medicine_Recipe.Where(Function(pair) pair.Key.Contains(xmedicine)).Select(Function(pair) pair.Value)
            For Each xkey In medicine_key
                xcount += xkey.craftable_amount
            Next
            For Each xkey In crafted_key
                xcraft += xkey.craftable_amount
            Next
            xtab.Text = $"{xmedicine} ({xcount}>{xcraft})"
        Next
    End Sub

    Public Sub UpdatedMedicine_to_PageButtonCounter()
        For Each xmedicine In Medicine_type
            For Each xlevel In Medicine_level
                Dim xbutton As Button = BrewingTabs.Controls.Find($"{xlevel}_{xmedicine}_button", True).FirstOrDefault
                If Not Possible_Medicine_Recipe.Keys.Contains($"{xlevel} {xmedicine}") Then
                    xbutton.Text = $"{xlevel} {xmedicine} (0)"
                    Continue For
                End If
                Dim xcount = Possible_Medicine_Recipe($"{xlevel} {xmedicine}").craftable_amount
                Dim xcraft = 0
                Try
                    xcraft = Temp_Medicine_Recipe($"{xlevel} {xmedicine}").craftable_amount
                Catch ex As Exception

                End Try

                xbutton.Text = $"{xlevel} {xmedicine} ({xcount}>{xcraft})"
            Next
        Next
    End Sub

    Private Sub CraftConfirm_button_MouseLeave(sender As Object, e As EventArgs) Handles CraftConfirm_button.MouseLeave
        PossibleMedicine_to_TabCounter()
        PossibleMedicine_to_PageButtonCounter()
    End Sub

    Private Sub CraftingPanel_HerbvalChanged(sender As Object, e As EventArgs) Handles CraftingPanel_Herbval3.ValueChanged, CraftingPanel_Herbval2.ValueChanged, CraftingPanel_Herbval1.ValueChanged
        Dim sumherb = 0
        For Each xval In Crafting_vals
            If xval.Visible = True Then
                sumherb += xval.Value
            End If
        Next
        Dim reqherb = HerbSelect_label.Tag
        If sumherb = reqherb OrElse sumherb Mod reqherb = 0 Then
            CraftConfirm_button.Enabled = True
            CraftConfirm_button.Text = $"Craft x{sumherb / reqherb}!"
            CraftConfirm_button.Tag = sumherb / reqherb
        Else
            CraftConfirm_button.Enabled = False
            CraftConfirm_button.Text = $"Craft!"
            CraftConfirm_button.Tag = 0
        End If
    End Sub

    Public Function MedicineBoxes_to_Vortex()
        Dim finallist As New List(Of String)
        Dim box_count = LastExistingBox
        For Each xbox In Crafted_Medicine_box
            box_count += 1
            Dim slottext As New List(Of String)
            For Each xmedicine In xbox.current_medicines
                slottext.Add($"{xmedicine.Value}x {xmedicine.Key}")
            Next
            finallist.Add($"Medicine Box({box_count}):|{String.Join("^", slottext)}|-32640")
        Next

        Return finallist
    End Function

    Private Sub CloseHERBS_button_Click(sender As Object, e As EventArgs) Handles CloseHERBS_button.Click
        If save_file = "" Then
            Me.Close()
            Exit Sub
        End If

        Dim xcontent As String = ""
        Dim filelines As New List(Of String)
        Using reader As New System.IO.StreamReader(save_file)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                filelines.Add(line)
                If line.StartsWith("HERBS") Then
                    xcontent = line
                End If
            End While
        End Using

        Dim updated_herbinventory As New List(Of String)
        For Each xobj In Current_Herbs
            updated_herbinventory.Add($"{xobj.Key}({xobj.Value})")
        Next

        Dim pattern As String = "#(.*?)#"
        Dim regex As New Regex(pattern)
        Dim matches As MatchCollection = regex.Matches(xcontent)
        xcontent = xcontent.Replace(matches(0).Groups(1).Value, "^" & String.Join("^", updated_herbinventory) & "^")

        Dim newmedicine_count = 0
        Dim newmedicines_forVortex As New List(Of String)
        Dim newlist = MedicineBoxes_to_Vortex()
        newmedicines_forVortex.AddRange(newlist)
        newmedicine_count += newlist.Count

        Dim updated_lines As New List(Of String)
        For Each xline In filelines
            If xline.StartsWith("HERBS") Then
                updated_lines.Add(xcontent)
                updated_lines.AddRange(newmedicines_forVortex)
            ElseIf xline.StartsWith("##EquipmentSlot-") Then
                Dim oldval = Integer.Parse(xline.Replace("##EquipmentSlot-", ""))
                updated_lines.Add($"##EquipmentSlot-{oldval + newmedicine_count}")
            Else
                updated_lines.Add(xline)
            End If
        Next
        File.WriteAllLines(save_file, updated_lines)
        Me.Close()
    End Sub
End Class
