'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormCategorias
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
		Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabLocalizar = New System.Windows.Forms.TabPage()
		Me.dgv_Categorias = New System.Windows.Forms.DataGridView()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_Localizar = New System.Windows.Forms.TextBox()
		Me.tabCadastrar = New System.Windows.Forms.TabPage()
		Me.tabControl2 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.bt_salvar = New System.Windows.Forms.Button()
		Me.bt_excluir = New System.Windows.Forms.Button()
		Me.bt_editar = New System.Windows.Forms.Button()
		Me.bt_novo = New System.Windows.Forms.Button()
		Me.txt_nome = New System.Windows.Forms.TextBox()
		Me.txt_id = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
		Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
		Me.tabControl1.SuspendLayout
		Me.tabLocalizar.SuspendLayout
		CType(Me.dgv_Categorias,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.tabCadastrar.SuspendLayout
		Me.tabControl2.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.panel5.SuspendLayout
		Me.panel3.SuspendLayout
		Me.panelEx3.SuspendLayout
		Me.SuspendLayout
		'
		'tabControl1
		'
		Me.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tabControl1.Controls.Add(Me.tabLocalizar)
		Me.tabControl1.Controls.Add(Me.tabCadastrar)
		Me.tabControl1.Location = New System.Drawing.Point(0, 41)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(470, 337)
		Me.tabControl1.TabIndex = 1
		'
		'tabLocalizar
		'
		Me.tabLocalizar.Controls.Add(Me.dgv_Categorias)
		Me.tabLocalizar.Controls.Add(Me.groupBox1)
		Me.tabLocalizar.Location = New System.Drawing.Point(4, 25)
		Me.tabLocalizar.Name = "tabLocalizar"
		Me.tabLocalizar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLocalizar.Size = New System.Drawing.Size(462, 308)
		Me.tabLocalizar.TabIndex = 0
		Me.tabLocalizar.Text = "Localizar"
		Me.tabLocalizar.UseVisualStyleBackColor = true
		AddHandler Me.tabLocalizar.Enter, AddressOf Me.TabLocalizarEnter
		'
		'dgv_Categorias
		'
		Me.dgv_Categorias.AllowUserToAddRows = false
		Me.dgv_Categorias.AllowUserToDeleteRows = false
		Me.dgv_Categorias.AllowUserToOrderColumns = true
		Me.dgv_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateGray
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Categorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7
		Me.dgv_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Categorias.Cursor = System.Windows.Forms.Cursors.Default
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Categorias.DefaultCellStyle = dataGridViewCellStyle8
		Me.dgv_Categorias.Location = New System.Drawing.Point(8, 66)
		Me.dgv_Categorias.MultiSelect = false
		Me.dgv_Categorias.Name = "dgv_Categorias"
		Me.dgv_Categorias.ReadOnly = true
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateGray
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Categorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle9
		Me.dgv_Categorias.RowHeadersVisible = false
		Me.dgv_Categorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Categorias.Size = New System.Drawing.Size(445, 231)
		Me.dgv_Categorias.TabIndex = 1
		AddHandler Me.dgv_Categorias.DoubleClick, AddressOf Me.Dgv_Categorias_DoubleClick
		AddHandler Me.dgv_Categorias.KeyDown, AddressOf Me.Dgv_CategoriasKeyDown
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_Localizar)
		Me.groupBox1.ForeColor = System.Drawing.Color.Navy
		Me.groupBox1.Location = New System.Drawing.Point(8, 8)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(445, 52)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Digite o Nome da Categoria"
		'
		'txt_Localizar
		'
		Me.txt_Localizar.Location = New System.Drawing.Point(6, 21)
		Me.txt_Localizar.Name = "txt_Localizar"
		Me.txt_Localizar.Size = New System.Drawing.Size(381, 20)
		Me.txt_Localizar.TabIndex = 0
		AddHandler Me.txt_Localizar.KeyDown, AddressOf Me.Txt_LocalizarKeyDown
		'
		'tabCadastrar
		'
		Me.tabCadastrar.Controls.Add(Me.tabControl2)
		Me.tabCadastrar.Location = New System.Drawing.Point(4, 25)
		Me.tabCadastrar.Name = "tabCadastrar"
		Me.tabCadastrar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCadastrar.Size = New System.Drawing.Size(462, 308)
		Me.tabCadastrar.TabIndex = 1
		Me.tabCadastrar.Text = "Cadastrar"
		Me.tabCadastrar.UseVisualStyleBackColor = true
		'
		'tabControl2
		'
		Me.tabControl2.Controls.Add(Me.tabPage1)
		Me.tabControl2.Location = New System.Drawing.Point(16, 10)
		Me.tabControl2.Name = "tabControl2"
		Me.tabControl2.SelectedIndex = 0
		Me.tabControl2.Size = New System.Drawing.Size(437, 217)
		Me.tabControl2.TabIndex = 0
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.panel5)
		Me.tabPage1.Controls.Add(Me.panel3)
		Me.tabPage1.Controls.Add(Me.bt_salvar)
		Me.tabPage1.Controls.Add(Me.bt_excluir)
		Me.tabPage1.Controls.Add(Me.bt_editar)
		Me.tabPage1.Controls.Add(Me.bt_novo)
		Me.tabPage1.Controls.Add(Me.txt_nome)
		Me.tabPage1.Controls.Add(Me.txt_id)
		Me.tabPage1.Controls.Add(Me.label4)
		Me.tabPage1.Controls.Add(Me.label3)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(429, 191)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Categorias"
		Me.tabPage1.UseVisualStyleBackColor = true
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.SlateGray
		Me.panel5.Controls.Add(Me.panel6)
		Me.panel5.Location = New System.Drawing.Point(13, 124)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(400, 2)
		Me.panel5.TabIndex = 15
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel6.Location = New System.Drawing.Point(0, 159)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(705, 1)
		Me.panel6.TabIndex = 15
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.SlateGray
		Me.panel3.Controls.Add(Me.panel4)
		Me.panel3.Location = New System.Drawing.Point(13, 19)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(400, 2)
		Me.panel3.TabIndex = 14
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel4.Location = New System.Drawing.Point(0, 159)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(705, 1)
		Me.panel4.TabIndex = 15
		'
		'bt_salvar
		'
		Me.bt_salvar.BackColor = System.Drawing.Color.SlateGray
		Me.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_salvar.ForeColor = System.Drawing.Color.White
		Me.bt_salvar.Location = New System.Drawing.Point(37, 149)
		Me.bt_salvar.Name = "bt_salvar"
		Me.bt_salvar.Size = New System.Drawing.Size(98, 23)
		Me.bt_salvar.TabIndex = 13
		Me.bt_salvar.Text = "&Salvar"
		Me.bt_salvar.UseVisualStyleBackColor = false
		Me.bt_salvar.Visible = false
		AddHandler Me.bt_salvar.Click, AddressOf Me.Bt_salvarClick
		'
		'bt_excluir
		'
		Me.bt_excluir.BackColor = System.Drawing.Color.SlateGray
		Me.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_excluir.ForeColor = System.Drawing.Color.White
		Me.bt_excluir.Location = New System.Drawing.Point(168, 149)
		Me.bt_excluir.Name = "bt_excluir"
		Me.bt_excluir.Size = New System.Drawing.Size(75, 23)
		Me.bt_excluir.TabIndex = 12
		Me.bt_excluir.Text = "E&xcluir"
		Me.bt_excluir.UseVisualStyleBackColor = false
		AddHandler Me.bt_excluir.Click, AddressOf Me.Bt_excluirClick
		'
		'bt_editar
		'
		Me.bt_editar.BackColor = System.Drawing.Color.SlateGray
		Me.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_editar.ForeColor = System.Drawing.Color.White
		Me.bt_editar.Location = New System.Drawing.Point(92, 149)
		Me.bt_editar.Name = "bt_editar"
		Me.bt_editar.Size = New System.Drawing.Size(75, 23)
		Me.bt_editar.TabIndex = 11
		Me.bt_editar.Text = "&Editar"
		Me.bt_editar.UseVisualStyleBackColor = false
		AddHandler Me.bt_editar.Click, AddressOf Me.Bt_editarClick
		'
		'bt_novo
		'
		Me.bt_novo.BackColor = System.Drawing.Color.SlateGray
		Me.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_novo.ForeColor = System.Drawing.Color.White
		Me.bt_novo.Location = New System.Drawing.Point(16, 149)
		Me.bt_novo.Name = "bt_novo"
		Me.bt_novo.Size = New System.Drawing.Size(75, 23)
		Me.bt_novo.TabIndex = 10
		Me.bt_novo.Text = "&Novo"
		Me.bt_novo.UseVisualStyleBackColor = false
		AddHandler Me.bt_novo.Click, AddressOf Me.Bt_novoClick
		'
		'txt_nome
		'
		Me.txt_nome.Location = New System.Drawing.Point(88, 65)
		Me.txt_nome.Name = "txt_nome"
		Me.txt_nome.Size = New System.Drawing.Size(253, 20)
		Me.txt_nome.TabIndex = 6
		AddHandler Me.txt_nome.KeyDown, AddressOf Me.Txt_nomeKeyDown
		'
		'txt_id
		'
		Me.txt_id.Location = New System.Drawing.Point(88, 39)
		Me.txt_id.Name = "txt_id"
		Me.txt_id.ReadOnly = true
		Me.txt_id.Size = New System.Drawing.Size(100, 20)
		Me.txt_id.TabIndex = 5
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label4.Location = New System.Drawing.Point(29, 73)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(43, 13)
		Me.label4.TabIndex = 1
		Me.label4.Text = "NOME"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label3.Location = New System.Drawing.Point(52, 42)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(20, 13)
		Me.label3.TabIndex = 0
		Me.label3.Text = "ID"
		'
		'bt_fechar
		'
		Me.bt_fechar.BackColor = System.Drawing.Color.Transparent
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bt_fechar.ForeColor = System.Drawing.Color.White
		Me.bt_fechar.Location = New System.Drawing.Point(382, 5)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(75, 28)
		Me.bt_fechar.TabIndex = 2
		Me.bt_fechar.Text = "&Fechar"
		Me.bt_fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fecharClick
		'
		'panelEx1
		'
		Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
		Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
		Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx1.Location = New System.Drawing.Point(0, 0)
		Me.panelEx1.Name = "panelEx1"
		Me.panelEx1.Size = New System.Drawing.Size(470, 36)
		Me.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelEx1.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
		Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx1.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.panelEx1.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx1.Style.ForeColor.Color = System.Drawing.Color.White
		Me.panelEx1.Style.GradientAngle = 90
		Me.panelEx1.TabIndex = 2
		Me.panelEx1.Text = " CADASTRO DE CATEGORIAS"
		'
		'panelEx3
		'
		Me.panelEx3.CanvasColor = System.Drawing.SystemColors.Control
		Me.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
		Me.panelEx3.Controls.Add(Me.bt_fechar)
		Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx3.Location = New System.Drawing.Point(0, 385)
		Me.panelEx3.Name = "panelEx3"
		Me.panelEx3.Size = New System.Drawing.Size(470, 36)
		Me.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelEx3.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
		Me.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx3.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.panelEx3.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx3.Style.ForeColor.Color = System.Drawing.Color.White
		Me.panelEx3.Style.GradientAngle = 90
		Me.panelEx3.TabIndex = 3
		Me.panelEx3.Text = " F1 Localizar / F3 Cadastrar"
		'
		'FormCategorias
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(470, 421)
		Me.Controls.Add(Me.panelEx3)
		Me.Controls.Add(Me.panelEx1)
		Me.Controls.Add(Me.tabControl1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = true
		Me.Name = "FormCategorias"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CATEGORIAS"
		AddHandler Shown, AddressOf Me.FormCategorias_Shown
		AddHandler KeyDown, AddressOf Me.FormCategoriasKeyDown
		Me.tabControl1.ResumeLayout(false)
		Me.tabLocalizar.ResumeLayout(false)
		CType(Me.dgv_Categorias,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.tabCadastrar.ResumeLayout(false)
		Me.tabControl2.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.tabPage1.PerformLayout
		Me.panel5.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.panelEx3.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private panelEx3 As DevComponents.DotNetBar.PanelEx
	Private panelEx1 As DevComponents.DotNetBar.PanelEx
	Private panel4 As System.Windows.Forms.Panel
	Private panel6 As System.Windows.Forms.Panel
	Private panel5 As System.Windows.Forms.Panel
	Private panel3 As System.Windows.Forms.Panel
	Private bt_novo As System.Windows.Forms.Button
	Private bt_editar As System.Windows.Forms.Button
	Private bt_excluir As System.Windows.Forms.Button
	Private bt_salvar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txt_id As System.Windows.Forms.TextBox
	Private txt_nome As System.Windows.Forms.TextBox
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabControl2 As System.Windows.Forms.TabControl
	Private txt_Localizar As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private dgv_Categorias As System.Windows.Forms.DataGridView
	Private bt_fechar As System.Windows.Forms.Button
	Private tabCadastrar As System.Windows.Forms.TabPage
	Private tabLocalizar As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
	
End Class
