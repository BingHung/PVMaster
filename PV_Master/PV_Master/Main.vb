Public Class Main
    Private Sub Flange_Design_btn_Click(sender As Object, e As EventArgs) Handles Flange_Design_btn.Click

        Dim FDP_UI_In As FlangeDesign_Parameters_Input

        FDP_UI_In.P = CDbl(FD_DP.Text)
        FDP_UI_In.T = CDbl(FD_DT.Text)
        FDP_UI_In.Ca = CDbl(FD_Ca.Text)
        FDP_UI_In.S = CDbl(FD_S.Text)
        FDP_UI_In.B = CDbl(FD_D.Text)
        FDP_UI_In.g0 = CDbl(FD_t.Text)
        FDP_UI_In.Fs = CDbl(FD_Fs.Text)
        FDP_UI_In.Sf = CDbl(FD_Sf.Text)
        FDP_UI_In.GSTP = (FD_GSTP.Text)
        FDP_UI_In.GSSk = (FD_GSSK.Text)
        FDP_UI_In.m = CDbl(FD_m.Text)
        FDP_UI_In.y = CDbl(FD_y.Text)
        FDP_UI_In.tg = CDbl(FD_tg.Text)
        FDP_UI_In.w = CDbl(FD_w.Text)
        FDP_UI_In.N = CDbl(FD_N.Text)
        FDP_UI_In.N1 = CDbl(FD_N1.Text)
        FDP_UI_In.Sa = CDbl(FD_Sa.Text)
        FDP_UI_In.Sb = CDbl(FD_Sb.Text)
        FDP_UI_In.Dbi = CDbl(FD_Dbi.Text)


        Dim FDP_UI_Out As FlangeDesign_Parameters_Output = FlangeDesign_Main(FDP_UI_In)
        FD_FOD.Text = FDP_UI_Out.FOD
        FD_FID.Text = FDP_UI_Out.FID
        FD_BCD.Text = FDP_UI_Out.BCD
        FD_tf.Text = FDP_UI_Out.FTHK
        FD_h.Text = FDP_UI_Out.h
        FD_g0.Text = FDP_UI_Out.g0
        FD_g1.Text = FDP_UI_Out.g1
        FD_GOD.Text = FDP_UI_Out.GOD
        FD_GID.Text = FDP_UI_Out.GID
        FD_nb.Text = FDP_UI_Out.nb
        FD_Db.Text = FDP_UI_Out.Db

        FD_GTHK.Text = FDP_UI_In.tg

    End Sub
End Class
