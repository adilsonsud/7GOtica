'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 31/3/2014
' Hora: 13:21
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormRelatoriosSinteticoVendas
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelatoriosSinteticoVendas))
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.txt_DataFinal = New System.Windows.Forms.TextBox()
		Me.txt_DataInicial = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.dgv_vendas = New System.Windows.Forms.DataGridView()
		Me.bt_Calcular = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.lbl_gasto = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.bt_imprimir = New System.Windows.Forms.Button()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.lbl_recebido = New System.Windows.Forms.Label()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.lbl_lucro = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.panel1.SuspendLayout
		CType(Me.dgv_vendas,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.panel1.Controls.Add(Me.dgv_vendas)
		Me.panel1.Controls.Add(Me.dateTimePicker2)
		Me.panel1.Controls.Add(Me.dateTimePicker1)
		Me.panel1.Controls.Add(Me.txt_DataFinal)
		Me.panel1.Controls.Add(Me.txt_DataInicial)
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(502, 79)
		Me.panel1.TabIndex = 1
		'
		'dateTimePicker2
		'
		Me.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker2.Location = New System.Drawing.Point(452, 37)
		Me.dateTimePicker2.Name = "dateTimePicker2"
		Me.dateTimePicker2.Size = New System.Drawing.Size(19, 20)
		Me.dateTimePicker2.TabIndex = 4
		AddHandler Me.dateTimePicker2.ValueChanged, AddressOf Me.DateTimePicker2ValueChanged
		'
		'dateTimePicker1
		'
		Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker1.Location = New System.Drawing.Point(206, 37)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(19, 20)
		Me.dateTimePicker1.TabIndex = 2
		AddHandler Me.dateTimePicker1.ValueChanged, AddressOf Me.DateTimePicker1ValueChanged
		'
		'txt_DataFinal
		'
		Me.txt_DataFinal.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.txt_DataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_DataFinal.Location = New System.Drawing.Point(353, 35)
		Me.txt_DataFinal.Name = "txt_DataFinal"
		Me.txt_DataFinal.ReadOnly = true
		Me.txt_DataFinal.Size = New System.Drawing.Size(121, 24)
		Me.txt_DataFinal.TabIndex = 3
		'
		'txt_DataInicial
		'
		Me.txt_DataInicial.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.txt_DataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_DataInicial.Location = New System.Drawing.Point(107, 35)
		Me.txt_DataInicial.Name = "txt_DataInicial"
		Me.txt_DataInicial.ReadOnly = true
		Me.txt_DataInicial.Size = New System.Drawing.Size(121, 24)
		Me.txt_DataInicial.TabIndex = 2
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(265, 39)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(83, 16)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Data Final:"
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 39)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(90, 16)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Data Inicial:"
		'
		'dgv_vendas
		'
		Me.dgv_vendas.AllowUserToAddRows = false
		Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_vendas.Location = New System.Drawing.Point(234, 3)
		Me.dgv_vendas.MultiSelect = false
		Me.dgv_vendas.Name = "dgv_vendas"
		Me.dgv_vendas.RowHeadersVisible = false
		Me.dgv_vendas.Size = New System.Drawing.Size(46, 30)
		Me.dgv_vendas.TabIndex = 5
		Me.dgv_vendas.Visible = false
		'
		'bt_Calcular
		'
		Me.bt_Calcular.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.bt_Calcular.FlatAppearance.BorderSize = 2
		Me.bt_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.bt_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
		Me.bt_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_Calcular.Image = CType(resources.GetObject("bt_Calcular.Image"),System.Drawing.Image)
		Me.bt_Calcular.Location = New System.Drawing.Point(4, 5)
		Me.bt_Calcular.Name = "bt_Calcular"
		Me.bt_Calcular.Size = New System.Drawing.Size(68, 58)
		Me.bt_Calcular.TabIndex = 5
		Me.bt_Calcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.bt_Calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.toolTip1.SetToolTip(Me.bt_Calcular, "Calcular os valores")
		Me.bt_Calcular.UseVisualStyleBackColor = true
		AddHandler Me.bt_Calcular.Click, AddressOf Me.Bt_CalcularClick
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.lbl_gasto)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.ForeColor = System.Drawing.Color.Red
		Me.groupBox1.Location = New System.Drawing.Point(8, 13)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(377, 80)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Valor Gasto"
		'
		'lbl_gasto
		'
		Me.lbl_gasto.AutoSize = true
		Me.lbl_gasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_gasto.Location = New System.Drawing.Point(30, 36)
		Me.lbl_gasto.Name = "lbl_gasto"
		Me.lbl_gasto.Size = New System.Drawing.Size(0, 25)
		Me.lbl_gasto.TabIndex = 0
		Me.lbl_gasto.Visible = false
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(19, 91)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(442, 23)
		Me.label3.TabIndex = 3
		Me.label3.Text = "CÁLCULO DE VALORES PARA O PERÍODO SELECIONADO"
		'
		'bt_imprimir
		'
		Me.bt_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.bt_imprimir.FlatAppearance.BorderSize = 2
		Me.bt_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.bt_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
		Me.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_imprimir.Image = CType(resources.GetObject("bt_imprimir.Image"),System.Drawing.Image)
		Me.bt_imprimir.Location = New System.Drawing.Point(4, 97)
		Me.bt_imprimir.Name = "bt_imprimir"
		Me.bt_imprimir.Size = New System.Drawing.Size(68, 58)
		Me.bt_imprimir.TabIndex = 6
		Me.toolTip1.SetToolTip(Me.bt_imprimir, "Imprimir Valores")
		Me.bt_imprimir.UseVisualStyleBackColor = true
		'
		'bt_fechar
		'
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
		Me.bt_fechar.FlatAppearance.BorderSize = 2
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.Image = CType(resources.GetObject("bt_fechar.Image"),System.Drawing.Image)
		Me.bt_fechar.Location = New System.Drawing.Point(3, 190)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(68, 58)
		Me.bt_fechar.TabIndex = 7
		Me.toolTip1.SetToolTip(Me.bt_fechar, "Fechar Janela")
		Me.bt_fechar.UseVisualStyleBackColor = true
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fecharClick
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.lbl_recebido)
		Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox2.ForeColor = System.Drawing.Color.Blue
		Me.groupBox2.Location = New System.Drawing.Point(8, 99)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(379, 80)
		Me.groupBox2.TabIndex = 3
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Valor Recebido"
		'
		'lbl_recebido
		'
		Me.lbl_recebido.AutoSize = true
		Me.lbl_recebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_recebido.Location = New System.Drawing.Point(32, 29)
		Me.lbl_recebido.Name = "lbl_recebido"
		Me.lbl_recebido.Size = New System.Drawing.Size(0, 25)
		Me.lbl_recebido.TabIndex = 0
		Me.lbl_recebido.Visible = false
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.lbl_lucro)
		Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox3.ForeColor = System.Drawing.Color.Green
		Me.groupBox3.Location = New System.Drawing.Point(8, 185)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(379, 80)
		Me.groupBox3.TabIndex = 4
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Lucro"
		'
		'lbl_lucro
		'
		Me.lbl_lucro.AutoSize = true
		Me.lbl_lucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_lucro.Location = New System.Drawing.Point(32, 31)
		Me.lbl_lucro.Name = "lbl_lucro"
		Me.lbl_lucro.Size = New System.Drawing.Size(0, 25)
		Me.lbl_lucro.TabIndex = 0
		Me.lbl_lucro.Visible = false
		'
		'panel2
		'
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel2.Controls.Add(Me.bt_fechar)
		Me.panel2.Controls.Add(Me.bt_imprimir)
		Me.panel2.Controls.Add(Me.bt_Calcular)
		Me.panel2.Location = New System.Drawing.Point(394, 6)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(79, 260)
		Me.panel2.TabIndex = 5
		'
		'panel3
		'
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel3.Controls.Add(Me.groupBox1)
		Me.panel3.Controls.Add(Me.panel2)
		Me.panel3.Controls.Add(Me.groupBox2)
		Me.panel3.Controls.Add(Me.groupBox3)
		Me.panel3.Location = New System.Drawing.Point(9, 117)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(480, 278)
		Me.panel3.TabIndex = 6
		'
		'FormRelatoriosSinteticoVendas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(502, 411)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "FormRelatoriosSinteticoVendas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "RELATÓRIO SINTÉTICO DE VENDAS"
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		CType(Me.dgv_vendas,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
    End Sub
	Private panel3 As System.Windows.Forms.Panel
	Private bt_imprimir As System.Windows.Forms.Button
	Private bt_fechar As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private dgv_vendas As System.Windows.Forms.DataGridView
	Private lbl_lucro As System.Windows.Forms.Label
	Private lbl_recebido As System.Windows.Forms.Label
	Private lbl_gasto As System.Windows.Forms.Label
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private label3 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private bt_Calcular As System.Windows.Forms.Button
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private dateTimePicker2 As System.Windows.Forms.DateTimePicker
	Private txt_DataInicial As System.Windows.Forms.TextBox
	Private txt_DataFinal As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
End Class
