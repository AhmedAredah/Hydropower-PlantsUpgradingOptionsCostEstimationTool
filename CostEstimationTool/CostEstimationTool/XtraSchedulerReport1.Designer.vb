<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraSchedulerReport1
    Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.UAT = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.UATM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PC = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PCM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.URGM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.URG = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.URT = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.URTM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.URUM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.URU = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand3 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ROTM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ROT = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand4 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PHT = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PHTM = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.URTotal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.URTotalM = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel26, Me.XrLabel4, Me.XrLabel25, Me.XrLabel3, Me.XrLabel7})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 169.5833!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1, Me.SubBand2, Me.SubBand3, Me.SubBand4})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.AutoWidth = True
        Me.XrLabel26.CanShrink = True
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.UAT, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel26.Dpi = 100.0!
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(313.1257!, 137.875!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel26.StylePriority.UseFont = False
        '
        'UAT
        '
        Me.UAT.Name = "UAT"
        Me.UAT.Type = GetType(Double)
        Me.UAT.ValueInfo = "0"
        Me.UAT.Visible = False
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(26.66628!, 104.5416!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(286.4594!, 22.99999!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "New Generator + New Turbine Cost:"
        '
        'XrLabel25
        '
        Me.XrLabel25.AutoWidth = True
        Me.XrLabel25.CanShrink = True
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.UATM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel25.Dpi = 100.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(313.1257!, 104.5416!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel25.StylePriority.UseFont = False
        '
        'UATM
        '
        Me.UATM.Name = "UATM"
        Me.UATM.Type = GetType(Double)
        Me.UATM.ValueInfo = "0"
        Me.UATM.Visible = False
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00047!, 71.20832!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(313.5416!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "UNIT ADDITION ( NO PENSTOCK )"
        '
        'XrLabel7
        '
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00045!, 10.00001!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(606.9996!, 50.08332!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Upgrading Options Cost Estimation"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel21, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24})
        Me.SubBand1.Dpi = 100.0!
        Me.SubBand1.HeightF = 111.3958!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel21
        '
        Me.XrLabel21.Dpi = 100.0!
        Me.XrLabel21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(10.00047!, 10.00001!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(313.5416!, 23.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.Text = "UNIT ADDITION ( PENSTOCK )"
        '
        'XrLabel22
        '
        Me.XrLabel22.Dpi = 100.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(26.66706!, 43.9428!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(286.4594!, 22.99998!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.Text = "Pipe"
        '
        'XrLabel23
        '
        Me.XrLabel23.AutoWidth = True
        Me.XrLabel23.CanShrink = True
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.PC, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel23.Dpi = 100.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(313.1301!, 77.27614!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel23.StylePriority.UseFont = False
        '
        'PC
        '
        Me.PC.Name = "PC"
        Me.PC.Type = GetType(Double)
        Me.PC.ValueInfo = "0"
        Me.PC.Visible = False
        '
        'XrLabel24
        '
        Me.XrLabel24.AutoWidth = True
        Me.XrLabel24.CanShrink = True
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.PCM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel24.Dpi = 100.0!
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(313.1283!, 43.9428!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel24.StylePriority.UseFont = False
        '
        'PCM
        '
        Me.PCM.Name = "PCM"
        Me.PCM.Type = GetType(Double)
        Me.PCM.ValueInfo = "0"
        Me.PCM.Visible = False
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLabel5, Me.XrLabel12, Me.XrLabel14, Me.XrLabel28, Me.XrLabel30, Me.XrLabel29, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9})
        Me.SubBand2.Dpi = 100.0!
        Me.SubBand2.HeightF = 242.8803!
        Me.SubBand2.Name = "SubBand2"
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 100.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(10.00045!, 10.00001!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(313.5416!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "UNIT REFURBISHMENT "
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(26.66706!, 44.19788!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(286.4594!, 22.99998!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Generator Refurbishment:"
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(26.66626!, 110.8646!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(286.4594!, 22.99998!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "Turbine Refurbishment:"
        '
        'XrLabel14
        '
        Me.XrLabel14.AutoWidth = True
        Me.XrLabel14.CanShrink = True
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.URGM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel14.Dpi = 100.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(313.1257!, 44.19788!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        '
        'URGM
        '
        Me.URGM.Name = "URGM"
        Me.URGM.Type = GetType(Double)
        Me.URGM.ValueInfo = "0"
        Me.URGM.Visible = False
        '
        'XrLabel28
        '
        Me.XrLabel28.AutoWidth = True
        Me.XrLabel28.CanShrink = True
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.URG, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel28.Dpi = 100.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(313.1275!, 77.53124!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        '
        'URG
        '
        Me.URG.Name = "URG"
        Me.URG.Type = GetType(Double)
        Me.URG.ValueInfo = "0"
        Me.URG.Visible = False
        '
        'XrLabel30
        '
        Me.XrLabel30.AutoWidth = True
        Me.XrLabel30.CanShrink = True
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.URT, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel30.Dpi = 100.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(313.1292!, 144.198!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        '
        'URT
        '
        Me.URT.Name = "URT"
        Me.URT.Type = GetType(Double)
        Me.URT.ValueInfo = "0"
        Me.URT.Visible = False
        '
        'XrLabel29
        '
        Me.XrLabel29.AutoWidth = True
        Me.XrLabel29.CanShrink = True
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.URTM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel29.Dpi = 100.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(313.1274!, 110.8646!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        '
        'URTM
        '
        Me.URTM.Name = "URTM"
        Me.URTM.Type = GetType(Double)
        Me.URTM.ValueInfo = "0"
        Me.URTM.Visible = False
        '
        'XrLabel11
        '
        Me.XrLabel11.AutoWidth = True
        Me.XrLabel11.CanShrink = True
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.URUM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel11.Dpi = 100.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(313.1264!, 177.5313!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        '
        'URUM
        '
        Me.URUM.Name = "URUM"
        Me.URUM.Type = GetType(Double)
        Me.URUM.ValueInfo = "0"
        Me.URUM.Visible = False
        '
        'XrLabel10
        '
        Me.XrLabel10.AutoWidth = True
        Me.XrLabel10.CanShrink = True
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.URU, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(313.1282!, 210.8646!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        '
        'URU
        '
        Me.URU.Name = "URU"
        Me.URU.Type = GetType(Double)
        Me.URU.ValueInfo = "0"
        Me.URU.Visible = False
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(26.66524!, 177.5313!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(286.4594!, 22.99998!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Unit Refurbishment:"
        '
        'SubBand3
        '
        Me.SubBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrLabel16, Me.XrLabel8, Me.XrLabel6})
        Me.SubBand3.Dpi = 100.0!
        Me.SubBand3.HeightF = 109.5625!
        Me.SubBand3.Name = "SubBand3"
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 100.0!
        Me.XrLabel20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(10.00047!, 10.00001!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(313.5416!, 23.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.Text = "REPLACING OLD TURBINE"
        '
        'XrLabel16
        '
        Me.XrLabel16.AutoWidth = True
        Me.XrLabel16.CanShrink = True
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.ROTM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel16.Dpi = 100.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(313.1273!, 40.6771!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        '
        'ROTM
        '
        Me.ROTM.Name = "ROTM"
        Me.ROTM.Type = GetType(Double)
        Me.ROTM.ValueInfo = "0"
        Me.ROTM.Visible = False
        '
        'XrLabel8
        '
        Me.XrLabel8.AutoWidth = True
        Me.XrLabel8.CanShrink = True
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.ROT, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(313.129!, 74.01044!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        '
        'ROT
        '
        Me.ROT.Name = "ROT"
        Me.ROT.Type = GetType(Double)
        Me.ROT.ValueInfo = "0"
        Me.ROT.Visible = False
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(26.66605!, 40.6771!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(286.4594!, 22.99998!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Turbine Replacement:"
        '
        'SubBand4
        '
        Me.SubBand4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17})
        Me.SubBand4.Dpi = 100.0!
        Me.SubBand4.HeightF = 107.5677!
        Me.SubBand4.Name = "SubBand4"
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 100.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(10.00047!, 10.00001!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(313.5416!, 23.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "CHANGE TO PUMPED-HYDRO"
        '
        'XrLabel19
        '
        Me.XrLabel19.Dpi = 100.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(26.66706!, 43.8021!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(286.4594!, 22.99998!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.Text = "Pumped-Hydro System:"
        '
        'XrLabel18
        '
        Me.XrLabel18.AutoWidth = True
        Me.XrLabel18.CanShrink = True
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.PHT, "Text", "{0:###,###.00 USD}")})
        Me.XrLabel18.Dpi = 100.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(313.1301!, 77.13544!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        '
        'PHT
        '
        Me.PHT.Name = "PHT"
        Me.PHT.Type = GetType(Double)
        Me.PHT.ValueInfo = "0"
        Me.PHT.Visible = False
        '
        'XrLabel17
        '
        Me.XrLabel17.AutoWidth = True
        Me.XrLabel17.CanShrink = True
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.PHTM, "Text", "{0:###,###.00 USD/MW}")})
        Me.XrLabel17.Dpi = 100.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(313.1283!, 43.8021!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(262.5!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        '
        'PHTM
        '
        Me.PHTM.Name = "PHTM"
        Me.PHTM.Type = GetType(Double)
        Me.PHTM.ValueInfo = "0"
        Me.PHTM.Visible = False
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00045!, 15.49997!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(606.9996!, 50.08332!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Hydropower-Plants Upgrading Options Cost Estimation Tool"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(417.0!, 65.5833!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(200.0!, 23.0!)
        Me.XrLabel2.Text = "M.Sc. Report By Sara Elfaramawy"
        '
        'XrLine1
        '
        Me.XrLine1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLine1.Dpi = 100.0!
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00028!, 89.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(606.9997!, 9.583282!)
        '
        'XrLine2
        '
        Me.XrLine2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrLine2.Dpi = 100.0!
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.00028!, 0.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(606.9997!, 7.916705!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrPageInfo1.Dpi = 100.0!
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(575.7502!, 17.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(41.24982!, 23.0!)
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top
        Me.XrPageInfo2.Dpi = 100.0!
        Me.XrPageInfo2.Format = "{0:d MMMM, yyyy}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(10.00016!, 66.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(210.4167!, 23.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel2, Me.XrPageInfo2, Me.XrLabel1})
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrPageInfo1})
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'URTotal
        '
        Me.URTotal.Name = "URTotal"
        Me.URTotal.Type = GetType(Double)
        Me.URTotal.ValueInfo = "0"
        Me.URTotal.Visible = False
        '
        'URTotalM
        '
        Me.URTotalM.Name = "URTotalM"
        Me.URTotalM.Type = GetType(Double)
        Me.URTotalM.ValueInfo = "0"
        Me.URTotalM.Visible = False
        '
        'XtraSchedulerReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 50)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.PCM, Me.PC, Me.UAT, Me.UATM, Me.URG, Me.URT, Me.URU, Me.URTotal, Me.URTotalM, Me.ROT, Me.ROTM, Me.PHT, Me.PHTM, Me.URTM, Me.URGM, Me.URUM})
        Me.Version = "16.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PCM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PC As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents UAT As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents UATM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URG As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URT As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URU As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URTotal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URTotalM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ROT As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ROTM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PHT As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PHTM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents URTM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URGM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents URUM As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand3 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand4 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
End Class
