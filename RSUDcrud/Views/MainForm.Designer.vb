﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnSEP = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPASIEN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSEP
        '
        Me.btnSEP.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSEP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEP.Image = Global.RSUDcrud.My.Resources.Resources.icon_bpjs_64
        Me.btnSEP.Location = New System.Drawing.Point(286, 172)
        Me.btnSEP.Name = "btnSEP"
        Me.btnSEP.Size = New System.Drawing.Size(99, 87)
        Me.btnSEP.TabIndex = 3
        Me.btnSEP.Text = "SEP"
        Me.btnSEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSEP.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Fuchsia
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.RSUDcrud.My.Resources.Resources.icon_exit_64
        Me.Button2.Location = New System.Drawing.Point(406, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 87)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXIT"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Fuchsia
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.RSUDcrud.My.Resources.Resources.icon_dokter_64
        Me.Button1.Location = New System.Drawing.Point(166, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 87)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "DOKTER"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPASIEN
        '
        Me.btnPASIEN.BackColor = System.Drawing.Color.Fuchsia
        Me.btnPASIEN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPASIEN.Image = Global.RSUDcrud.My.Resources.Resources.icon_pasien_64
        Me.btnPASIEN.Location = New System.Drawing.Point(45, 172)
        Me.btnPASIEN.Name = "btnPASIEN"
        Me.btnPASIEN.Size = New System.Drawing.Size(102, 87)
        Me.btnPASIEN.TabIndex = 0
        Me.btnPASIEN.Text = "PASIEN"
        Me.btnPASIEN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPASIEN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(41, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 78)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SIMRS MINI"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(556, 271)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSEP)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPASIEN)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPASIEN As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents btnSEP As Button
	Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
