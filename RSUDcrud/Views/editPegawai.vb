﻿Public Class editPegawai
	Dim pegawai As New Pegawai

	Private Sub editPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		pegawai.kd_pegawai = varTempPegawai
		pegawai.Read()
		txtKDPEGAWAI.Text = pegawai.kd_pegawai
		txtKDPEGAWAI.Enabled = False
		txtNAMA.Text = pegawai.nama
		txtALAMAT.Text = pegawai.alamat
		txtNOTELP.Text = pegawai.no_telp
		txtUNIT.Text = pegawai.unit
		cbJABATAN.Text = pegawai.jabatan
	End Sub
	Private Sub save()
		With pegawai
			.kd_pegawai = varTempPegawai
			.nama = txtNAMA.Text
			.alamat = txtALAMAT.Text
			.no_telp = txtNOTELP.Text
			.unit = txtUNIT.Text
			.jabatan = cbJABATAN.Text
			If .Update Then
				Me.Dispose()
				MainPegawai.Button1.PerformClick()
			End If
		End With
	End Sub

	Private Sub btnBATAL_Click(sender As Object, e As EventArgs) Handles btnBATAL.Click
		Me.Dispose()
	End Sub

	Private Sub btnSIMPAN_Click(sender As Object, e As EventArgs) Handles btnSIMPAN.Click
		save()
	End Sub

	Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

	End Sub
End Class