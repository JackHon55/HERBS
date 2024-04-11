<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HERBS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BrewingTabs = New System.Windows.Forms.TabControl()
        Me.HerbList = New System.Windows.Forms.ListView()
        Me.HerbList_herbs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HerbList_quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HerbList_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HerbList_potency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CraftingPanel = New System.Windows.Forms.Panel()
        Me.HerbSelect_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CraftingPanel_Herbval3 = New System.Windows.Forms.NumericUpDown()
        Me.CraftingPanel_Herbval2 = New System.Windows.Forms.NumericUpDown()
        Me.CraftingPanel_Herbval1 = New System.Windows.Forms.NumericUpDown()
        Me.CraftingPanel_Herb3 = New System.Windows.Forms.Label()
        Me.CraftingPanel_Herb2 = New System.Windows.Forms.Label()
        Me.CraftingPanel_Herb1 = New System.Windows.Forms.Label()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.CraftConfirm_button = New System.Windows.Forms.Button()
        Me.CraftedMedicine_List = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseHERBS_button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.CraftingPanel.SuspendLayout()
        CType(Me.CraftingPanel_Herbval3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CraftingPanel_Herbval2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CraftingPanel_Herbval1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnimationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.5814!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.39535!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.02325!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BrewingTabs, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HerbList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CraftingPanel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AnimationPanel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CraftedMedicine_List, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CloseHERBS_button, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.2415!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.678!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.25939!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(859, 590)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(620, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Crafted Medicine"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Medicine and Availability"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BrewingTabs
        '
        Me.BrewingTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.BrewingTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrewingTabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewingTabs.Location = New System.Drawing.Point(308, 34)
        Me.BrewingTabs.Multiline = True
        Me.BrewingTabs.Name = "BrewingTabs"
        Me.BrewingTabs.Padding = New System.Drawing.Point(6, 1)
        Me.BrewingTabs.SelectedIndex = 0
        Me.BrewingTabs.Size = New System.Drawing.Size(306, 190)
        Me.BrewingTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.BrewingTabs.TabIndex = 0
        '
        'HerbList
        '
        Me.HerbList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HerbList_herbs, Me.HerbList_quantity, Me.HerbList_type, Me.HerbList_potency})
        Me.HerbList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HerbList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbList.HideSelection = False
        Me.HerbList.Location = New System.Drawing.Point(3, 34)
        Me.HerbList.Name = "HerbList"
        Me.TableLayoutPanel1.SetRowSpan(Me.HerbList, 2)
        Me.HerbList.Size = New System.Drawing.Size(299, 299)
        Me.HerbList.TabIndex = 1
        Me.HerbList.UseCompatibleStateImageBehavior = False
        Me.HerbList.View = System.Windows.Forms.View.Details
        '
        'HerbList_herbs
        '
        Me.HerbList_herbs.Text = "Herbs"
        Me.HerbList_herbs.Width = 76
        '
        'HerbList_quantity
        '
        Me.HerbList_quantity.Text = "#"
        Me.HerbList_quantity.Width = 26
        '
        'HerbList_type
        '
        Me.HerbList_type.Text = "Type"
        Me.HerbList_type.Width = 115
        '
        'HerbList_potency
        '
        Me.HerbList_potency.Text = "Potency"
        Me.HerbList_potency.Width = 65
        '
        'CraftingPanel
        '
        Me.CraftingPanel.BackColor = System.Drawing.SystemColors.Control
        Me.CraftingPanel.Controls.Add(Me.HerbSelect_label)
        Me.CraftingPanel.Controls.Add(Me.Label1)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herbval3)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herbval2)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herbval1)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herb3)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herb2)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herb1)
        Me.CraftingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CraftingPanel.Location = New System.Drawing.Point(308, 230)
        Me.CraftingPanel.Name = "CraftingPanel"
        Me.CraftingPanel.Size = New System.Drawing.Size(306, 103)
        Me.CraftingPanel.TabIndex = 2
        '
        'HerbSelect_label
        '
        Me.HerbSelect_label.AutoSize = True
        Me.HerbSelect_label.Location = New System.Drawing.Point(159, 0)
        Me.HerbSelect_label.Name = "HerbSelect_label"
        Me.HerbSelect_label.Size = New System.Drawing.Size(43, 13)
        Me.HerbSelect_label.TabIndex = 7
        Me.HerbSelect_label.Text = "Choose"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "With Herbs of"
        '
        'CraftingPanel_Herbval3
        '
        Me.CraftingPanel_Herbval3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herbval3.Location = New System.Drawing.Point(227, 70)
        Me.CraftingPanel_Herbval3.Name = "CraftingPanel_Herbval3"
        Me.CraftingPanel_Herbval3.Size = New System.Drawing.Size(61, 21)
        Me.CraftingPanel_Herbval3.TabIndex = 5
        Me.CraftingPanel_Herbval3.Visible = False
        '
        'CraftingPanel_Herbval2
        '
        Me.CraftingPanel_Herbval2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herbval2.Location = New System.Drawing.Point(227, 46)
        Me.CraftingPanel_Herbval2.Name = "CraftingPanel_Herbval2"
        Me.CraftingPanel_Herbval2.Size = New System.Drawing.Size(61, 21)
        Me.CraftingPanel_Herbval2.TabIndex = 4
        Me.CraftingPanel_Herbval2.Visible = False
        '
        'CraftingPanel_Herbval1
        '
        Me.CraftingPanel_Herbval1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herbval1.Location = New System.Drawing.Point(227, 21)
        Me.CraftingPanel_Herbval1.Name = "CraftingPanel_Herbval1"
        Me.CraftingPanel_Herbval1.Size = New System.Drawing.Size(61, 21)
        Me.CraftingPanel_Herbval1.TabIndex = 3
        Me.CraftingPanel_Herbval1.Visible = False
        '
        'CraftingPanel_Herb3
        '
        Me.CraftingPanel_Herb3.AutoSize = True
        Me.CraftingPanel_Herb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herb3.Location = New System.Drawing.Point(159, 72)
        Me.CraftingPanel_Herb3.Name = "CraftingPanel_Herb3"
        Me.CraftingPanel_Herb3.Size = New System.Drawing.Size(45, 15)
        Me.CraftingPanel_Herb3.TabIndex = 2
        Me.CraftingPanel_Herb3.Text = "Label3"
        Me.CraftingPanel_Herb3.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CraftingPanel_Herb3.Visible = False
        '
        'CraftingPanel_Herb2
        '
        Me.CraftingPanel_Herb2.AutoSize = True
        Me.CraftingPanel_Herb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herb2.Location = New System.Drawing.Point(159, 48)
        Me.CraftingPanel_Herb2.Name = "CraftingPanel_Herb2"
        Me.CraftingPanel_Herb2.Size = New System.Drawing.Size(45, 15)
        Me.CraftingPanel_Herb2.TabIndex = 1
        Me.CraftingPanel_Herb2.Text = "Label2"
        Me.CraftingPanel_Herb2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CraftingPanel_Herb2.Visible = False
        '
        'CraftingPanel_Herb1
        '
        Me.CraftingPanel_Herb1.AutoSize = True
        Me.CraftingPanel_Herb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herb1.Location = New System.Drawing.Point(159, 23)
        Me.CraftingPanel_Herb1.Name = "CraftingPanel_Herb1"
        Me.CraftingPanel_Herb1.Size = New System.Drawing.Size(45, 15)
        Me.CraftingPanel_Herb1.TabIndex = 0
        Me.CraftingPanel_Herb1.Text = "Label1"
        Me.CraftingPanel_Herb1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CraftingPanel_Herb1.Visible = False
        '
        'AnimationPanel
        '
        Me.AnimationPanel.Controls.Add(Me.CraftConfirm_button)
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(308, 339)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(306, 248)
        Me.AnimationPanel.TabIndex = 3
        '
        'CraftConfirm_button
        '
        Me.CraftConfirm_button.Enabled = False
        Me.CraftConfirm_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftConfirm_button.Location = New System.Drawing.Point(104, 27)
        Me.CraftConfirm_button.Name = "CraftConfirm_button"
        Me.CraftConfirm_button.Size = New System.Drawing.Size(100, 34)
        Me.CraftConfirm_button.TabIndex = 0
        Me.CraftConfirm_button.Text = "Craft!"
        Me.CraftConfirm_button.UseVisualStyleBackColor = True
        '
        'CraftedMedicine_List
        '
        Me.CraftedMedicine_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CraftedMedicine_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftedMedicine_List.FormattingEnabled = True
        Me.CraftedMedicine_List.ItemHeight = 20
        Me.CraftedMedicine_List.Location = New System.Drawing.Point(620, 34)
        Me.CraftedMedicine_List.Name = "CraftedMedicine_List"
        Me.CraftedMedicine_List.Size = New System.Drawing.Size(236, 190)
        Me.CraftedMedicine_List.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Herb Inventory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseHERBS_button
        '
        Me.CloseHERBS_button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CloseHERBS_button.Location = New System.Drawing.Point(700, 230)
        Me.CloseHERBS_button.Name = "CloseHERBS_button"
        Me.CloseHERBS_button.Size = New System.Drawing.Size(75, 23)
        Me.CloseHERBS_button.TabIndex = 8
        Me.CloseHERBS_button.Text = "Done"
        Me.CloseHERBS_button.UseVisualStyleBackColor = True
        '
        'HERBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 590)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "HERBS"
        Me.Text = "HERBS"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.CraftingPanel.ResumeLayout(False)
        Me.CraftingPanel.PerformLayout()
        CType(Me.CraftingPanel_Herbval3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CraftingPanel_Herbval2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CraftingPanel_Herbval1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnimationPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BrewingTabs As TabControl
    Friend WithEvents HerbList As ListView
    Friend WithEvents HerbList_herbs As ColumnHeader
    Friend WithEvents HerbList_quantity As ColumnHeader
    Friend WithEvents HerbList_type As ColumnHeader
    Friend WithEvents HerbList_potency As ColumnHeader
    Friend WithEvents CraftingPanel As Panel
    Friend WithEvents CraftingPanel_Herbval3 As NumericUpDown
    Friend WithEvents CraftingPanel_Herbval2 As NumericUpDown
    Friend WithEvents CraftingPanel_Herbval1 As NumericUpDown
    Friend WithEvents CraftingPanel_Herb3 As Label
    Friend WithEvents CraftingPanel_Herb2 As Label
    Friend WithEvents CraftingPanel_Herb1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents CraftConfirm_button As Button
    Friend WithEvents CraftedMedicine_List As ListBox
    Friend WithEvents HerbSelect_label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CloseHERBS_button As Button
End Class
