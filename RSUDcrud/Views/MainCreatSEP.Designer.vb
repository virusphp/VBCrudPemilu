<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainCreatSEP
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtCARI = New System.Windows.Forms.TextBox()
		Me.dgPASIEN = New System.Windows.Forms.DataGridView()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgPASIEN, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(149, 32)
		Me.PictureBox1.TabIndex = 17
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.UseWaitCursor = True
		Me.PictureBox1.WaitOnLoad = True
		'
		'txtCARI
		'
		Me.txtCARI.Location = New System.Drawing.Point(521, 49)
		Me.txtCARI.Name = "txtCARI"
		Me.txtCARI.Size = New System.Drawing.Size(143, 20)
		Me.txtCARI.TabIndex = 16
		'
		'dgPASIEN
		'
		Me.dgPASIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgPASIEN.Location = New System.Drawing.Point(12, 76)
		Me.dgPASIEN.Name = "dgPASIEN"
		Me.dgPASIEN.Size = New System.Drawing.Size(652, 215)
		Me.dgPASIEN.TabIndex = 18
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(156, 49)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePicker1.TabIndex = 19
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(12, 48)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 20
		'
		'MainCreatSEP
		'
		Me.ClientSize = New System.Drawing.Size(680, 303)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.dgPASIEN)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.txtCARI)
		Me.Name = "MainCreatSEP"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgPASIEN, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtCARI As TextBox
	Private WithEvents dgPASIEN As DataGridView
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents ComboBox1 As ComboBox
End Class
