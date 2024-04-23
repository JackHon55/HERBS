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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HerbList = New System.Windows.Forms.ListView()
        Me.HerbList_herbs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HerbList_quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HerbList_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HerbList_potency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.Fail_button3 = New System.Windows.Forms.Button()
        Me.Pass_button3 = New System.Windows.Forms.Button()
        Me.Fail_button4 = New System.Windows.Forms.Button()
        Me.Pass_button4 = New System.Windows.Forms.Button()
        Me.Fail_button2 = New System.Windows.Forms.Button()
        Me.Pass_button2 = New System.Windows.Forms.Button()
        Me.CaldronText = New System.Windows.Forms.Label()
        Me.CaldronVial4 = New System.Windows.Forms.PictureBox()
        Me.CaldronVial3 = New System.Windows.Forms.PictureBox()
        Me.CaldronVial2 = New System.Windows.Forms.PictureBox()
        Me.CaldronVial1 = New System.Windows.Forms.PictureBox()
        Me.Fail_button1 = New System.Windows.Forms.Button()
        Me.Pass_button1 = New System.Windows.Forms.Button()
        Me.CraftingPanel = New System.Windows.Forms.Panel()
        Me.HerbSelect_label = New System.Windows.Forms.Label()
        Me.CraftConfirm_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CraftingPanel_Herbval3 = New System.Windows.Forms.NumericUpDown()
        Me.CraftingPanel_Herbval2 = New System.Windows.Forms.NumericUpDown()
        Me.CraftingPanel_Herbval1 = New System.Windows.Forms.NumericUpDown()
        Me.CraftingPanel_Herb3 = New System.Windows.Forms.Label()
        Me.CraftingPanel_Herb2 = New System.Windows.Forms.Label()
        Me.CraftingPanel_Herb1 = New System.Windows.Forms.Label()
        Me.CraftedMedicine_List = New System.Windows.Forms.ListBox()
        Me.CloseHERBS_button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProxyTabButtons_Panel = New System.Windows.Forms.Panel()
        Me.BrewingTabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HerbIcon_fixed1 = New System.Windows.Forms.Button()
        Me.HerbIcon_animated1 = New System.Windows.Forms.Button()
        Me.HerbIcon_fixed2 = New System.Windows.Forms.Button()
        Me.HerbIcon_fixed3 = New System.Windows.Forms.Button()
        Me.HerbIcon_animated2 = New System.Windows.Forms.Button()
        Me.HerbIcon_animated3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.AnimationPanel.SuspendLayout()
        CType(Me.CaldronVial4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaldronVial3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaldronVial2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaldronVial1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CraftingPanel.SuspendLayout()
        CType(Me.CraftingPanel_Herbval3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CraftingPanel_Herbval2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CraftingPanel_Herbval1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.BrewingTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.HERBS.My.Resources.Resources.ForestPathVol6Public
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.10145!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.89855!))
        Me.TableLayoutPanel1.Controls.Add(Me.HerbList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AnimationPanel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CraftedMedicine_List, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CloseHERBS_button, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.78689!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.21312!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(734, 786)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'HerbList
        '
        Me.HerbList.BackColor = System.Drawing.Color.PeachPuff
        Me.HerbList.BackgroundImage = Global.HERBS.My.Resources.Resources.ForestBackDrop_Controls
        Me.HerbList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HerbList_herbs, Me.HerbList_quantity, Me.HerbList_type, Me.HerbList_potency})
        Me.HerbList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HerbList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbList.HideSelection = False
        Me.HerbList.Location = New System.Drawing.Point(3, 46)
        Me.HerbList.Name = "HerbList"
        Me.TableLayoutPanel1.SetRowSpan(Me.HerbList, 2)
        Me.HerbList.Size = New System.Drawing.Size(339, 324)
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
        'AnimationPanel
        '
        Me.AnimationPanel.BackColor = System.Drawing.Color.Transparent
        Me.AnimationPanel.BackgroundImage = Global.HERBS.My.Resources.Resources.HERBS_Cauldron
        Me.AnimationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnimationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AnimationPanel.Controls.Add(Me.HerbIcon_fixed3)
        Me.AnimationPanel.Controls.Add(Me.HerbIcon_fixed2)
        Me.AnimationPanel.Controls.Add(Me.HerbIcon_fixed1)
        Me.AnimationPanel.Controls.Add(Me.Fail_button3)
        Me.AnimationPanel.Controls.Add(Me.Pass_button3)
        Me.AnimationPanel.Controls.Add(Me.Fail_button4)
        Me.AnimationPanel.Controls.Add(Me.Pass_button4)
        Me.AnimationPanel.Controls.Add(Me.Fail_button2)
        Me.AnimationPanel.Controls.Add(Me.Pass_button2)
        Me.AnimationPanel.Controls.Add(Me.CaldronText)
        Me.AnimationPanel.Controls.Add(Me.CaldronVial4)
        Me.AnimationPanel.Controls.Add(Me.CaldronVial3)
        Me.AnimationPanel.Controls.Add(Me.CaldronVial2)
        Me.AnimationPanel.Controls.Add(Me.CaldronVial1)
        Me.AnimationPanel.Controls.Add(Me.Fail_button1)
        Me.AnimationPanel.Controls.Add(Me.Pass_button1)
        Me.AnimationPanel.Controls.Add(Me.CraftingPanel)
        Me.AnimationPanel.Controls.Add(Me.HerbIcon_animated1)
        Me.AnimationPanel.Controls.Add(Me.HerbIcon_animated2)
        Me.AnimationPanel.Controls.Add(Me.HerbIcon_animated3)
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimationPanel.Location = New System.Drawing.Point(348, 286)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.TableLayoutPanel1.SetRowSpan(Me.AnimationPanel, 4)
        Me.AnimationPanel.Size = New System.Drawing.Size(383, 497)
        Me.AnimationPanel.TabIndex = 3
        '
        'Fail_button3
        '
        Me.Fail_button3.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_red_small
        Me.Fail_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Fail_button3.FlatAppearance.BorderSize = 0
        Me.Fail_button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Fail_button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Fail_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fail_button3.Location = New System.Drawing.Point(37, 413)
        Me.Fail_button3.Name = "Fail_button3"
        Me.Fail_button3.Size = New System.Drawing.Size(30, 30)
        Me.Fail_button3.TabIndex = 15
        Me.Fail_button3.UseVisualStyleBackColor = True
        '
        'Pass_button3
        '
        Me.Pass_button3.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_blue_small
        Me.Pass_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pass_button3.FlatAppearance.BorderSize = 0
        Me.Pass_button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Pass_button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Pass_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass_button3.Location = New System.Drawing.Point(4, 413)
        Me.Pass_button3.Name = "Pass_button3"
        Me.Pass_button3.Size = New System.Drawing.Size(30, 30)
        Me.Pass_button3.TabIndex = 14
        Me.Pass_button3.Tag = ""
        Me.Pass_button3.UseVisualStyleBackColor = True
        '
        'Fail_button4
        '
        Me.Fail_button4.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_red_small
        Me.Fail_button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Fail_button4.FlatAppearance.BorderSize = 0
        Me.Fail_button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Fail_button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Fail_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fail_button4.Location = New System.Drawing.Point(346, 413)
        Me.Fail_button4.Name = "Fail_button4"
        Me.Fail_button4.Size = New System.Drawing.Size(30, 30)
        Me.Fail_button4.TabIndex = 13
        Me.Fail_button4.UseVisualStyleBackColor = True
        '
        'Pass_button4
        '
        Me.Pass_button4.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_blue_small
        Me.Pass_button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pass_button4.FlatAppearance.BorderSize = 0
        Me.Pass_button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Pass_button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Pass_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass_button4.Location = New System.Drawing.Point(313, 413)
        Me.Pass_button4.Name = "Pass_button4"
        Me.Pass_button4.Size = New System.Drawing.Size(30, 30)
        Me.Pass_button4.TabIndex = 12
        Me.Pass_button4.Tag = ""
        Me.Pass_button4.UseVisualStyleBackColor = True
        '
        'Fail_button2
        '
        Me.Fail_button2.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_red_small
        Me.Fail_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Fail_button2.FlatAppearance.BorderSize = 0
        Me.Fail_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Fail_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Fail_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fail_button2.Location = New System.Drawing.Point(346, 284)
        Me.Fail_button2.Name = "Fail_button2"
        Me.Fail_button2.Size = New System.Drawing.Size(30, 30)
        Me.Fail_button2.TabIndex = 11
        Me.Fail_button2.UseVisualStyleBackColor = True
        '
        'Pass_button2
        '
        Me.Pass_button2.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_blue_small
        Me.Pass_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pass_button2.FlatAppearance.BorderSize = 0
        Me.Pass_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Pass_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Pass_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass_button2.Location = New System.Drawing.Point(313, 284)
        Me.Pass_button2.Name = "Pass_button2"
        Me.Pass_button2.Size = New System.Drawing.Size(30, 30)
        Me.Pass_button2.TabIndex = 10
        Me.Pass_button2.Tag = ""
        Me.Pass_button2.UseVisualStyleBackColor = True
        '
        'CaldronText
        '
        Me.CaldronText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaldronText.Location = New System.Drawing.Point(129, 295)
        Me.CaldronText.Name = "CaldronText"
        Me.CaldronText.Size = New System.Drawing.Size(125, 51)
        Me.CaldronText.TabIndex = 9
        Me.CaldronText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CaldronVial4
        '
        Me.CaldronVial4.BackgroundImage = Global.HERBS.My.Resources.Resources.vialc_empty
        Me.CaldronVial4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CaldronVial4.Location = New System.Drawing.Point(323, 352)
        Me.CaldronVial4.Name = "CaldronVial4"
        Me.CaldronVial4.Size = New System.Drawing.Size(41, 55)
        Me.CaldronVial4.TabIndex = 8
        Me.CaldronVial4.TabStop = False
        '
        'CaldronVial3
        '
        Me.CaldronVial3.BackgroundImage = Global.HERBS.My.Resources.Resources.vialc_empty
        Me.CaldronVial3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CaldronVial3.Location = New System.Drawing.Point(15, 352)
        Me.CaldronVial3.Name = "CaldronVial3"
        Me.CaldronVial3.Size = New System.Drawing.Size(41, 55)
        Me.CaldronVial3.TabIndex = 7
        Me.CaldronVial3.TabStop = False
        '
        'CaldronVial2
        '
        Me.CaldronVial2.BackgroundImage = Global.HERBS.My.Resources.Resources.vialc_empty
        Me.CaldronVial2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CaldronVial2.Location = New System.Drawing.Point(323, 227)
        Me.CaldronVial2.Name = "CaldronVial2"
        Me.CaldronVial2.Size = New System.Drawing.Size(41, 55)
        Me.CaldronVial2.TabIndex = 6
        Me.CaldronVial2.TabStop = False
        '
        'CaldronVial1
        '
        Me.CaldronVial1.BackColor = System.Drawing.Color.Transparent
        Me.CaldronVial1.BackgroundImage = Global.HERBS.My.Resources.Resources.vialc_empty
        Me.CaldronVial1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CaldronVial1.Location = New System.Drawing.Point(15, 227)
        Me.CaldronVial1.Name = "CaldronVial1"
        Me.CaldronVial1.Size = New System.Drawing.Size(41, 55)
        Me.CaldronVial1.TabIndex = 5
        Me.CaldronVial1.TabStop = False
        '
        'Fail_button1
        '
        Me.Fail_button1.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_red_small
        Me.Fail_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Fail_button1.FlatAppearance.BorderSize = 0
        Me.Fail_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Fail_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Fail_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fail_button1.Location = New System.Drawing.Point(37, 284)
        Me.Fail_button1.Name = "Fail_button1"
        Me.Fail_button1.Size = New System.Drawing.Size(30, 30)
        Me.Fail_button1.TabIndex = 4
        Me.Fail_button1.UseVisualStyleBackColor = True
        '
        'Pass_button1
        '
        Me.Pass_button1.BackgroundImage = Global.HERBS.My.Resources.Resources.Dice_blue_small
        Me.Pass_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pass_button1.FlatAppearance.BorderSize = 0
        Me.Pass_button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Pass_button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Pass_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass_button1.Location = New System.Drawing.Point(4, 284)
        Me.Pass_button1.Name = "Pass_button1"
        Me.Pass_button1.Size = New System.Drawing.Size(30, 30)
        Me.Pass_button1.TabIndex = 3
        Me.Pass_button1.Tag = ""
        Me.Pass_button1.UseVisualStyleBackColor = True
        '
        'CraftingPanel
        '
        Me.CraftingPanel.BackColor = System.Drawing.Color.Transparent
        Me.CraftingPanel.BackgroundImage = Global.HERBS.My.Resources.Resources.Map_Blank_A_2x1
        Me.CraftingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CraftingPanel.Controls.Add(Me.HerbSelect_label)
        Me.CraftingPanel.Controls.Add(Me.CraftConfirm_button)
        Me.CraftingPanel.Controls.Add(Me.Label1)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herbval3)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herbval2)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herbval1)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herb3)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herb2)
        Me.CraftingPanel.Controls.Add(Me.CraftingPanel_Herb1)
        Me.CraftingPanel.Location = New System.Drawing.Point(15, 7)
        Me.CraftingPanel.Name = "CraftingPanel"
        Me.CraftingPanel.Size = New System.Drawing.Size(354, 174)
        Me.CraftingPanel.TabIndex = 2
        '
        'HerbSelect_label
        '
        Me.HerbSelect_label.AutoSize = True
        Me.HerbSelect_label.Location = New System.Drawing.Point(122, 11)
        Me.HerbSelect_label.Name = "HerbSelect_label"
        Me.HerbSelect_label.Size = New System.Drawing.Size(43, 13)
        Me.HerbSelect_label.TabIndex = 7
        Me.HerbSelect_label.Text = "Choose"
        '
        'CraftConfirm_button
        '
        Me.CraftConfirm_button.BackColor = System.Drawing.Color.Transparent
        Me.CraftConfirm_button.BackgroundImage = Global.HERBS.My.Resources.Resources.mortarpestle1
        Me.CraftConfirm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CraftConfirm_button.Enabled = False
        Me.CraftConfirm_button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CraftConfirm_button.FlatAppearance.BorderSize = 0
        Me.CraftConfirm_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CraftConfirm_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CraftConfirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CraftConfirm_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftConfirm_button.ForeColor = System.Drawing.SystemColors.Control
        Me.CraftConfirm_button.Location = New System.Drawing.Point(180, 78)
        Me.CraftConfirm_button.Margin = New System.Windows.Forms.Padding(0)
        Me.CraftConfirm_button.Name = "CraftConfirm_button"
        Me.CraftConfirm_button.Size = New System.Drawing.Size(82, 79)
        Me.CraftConfirm_button.TabIndex = 0
        Me.CraftConfirm_button.Text = "Craft!"
        Me.CraftConfirm_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "With Herbs of"
        '
        'CraftingPanel_Herbval3
        '
        Me.CraftingPanel_Herbval3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herbval3.Location = New System.Drawing.Point(272, 48)
        Me.CraftingPanel_Herbval3.Name = "CraftingPanel_Herbval3"
        Me.CraftingPanel_Herbval3.Size = New System.Drawing.Size(47, 23)
        Me.CraftingPanel_Herbval3.TabIndex = 5
        Me.CraftingPanel_Herbval3.Visible = False
        '
        'CraftingPanel_Herbval2
        '
        Me.CraftingPanel_Herbval2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herbval2.Location = New System.Drawing.Point(197, 48)
        Me.CraftingPanel_Herbval2.Name = "CraftingPanel_Herbval2"
        Me.CraftingPanel_Herbval2.Size = New System.Drawing.Size(47, 23)
        Me.CraftingPanel_Herbval2.TabIndex = 4
        Me.CraftingPanel_Herbval2.Visible = False
        '
        'CraftingPanel_Herbval1
        '
        Me.CraftingPanel_Herbval1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herbval1.Location = New System.Drawing.Point(125, 48)
        Me.CraftingPanel_Herbval1.Name = "CraftingPanel_Herbval1"
        Me.CraftingPanel_Herbval1.Size = New System.Drawing.Size(47, 23)
        Me.CraftingPanel_Herbval1.TabIndex = 3
        Me.CraftingPanel_Herbval1.Visible = False
        '
        'CraftingPanel_Herb3
        '
        Me.CraftingPanel_Herb3.AutoSize = True
        Me.CraftingPanel_Herb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftingPanel_Herb3.Location = New System.Drawing.Point(269, 30)
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
        Me.CraftingPanel_Herb2.Location = New System.Drawing.Point(194, 30)
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
        Me.CraftingPanel_Herb1.Location = New System.Drawing.Point(122, 30)
        Me.CraftingPanel_Herb1.Name = "CraftingPanel_Herb1"
        Me.CraftingPanel_Herb1.Size = New System.Drawing.Size(45, 15)
        Me.CraftingPanel_Herb1.TabIndex = 0
        Me.CraftingPanel_Herb1.Text = "Label1"
        Me.CraftingPanel_Herb1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.CraftingPanel_Herb1.Visible = False
        '
        'CraftedMedicine_List
        '
        Me.CraftedMedicine_List.BackColor = System.Drawing.Color.PeachPuff
        Me.CraftedMedicine_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CraftedMedicine_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CraftedMedicine_List.FormattingEnabled = True
        Me.CraftedMedicine_List.ItemHeight = 20
        Me.CraftedMedicine_List.Location = New System.Drawing.Point(3, 423)
        Me.CraftedMedicine_List.Name = "CraftedMedicine_List"
        Me.CraftedMedicine_List.Size = New System.Drawing.Size(339, 325)
        Me.CraftedMedicine_List.TabIndex = 4
        '
        'CloseHERBS_button
        '
        Me.CloseHERBS_button.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CloseHERBS_button.Location = New System.Drawing.Point(135, 754)
        Me.CloseHERBS_button.Name = "CloseHERBS_button"
        Me.CloseHERBS_button.Size = New System.Drawing.Size(75, 23)
        Me.CloseHERBS_button.TabIndex = 8
        Me.CloseHERBS_button.Text = "Done"
        Me.CloseHERBS_button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HERBS.My.Resources.Resources.woodtabs
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(50, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 43)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Herb Inventory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HERBS.My.Resources.Resources.woodtabs
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(395, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(289, 43)
        Me.Panel2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Medicine and Availability"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HERBS.My.Resources.Resources.woodtabs
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 373)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 47)
        Me.Panel3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Crafted Medicine"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ProxyTabButtons_Panel)
        Me.Panel4.Controls.Add(Me.BrewingTabs)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(345, 43)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(389, 240)
        Me.Panel4.TabIndex = 12
        '
        'ProxyTabButtons_Panel
        '
        Me.ProxyTabButtons_Panel.AutoScroll = True
        Me.ProxyTabButtons_Panel.BackColor = System.Drawing.Color.Transparent
        Me.ProxyTabButtons_Panel.BackgroundImage = Global.HERBS.My.Resources.Resources.Table_Rectangle_Wood_Ashen_J_2x1
        Me.ProxyTabButtons_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProxyTabButtons_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProxyTabButtons_Panel.Location = New System.Drawing.Point(0, 0)
        Me.ProxyTabButtons_Panel.Name = "ProxyTabButtons_Panel"
        Me.ProxyTabButtons_Panel.Size = New System.Drawing.Size(126, 240)
        Me.ProxyTabButtons_Panel.TabIndex = 1
        '
        'BrewingTabs
        '
        Me.BrewingTabs.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.BrewingTabs.Controls.Add(Me.TabPage1)
        Me.BrewingTabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrewingTabs.Location = New System.Drawing.Point(84, -4)
        Me.BrewingTabs.Multiline = True
        Me.BrewingTabs.Name = "BrewingTabs"
        Me.BrewingTabs.Padding = New System.Drawing.Point(6, 1)
        Me.BrewingTabs.SelectedIndex = 0
        Me.BrewingTabs.Size = New System.Drawing.Size(309, 248)
        Me.BrewingTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.BrewingTabs.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.HERBS.My.Resources.Resources.Table_Rectangle_Wood_Ashen_J_2x1
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(282, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HerbIcon_fixed1
        '
        Me.HerbIcon_fixed1.BackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HerbIcon_fixed1.FlatAppearance.BorderSize = 3
        Me.HerbIcon_fixed1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HerbIcon_fixed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbIcon_fixed1.Location = New System.Drawing.Point(77, 187)
        Me.HerbIcon_fixed1.Name = "HerbIcon_fixed1"
        Me.HerbIcon_fixed1.Size = New System.Drawing.Size(40, 40)
        Me.HerbIcon_fixed1.TabIndex = 16
        Me.HerbIcon_fixed1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HerbIcon_fixed1.UseVisualStyleBackColor = False
        '
        'HerbIcon_animated1
        '
        Me.HerbIcon_animated1.BackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.HerbIcon_animated1.FlatAppearance.BorderSize = 0
        Me.HerbIcon_animated1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HerbIcon_animated1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbIcon_animated1.ForeColor = System.Drawing.Color.LimeGreen
        Me.HerbIcon_animated1.Location = New System.Drawing.Point(65, 194)
        Me.HerbIcon_animated1.Name = "HerbIcon_animated1"
        Me.HerbIcon_animated1.Size = New System.Drawing.Size(65, 40)
        Me.HerbIcon_animated1.TabIndex = 17
        Me.HerbIcon_animated1.Tag = ""
        Me.HerbIcon_animated1.UseVisualStyleBackColor = False
        '
        'HerbIcon_fixed2
        '
        Me.HerbIcon_fixed2.BackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HerbIcon_fixed2.FlatAppearance.BorderSize = 3
        Me.HerbIcon_fixed2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HerbIcon_fixed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbIcon_fixed2.Location = New System.Drawing.Point(175, 167)
        Me.HerbIcon_fixed2.Name = "HerbIcon_fixed2"
        Me.HerbIcon_fixed2.Size = New System.Drawing.Size(40, 40)
        Me.HerbIcon_fixed2.TabIndex = 18
        Me.HerbIcon_fixed2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HerbIcon_fixed2.UseVisualStyleBackColor = False
        '
        'HerbIcon_fixed3
        '
        Me.HerbIcon_fixed3.BackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HerbIcon_fixed3.FlatAppearance.BorderSize = 3
        Me.HerbIcon_fixed3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki
        Me.HerbIcon_fixed3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HerbIcon_fixed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbIcon_fixed3.Location = New System.Drawing.Point(266, 187)
        Me.HerbIcon_fixed3.Name = "HerbIcon_fixed3"
        Me.HerbIcon_fixed3.Size = New System.Drawing.Size(40, 40)
        Me.HerbIcon_fixed3.TabIndex = 19
        Me.HerbIcon_fixed3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HerbIcon_fixed3.UseVisualStyleBackColor = False
        '
        'HerbIcon_animated2
        '
        Me.HerbIcon_animated2.BackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.HerbIcon_animated2.FlatAppearance.BorderSize = 0
        Me.HerbIcon_animated2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HerbIcon_animated2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbIcon_animated2.ForeColor = System.Drawing.Color.LimeGreen
        Me.HerbIcon_animated2.Location = New System.Drawing.Point(164, 173)
        Me.HerbIcon_animated2.Name = "HerbIcon_animated2"
        Me.HerbIcon_animated2.Size = New System.Drawing.Size(65, 40)
        Me.HerbIcon_animated2.TabIndex = 20
        Me.HerbIcon_animated2.Tag = ""
        Me.HerbIcon_animated2.UseVisualStyleBackColor = False
        '
        'HerbIcon_animated3
        '
        Me.HerbIcon_animated3.BackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated3.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.HerbIcon_animated3.FlatAppearance.BorderSize = 0
        Me.HerbIcon_animated3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.HerbIcon_animated3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HerbIcon_animated3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerbIcon_animated3.ForeColor = System.Drawing.Color.LimeGreen
        Me.HerbIcon_animated3.Location = New System.Drawing.Point(254, 193)
        Me.HerbIcon_animated3.Name = "HerbIcon_animated3"
        Me.HerbIcon_animated3.Size = New System.Drawing.Size(65, 40)
        Me.HerbIcon_animated3.TabIndex = 21
        Me.HerbIcon_animated3.Tag = ""
        Me.HerbIcon_animated3.UseVisualStyleBackColor = False
        '
        'HERBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 786)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(750, 825)
        Me.MinimumSize = New System.Drawing.Size(750, 825)
        Me.Name = "HERBS"
        Me.Text = "HERBS"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.AnimationPanel.ResumeLayout(False)
        CType(Me.CaldronVial4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaldronVial3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaldronVial2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaldronVial1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CraftingPanel.ResumeLayout(False)
        Me.CraftingPanel.PerformLayout()
        CType(Me.CraftingPanel_Herbval3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CraftingPanel_Herbval2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CraftingPanel_Herbval1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.BrewingTabs.ResumeLayout(False)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CloseHERBS_button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Fail_button1 As Button
    Friend WithEvents Pass_button1 As Button
    Friend WithEvents HerbSelect_label As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ProxyTabButtons_Panel As Panel
    Friend WithEvents CaldronVial4 As PictureBox
    Friend WithEvents CaldronVial3 As PictureBox
    Friend WithEvents CaldronVial2 As PictureBox
    Friend WithEvents CaldronVial1 As PictureBox
    Friend WithEvents CaldronText As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Fail_button3 As Button
    Friend WithEvents Pass_button3 As Button
    Friend WithEvents Fail_button4 As Button
    Friend WithEvents Pass_button4 As Button
    Friend WithEvents Fail_button2 As Button
    Friend WithEvents Pass_button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HerbIcon_fixed1 As Button
    Friend WithEvents HerbIcon_animated1 As Button
    Friend WithEvents HerbIcon_fixed3 As Button
    Friend WithEvents HerbIcon_fixed2 As Button
    Friend WithEvents HerbIcon_animated2 As Button
    Friend WithEvents HerbIcon_animated3 As Button
End Class
