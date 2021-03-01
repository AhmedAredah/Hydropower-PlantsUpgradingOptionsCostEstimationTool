Imports System.ComponentModel
Imports System.Text
Imports System.Math
Imports System.Globalization


Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
		InitializeComponent()
	End Sub

   

    Private Sub ComboBoxEdit2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PenstockMaterialType.SelectedIndexChanged
        GroupControl10.Text = CB_PenstockMaterialType.SelectedItem.ToString & " Properties"
        If CB_PenstockMaterialType.SelectedItem.ToString = "" Then
            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            If CB_PenstockMaterialType.SelectedIndex = 0 Then
                LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Else
                LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
        End If
    End Sub

    Private Function TurbinSelectionCost() As Double()
        Dim perMW, Total As Double
        If CB_TurbineType.SelectedIndex = 0 Then
            perMW = CalculateFrancisCost(CDbl(SE_Turbine_H.EditValue), CDbl(SE_Turbine_Q.EditValue)) * 1000
            Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            Return New Double() {perMW, Total}

        ElseIf CB_TurbineType.SelectedIndex = 1 Then
            perMW = CalculatePelton2Cost(CDbl(SE_Turbine_H.EditValue), CDbl(SE_Turbine_Q.EditValue)) * 1000
            Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            Return New Double() {perMW, Total}

        ElseIf CB_TurbineType.SelectedIndex = 2 Then
            perMW = CalculatePelton5Cost(CDbl(SE_Turbine_H.EditValue), CDbl(SE_Turbine_Q.EditValue)) * 1000
            Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            Return New Double() {perMW, Total}

        ElseIf CB_TurbineType.SelectedIndex = 3 Then
            perMW = CalculateKaplanCCost(CDbl(SE_Turbine_H.EditValue), CDbl(SE_Turbine_Q.EditValue)) * 1000
            Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            Return New Double() {perMW, Total}

        ElseIf CB_TurbineType.SelectedIndex = 4 Then
            perMW = CalculateKaplanSCost(CDbl(SE_Turbine_H.EditValue), CDbl(SE_Turbine_Q.EditValue)) * 1000
            Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            Return New Double() {perMW, Total}

        Else
            Return New Double() {0, 0}
        End If
    End Function

    Private Function PipeSelectionCost() As Double()
        Try
            If CB_PenstockMaterialType.SelectedIndex = 0 Then
                Return New Double() {GRP_Pipe(CB_Material_P.SelectedText, CDbl(SE_Material_D.Value)), _
                                     GRP_Pipe(CB_Material_P.SelectedText, CDbl(SE_Material_D.Value)) * CDbl(SE_Material_L.Value)}

            ElseIf CB_TurbineType.SelectedIndex = 1 Then
                Return New Double() {CalculateSPipeCost(CDbl(SE_Material_H.EditValue), CDbl(SE_Material_D.Value)), _
                                     CalculateSPipeCost(CDbl(SE_Material_H.EditValue), CDbl(SE_Material_D.Value)) * CDbl(SE_Material_L.Value)}

            ElseIf CB_TurbineType.SelectedIndex = 2 Then
                Return New Double() {CalculateSLCost(CDbl(SE_Material_H.EditValue), CDbl(SE_Material_D.Value)), _
                                     CalculateSLCost(CDbl(SE_Material_H.EditValue), CDbl(SE_Material_D.Value)) * CDbl(SE_Material_L.Value)}

            Else
                Return New Double() {0, 0}
            End If
        Catch ex As Exception
            Return New Double() {0, 0}
        End Try
    End Function


    Private Function interpolation(upper_y As Double, upper_bound As Double, lower_y As Double, lower_bound As Double, concerned_value As Double) As Double
        Dim Normalized_Diff As Double
        Normalized_Diff = (upper_y - lower_y) / Math.Abs(lower_bound - upper_bound)
        Return ((Math.Abs(lower_bound - concerned_value) * Normalized_Diff) + lower_y)
    End Function

