'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormFornecedores
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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFornecedores))
		Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabLocalizar = New System.Windows.Forms.TabPage()
		Me.dgv_Fornecedor = New System.Windows.Forms.DataGridView()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_Localizar = New System.Windows.Forms.TextBox()
		Me.tabCadastrar = New System.Windows.Forms.TabPage()
		Me.tabControl2 = New System.Windows.Forms.TabControl()
		Me.tabFornecedor = New System.Windows.Forms.TabPage()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.gb_idcliente = New System.Windows.Forms.GroupBox()
		Me.txt_idFornecedor = New System.Windows.Forms.TextBox()
		Me.gb_dados = New System.Windows.Forms.GroupBox()
		Me.lbl_cpfCnpj = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.txt_site = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.txt_RazaoSocial = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.txt_NomeFantasia = New System.Windows.Forms.TextBox()
		Me.txt_InscEstadual = New System.Windows.Forms.TextBox()
		Me.txt_CpfCnpj = New System.Windows.Forms.TextBox()
		Me.gb_endereco = New System.Windows.Forms.GroupBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.txt_endereco = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.txt_complemento = New System.Windows.Forms.TextBox()
		Me.txt_estado = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.txt_cidade = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.txt_bairro = New System.Windows.Forms.TextBox()
		Me.txt_cep = New System.Windows.Forms.TextBox()
		Me.gb_Contatos = New System.Windows.Forms.GroupBox()
		Me.label20 = New System.Windows.Forms.Label()
		Me.txt_fone4 = New System.Windows.Forms.TextBox()
		Me.txt_fone1 = New System.Windows.Forms.TextBox()
		Me.label15 = New System.Windows.Forms.Label()
		Me.label19 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.label18 = New System.Windows.Forms.Label()
		Me.txt_fone2 = New System.Windows.Forms.TextBox()
		Me.label17 = New System.Windows.Forms.Label()
		Me.txt_fone3 = New System.Windows.Forms.TextBox()
		Me.txt_email1 = New System.Windows.Forms.TextBox()
		Me.txt_email2 = New System.Windows.Forms.TextBox()
		Me.gb_pessoa = New System.Windows.Forms.GroupBox()
		Me.rb_juridica = New System.Windows.Forms.RadioButton()
		Me.rb_Fisica = New System.Windows.Forms.RadioButton()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.bt_salvar = New System.Windows.Forms.Button()
		Me.bt_excluir = New System.Windows.Forms.Button()
		Me.bt_editar = New System.Windows.Forms.Button()
		Me.bt_novo = New System.Windows.Forms.Button()
		Me.tabProdutos = New System.Windows.Forms.TabPage()
		Me.dgv_Produto = New System.Windows.Forms.DataGridView()
		Me.panelControl1 = New DevComponents.DotNetBar.PanelControl()
		Me.txt_LocalizarCategoria = New System.Windows.Forms.TextBox()
		Me.label23 = New System.Windows.Forms.Label()
		Me.dgv_Categoria = New System.Windows.Forms.DataGridView()
		Me.pnl_prodfor = New System.Windows.Forms.Panel()
		Me.pnl_interno = New System.Windows.Forms.Panel()
		Me.bt_ok = New System.Windows.Forms.Button()
		Me.gb_prodFor = New System.Windows.Forms.GroupBox()
		Me.label22 = New System.Windows.Forms.Label()
		Me.txt_Categoria = New System.Windows.Forms.TextBox()
		Me.txt_Produto = New System.Windows.Forms.TextBox()
		Me.label21 = New System.Windows.Forms.Label()
		Me.txt_precoVenda = New System.Windows.Forms.TextBox()
		Me.txt_precocusto = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.bt_inserir = New System.Windows.Forms.Button()
		Me.lbl_NomeFantasia = New System.Windows.Forms.Label()
		Me.dgv_produtos = New System.Windows.Forms.DataGridView()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
		Me.bt_Fechar = New System.Windows.Forms.Button()
		Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
		Me.tabControl1.SuspendLayout
		Me.tabLocalizar.SuspendLayout
		CType(Me.dgv_Fornecedor,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.tabCadastrar.SuspendLayout
		Me.tabControl2.SuspendLayout
		Me.tabFornecedor.SuspendLayout
		Me.gb_idcliente.SuspendLayout
		Me.gb_dados.SuspendLayout
		Me.gb_endereco.SuspendLayout
		Me.gb_Contatos.SuspendLayout
		Me.gb_pessoa.SuspendLayout
		Me.panel5.SuspendLayout
		Me.tabProdutos.SuspendLayout
		CType(Me.dgv_Produto,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dgv_Categoria,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_prodfor.SuspendLayout
		Me.pnl_interno.SuspendLayout
		Me.gb_prodFor.SuspendLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).BeginInit
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
		Me.tabControl1.Size = New System.Drawing.Size(924, 511)
		Me.tabControl1.TabIndex = 54
		'
		'tabLocalizar
		'
		Me.tabLocalizar.Controls.Add(Me.dgv_Fornecedor)
		Me.tabLocalizar.Controls.Add(Me.groupBox1)
		Me.tabLocalizar.Location = New System.Drawing.Point(4, 25)
		Me.tabLocalizar.Name = "tabLocalizar"
		Me.tabLocalizar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLocalizar.Size = New System.Drawing.Size(916, 482)
		Me.tabLocalizar.TabIndex = 53
		Me.tabLocalizar.Text = "Localizar"
		Me.tabLocalizar.UseVisualStyleBackColor = true
		AddHandler Me.tabLocalizar.Enter, AddressOf Me.TabLocalizarEnter
		'
		'dgv_Fornecedor
		'
		Me.dgv_Fornecedor.AllowUserToAddRows = false
		Me.dgv_Fornecedor.AllowUserToDeleteRows = false
		Me.dgv_Fornecedor.AllowUserToOrderColumns = true
		Me.dgv_Fornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Fornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_Fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Fornecedor.DefaultCellStyle = dataGridViewCellStyle2
		Me.dgv_Fornecedor.Location = New System.Drawing.Point(8, 78)
		Me.dgv_Fornecedor.MultiSelect = false
		Me.dgv_Fornecedor.Name = "dgv_Fornecedor"
		Me.dgv_Fornecedor.ReadOnly = true
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Fornecedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_Fornecedor.RowHeadersVisible = false
		Me.dgv_Fornecedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Fornecedor.Size = New System.Drawing.Size(895, 394)
		Me.dgv_Fornecedor.TabIndex = 52
		AddHandler Me.dgv_Fornecedor.DoubleClick, AddressOf Me.Dgv_Fornecedor_DoubleClick
		AddHandler Me.dgv_Fornecedor.KeyDown, AddressOf Me.Dgv_FornecedoresKeyDown
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_Localizar)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.ForeColor = System.Drawing.Color.Navy
		Me.groupBox1.Location = New System.Drawing.Point(8, 6)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(445, 66)
		Me.groupBox1.TabIndex = 51
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Digite o Nome do Fornecedor"
		'
		'txt_Localizar
		'
		Me.txt_Localizar.Location = New System.Drawing.Point(6, 29)
		Me.txt_Localizar.Name = "txt_Localizar"
		Me.txt_Localizar.Size = New System.Drawing.Size(381, 20)
		Me.txt_Localizar.TabIndex = 55
		AddHandler Me.txt_Localizar.KeyDown, AddressOf Me.Txt_LocalizarKeyDown
		'
		'tabCadastrar
		'
		Me.tabCadastrar.Controls.Add(Me.tabControl2)
		Me.tabCadastrar.Location = New System.Drawing.Point(4, 25)
		Me.tabCadastrar.Name = "tabCadastrar"
		Me.tabCadastrar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCadastrar.Size = New System.Drawing.Size(916, 482)
		Me.tabCadastrar.TabIndex = 50
		Me.tabCadastrar.Text = "Cadastrar"
		Me.tabCadastrar.UseVisualStyleBackColor = true
		'
		'tabControl2
		'
		Me.tabControl2.Controls.Add(Me.tabFornecedor)
		Me.tabControl2.Controls.Add(Me.tabProdutos)
		Me.tabControl2.Location = New System.Drawing.Point(16, 10)
		Me.tabControl2.Name = "tabControl2"
		Me.tabControl2.SelectedIndex = 0
		Me.tabControl2.Size = New System.Drawing.Size(891, 471)
		Me.tabControl2.TabIndex = 49
		AddHandler Me.tabControl2.KeyDown, AddressOf Me.TabControl2_KeyDown
		'
		'tabFornecedor
		'
		Me.tabFornecedor.Controls.Add(Me.panel4)
		Me.tabFornecedor.Controls.Add(Me.gb_idcliente)
		Me.tabFornecedor.Controls.Add(Me.gb_dados)
		Me.tabFornecedor.Controls.Add(Me.gb_endereco)
		Me.tabFornecedor.Controls.Add(Me.gb_Contatos)
		Me.tabFornecedor.Controls.Add(Me.gb_pessoa)
		Me.tabFornecedor.Controls.Add(Me.panel5)
		Me.tabFornecedor.Controls.Add(Me.panel3)
		Me.tabFornecedor.Controls.Add(Me.bt_salvar)
		Me.tabFornecedor.Controls.Add(Me.bt_excluir)
		Me.tabFornecedor.Controls.Add(Me.bt_editar)
		Me.tabFornecedor.Controls.Add(Me.bt_novo)
		Me.tabFornecedor.Location = New System.Drawing.Point(4, 22)
		Me.tabFornecedor.Name = "tabFornecedor"
		Me.tabFornecedor.Padding = New System.Windows.Forms.Padding(3)
		Me.tabFornecedor.Size = New System.Drawing.Size(883, 445)
		Me.tabFornecedor.TabIndex = 48
		Me.tabFornecedor.Text = "Fornecedor (F3)"
		Me.tabFornecedor.UseVisualStyleBackColor = true
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.SlateGray
		Me.panel4.Location = New System.Drawing.Point(11, 6)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(830, 2)
		Me.panel4.TabIndex = 47
		'
		'gb_idcliente
		'
		Me.gb_idcliente.Controls.Add(Me.txt_idFornecedor)
		Me.gb_idcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_idcliente.ForeColor = System.Drawing.Color.Navy
		Me.gb_idcliente.Location = New System.Drawing.Point(26, 15)
		Me.gb_idcliente.Name = "gb_idcliente"
		Me.gb_idcliente.Size = New System.Drawing.Size(384, 50)
		Me.gb_idcliente.TabIndex = 46
		Me.gb_idcliente.TabStop = false
		Me.gb_idcliente.Text = "ID FORNECEDOR"
		'
		'txt_idFornecedor
		'
		Me.txt_idFornecedor.Location = New System.Drawing.Point(12, 22)
		Me.txt_idFornecedor.Name = "txt_idFornecedor"
		Me.txt_idFornecedor.ReadOnly = true
		Me.txt_idFornecedor.Size = New System.Drawing.Size(120, 20)
		Me.txt_idFornecedor.TabIndex = 45
		'
		'gb_dados
		'
		Me.gb_dados.Controls.Add(Me.lbl_cpfCnpj)
		Me.gb_dados.Controls.Add(Me.label6)
		Me.gb_dados.Controls.Add(Me.label7)
		Me.gb_dados.Controls.Add(Me.txt_site)
		Me.gb_dados.Controls.Add(Me.label8)
		Me.gb_dados.Controls.Add(Me.txt_RazaoSocial)
		Me.gb_dados.Controls.Add(Me.label5)
		Me.gb_dados.Controls.Add(Me.txt_NomeFantasia)
		Me.gb_dados.Controls.Add(Me.txt_InscEstadual)
		Me.gb_dados.Controls.Add(Me.txt_CpfCnpj)
		Me.gb_dados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_dados.ForeColor = System.Drawing.Color.Navy
		Me.gb_dados.Location = New System.Drawing.Point(26, 81)
		Me.gb_dados.Name = "gb_dados"
		Me.gb_dados.Size = New System.Drawing.Size(384, 185)
		Me.gb_dados.TabIndex = 1
		Me.gb_dados.TabStop = false
		Me.gb_dados.Text = "DADOS"
		'
		'lbl_cpfCnpj
		'
		Me.lbl_cpfCnpj.AutoSize = true
		Me.lbl_cpfCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_cpfCnpj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.lbl_cpfCnpj.Location = New System.Drawing.Point(47, 90)
		Me.lbl_cpfCnpj.Name = "lbl_cpfCnpj"
		Me.lbl_cpfCnpj.Size = New System.Drawing.Size(59, 13)
		Me.lbl_cpfCnpj.TabIndex = 42
		Me.lbl_cpfCnpj.Text = "CPF/CNPJ"
		'
		'label6
		'
		Me.label6.AutoSize = true
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label6.Location = New System.Drawing.Point(14, 118)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(92, 13)
		Me.label6.TabIndex = 41
		Me.label6.Text = "INSC.ESTADUAL"
		'
		'label7
		'
		Me.label7.AutoSize = true
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label7.Location = New System.Drawing.Point(12, 36)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(94, 13)
		Me.label7.TabIndex = 40
		Me.label7.Text = "NOME FANTASIA"
		'
		'txt_site
		'
		Me.txt_site.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_site.Location = New System.Drawing.Point(112, 141)
		Me.txt_site.Name = "txt_site"
		Me.txt_site.Size = New System.Drawing.Size(250, 20)
		Me.txt_site.TabIndex = 7
		AddHandler Me.txt_site.KeyDown, AddressOf Me.Txt_site_KeyDown
		'
		'label8
		'
		Me.label8.AutoSize = true
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label8.Location = New System.Drawing.Point(72, 144)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(31, 13)
		Me.label8.TabIndex = 39
		Me.label8.Text = "SITE"
		'
		'txt_RazaoSocial
		'
		Me.txt_RazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_RazaoSocial.Location = New System.Drawing.Point(112, 58)
		Me.txt_RazaoSocial.Name = "txt_RazaoSocial"
		Me.txt_RazaoSocial.Size = New System.Drawing.Size(250, 20)
		Me.txt_RazaoSocial.TabIndex = 4
		AddHandler Me.txt_RazaoSocial.KeyDown, AddressOf Me.Txt_RazaoSocial_KeyDown
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label5.Location = New System.Drawing.Point(21, 61)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(85, 13)
		Me.label5.TabIndex = 38
		Me.label5.Text = "RAZÃO SOCIAL"
		'
		'txt_NomeFantasia
		'
		Me.txt_NomeFantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_NomeFantasia.Location = New System.Drawing.Point(112, 30)
		Me.txt_NomeFantasia.Name = "txt_NomeFantasia"
		Me.txt_NomeFantasia.Size = New System.Drawing.Size(250, 20)
		Me.txt_NomeFantasia.TabIndex = 3
		'
		'txt_InscEstadual
		'
		Me.txt_InscEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_InscEstadual.Location = New System.Drawing.Point(112, 112)
		Me.txt_InscEstadual.Name = "txt_InscEstadual"
		Me.txt_InscEstadual.Size = New System.Drawing.Size(250, 20)
		Me.txt_InscEstadual.TabIndex = 6
		AddHandler Me.txt_InscEstadual.KeyDown, AddressOf Me.Txt_InscEstadual_KeyDown
		'
		'txt_CpfCnpj
		'
		Me.txt_CpfCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_CpfCnpj.Location = New System.Drawing.Point(112, 85)
		Me.txt_CpfCnpj.Name = "txt_CpfCnpj"
		Me.txt_CpfCnpj.Size = New System.Drawing.Size(250, 20)
		Me.txt_CpfCnpj.TabIndex = 5
		AddHandler Me.txt_CpfCnpj.KeyPress, AddressOf Me.Txt_CpfCnpj_KeyPress
		'
		'gb_endereco
		'
		Me.gb_endereco.Controls.Add(Me.label9)
		Me.gb_endereco.Controls.Add(Me.txt_endereco)
		Me.gb_endereco.Controls.Add(Me.label10)
		Me.gb_endereco.Controls.Add(Me.label14)
		Me.gb_endereco.Controls.Add(Me.txt_complemento)
		Me.gb_endereco.Controls.Add(Me.txt_estado)
		Me.gb_endereco.Controls.Add(Me.label13)
		Me.gb_endereco.Controls.Add(Me.label11)
		Me.gb_endereco.Controls.Add(Me.txt_cidade)
		Me.gb_endereco.Controls.Add(Me.label12)
		Me.gb_endereco.Controls.Add(Me.txt_bairro)
		Me.gb_endereco.Controls.Add(Me.txt_cep)
		Me.gb_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_endereco.ForeColor = System.Drawing.Color.Navy
		Me.gb_endereco.Location = New System.Drawing.Point(416, 81)
		Me.gb_endereco.Name = "gb_endereco"
		Me.gb_endereco.Size = New System.Drawing.Size(381, 185)
		Me.gb_endereco.TabIndex = 1
		Me.gb_endereco.TabStop = false
		Me.gb_endereco.Text = "ENDEREÇO"
		'
		'label9
		'
		Me.label9.AutoSize = true
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label9.Location = New System.Drawing.Point(28, 30)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(67, 13)
		Me.label9.TabIndex = 36
		Me.label9.Text = "ENDEREÇO"
		'
		'txt_endereco
		'
		Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_endereco.Location = New System.Drawing.Point(110, 23)
		Me.txt_endereco.Name = "txt_endereco"
		Me.txt_endereco.Size = New System.Drawing.Size(250, 20)
		Me.txt_endereco.TabIndex = 8
		AddHandler Me.txt_endereco.KeyDown, AddressOf Me.Txt_endereco_KeyDown
		'
		'label10
		'
		Me.label10.AutoSize = true
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label10.Location = New System.Drawing.Point(6, 56)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(90, 13)
		Me.label10.TabIndex = 35
		Me.label10.Text = "COMPLEMENTO"
		'
		'label14
		'
		Me.label14.AutoSize = true
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label14.Location = New System.Drawing.Point(44, 159)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(51, 13)
		Me.label14.TabIndex = 34
		Me.label14.Text = "ESTADO"
		'
		'txt_complemento
		'
		Me.txt_complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_complemento.Location = New System.Drawing.Point(110, 49)
		Me.txt_complemento.Name = "txt_complemento"
		Me.txt_complemento.Size = New System.Drawing.Size(250, 20)
		Me.txt_complemento.TabIndex = 9
		AddHandler Me.txt_complemento.KeyDown, AddressOf Me.Txt_complemento_KeyDown
		'
		'txt_estado
		'
		Me.txt_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_estado.Location = New System.Drawing.Point(110, 156)
		Me.txt_estado.Name = "txt_estado"
		Me.txt_estado.Size = New System.Drawing.Size(250, 20)
		Me.txt_estado.TabIndex = 13
		AddHandler Me.txt_estado.KeyDown, AddressOf Me.Txt_estado_KeyDown
		'
		'label13
		'
		Me.label13.AutoSize = true
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label13.Location = New System.Drawing.Point(48, 131)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(47, 13)
		Me.label13.TabIndex = 33
		Me.label13.Text = "CIDADE"
		'
		'label11
		'
		Me.label11.AutoSize = true
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label11.Location = New System.Drawing.Point(47, 80)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(48, 13)
		Me.label11.TabIndex = 32
		Me.label11.Text = "BAIRRO"
		'
		'txt_cidade
		'
		Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_cidade.Location = New System.Drawing.Point(110, 131)
		Me.txt_cidade.Name = "txt_cidade"
		Me.txt_cidade.Size = New System.Drawing.Size(250, 20)
		Me.txt_cidade.TabIndex = 12
		AddHandler Me.txt_cidade.KeyDown, AddressOf Me.Txt_cidade_KeyDown
		'
		'label12
		'
		Me.label12.AutoSize = true
		Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label12.Location = New System.Drawing.Point(67, 108)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(28, 13)
		Me.label12.TabIndex = 31
		Me.label12.Text = "CEP"
		'
		'txt_bairro
		'
		Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_bairro.Location = New System.Drawing.Point(110, 75)
		Me.txt_bairro.Name = "txt_bairro"
		Me.txt_bairro.Size = New System.Drawing.Size(250, 20)
		Me.txt_bairro.TabIndex = 10
		AddHandler Me.txt_bairro.KeyDown, AddressOf Me.Txt_bairro_KeyDown
		'
		'txt_cep
		'
		Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_cep.Location = New System.Drawing.Point(110, 101)
		Me.txt_cep.Name = "txt_cep"
		Me.txt_cep.Size = New System.Drawing.Size(250, 20)
		Me.txt_cep.TabIndex = 11
		AddHandler Me.txt_cep.KeyDown, AddressOf Me.Txt_cep_KeyDown
		'
		'gb_Contatos
		'
		Me.gb_Contatos.Controls.Add(Me.label20)
		Me.gb_Contatos.Controls.Add(Me.txt_fone4)
		Me.gb_Contatos.Controls.Add(Me.txt_fone1)
		Me.gb_Contatos.Controls.Add(Me.label15)
		Me.gb_Contatos.Controls.Add(Me.label19)
		Me.gb_Contatos.Controls.Add(Me.label16)
		Me.gb_Contatos.Controls.Add(Me.label18)
		Me.gb_Contatos.Controls.Add(Me.txt_fone2)
		Me.gb_Contatos.Controls.Add(Me.label17)
		Me.gb_Contatos.Controls.Add(Me.txt_fone3)
		Me.gb_Contatos.Controls.Add(Me.txt_email1)
		Me.gb_Contatos.Controls.Add(Me.txt_email2)
		Me.gb_Contatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_Contatos.ForeColor = System.Drawing.Color.Navy
		Me.gb_Contatos.Location = New System.Drawing.Point(26, 275)
		Me.gb_Contatos.Name = "gb_Contatos"
		Me.gb_Contatos.Size = New System.Drawing.Size(771, 110)
		Me.gb_Contatos.TabIndex = 1
		Me.gb_Contatos.TabStop = false
		Me.gb_Contatos.Text = "CONTATOS"
		'
		'label20
		'
		Me.label20.AutoSize = true
		Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label20.Location = New System.Drawing.Point(578, 25)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(45, 13)
		Me.label20.TabIndex = 45
		Me.label20.Text = "FONE 4"
		'
		'txt_fone4
		'
		Me.txt_fone4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone4.Location = New System.Drawing.Point(578, 41)
		Me.txt_fone4.Name = "txt_fone4"
		Me.txt_fone4.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone4.TabIndex = 17
		AddHandler Me.txt_fone4.KeyDown, AddressOf Me.Txt_fone4_KeyDown
		'
		'txt_fone1
		'
		Me.txt_fone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone1.Location = New System.Drawing.Point(12, 41)
		Me.txt_fone1.Name = "txt_fone1"
		Me.txt_fone1.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone1.TabIndex = 14
		AddHandler Me.txt_fone1.KeyDown, AddressOf Me.Txt_fone1_KeyDown
		'
		'label15
		'
		Me.label15.AutoSize = true
		Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label15.Location = New System.Drawing.Point(12, 25)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(45, 13)
		Me.label15.TabIndex = 39
		Me.label15.Text = "FONE 1"
		'
		'label19
		'
		Me.label19.AutoSize = true
		Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label19.Location = New System.Drawing.Point(389, 90)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(48, 13)
		Me.label19.TabIndex = 43
		Me.label19.Text = "EMAIL 2"
		'
		'label16
		'
		Me.label16.AutoSize = true
		Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label16.Location = New System.Drawing.Point(203, 25)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(45, 13)
		Me.label16.TabIndex = 40
		Me.label16.Text = "FONE 2"
		'
		'label18
		'
		Me.label18.AutoSize = true
		Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label18.Location = New System.Drawing.Point(12, 90)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(48, 13)
		Me.label18.TabIndex = 42
		Me.label18.Text = "EMAIL 1"
		'
		'txt_fone2
		'
		Me.txt_fone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone2.Location = New System.Drawing.Point(201, 41)
		Me.txt_fone2.Name = "txt_fone2"
		Me.txt_fone2.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone2.TabIndex = 15
		AddHandler Me.txt_fone2.KeyDown, AddressOf Me.Txt_fone2_KeyDown
		'
		'label17
		'
		Me.label17.AutoSize = true
		Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label17.Location = New System.Drawing.Point(390, 25)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(45, 13)
		Me.label17.TabIndex = 41
		Me.label17.Text = "FONE 3"
		'
		'txt_fone3
		'
		Me.txt_fone3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone3.Location = New System.Drawing.Point(390, 41)
		Me.txt_fone3.Name = "txt_fone3"
		Me.txt_fone3.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone3.TabIndex = 16
		AddHandler Me.txt_fone3.KeyDown, AddressOf Me.Txt_fone3_KeyDown
		'
		'txt_email1
		'
		Me.txt_email1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_email1.Location = New System.Drawing.Point(12, 67)
		Me.txt_email1.Name = "txt_email1"
		Me.txt_email1.Size = New System.Drawing.Size(374, 20)
		Me.txt_email1.TabIndex = 18
		AddHandler Me.txt_email1.KeyDown, AddressOf Me.Txt_email1_KeyDown
		'
		'txt_email2
		'
		Me.txt_email2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_email2.Location = New System.Drawing.Point(389, 67)
		Me.txt_email2.Name = "txt_email2"
		Me.txt_email2.Size = New System.Drawing.Size(374, 20)
		Me.txt_email2.TabIndex = 19
		AddHandler Me.txt_email2.KeyDown, AddressOf Me.Txt_email2_KeyDown
		'
		'gb_pessoa
		'
		Me.gb_pessoa.Controls.Add(Me.rb_juridica)
		Me.gb_pessoa.Controls.Add(Me.rb_Fisica)
		Me.gb_pessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gb_pessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_pessoa.ForeColor = System.Drawing.Color.Navy
		Me.gb_pessoa.Location = New System.Drawing.Point(416, 15)
		Me.gb_pessoa.Name = "gb_pessoa"
		Me.gb_pessoa.Size = New System.Drawing.Size(381, 50)
		Me.gb_pessoa.TabIndex = 1
		Me.gb_pessoa.TabStop = false
		Me.gb_pessoa.Text = "PESSOA"
		'
		'rb_juridica
		'
		Me.rb_juridica.AutoSize = true
		Me.rb_juridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rb_juridica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_juridica.Location = New System.Drawing.Point(151, 25)
		Me.rb_juridica.Name = "rb_juridica"
		Me.rb_juridica.Size = New System.Drawing.Size(69, 17)
		Me.rb_juridica.TabIndex = 1
		Me.rb_juridica.Text = "Juridica"
		Me.rb_juridica.UseVisualStyleBackColor = true
		'
		'rb_Fisica
		'
		Me.rb_Fisica.AutoSize = true
		Me.rb_Fisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rb_Fisica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_Fisica.Location = New System.Drawing.Point(16, 25)
		Me.rb_Fisica.Name = "rb_Fisica"
		Me.rb_Fisica.Size = New System.Drawing.Size(60, 17)
		Me.rb_Fisica.TabIndex = 0
		Me.rb_Fisica.Text = "Física"
		Me.rb_Fisica.UseVisualStyleBackColor = true
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.SlateGray
		Me.panel5.Controls.Add(Me.panel6)
		Me.panel5.Location = New System.Drawing.Point(10, 394)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(830, 2)
		Me.panel5.TabIndex = 60
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel6.Location = New System.Drawing.Point(0, 159)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(705, 1)
		Me.panel6.TabIndex = 61
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.SlateGray
		Me.panel3.Location = New System.Drawing.Point(10, 73)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(830, 2)
		Me.panel3.TabIndex = 62
		'
		'bt_salvar
		'
		Me.bt_salvar.BackColor = System.Drawing.Color.SlateGray
		Me.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_salvar.ForeColor = System.Drawing.Color.White
		Me.bt_salvar.Location = New System.Drawing.Point(46, 410)
		Me.bt_salvar.Name = "bt_salvar"
		Me.bt_salvar.Size = New System.Drawing.Size(98, 23)
		Me.bt_salvar.TabIndex = 20
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
		Me.bt_excluir.Location = New System.Drawing.Point(177, 410)
		Me.bt_excluir.Name = "bt_excluir"
		Me.bt_excluir.Size = New System.Drawing.Size(75, 23)
		Me.bt_excluir.TabIndex = 66
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
		Me.bt_editar.Location = New System.Drawing.Point(101, 410)
		Me.bt_editar.Name = "bt_editar"
		Me.bt_editar.Size = New System.Drawing.Size(75, 23)
		Me.bt_editar.TabIndex = 64
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
		Me.bt_novo.Location = New System.Drawing.Point(25, 410)
		Me.bt_novo.Name = "bt_novo"
		Me.bt_novo.Size = New System.Drawing.Size(75, 23)
		Me.bt_novo.TabIndex = 65
		Me.bt_novo.Text = "&Novo"
		Me.bt_novo.UseVisualStyleBackColor = false
		AddHandler Me.bt_novo.Click, AddressOf Me.Bt_novoClick
		'
		'tabProdutos
		'
		Me.tabProdutos.Controls.Add(Me.dgv_Produto)
		Me.tabProdutos.Controls.Add(Me.panelControl1)
		Me.tabProdutos.Controls.Add(Me.txt_LocalizarCategoria)
		Me.tabProdutos.Controls.Add(Me.label23)
		Me.tabProdutos.Controls.Add(Me.dgv_Categoria)
		Me.tabProdutos.Controls.Add(Me.pnl_prodfor)
		Me.tabProdutos.Controls.Add(Me.bt_inserir)
		Me.tabProdutos.Controls.Add(Me.lbl_NomeFantasia)
		Me.tabProdutos.Controls.Add(Me.dgv_produtos)
		Me.tabProdutos.Location = New System.Drawing.Point(4, 22)
		Me.tabProdutos.Name = "tabProdutos"
		Me.tabProdutos.Padding = New System.Windows.Forms.Padding(3)
		Me.tabProdutos.Size = New System.Drawing.Size(883, 445)
		Me.tabProdutos.TabIndex = 49
		Me.tabProdutos.Text = "Produtos (F5)"
		Me.tabProdutos.UseVisualStyleBackColor = true
		'
		'dgv_Produto
		'
		Me.dgv_Produto.AllowUserToAddRows = false
		Me.dgv_Produto.AllowUserToDeleteRows = false
		Me.dgv_Produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Produto.DefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_Produto.Location = New System.Drawing.Point(65, 242)
		Me.dgv_Produto.MultiSelect = false
		Me.dgv_Produto.Name = "dgv_Produto"
		Me.dgv_Produto.ReadOnly = true
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Produto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5
		Me.dgv_Produto.RowHeadersVisible = false
		Me.dgv_Produto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Produto.Size = New System.Drawing.Size(267, 150)
		Me.dgv_Produto.TabIndex = 7
		Me.dgv_Produto.Visible = false
		AddHandler Me.dgv_Produto.KeyDown, AddressOf Me.Dgv_ProdutoKeyDown
		'
		'panelControl1
		'
		Me.panelControl1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelControl1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.panelControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelControl1.Location = New System.Drawing.Point(26, 43)
		Me.panelControl1.Name = "panelControl1"
		Me.panelControl1.Size = New System.Drawing.Size(825, 18)
		'
		'
		'
		Me.panelControl1.Style.BackColor = System.Drawing.Color.SlateGray
		Me.panelControl1.Style.BackColor2 = System.Drawing.Color.SlateGray
		Me.panelControl1.Style.BackColorGradientAngle = 90
		Me.panelControl1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
		Me.panelControl1.Style.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(65,Byte),Integer), CType(CType(66,Byte),Integer))
		Me.panelControl1.Style.BorderBottomWidth = 1
		Me.panelControl1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(65,Byte),Integer), CType(CType(66,Byte),Integer))
		Me.panelControl1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
		Me.panelControl1.Style.BorderLeftWidth = 1
		Me.panelControl1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
		Me.panelControl1.Style.BorderRightWidth = 1
		Me.panelControl1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
		Me.panelControl1.Style.BorderTopWidth = 1
		Me.panelControl1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.panelControl1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
		Me.panelControl1.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		'
		'
		'
		Me.panelControl1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.panelControl1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.panelControl1.TabIndex = 19
		Me.panelControl1.Text = "  PRODUTOS"
		'
		'txt_LocalizarCategoria
		'
		Me.txt_LocalizarCategoria.Location = New System.Drawing.Point(374, 300)
		Me.txt_LocalizarCategoria.Name = "txt_LocalizarCategoria"
		Me.txt_LocalizarCategoria.Size = New System.Drawing.Size(182, 20)
		Me.txt_LocalizarCategoria.TabIndex = 18
		Me.txt_LocalizarCategoria.Visible = false
		AddHandler Me.txt_LocalizarCategoria.KeyDown, AddressOf Me.Txt_LocalizarCategoriaKeyDown
		'
		'label23
		'
		Me.label23.AutoSize = true
		Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label23.ForeColor = System.Drawing.Color.Navy
		Me.label23.Location = New System.Drawing.Point(26, 13)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(224, 24)
		Me.label23.TabIndex = 8
		Me.label23.Text = "Nome do Fornecedor :"
		'
		'dgv_Categoria
		'
		Me.dgv_Categoria.AllowUserToAddRows = false
		Me.dgv_Categoria.AllowUserToDeleteRows = false
		Me.dgv_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Categoria.ColumnHeadersVisible = false
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateGray
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Categoria.DefaultCellStyle = dataGridViewCellStyle6
		Me.dgv_Categoria.Location = New System.Drawing.Point(375, 326)
		Me.dgv_Categoria.MultiSelect = false
		Me.dgv_Categoria.Name = "dgv_Categoria"
		Me.dgv_Categoria.ReadOnly = true
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Categoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle7
		Me.dgv_Categoria.RowHeadersVisible = false
		Me.dgv_Categoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Categoria.Size = New System.Drawing.Size(181, 66)
		Me.dgv_Categoria.TabIndex = 6
		Me.dgv_Categoria.Visible = false
		AddHandler Me.dgv_Categoria.CellDoubleClick, AddressOf Me.Dgv_CategoriaCellDoubleClick
		AddHandler Me.dgv_Categoria.KeyDown, AddressOf Me.Dgv_CategoriaKeyDown
		AddHandler Me.dgv_Categoria.Leave, AddressOf Me.Dgv_CategoriaLeave
		'
		'pnl_prodfor
		'
		Me.pnl_prodfor.BackColor = System.Drawing.Color.SlateGray
		Me.pnl_prodfor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_prodfor.Controls.Add(Me.pnl_interno)
		Me.pnl_prodfor.Location = New System.Drawing.Point(32, 138)
		Me.pnl_prodfor.Name = "pnl_prodfor"
		Me.pnl_prodfor.Size = New System.Drawing.Size(799, 156)
		Me.pnl_prodfor.TabIndex = 5
		Me.pnl_prodfor.Visible = false
		'
		'pnl_interno
		'
		Me.pnl_interno.BackColor = System.Drawing.SystemColors.Control
		Me.pnl_interno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_interno.Controls.Add(Me.bt_ok)
		Me.pnl_interno.Controls.Add(Me.gb_prodFor)
		Me.pnl_interno.Location = New System.Drawing.Point(3, 4)
		Me.pnl_interno.Name = "pnl_interno"
		Me.pnl_interno.Size = New System.Drawing.Size(789, 146)
		Me.pnl_interno.TabIndex = 6
		'
		'bt_ok
		'
		Me.bt_ok.BackColor = System.Drawing.SystemColors.Control
		Me.bt_ok.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
		Me.bt_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_ok.Location = New System.Drawing.Point(689, 113)
		Me.bt_ok.Name = "bt_ok"
		Me.bt_ok.Size = New System.Drawing.Size(58, 23)
		Me.bt_ok.TabIndex = 14
		Me.bt_ok.Text = "&OK"
		Me.bt_ok.UseVisualStyleBackColor = false
		AddHandler Me.bt_ok.Click, AddressOf Me.Bt_ok_Click
		'
		'gb_prodFor
		'
		Me.gb_prodFor.Controls.Add(Me.label22)
		Me.gb_prodFor.Controls.Add(Me.txt_Categoria)
		Me.gb_prodFor.Controls.Add(Me.txt_Produto)
		Me.gb_prodFor.Controls.Add(Me.label21)
		Me.gb_prodFor.Controls.Add(Me.txt_precoVenda)
		Me.gb_prodFor.Controls.Add(Me.txt_precocusto)
		Me.gb_prodFor.Controls.Add(Me.label4)
		Me.gb_prodFor.Controls.Add(Me.label3)
		Me.gb_prodFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_prodFor.ForeColor = System.Drawing.Color.Navy
		Me.gb_prodFor.Location = New System.Drawing.Point(11, 18)
		Me.gb_prodFor.Name = "gb_prodFor"
		Me.gb_prodFor.Size = New System.Drawing.Size(761, 90)
		Me.gb_prodFor.TabIndex = 7
		Me.gb_prodFor.TabStop = false
		Me.gb_prodFor.Text = "ADICIONE PRODUTOS PARA ESTE FORNECEDOR"
		'
		'label22
		'
		Me.label22.AutoSize = true
		Me.label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label22.Location = New System.Drawing.Point(291, 36)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(61, 13)
		Me.label22.TabIndex = 12
		Me.label22.Text = "Categoria"
		'
		'txt_Categoria
		'
		Me.txt_Categoria.Location = New System.Drawing.Point(289, 53)
		Me.txt_Categoria.Name = "txt_Categoria"
		Me.txt_Categoria.ReadOnly = true
		Me.txt_Categoria.Size = New System.Drawing.Size(182, 20)
		Me.txt_Categoria.TabIndex = 16
		AddHandler Me.txt_Categoria.KeyDown, AddressOf Me.Txt_CategoriaKeyDown
		'
		'txt_Produto
		'
		Me.txt_Produto.Location = New System.Drawing.Point(16, 53)
		Me.txt_Produto.Name = "txt_Produto"
		Me.txt_Produto.Size = New System.Drawing.Size(267, 20)
		Me.txt_Produto.TabIndex = 15
		AddHandler Me.txt_Produto.KeyDown, AddressOf Me.Txt_ProdutoKeyDown
		'
		'label21
		'
		Me.label21.AutoSize = true
		Me.label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label21.Location = New System.Drawing.Point(612, 37)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(97, 13)
		Me.label21.TabIndex = 14
		Me.label21.Text = "Preço de venda"
		'
		'txt_precoVenda
		'
		Me.txt_precoVenda.Location = New System.Drawing.Point(612, 53)
		Me.txt_precoVenda.Name = "txt_precoVenda"
		Me.txt_precoVenda.Size = New System.Drawing.Size(124, 20)
		Me.txt_precoVenda.TabIndex = 18
		AddHandler Me.txt_precoVenda.Enter, AddressOf Me.Txt_precoVendaEnter
		AddHandler Me.txt_precoVenda.KeyDown, AddressOf Me.Txt_precoVenda_KeyDown
		AddHandler Me.txt_precoVenda.Leave, AddressOf Me.Txt_precoVenda_Leave
		'
		'txt_precocusto
		'
		Me.txt_precocusto.Location = New System.Drawing.Point(477, 54)
		Me.txt_precocusto.Name = "txt_precocusto"
		Me.txt_precocusto.Size = New System.Drawing.Size(124, 20)
		Me.txt_precocusto.TabIndex = 17
		AddHandler Me.txt_precocusto.Enter, AddressOf Me.Txt_precocustoEnter
		AddHandler Me.txt_precocusto.KeyDown, AddressOf Me.Txt_precocusto_KeyDown
		AddHandler Me.txt_precocusto.Leave, AddressOf Me.Txt_precocusto_Leave
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label4.Location = New System.Drawing.Point(480, 37)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(93, 13)
		Me.label4.TabIndex = 9
		Me.label4.Text = "Preço de custo"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label3.Location = New System.Drawing.Point(16, 36)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(87, 13)
		Me.label3.TabIndex = 8
		Me.label3.Text = "Nome Produto"
		'
		'bt_inserir
		'
		Me.bt_inserir.AccessibleDescription = ""
		Me.bt_inserir.BackColor = System.Drawing.Color.SlateGray
		Me.bt_inserir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_inserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bt_inserir.ForeColor = System.Drawing.Color.White
		Me.bt_inserir.Image = CType(resources.GetObject("bt_inserir.Image"),System.Drawing.Image)
		Me.bt_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_inserir.Location = New System.Drawing.Point(781, 10)
		Me.bt_inserir.Name = "bt_inserir"
		Me.bt_inserir.Size = New System.Drawing.Size(72, 27)
		Me.bt_inserir.TabIndex = 2
		Me.bt_inserir.Tag = ""
		Me.bt_inserir.Text = "&Inserir"
		Me.bt_inserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.bt_inserir.UseVisualStyleBackColor = false
		Me.bt_inserir.Visible = false
		AddHandler Me.bt_inserir.Click, AddressOf Me.Bt_inserir_Click
		'
		'lbl_NomeFantasia
		'
		Me.lbl_NomeFantasia.AutoSize = true
		Me.lbl_NomeFantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_NomeFantasia.ForeColor = System.Drawing.Color.Navy
		Me.lbl_NomeFantasia.Location = New System.Drawing.Point(255, 14)
		Me.lbl_NomeFantasia.Name = "lbl_NomeFantasia"
		Me.lbl_NomeFantasia.Size = New System.Drawing.Size(343, 24)
		Me.lbl_NomeFantasia.TabIndex = 0
		Me.lbl_NomeFantasia.Text = "Escolha um Fornecedor - Press. F1"
		'
		'dgv_produtos
		'
		Me.dgv_produtos.AllowUserToAddRows = false
		Me.dgv_produtos.AllowUserToDeleteRows = false
		Me.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8
		Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateGray
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_produtos.DefaultCellStyle = dataGridViewCellStyle9
		Me.dgv_produtos.Location = New System.Drawing.Point(24, 64)
		Me.dgv_produtos.MultiSelect = false
		Me.dgv_produtos.Name = "dgv_produtos"
		Me.dgv_produtos.ReadOnly = true
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10
		Me.dgv_produtos.RowHeadersVisible = false
		Me.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_produtos.Size = New System.Drawing.Size(829, 369)
		Me.dgv_produtos.TabIndex = 4
		AddHandler Me.dgv_produtos.DoubleClick, AddressOf Me.Dgv_produtos_DoubleClick
		AddHandler Me.dgv_produtos.KeyDown, AddressOf Me.Dgv_produtos_KeyDown
		'
		'toolTip1
		'
		Me.toolTip1.IsBalloon = true
		'
		'panelEx3
		'
		Me.panelEx3.CanvasColor = System.Drawing.SystemColors.Control
		Me.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
		Me.panelEx3.Controls.Add(Me.bt_Fechar)
		Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx3.Location = New System.Drawing.Point(0, 556)
		Me.panelEx3.Name = "panelEx3"
		Me.panelEx3.Size = New System.Drawing.Size(924, 39)
		Me.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelEx3.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
		Me.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx3.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.panelEx3.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx3.Style.ForeColor.Color = System.Drawing.Color.White
		Me.panelEx3.Style.GradientAngle = 90
		Me.panelEx3.TabIndex = 72
		Me.panelEx3.Text = " F1 Localizar / F3 Cadastrar"
		'
		'bt_Fechar
		'
		Me.bt_Fechar.BackColor = System.Drawing.Color.Transparent
		Me.bt_Fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_Fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.bt_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
		Me.bt_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_Fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bt_Fechar.ForeColor = System.Drawing.Color.White
		Me.bt_Fechar.Location = New System.Drawing.Point(832, 6)
		Me.bt_Fechar.Name = "bt_Fechar"
		Me.bt_Fechar.Size = New System.Drawing.Size(75, 28)
		Me.bt_Fechar.TabIndex = 2
		Me.bt_Fechar.Text = "&Fechar"
		Me.bt_Fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_Fechar.Click, AddressOf Me.Bt_FecharClick
		'
		'panelEx1
		'
		Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
		Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
		Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx1.Location = New System.Drawing.Point(0, 0)
		Me.panelEx1.Name = "panelEx1"
		Me.panelEx1.Size = New System.Drawing.Size(924, 35)
		Me.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelEx1.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
		Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx1.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.panelEx1.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx1.Style.ForeColor.Color = System.Drawing.Color.White
		Me.panelEx1.Style.GradientAngle = 90
		Me.panelEx1.TabIndex = 71
		Me.panelEx1.Text = " CADASTRO DE FORNECEDORES"
		'
		'FormFornecedores
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(924, 595)
		Me.Controls.Add(Me.panelEx3)
		Me.Controls.Add(Me.panelEx1)
		Me.Controls.Add(Me.tabControl1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = true
		Me.Name = "FormFornecedores"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FORNECEDORES"
		AddHandler Shown, AddressOf Me.FormFornecedores_Shown
		AddHandler KeyDown, AddressOf Me.FormFornecedoresKeyDown
		AddHandler KeyPress, AddressOf Me.FormFornecedores_KeyPress
		Me.tabControl1.ResumeLayout(false)
		Me.tabLocalizar.ResumeLayout(false)
		CType(Me.dgv_Fornecedor,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.tabCadastrar.ResumeLayout(false)
		Me.tabControl2.ResumeLayout(false)
		Me.tabFornecedor.ResumeLayout(false)
		Me.gb_idcliente.ResumeLayout(false)
		Me.gb_idcliente.PerformLayout
		Me.gb_dados.ResumeLayout(false)
		Me.gb_dados.PerformLayout
		Me.gb_endereco.ResumeLayout(false)
		Me.gb_endereco.PerformLayout
		Me.gb_Contatos.ResumeLayout(false)
		Me.gb_Contatos.PerformLayout
		Me.gb_pessoa.ResumeLayout(false)
		Me.gb_pessoa.PerformLayout
		Me.panel5.ResumeLayout(false)
		Me.tabProdutos.ResumeLayout(false)
		Me.tabProdutos.PerformLayout
		CType(Me.dgv_Produto,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dgv_Categoria,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_prodfor.ResumeLayout(false)
		Me.pnl_interno.ResumeLayout(false)
		Me.gb_prodFor.ResumeLayout(false)
		Me.gb_prodFor.PerformLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).EndInit
		Me.panelEx3.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private panelEx1 As DevComponents.DotNetBar.PanelEx
	Private bt_Fechar As System.Windows.Forms.Button
	Private panelEx3 As DevComponents.DotNetBar.PanelEx
	Private panelControl1 As DevComponents.DotNetBar.PanelControl
	Private label23 As System.Windows.Forms.Label
	Private dgv_Produto As System.Windows.Forms.DataGridView
	Private txt_LocalizarCategoria As System.Windows.Forms.TextBox
	Private txt_Produto As System.Windows.Forms.TextBox
	Private txt_Categoria As System.Windows.Forms.TextBox
	Private label22 As System.Windows.Forms.Label
	Private dgv_Categoria As System.Windows.Forms.DataGridView
	Private txt_precoVenda As System.Windows.Forms.TextBox
	Private label21 As System.Windows.Forms.Label
	Private txt_precocusto As System.Windows.Forms.TextBox
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private dgv_produtos As System.Windows.Forms.DataGridView
	Private pnl_prodfor As System.Windows.Forms.Panel
	Private pnl_interno As System.Windows.Forms.Panel
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private bt_ok As System.Windows.Forms.Button
	Private gb_prodFor As System.Windows.Forms.GroupBox
	Private bt_inserir As System.Windows.Forms.Button
	Private lbl_NomeFantasia As System.Windows.Forms.Label
	Private tabProdutos As System.Windows.Forms.TabPage
	Private gb_idcliente As System.Windows.Forms.GroupBox
	Private txt_fone4 As System.Windows.Forms.TextBox
	Private label20 As System.Windows.Forms.Label
	Private gb_dados As System.Windows.Forms.GroupBox
	Private gb_Contatos As System.Windows.Forms.GroupBox
	Private gb_endereco As System.Windows.Forms.GroupBox
	Private txt_InscEstadual As System.Windows.Forms.TextBox
	Private txt_NomeFantasia As System.Windows.Forms.TextBox
	Private txt_RazaoSocial As System.Windows.Forms.TextBox
	Private txt_site As System.Windows.Forms.TextBox
	Private txt_endereco As System.Windows.Forms.TextBox
	Private txt_complemento As System.Windows.Forms.TextBox
	Private txt_bairro As System.Windows.Forms.TextBox
	Private txt_cep As System.Windows.Forms.TextBox
	Private txt_estado As System.Windows.Forms.TextBox
	Private txt_fone1 As System.Windows.Forms.TextBox
	Private txt_fone2 As System.Windows.Forms.TextBox
	Private txt_fone3 As System.Windows.Forms.TextBox
	Private txt_email1 As System.Windows.Forms.TextBox
	Private txt_email2 As System.Windows.Forms.TextBox
	Private txt_cidade As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private label18 As System.Windows.Forms.Label
	Private label19 As System.Windows.Forms.Label
	Private rb_Fisica As System.Windows.Forms.RadioButton
	Private rb_juridica As System.Windows.Forms.RadioButton
	Private gb_pessoa As System.Windows.Forms.GroupBox
	Private panel4 As System.Windows.Forms.Panel
	Private panel6 As System.Windows.Forms.Panel
	Private panel5 As System.Windows.Forms.Panel
	Private panel3 As System.Windows.Forms.Panel
	Private bt_novo As System.Windows.Forms.Button
	Private bt_editar As System.Windows.Forms.Button
	Private bt_excluir As System.Windows.Forms.Button
	Private bt_salvar As System.Windows.Forms.Button
	Private lbl_cpfCnpj As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private txt_idFornecedor As System.Windows.Forms.TextBox
	Private txt_CpfCnpj As System.Windows.Forms.TextBox
	Private tabFornecedor As System.Windows.Forms.TabPage
	Private tabControl2 As System.Windows.Forms.TabControl
	Private txt_Localizar As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private dgv_Fornecedor As System.Windows.Forms.DataGridView
	Private tabCadastrar As System.Windows.Forms.TabPage
	Private tabLocalizar As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
	
	

End Class
