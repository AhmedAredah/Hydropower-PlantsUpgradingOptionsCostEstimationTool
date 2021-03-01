Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ToggleSwitch2 = New DevExpress.XtraEditors.ToggleSwitch()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl5 = New DevExpress.XtraLayout.LayoutControl()
        Me.SE_Turbine_H = New DevExpress.XtraEditors.SpinEdit()
        Me.SE_Turbine_Q = New DevExpress.XtraEditors.SpinEdit()
        Me.SE_Turbine_P = New DevExpress.XtraEditors.SpinEdit()
        Me.CB_TurbineType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl10 = New DevExpress.XtraLayout.LayoutControl()
        Me.CB_PenstockMaterialType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.SE_Material_H = New DevExpress.XtraEditors.SpinEdit()
        Me.SE_Material_D = New DevExpress.XtraEditors.SpinEdit()
        Me.SE_Material_L = New DevExpress.XtraEditors.SpinEdit()
        Me.CB_Material_P = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.LC_Turbine_Rec = New DevExpress.XtraEditors.LabelControl()
        Me.SE_Turbine_Rec_Q = New DevExpress.XtraEditors.SpinEdit()
        Me.SE_Turbine_Rec_H = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SE_GeneratorN = New DevExpress.XtraEditors.SpinEdit()
        Me.SE_GeneratorPower = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Form1LayoutControl4ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ToggleSwitch2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl5.SuspendLayout()
        CType(Me.SE_Turbine_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SE_Turbine_Q.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SE_Turbine_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CB_TurbineType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.LayoutControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl10.SuspendLayout()
        CType(Me.CB_PenstockMaterialType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl10.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.SE_Material_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SE_Material_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SE_Material_L.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CB_Material_P.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.SE_Turbine_Rec_Q.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SE_Turbine_Rec_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.SE_GeneratorN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SE_GeneratorPower.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form1LayoutControl4ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Form1LayoutControl4ConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationIcon = CType(resources.GetObject("ribbonControl1.ApplicationIcon"), System.Drawing.Bitmap)
        Me.ribbonControl1.AutoSaveLayoutToXml = True
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem2})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 3
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.Size = New System.Drawing.Size(704, 143)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Calc and Show Report"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Report"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        Me.ribbonPageGroup1.Text = "Report"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ToggleSwitch2)
        Me.LayoutControl1.Controls.Add(Me.GroupControl4)
        Me.LayoutControl1.Controls.Add(Me.GroupControl8)
        Me.LayoutControl1.Controls.Add(Me.GroupControl2)
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(463, 255, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(680, 415)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ToggleSwitch2
        '
        Me.ToggleSwitch2.Location = New System.Drawing.Point(99, 240)
        Me.ToggleSwitch2.MenuManager = Me.ribbonControl1
        Me.ToggleSwitch2.Name = "ToggleSwitch2"
        Me.ToggleSwitch2.Properties.OffText = "Off"
        Me.ToggleSwitch2.Properties.OnText = "On"
        Me.ToggleSwitch2.Size = New System.Drawing.Size(569, 23)
        Me.ToggleSwitch2.StyleController = Me.LayoutControl1
        Me.ToggleSwitch2.TabIndex = 15
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.LayoutControl5)
        Me.GroupControl4.Location = New System.Drawing.Point(12, 104)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(656, 132)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "Turbine Properties"
        '
        'LayoutControl5
        '
        Me.LayoutControl5.Controls.Add(Me.SE_Turbine_H)
        Me.LayoutControl5.Controls.Add(Me.SE_Turbine_Q)
        Me.LayoutControl5.Controls.Add(Me.SE_Turbine_P)
        Me.LayoutControl5.Controls.Add(Me.CB_TurbineType)
        Me.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl5.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl5.Name = "LayoutControl5"
        Me.LayoutControl5.Root = Me.LayoutControlGroup6
        Me.LayoutControl5.Size = New System.Drawing.Size(652, 110)
        Me.LayoutControl5.TabIndex = 0
        Me.LayoutControl5.Text = "LayoutControl5"
        '
        'SE_Turbine_H
        '
        Me.SE_Turbine_H.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Turbine_H.Location = New System.Drawing.Point(73, 66)
        Me.SE_Turbine_H.MenuManager = Me.ribbonControl1
        Me.SE_Turbine_H.Name = "SE_Turbine_H"
        Me.SE_Turbine_H.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Turbine_H.Size = New System.Drawing.Size(150, 20)
        Me.SE_Turbine_H.StyleController = Me.LayoutControl5
        Me.SE_Turbine_H.TabIndex = 4
        '
        'SE_Turbine_Q
        '
        Me.SE_Turbine_Q.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Turbine_Q.Location = New System.Drawing.Point(344, 66)
        Me.SE_Turbine_Q.MenuManager = Me.ribbonControl1
        Me.SE_Turbine_Q.Name = "SE_Turbine_Q"
        Me.SE_Turbine_Q.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Turbine_Q.Size = New System.Drawing.Size(81, 20)
        Me.SE_Turbine_Q.StyleController = Me.LayoutControl5
        Me.SE_Turbine_Q.TabIndex = 5
        '
        'SE_Turbine_P
        '
        Me.SE_Turbine_P.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Turbine_P.Location = New System.Drawing.Point(491, 66)
        Me.SE_Turbine_P.MenuManager = Me.ribbonControl1
        Me.SE_Turbine_P.Name = "SE_Turbine_P"
        Me.SE_Turbine_P.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Turbine_P.Size = New System.Drawing.Size(137, 20)
        Me.SE_Turbine_P.StyleController = Me.LayoutControl5
        Me.SE_Turbine_P.TabIndex = 6
        '
        'CB_TurbineType
        '
        Me.CB_TurbineType.EditValue = ""
        Me.CB_TurbineType.Location = New System.Drawing.Point(129, 12)
        Me.CB_TurbineType.MenuManager = Me.RibbonControl2
        Me.CB_TurbineType.Name = "CB_TurbineType"
        Me.CB_TurbineType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CB_TurbineType.Properties.DropDownRows = 5
        Me.CB_TurbineType.Properties.Items.AddRange(New Object() {"Francis Turbine", "Pelton Turbine (2 nozzles)", "Pelton Turbine (5-6 nozzles)", "Kaplan Turbine (concrete casing)", "Kaplan Turbine (steel casing)"})
        Me.CB_TurbineType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CB_TurbineType.Size = New System.Drawing.Size(511, 20)
        Me.CB_TurbineType.StyleController = Me.LayoutControl5
        Me.CB_TurbineType.TabIndex = 4
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 1
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2})
        Me.RibbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl2.Size = New System.Drawing.Size(893, 141)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "ribbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "ribbonPageGroup1"
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlGroup7})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(652, 110)
        Me.LayoutControlGroup6.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CB_TurbineType
        Me.LayoutControlItem10.CustomizationFormText = "Turbine Type"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(632, 24)
        Me.LayoutControlItem10.Text = "Turbine Type"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(114, 13)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem11})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(632, 66)
        Me.LayoutControlGroup7.Text = " "
        Me.LayoutControlGroup7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SE_Turbine_Q
        Me.LayoutControlItem12.Location = New System.Drawing.Point(203, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem12.Text = "Maximum Flow (m3/sec)"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(114, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SE_Turbine_P
        Me.LayoutControlItem13.Location = New System.Drawing.Point(405, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem13.Text = "Power (KW)"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(57, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SE_Turbine_H
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem11.Text = "Head (m)"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(44, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.LayoutControl10)
        Me.GroupControl8.Location = New System.Drawing.Point(12, 267)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(656, 136)
        Me.GroupControl8.TabIndex = 13
        Me.GroupControl8.Text = "Penstock Material"
        '
        'LayoutControl10
        '
        Me.LayoutControl10.Controls.Add(Me.CB_PenstockMaterialType)
        Me.LayoutControl10.Controls.Add(Me.GroupControl10)
        Me.LayoutControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl10.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl10.Name = "LayoutControl10"
        Me.LayoutControl10.Root = Me.LayoutControlGroup11
        Me.LayoutControl10.Size = New System.Drawing.Size(652, 114)
        Me.LayoutControl10.TabIndex = 0
        Me.LayoutControl10.Text = "LayoutControl10"
        '
        'CB_PenstockMaterialType
        '
        Me.CB_PenstockMaterialType.Location = New System.Drawing.Point(99, 12)
        Me.CB_PenstockMaterialType.MenuManager = Me.ribbonControl1
        Me.CB_PenstockMaterialType.Name = "CB_PenstockMaterialType"
        Me.CB_PenstockMaterialType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CB_PenstockMaterialType.Properties.DropDownRows = 4
        Me.CB_PenstockMaterialType.Properties.Items.AddRange(New Object() {"GRP Penstock", "Steel Penstock", "Steel lined pressure shaft Penstock"})
        Me.CB_PenstockMaterialType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.CB_PenstockMaterialType.Size = New System.Drawing.Size(541, 20)
        Me.CB_PenstockMaterialType.StyleController = Me.LayoutControl10
        Me.CB_PenstockMaterialType.TabIndex = 4
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.LayoutControl4)
        Me.GroupControl10.Location = New System.Drawing.Point(12, 36)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(628, 66)
        Me.GroupControl10.TabIndex = 14
        Me.GroupControl10.Visible = False
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.SE_Material_H)
        Me.LayoutControl4.Controls.Add(Me.SE_Material_D)
        Me.LayoutControl4.Controls.Add(Me.SE_Material_L)
        Me.LayoutControl4.Controls.Add(Me.CB_Material_P)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup8
        Me.LayoutControl4.Size = New System.Drawing.Size(624, 44)
        Me.LayoutControl4.TabIndex = 0
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'SE_Material_H
        '
        Me.SE_Material_H.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Material_H.Location = New System.Drawing.Point(58, 12)
        Me.SE_Material_H.MenuManager = Me.ribbonControl1
        Me.SE_Material_H.Name = "SE_Material_H"
        Me.SE_Material_H.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Material_H.Size = New System.Drawing.Size(101, 20)
        Me.SE_Material_H.StyleController = Me.LayoutControl4
        Me.SE_Material_H.TabIndex = 4
        '
        'SE_Material_D
        '
        Me.SE_Material_D.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Material_D.Location = New System.Drawing.Point(261, 12)
        Me.SE_Material_D.MenuManager = Me.ribbonControl1
        Me.SE_Material_D.Name = "SE_Material_D"
        Me.SE_Material_D.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Material_D.Size = New System.Drawing.Size(50, 20)
        Me.SE_Material_D.StyleController = Me.LayoutControl4
        Me.SE_Material_D.TabIndex = 5
        '
        'SE_Material_L
        '
        Me.SE_Material_L.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Material_L.Location = New System.Drawing.Point(395, 12)
        Me.SE_Material_L.MenuManager = Me.ribbonControl1
        Me.SE_Material_L.Name = "SE_Material_L"
        Me.SE_Material_L.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Material_L.Size = New System.Drawing.Size(66, 20)
        Me.SE_Material_L.StyleController = Me.LayoutControl4
        Me.SE_Material_L.TabIndex = 6
        '
        'CB_Material_P
        '
        Me.CB_Material_P.Location = New System.Drawing.Point(536, 12)
        Me.CB_Material_P.MenuManager = Me.ribbonControl1
        Me.CB_Material_P.Name = "CB_Material_P"
        Me.CB_Material_P.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CB_Material_P.Properties.Items.AddRange(New Object() {"PN06", "PN10", "PN16", "PN20", "PN32"})
        Me.CB_Material_P.Size = New System.Drawing.Size(76, 20)
        Me.CB_Material_P.StyleController = Me.LayoutControl4
        Me.CB_Material_P.TabIndex = 7
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup8.GroupBordersVisible = False
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(624, 44)
        Me.LayoutControlGroup8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SE_Material_H
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem9.Text = "Head(m)"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SE_Material_D
        Me.LayoutControlItem15.Location = New System.Drawing.Point(151, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(152, 24)
        Me.LayoutControlItem15.Text = "Pipe Diameter (mm)"
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(93, 13)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.SE_Material_L
        Me.LayoutControlItem16.Location = New System.Drawing.Point(303, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem16.Text = "Pipe Length (m)"
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem16.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CB_Material_P
        Me.LayoutControlItem17.Location = New System.Drawing.Point(453, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(151, 24)
        Me.LayoutControlItem17.Text = "Pressure (PN)"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(66, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup11.GroupBordersVisible = False
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem30})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(652, 114)
        Me.LayoutControlGroup11.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GroupControl10
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(632, 70)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.CB_PenstockMaterialType
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(632, 24)
        Me.LayoutControlItem30.Text = "Penstock Material"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(84, 13)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LayoutControl3)
        Me.GroupControl2.Location = New System.Drawing.Point(342, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(326, 88)
        Me.GroupControl2.TabIndex = 7
        Me.GroupControl2.Text = "Turbine Selection"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.LC_Turbine_Rec)
        Me.LayoutControl3.Controls.Add(Me.SE_Turbine_Rec_Q)
        Me.LayoutControl3.Controls.Add(Me.SE_Turbine_Rec_H)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(322, 66)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'LC_Turbine_Rec
        '
        Me.LC_Turbine_Rec.Location = New System.Drawing.Point(12, 36)
        Me.LC_Turbine_Rec.Name = "LC_Turbine_Rec"
        Me.LC_Turbine_Rec.Size = New System.Drawing.Size(298, 13)
        Me.LC_Turbine_Rec.StyleController = Me.LayoutControl3
        Me.LC_Turbine_Rec.TabIndex = 6
        '
        'SE_Turbine_Rec_Q
        '
        Me.SE_Turbine_Rec_Q.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Turbine_Rec_Q.Location = New System.Drawing.Point(82, 12)
        Me.SE_Turbine_Rec_Q.MenuManager = Me.ribbonControl1
        Me.SE_Turbine_Rec_Q.Name = "SE_Turbine_Rec_Q"
        Me.SE_Turbine_Rec_Q.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Turbine_Rec_Q.Size = New System.Drawing.Size(57, 20)
        Me.SE_Turbine_Rec_Q.StyleController = Me.LayoutControl3
        Me.SE_Turbine_Rec_Q.TabIndex = 4
        '
        'SE_Turbine_Rec_H
        '
        Me.SE_Turbine_Rec_H.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_Turbine_Rec_H.Location = New System.Drawing.Point(192, 12)
        Me.SE_Turbine_Rec_H.MenuManager = Me.ribbonControl1
        Me.SE_Turbine_Rec_H.Name = "SE_Turbine_Rec_H"
        Me.SE_Turbine_Rec_H.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_Turbine_Rec_H.Size = New System.Drawing.Size(118, 20)
        Me.SE_Turbine_Rec_H.StyleController = Me.LayoutControl3
        Me.SE_Turbine_Rec_H.TabIndex = 5
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem20})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(322, 66)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SE_Turbine_Rec_Q
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(131, 24)
        Me.LayoutControlItem5.Text = "Flow (m3/sec)"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(67, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SE_Turbine_Rec_H
        Me.LayoutControlItem6.Location = New System.Drawing.Point(131, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem6.Text = "Head (m)"
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(44, 13)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.LC_Turbine_Rec
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(302, 22)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LayoutControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(326, 88)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Generator Cost"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SE_GeneratorN)
        Me.LayoutControl2.Controls.Add(Me.SE_GeneratorPower)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 20)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(322, 66)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SE_GeneratorN
        '
        Me.SE_GeneratorN.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.SE_GeneratorN.Location = New System.Drawing.Point(56, 12)
        Me.SE_GeneratorN.MenuManager = Me.ribbonControl1
        Me.SE_GeneratorN.Name = "SE_GeneratorN"
        Me.SE_GeneratorN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_GeneratorN.Properties.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SE_GeneratorN.Properties.IsFloatValue = False
        Me.SE_GeneratorN.Properties.Mask.EditMask = "N00"
        Me.SE_GeneratorN.Properties.MaxValue = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.SE_GeneratorN.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.SE_GeneratorN.Size = New System.Drawing.Size(50, 20)
        Me.SE_GeneratorN.StyleController = Me.LayoutControl2
        Me.SE_GeneratorN.TabIndex = 4
        '
        'SE_GeneratorPower
        '
        Me.SE_GeneratorPower.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SE_GeneratorPower.Location = New System.Drawing.Point(172, 12)
        Me.SE_GeneratorPower.MenuManager = Me.ribbonControl1
        Me.SE_GeneratorPower.Name = "SE_GeneratorPower"
        Me.SE_GeneratorPower.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SE_GeneratorPower.Properties.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.SE_GeneratorPower.Size = New System.Drawing.Size(138, 20)
        Me.SE_GeneratorPower.StyleController = Me.LayoutControl2
        Me.SE_GeneratorPower.TabIndex = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(322, 66)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SE_GeneratorN
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(98, 46)
        Me.LayoutControlItem1.Text = "N (RPM)"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(39, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SE_GeneratorPower
        Me.LayoutControlItem4.Location = New System.Drawing.Point(98, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(204, 46)
        Me.LayoutControlItem4.Text = "Power (MW)"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem29, Me.LayoutControlItem7, Me.LayoutControlItem19})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(680, 415)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GroupControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 92)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(242, 92)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(330, 92)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GroupControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(330, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 92)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(255, 92)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(330, 92)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.GroupControl8
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 255)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(660, 140)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        Me.LayoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GroupControl4
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 92)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 136)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(442, 136)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(660, 136)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.ToggleSwitch2
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 228)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(660, 27)
        Me.LayoutControlItem19.Text = "Penstock Material"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(180, 120)
        '
        'Form1LayoutControl4ConvertedLayout
        '
        Me.Form1LayoutControl4ConvertedLayout.Controls.Add(Me.LayoutControl1)
        Me.Form1LayoutControl4ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Form1LayoutControl4ConvertedLayout.Location = New System.Drawing.Point(0, 143)
        Me.Form1LayoutControl4ConvertedLayout.Name = "Form1LayoutControl4ConvertedLayout"
        Me.Form1LayoutControl4ConvertedLayout.Root = Me.LayoutControlGroup4
        Me.Form1LayoutControl4ConvertedLayout.Size = New System.Drawing.Size(704, 439)
        Me.Form1LayoutControl4ConvertedLayout.TabIndex = 3
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(704, 439)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.LayoutControl1
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControl1item"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(684, 419)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClientSize = New System.Drawing.Size(704, 582)
        Me.Controls.Add(Me.Form1LayoutControl4ConvertedLayout)
        Me.Controls.Add(Me.ribbonControl1)
        Me.MinimumSize = New System.Drawing.Size(714, 548)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Hydropower plant Cost Estimation"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ToggleSwitch2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl5.ResumeLayout(False)
        CType(Me.SE_Turbine_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SE_Turbine_Q.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SE_Turbine_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CB_TurbineType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.LayoutControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl10.ResumeLayout(False)
        CType(Me.CB_PenstockMaterialType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl10.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.SE_Material_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SE_Material_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SE_Material_L.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CB_Material_P.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.SE_Turbine_Rec_Q.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SE_Turbine_Rec_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.SE_GeneratorN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SE_GeneratorPower.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form1LayoutControl4ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Form1LayoutControl4ConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SE_GeneratorN As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SE_Turbine_Rec_Q As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SE_Turbine_Rec_H As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl5 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SE_Turbine_H As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SE_Turbine_Q As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SE_Turbine_P As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControl10 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CB_PenstockMaterialType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CB_TurbineType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Form1LayoutControl4ConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SE_GeneratorPower As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SpinEdit8 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SE_Material_H As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SE_Material_D As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SE_Material_L As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CB_Material_P As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToggleSwitch2 As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LC_Turbine_Rec As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
End Class
