Public Class Pegawai
	Public Property kd_pegawai As String
	Public Property nama As String
	Public Property alamat As String
	Public Property no_telp As String
	Public Property unit As String
	Public Property jabatan As String
	Dim strQuery As String
	Dim dt As New DataTable
	Dim db As New BindingSource

	Public Function Insert() As Boolean
		strQuery = "insert into pegawai(kd_pegawai,nama,alamat,no_telp,unit,jabatan)"
		strQuery += "value('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
		strQuery = String.Format(strQuery, kd_pegawai, nama, alamat, no_telp, unit, jabatan)
		Return AksiQuery(strQuery)
	End Function

	Public Function Update() As Boolean
		strQuery = "update pegawai set nama='{0}', alamat='{1}', no_telp='{2}', unit='{3}', jabatan='{4}' where kd_pegawai='{5}'"
		strQuery = String.Format(strQuery, nama, alamat, no_telp, unit, jabatan, kd_pegawai)
		Return AksiQuery(strQuery)
	End Function

	Public Function Delete() As Boolean
		strQuery = "delete from pegawai where kd_pegawai='{0}'"
		strQuery = String.Format(strQuery, kd_pegawai)
		Return AksiQuery(strQuery)
	End Function

	Public Sub LoadData(ByVal grid As DataGridView)
		strQuery = "select kd_pegawai,nip,nama_pegawai,tempat_lahir,tgl_lahir,alamat,no_ktp from pegawai where kd_jns_pegawai='1' and len(kd_pegawai) > '3'"
		dt = BukaTabel(strQuery)
		grid.DataSource = dt
		'grid.Columns(0).Visible = False
		db.DataSource = dt
	End Sub

	Public Sub CariData(ByVal text As TextBox)
		db.Filter = "nama_pegawai like '%" + text.Text + "%'"
	End Sub

	Public Sub Read()
		strQuery = "select * from pegawai where kd_pegawai='{0}'"
		strQuery = String.Format(strQuery, kd_pegawai)
		dt = BukaTabel(strQuery)
		kd_pegawai = dt.Rows(0)(0).ToString
		nama = dt.Rows(0)(1).ToString
		alamat = dt.Rows(0)(2).ToString
		no_telp = dt.Rows(0)(3).ToString
		unit = dt.Rows(0)(4).ToString
		jabatan = dt.Rows(0)(5).ToString

	End Sub
End Class
