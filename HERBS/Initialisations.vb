Imports System.Xml
Imports System.Text.RegularExpressions

Public Class Initialisations
    Public Shared Sub Herb_Initialisation()
        Dim xmldoc As New XmlDocument
        xmldoc.LoadXml(My.Resources.Herbs_library)

        Dim root As XmlNode = xmldoc.DocumentElement

        HERBS.Medicine_type = root.SelectSingleNode("type").InnerText.Split(",")
        HERBS.Medicine_level = root.SelectSingleNode("level").InnerText.Split(",")

        For Each xstep As XmlNode In root.SelectNodes("steps")
            Dim xpotency = xstep.SelectSingleNode("potency").InnerText
            Dim xformula = xstep.SelectSingleNode("formula").InnerText
            Dim tempdict As New Dictionary(Of String, Integer)
            For Each xx In xformula.Split(",")
                tempdict.Add(xx.Split("|")(0), Integer.Parse(xx.Split("|")(1)))
            Next
            HERBS.Medicine_steps.Add(xpotency, tempdict)
        Next

        For Each xtype In HERBS.Medicine_type
            Dim xtab As New TabPage With {.Name = xtype & "_page", .Text = xtype & " (0)"}
            HERBS.BrewingTabs.TabPages.Add(xtab)

            Dim xc = 55
            Dim yc = 20

            For Each xlevel In HERBS.Medicine_level
                HERBS.Current_Types.Add(xlevel & "_" & xtype, New Classlib.HerbstoragebyType)
                BrewingPage_Buttons(xtab, xtype, xlevel, xc, yc)
                yc += 27
            Next
        Next

        For Each xherb As XmlNode In root.SelectNodes("herb")
            Dim xname = xherb.SelectSingleNode("name").InnerText
            Dim xpotency = xherb.SelectSingleNode("potency").InnerText
            Dim xtype = xherb.SelectSingleNode("medtype").InnerText
            HERBS.Herb_library.Add(xname, New Classlib.Herb_type With {.type = xtype, .potency = xpotency})
        Next

        HERBS.Crafting_labels.Add(HERBS.CraftingPanel_Herb1)
        HERBS.Crafting_labels.Add(HERBS.CraftingPanel_Herb2)
        HERBS.Crafting_labels.Add(HERBS.CraftingPanel_Herb3)
        HERBS.Crafting_vals.Add(HERBS.CraftingPanel_Herbval1)
        HERBS.Crafting_vals.Add(HERBS.CraftingPanel_Herbval2)
        HERBS.Crafting_vals.Add(HERBS.CraftingPanel_Herbval3)

        Dim yy = 20
        Dim xy = 25
        For Each xlevel In HERBS.Medicine_level
            Dim craftinglevel As New Button With {
                .Text = $"{xlevel.Substring(0, 1)}",
                .Name = $"{xlevel}_Herbs_button",
                .Font = New Font("Microsoft Sans Serif", 11),
                .Size = New Size(30, 30),
                .Location = New Point(xy, yy),
                .Enabled = False
            }
            HERBS.CraftingPanel.Controls.Add(craftinglevel)
            HERBS.Crafting_levels.Add(craftinglevel)
            AddHandler craftinglevel.Click, AddressOf HERBS.CraftingLevel_to_HerbSelect
            If yy > 30 Then
                yy = 20
                xy += 32
            Else
                yy += 30
            End If
        Next
    End Sub

    Public Shared Sub Herb_Inventory(xherbs As List(Of String))
        For Each xherb In xherbs
            Dim xname = xherb.Split("(")(0)
            Dim xquantity = xherb.Split("(")(1).Replace(")", "")
            Dim current_herb = HERBS.Herb_library(xname)

            Dim xitem As New ListViewItem With {.Text = xname}
            xitem.SubItems.Add(xquantity)
            xitem.SubItems.Add(current_herb.type)
            xitem.SubItems.Add(current_herb.potency)

            HERBS.HerbList.Items.Add(xitem)
            HERBS.Current_Herbs.Add(xname, xquantity)

            For Each xtype In HERBS.Medicine_type
                If current_herb.Type_checker(xtype) Then
                    Dim oldval As Integer = HERBS.Current_Types(current_herb.potency & "_" & xtype).typeamount
                    oldval += xquantity
                    HERBS.Current_Types(current_herb.potency & "_" & xtype).typeamount = oldval
                    HERBS.Current_Types(current_herb.potency & "_" & xtype).herbamount.Add($"{xname}")
                End If
            Next
        Next
    End Sub


    Public Shared Sub BrewingPage_Buttons(xtab As TabPage, xtype As String, xlevel As String, xc As Integer, yc As Integer)
        Dim newbutton As New Button With {
            .Text = $"{xlevel} {xtype}",
            .Name = $"{xlevel}_{xtype}_button",
            .Size = New Size(220, 25),
            .Location = New Point(xc, yc)
        }
        xtab.Controls.Add(newbutton)
        HERBS.Brewing_buttons.Add(newbutton)
        AddHandler newbutton.Click, AddressOf HERBS.BrewingButton_to_Crafting
    End Sub

    Public Shared Sub Medicine_Initialisation()
        Dim xmldoc As New XmlDocument
        xmldoc.LoadXml(My.Resources.Medicine_library)

        Dim root As XmlNode = xmldoc.DocumentElement
        HERBS.Medicine_stacksize = root.SelectSingleNode("stacksize").InnerText

        For Each xmedicine As XmlNode In root.SelectNodes("medicines")
            Dim xtype = xmedicine.SelectSingleNode("type").InnerText
            Dim xinfo = xmedicine.SelectSingleNode("info").InnerText
            Dim xeffect = xmedicine.SelectSingleNode("effect").InnerText
            HERBS.Medicine_library.Add(xtype, New Classlib.Medicine_info With {
                .info = xinfo,
                .effect = xeffect
            })
        Next
    End Sub
End Class