#Region "Recommended Turbin"
    Private Function RecommendTurbin(Q As Double, H As Double) As String
        If (Q >= 40 And Q <= 400) And (H >= 10 And H <= 30) Then
            Return "Kaplan Turbine (Concrete Casing)"
        ElseIf (Q >= 30 And Q <= 350) And (H >= 35 And H <= 50) Then
            Return "Kaplan Turbine (Steel Casing)"
        ElseIf (Q >= 1 And Q <= 150) And (H >= 50 And H <= 650) Then
            Return "Francis Turbine"
        ElseIf (Q >= 1 And Q <= 10) And (H >= 650 And H <= 1000) Then
            Return "Pelton Turbine (2 Nozzles)"
        ElseIf (Q >= 10 And Q <= 40) And (H >= 650 And H <= 1000) Then
            Return "Pelton Turbine (5-6 Nozzles)"
        Else
            Return "No Feasible Range"
        End If
    End Function

#End Region

#Region "Kaplan-Steel"

    Public Function CalculateKaplanSCost(H As Double, Q As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculateKaplanSUpperCost(H, Q)
        LowerCost = CalculateKaplanSLowerCost(H, Q)
        Return interpolation(UpperCost, GetKaplanSUpperH(H), LowerCost, GetKaplanSLowerH(H), H)
    End Function

    Private Function GetKaplanSUpperH(H As Double) As Double
        If H >= 35 Then
            Return 10
        Else
            Return 0
        End If
    End Function

    Private Function GetKaplanSLowerH(H As Double) As Double
        If H >= 35 Then
            Return 50
        Else
            Return 0
        End If
    End Function

    Private Function CalculateKaplanSUpperCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 35 Then
            C = 1396.5254 * (Q) ^ -0.3494
        End If
        Return C
    End Function

    Private Function CalculateKaplanSLowerCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 35 Then
            C = 1220.5116 * (Q) ^ -0.3613
        End If
        Return C
    End Function


#End Region

#Region "Kaplan-C"

    Public Function CalculateKaplanCCost(H As Double, Q As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculateKaplanCUpperCost(H, Q)
        LowerCost = CalculateKaplanCLowerCost(H, Q)
        Return interpolation(UpperCost, GetKaplanCUpperH(H), LowerCost, GetKaplanCLowerH(H), H)
    End Function

    Private Function GetKaplanCUpperH(H As Double) As Double
        If H >= 15 Then
            Return 15
        ElseIf H >= 10 Then
            Return 10
        Else
            Return 0
        End If
    End Function

    Private Function GetKaplanCLowerH(H As Double) As Double
        If H >= 15 Then
            Return 30
        ElseIf H >= 10 Then
            Return 15
        Else
            Return 10
        End If
    End Function

    Private Function CalculateKaplanCUpperCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 15 Then
            C = 2300.4814 * (Q) ^ -0.3159
        ElseIf H >= 10 Then
            C = 3380.0722 * (Q) ^ -0.3155
        End If
        Return C
    End Function

    Private Function CalculateKaplanCLowerCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 15 Then
            C = 1201.9088 * (Q) ^ -0.2868
        ElseIf H >= 10 Then
            C = 2300.4814 * (Q) ^ -0.3159
        End If
        Return C
    End Function


#End Region

#Region "Pelton-5-6Nozzles"

    Public Function CalculatePelton5Cost(H As Double, Q As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculatePelton5UpperCost(H, Q)
        LowerCost = CalculatePelton5LowerCost(H, Q)
        Return interpolation(UpperCost, GetPelton5UpperH(H), LowerCost, GetPelton5LowerH(H), H)
    End Function

    Private Function GetPelton5UpperH(H As Double) As Double
        If H >= 800 Then
            Return 800
        ElseIf H >= 600 Then
            Return 600
        Else
            Return 0
        End If
    End Function

    Private Function GetPelton5LowerH(H As Double) As Double
        If H >= 800 Then
            Return 1000
        ElseIf H >= 600 Then
            Return 800
        Else
            Return 600
        End If
    End Function

    Private Function CalculatePelton5UpperCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 800 Then
            C = 307.2184 * (Q) ^ -0.5218
        ElseIf H >= 600 Then
            C = 386.4508 * (Q) ^ -0.5115
        End If
        Return C
    End Function

    Private Function CalculatePelton5LowerCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 800 Then
            C = 249.9738 * (Q) ^ -0.5179
        ElseIf H >= 600 Then
            C = 307.2184 * (Q) ^ -0.5218
        End If
        Return C
    End Function


#End Region

#Region "Pelton-2Nozzles"

    Public Function CalculatePelton2Cost(H As Double, Q As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculatePelton2UpperCost(H, Q)
        LowerCost = CalculatePelton2LowerCost(H, Q)
        Return interpolation(UpperCost, GetPelton2UpperH(H), LowerCost, GetPelton2LowerH(H), H)
    End Function

    Private Function GetPelton2UpperH(H As Double) As Double
        If H >= 800 Then
            Return 800
        ElseIf H >= 600 Then
            Return 600
        Else
            Return 0
        End If
    End Function

    Private Function GetPelton2LowerH(H As Double) As Double
        If H >= 800 Then
            Return 1000
        ElseIf H >= 600 Then
            Return 800
        Else
            Return 600
        End If
    End Function

    Private Function CalculatePelton2UpperCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 800 Then
            C = 219.286 * (Q) ^ -0.5176
        ElseIf H >= 600 Then
            C = 280.9354 * (Q) ^ -0.5087
        End If
        Return C
    End Function

    Private Function CalculatePelton2LowerCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 800 Then
            C = 177.1475 * (Q) ^ -0.5106
        ElseIf H >= 600 Then
            C = 219.286 * (Q) ^ -0.5176
        End If
        Return C
    End Function


#End Region

#Region "Francis"

    Public Function CalculateFrancisCost(H As Double, Q As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculateFrancisUpperCost(H, Q)
        LowerCost = CalculateFrancisLowerCost(H, Q)
        Return interpolation(UpperCost, GetFrancisUpperH(H), LowerCost, GetFrancisLowerH(H), H)
    End Function

    Private Function GetFrancisUpperH(H As Double) As Double
        If H >= 400 Then
            Return 400
        ElseIf H >= 300 Then
            Return 300
        ElseIf H >= 200 Then
            Return 200
        ElseIf H >= 100 Then
            Return 100
        ElseIf H >= 50 Then
            Return 50
        Else
            Return 0
        End If
    End Function

    Private Function GetFrancisLowerH(H As Double) As Double
        If H >= 400 Then
            Return 650
        ElseIf H >= 300 Then
            Return 400
        ElseIf H >= 200 Then
            Return 300
        ElseIf H >= 100 Then
            Return 200
        ElseIf H >= 50 Then
            Return 100
        Else
            Return 50
        End If
    End Function

    Private Function CalculateFrancisUpperCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 400 Then
            C = 192.2916 * (Q) ^ -0.323
        ElseIf H >= 300 Then
            C = 220.6693 * (Q) ^ -0.3143
        ElseIf H >= 200 Then
            C = 285.4376 * (Q) ^ -0.3149
        ElseIf H >= 100 Then
            C = 417.3648 * (Q) ^ -0.3139
        ElseIf H >= 50 Then
            C = 677.088 * (Q) ^ -0.3334
        End If
        Return C
    End Function

    Private Function CalculateFrancisLowerCost(H As Double, Q As Double) As Double
        Dim C As Double = 0
        If H >= 400 Then
            C = 138.1047 * (Q) ^ -0.3044
        ElseIf H >= 300 Then
            C = 192.2916 * (Q) ^ -0.323
        ElseIf H >= 200 Then
            C = 220.6693 * (Q) ^ -0.3143
        ElseIf H >= 100 Then
            C = 285.4376 * (Q) ^ -0.3149
        ElseIf H >= 50 Then
            C = 417.3648 * (Q) ^ -0.3139
        End If
        Return C
    End Function


#End Region

#Region "GeneratorCost"
    Public Function CalculateGeneratorCost(N As Double, P As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculateGeneratorUpperCost(N, P)
        LowerCost = CalculateGeneratorLowerCost(N, P)
        Return interpolation(UpperCost, GetGeneratorUpperN(N), LowerCost, GetGeneratorLowerN(N), N) * (10 ^ 6)
    End Function

    Private Function GetGeneratorUpperN(N As Double) As Double
        If N >= 1000 Then
            Return 1000
        ElseIf N >= 750 Then
            Return 750
        ElseIf N >= 500 Then
            Return 500
        ElseIf N >= 300 Then
            Return 300
        ElseIf N >= 200 Then
            Return 200
        ElseIf N >= 100 Then
            Return 100
        Else
            Return 0
        End If
    End Function
    Private Function GetGeneratorLowerN(N As Double) As Double
        If N >= 1000 Then
            Return 1500
        ElseIf N >= 750 Then
            Return 1000
        ElseIf N >= 500 Then
            Return 750
        ElseIf N >= 300 Then
            Return 500
        ElseIf N >= 200 Then
            Return 300
        ElseIf N >= 100 Then
            Return 200
        Else
            Return 100
        End If
    End Function
    Private Function CalculateGeneratorUpperCost(N As Double, P As Double) As Double
        Dim C As Double = 0
        If N >= 1000 Then
            C = 0.2709 * (P) ^ 0.62
        ElseIf N >= 750 Then
            C = 0.3084 * (P) ^ 0.62
        ElseIf N >= 500 Then
            C = 0.3703 * (P) ^ 0.62
        ElseIf N >= 300 Then
            C = 0.4663 * (P) ^ 0.62
        ElseIf N >= 200 Then
            C = 0.5598 * (P) ^ 0.62
        ElseIf N >= 100 Then
            C = 0.7652 * (P) ^ 0.62
        End If
        Return C
    End Function

    Private Function CalculateGeneratorLowerCost(N As Double, P As Double) As Double
        Dim C As Double = 0
        If N >= 1000 Then
            C = 0.2256 * (P) ^ 0.62
        ElseIf N >= 750 Then
            C = 0.2709 * (P) ^ 0.62
        ElseIf N >= 500 Then
            C = 0.3084 * (P) ^ 0.62
        ElseIf N >= 300 Then
            C = 0.3703 * (P) ^ 0.62
        ElseIf N >= 200 Then
            C = 0.4663 * (P) ^ 0.62
        ElseIf N >= 100 Then
            C = 0.5598 * (P) ^ 0.62
        End If
        Return C
    End Function

#End Region

#Region "SteelPipeCost"
    Public Function CalculateSPipeCost(H As Double, D As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculateSPipeUpperCost(H, D)
        LowerCost = CalculateSPipeLowerCost(H, D)
        Return interpolation(UpperCost, GetSPipeUpperN(H), LowerCost, GetSPipeLowerN(H), H)
    End Function

    Private Function GetSPipeUpperN(H As Double) As Double
        If H >= 600 Then
            Return 800
        ElseIf H >= 400 Then
            Return 600
        ElseIf H >= 300 Then
            Return 400
        ElseIf H >= 200 Then
            Return 300
        Else
            Return 0
        End If
    End Function
    Private Function GetSPipeLowerN(H As Double) As Double
        If H >= 600 Then
            Return 600
        ElseIf H >= 400 Then
            Return 400
        ElseIf H >= 300 Then
            Return 300
        ElseIf H >= 200 Then
            Return 200
        Else
            Return 0
        End If
    End Function
    Private Function CalculateSPipeUpperCost(H As Double, D As Double) As Double
        Dim C As Double = 0
        If H >= 600 Then
            C = 9.534 * (10 ^ -3) * (D ^ 1.105)
        ElseIf H >= 400 Then
            C = 3.325 * (10 ^ -3) * (D ^ 1.235)
        ElseIf H >= 300 Then
            C = 1.708 * (10 ^ -3) * (D ^ 1.302)
        ElseIf H >= 200 Then
            C = 4.883 * (10 ^ -4) * (D ^ 1.452)
        End If
        Return C
    End Function

    Private Function CalculateSPipeLowerCost(H As Double, D As Double) As Double
        Dim C As Double = 0
        If H >= 600 Then
            C = 3.325 * (10 ^ -3) * (D ^ 1.235)
        ElseIf H >= 400 Then
            C = 1.708 * (10 ^ -3) * (D ^ 1.302)
        ElseIf H >= 300 Then
            C = 4.883 * (10 ^ -4) * (D ^ 1.452)
        ElseIf H >= 200 Then
            C = 3.006 * (10 ^ -4) * (D ^ 1.478)
        End If
        Return C
    End Function

#End Region

#Region "GRP Pipe"

    Private Function GRP_Pipe(PN As String, D As Double) As Double
        Dim C As Double = 0
        If PN = "PN06" Then
            C = (0.00016 * (D) ^ 2) + (0.26255 * (D))
        ElseIf PN = "PN10" Then
            C = (0.00018 * (D) ^ 2) + (0.29732 * (D))
        ElseIf PN = "PN16" Then
            C = (0.0002 * (D) ^ 2) + (0.32184 * (D))
        ElseIf PN = "PN20" Then
            C = (0.00022 * (D) ^ 2) + (0.34663 * (D))
        ElseIf PN = "PN32" Then
            C = (0.00023 * (D) ^ 2) + (0.44802 * (D))
        End If
        Return C
    End Function
#End Region

#Region "Steel Lined"

    Public Function CalculateSLCost(H As Double, D As Double) As Double
        Dim UpperCost, LowerCost As Double
        UpperCost = CalculateSLUpperCost(H, D)
        LowerCost = CalculateSLLowerCost(H, D)
        Return interpolation(UpperCost, GetSLUpperN(H), LowerCost, GetSLLowerN(H), H)
    End Function

    Private Function GetSLUpperN(H As Double) As Double
        If H >= 700 Then
            Return 900
        ElseIf H >= 500 Then
            Return 700
        ElseIf H >= 300 Then
            Return 500
        Else
            Return 0
        End If
    End Function
    Private Function GetSLLowerN(H As Double) As Double
        If H >= 700 Then
            Return 700
        ElseIf H >= 500 Then
            Return 500
        ElseIf H >= 300 Then
            Return 300
        Else
            Return 0
        End If
    End Function
    Private Function CalculateSLUpperCost(H As Double, D As Double) As Double
        Dim C As Double = 0
        If H >= 700 Then
            C = 0.00000178 * (D ^ 2) - 0.00251 * D + 8.05
        ElseIf H >= 500 Then
            C = 0.00000143 * (D ^ 2) - 0.00231 * D + 7.39
        ElseIf H >= 300 Then
            C = 0.00000105 * (D ^ 2) - 0.00132 * D + 5
        End If
        Return C
    End Function

    Private Function CalculateSLLowerCost(H As Double, D As Double) As Double
        Dim C As Double = 0

        If H >= 700 Then
            C = 0.00000143 * (D ^ 2) - 0.00231 * D + 7.39
        ElseIf H >= 500 Then
            C = 0.00000105 * (D ^ 2) - 0.00132 * D + 5
        ElseIf H >= 300 Then
            C = 0.000000468 * (D ^ 2) + 0.000308 * (D) + 1.5
        End If
        Return C
    End Function

#End Region


    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try

            Dim form As New XtraForm1

            Dim report As New XtraSchedulerReport1

            report.RequestParameters = False
            '
            report.Parameters("UATM").Value = Math.Round(CDbl(TurbinSelectionCost()(0)) + CalculateGeneratorCost(CDbl(SE_GeneratorN.EditValue), CDbl(SE_GeneratorPower.EditValue)) / CDbl(SE_GeneratorPower.EditValue), 2)
            report.Parameters("UAT").Value = Math.Round(CDbl(TurbinSelectionCost()(1)) + CalculateGeneratorCost(CDbl(SE_GeneratorN.EditValue), CDbl(SE_GeneratorPower.EditValue)), 2)

            Dim GeneratorRef As Double
            GeneratorRef = Math.Round(0.1 * CalculateGeneratorCost(CDbl(SE_GeneratorN.EditValue), CDbl(SE_GeneratorPower.EditValue)) / CDbl(SE_GeneratorPower.EditValue), 2)

            report.Parameters("URGM").Value = GeneratorRef
            report.Parameters("URG").Value = GeneratorRef * (CDbl(SE_GeneratorPower.EditValue))
            report.Parameters("URTM").Value = Math.Round(0.4 * CDbl(TurbinSelectionCost()(0)), 2)
            report.Parameters("URT").Value = Math.Round(0.4 * CDbl(TurbinSelectionCost()(1)), 2)
            report.Parameters("URUM").Value = Math.Round(((0.4 * CDbl(TurbinSelectionCost()(0))) + GeneratorRef), 2)
            report.Parameters("URU").Value = Math.Round((0.4 * (CDbl(TurbinSelectionCost()(1)))) + (GeneratorRef * (1000000 / CDbl(SE_GeneratorPower.EditValue))), 2)


            report.Parameters("ROTM").Value = Math.Round(CDbl(TurbinSelectionCost()(0)), 2)
            report.Parameters("ROT").Value = Math.Round(CDbl(TurbinSelectionCost()(1)), 2)

            Dim perMW, Total As Double


            MsgBox(CB_TurbineType.SelectedItem.ToString)
            If CB_TurbineType.SelectedItem.ToString = "Kaplan Turbine (concrete casing)" Or _
                CB_TurbineType.SelectedItem.ToString = "Kaplan Turbine (steel casing)" Then

                perMW = CalculateFrancisCost(50, CDbl(SE_Turbine_Q.EditValue)) * 1000
                Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            Else
                perMW = CalculateFrancisCost(CDbl(SE_Turbine_H.EditValue), CDbl(SE_Turbine_Q.EditValue)) * 1000
                Total = perMW * (CDbl(SE_Turbine_P.EditValue) / 1000)
            End If

            report.Parameters("PHTM").Value = Math.Round(1.25 * perMW, 2)
            report.Parameters("PHT").Value = Math.Round(1.25 * Total, 2)

            report.Parameters("PCM").Value = CDbl(PipeSelectionCost()(0))
            report.Parameters("PC").Value = CDbl(PipeSelectionCost()(1))

            If CB_PenstockMaterialType.SelectedIndex >= 0 Then
                report.XrLabel22.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CB_PenstockMaterialType.SelectedItem.ToString & ":")
            End If

            If ToggleSwitch2.IsOn Then
                report.SubBand1.Visible = True
            Else
                report.SubBand1.Visible = False
            End If

            form.DocumentViewer1.DocumentSource = report

            form.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToggleSwitch2_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch2.Toggled
        If ToggleSwitch2.IsOn Then
            LayoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CB_TurbineType.SelectedIndexChanged
        If CB_TurbineType.SelectedIndex >= 0 Then
            LayoutControlGroup7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlGroup7.Text = CB_TurbineType.SelectedText & " Properties"

            'DONE: Configure turbin limits
            Select Case CB_TurbineType.SelectedItem.ToString
                Case "Francis Turbine"
                    SE_Turbine_H.Properties.MinValue = 50
                    SE_Turbine_H.Properties.MaxValue = 650
                    SE_Turbine_H.Properties.Increment = 50
                Case "Pelton Turbine (2 nozzles)"
                    SE_Turbine_H.Properties.MinValue = 600
                    SE_Turbine_H.Properties.MaxValue = 1000
                    SE_Turbine_H.Properties.Increment = 50
                Case "Pelton Turbine (5-6 nozzles)"
                    SE_Turbine_H.Properties.MinValue = 600
                    SE_Turbine_H.Properties.MaxValue = 800
                    SE_Turbine_H.Properties.Increment = 50
                Case "Kaplan Turbine (concrete casing)"
                    SE_Turbine_H.Properties.MinValue = 10
                    SE_Turbine_H.Properties.MaxValue = 30
                    SE_Turbine_H.Properties.Increment = 5
                Case "Kaplan Turbine (steel casing)"
                    SE_Turbine_H.Properties.MinValue = 10
                    SE_Turbine_H.Properties.MaxValue = 50
                    SE_Turbine_H.Properties.Increment = 5
                Case Else
                    SE_Turbine_H.Properties.MinValue = 0
                    SE_Turbine_H.Properties.MaxValue = 0
                    SE_Turbine_H.Properties.Increment = 0
            End Select

        Else
            LayoutControlGroup7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

    End Sub

    Private Sub SpinEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles SE_Turbine_Rec_Q.EditValueChanged, SE_Turbine_Rec_H.EditValueChanged
        LC_Turbine_Rec.Text = RecommendTurbin(CDbl(SE_Turbine_Rec_Q.EditValue), CDbl(SE_Turbine_Rec_H.EditValue))
    End Sub
End Class
