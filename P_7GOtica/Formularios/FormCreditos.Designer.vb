'
' Criado por SharpDevelop.
' Usuário: adilson
' Data: 2015-11-14
' Hora: 18:08
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormCreditos
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCreditos))
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txt_infromacao = New System.Windows.Forms.TextBox()
		Me.bt_fechar = New System.Windows.Forms.Button()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(188, 301)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(180, 181)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Forte", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(158, 23)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(327, 38)
		Me.label1.TabIndex = 1
		Me.label1.Text = "7 - PDV e Estoque 1.0"
		'
		'pictureBox2
		'
		Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
		Me.pictureBox2.Location = New System.Drawing.Point(1, 0)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(107, 96)
		Me.pictureBox2.TabIndex = 2
		Me.pictureBox2.TabStop = false
		'
		'panel1
		'
		Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Controls.Add(Me.pictureBox2)
		Me.panel1.Location = New System.Drawing.Point(2, 2)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(558, 100)
		Me.panel1.TabIndex = 3
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(251, 72)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(84, 13)
		Me.label3.TabIndex = 3
		Me.label3.Text = "Versão de teste."
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(141, 270)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(261, 20)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Contato: adilsonsud@yahoo.com.br"
		'
		'txt_infromacao
		'
		Me.txt_infromacao.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.txt_infromacao.CausesValidation = false
		Me.txt_infromacao.Location = New System.Drawing.Point(6, 108)
		Me.txt_infromacao.Multiline = true
		Me.txt_infromacao.Name = "txt_infromacao"
		Me.txt_infromacao.ReadOnly = true
		Me.txt_infromacao.Size = New System.Drawing.Size(550, 157)
		Me.txt_infromacao.TabIndex = 5
		Me.txt_infromacao.Text = resources.GetString("txt_infromacao.Text")
		'
		'bt_fechar
		'
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.Location = New System.Drawing.Point(237, 495)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(88, 29)
		Me.bt_fechar.TabIndex = 6
		Me.bt_fechar.Text = "&Fechar"
		Me.bt_fechar.UseVisualStyleBackColor = true
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fecharClick
		'
		'FormCreditos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(563, 530)
		Me.ControlBox = false
		Me.Controls.Add(Me.bt_fechar)
		Me.Controls.Add(Me.txt_infromacao)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.pictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FormCreditos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Créditos"
		AddHandler Shown, AddressOf Me.FormCreditosShown
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label3 As System.Windows.Forms.Label
	Private bt_fechar As System.Windows.Forms.Button
	Private txt_infromacao As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
End Class
