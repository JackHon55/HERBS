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

        Dim proxyx = 6
        For Each xtype In HERBS.Medicine_type
            Dim xtab As New TabPage With {.Name = xtype & "_page", .Text = xtype & " (0)"}
            Dim xbutt As New Button With {
                .Text = $"    {xtype}{vbCrLf}    (0)",
                .Name = xtype & "_pagebutton",
                .Font = New Font("Microsoft Sans Serif", 10),
                .FlatStyle = FlatStyle.Flat,
                .BackColor = Color.Transparent,
                .ForeColor = Color.White,
                .Tag = xtab,
                .Width = 125,
                .Height = 45,
                .Location = New Point(0, proxyx),
                .BackgroundImage = My.Resources.vial_empty,
                .BackgroundImageLayout = ImageLayout.Stretch
            }
            xbutt.FlatAppearance.BorderSize = 0
            xbutt.FlatAppearance.MouseDownBackColor = Color.Transparent
            xbutt.FlatAppearance.MouseOverBackColor = Color.Transparent
            xtab.BackgroundImage = My.Resources.Table_Rectangle_Wood_Ashen_J_2x1
            xtab.BackgroundImageLayout = ImageLayout.Stretch
            HERBS.BrewingTabs.TabPages.Add(xtab)
            HERBS.ProxyTabButtons_Panel.Controls.Add(xbutt)
            proxyx += 46

            AddHandler xbutt.Click, AddressOf HERBS.ProxyTabButtonClick
            AddHandler xbutt.MouseEnter, AddressOf HERBS.ProxyTabButtonChange
            AddHandler xbutt.MouseLeave, AddressOf HERBS.ProxyTabButtonReset

            Dim xc = 45
            Dim yc = 35

            For Each xlevel In HERBS.Medicine_level
                HERBS.Current_Types.Add(xlevel & "_" & xtype, New Classlib.HerbstoragebyType)
                BrewingPage_Buttons(xtab, xtype, xlevel, xc, yc)
                yc += 45
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
        HERBS.CraftingPanel_Herbval1.Tag = HERBS.HerbIcon_fixed1
        HERBS.CraftingPanel_Herbval2.Tag = HERBS.HerbIcon_fixed2
        HERBS.CraftingPanel_Herbval3.Tag = HERBS.HerbIcon_fixed3
        HERBS.HerbIcon_fixed1.Tag = HERBS.HerbIcon_animated1
        HERBS.HerbIcon_fixed2.Tag = HERBS.HerbIcon_animated2
        HERBS.HerbIcon_fixed3.Tag = HERBS.HerbIcon_animated3

        Dim yy = 35
        Dim xy = 33
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
            yy += 32
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
            .Size = New Size(180, 35),
            .Font = New Font("Microsoft Sans Serif", 9),
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
