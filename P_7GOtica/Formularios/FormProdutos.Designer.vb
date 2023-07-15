'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormProdutos
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
		Dim dataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabLocalizar = New System.Windows.Forms.TabPage()
		Me.dgv_Produtos = New System.Windows.Forms.DataGridView()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_Localizar = New System.Windows.Forms.TextBox()
		Me.tabCadastrar = New System.Windows.Forms.TabPage()
		Me.tabControl2 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.dgv_Fornecedor = New System.Windows.Forms.DataGridView()
		Me.dgv_Categorias = New System.Windows.Forms.DataGridView()
		Me.txt_precoVenda = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.txt_precoCusto = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.txt_pesquisaFornecedor = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txt_Fornecedor = New System.Windows.Forms.TextBox()
		Me.lbl_imagem = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.txt_CDB = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txt_pesquisaCategoria = New System.Windows.Forms.TextBox()
		Me.txt_categoria = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
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
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.lbl_fornecedor = New System.Windows.Forms.Label()
		Me.lbl14 = New System.Windows.Forms.Label()
		Me.lbl_idProduto = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.bt_confirmar = New System.Windows.Forms.Button()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.panel7 = New System.Windows.Forms.Panel()
		Me.panel8 = New System.Windows.Forms.Panel()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.lbl_NomeProduto = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
		Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
		Me.bt_Fechar = New System.Windows.Forms.Button()
		Me.OFD = New System.Windows.Forms.OpenFileDialog()
		Me.panelEx2 = New DevComponents.DotNetBar.PanelEx()
		Me.lbl_qtdLoja = New System.Windows.Forms.Label()
		Me.lbl_qtdEstoque = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.tabControl1.SuspendLayout
		Me.tabLocalizar.SuspendLayout
		CType(Me.dgv_Produtos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.tabCadastrar.SuspendLayout
		Me.tabControl2.SuspendLayout
		Me.tabPage1.SuspendLayout
		CType(Me.dgv_Fornecedor,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dgv_Categorias,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel3.SuspendLayout
		Me.tabPage2.SuspendLayout
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel7.SuspendLayout
		Me.panel5.SuspendLayout
		Me.panelEx3.SuspendLayout
		Me.panelEx2.SuspendLayout
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
		Me.tabControl1.Size = New System.Drawing.Size(720, 437)
		Me.tabControl1.TabIndex = 1
		'
		'tabLocalizar
		'
		Me.tabLocalizar.Controls.Add(Me.dgv_Produtos)
		Me.tabLocalizar.Controls.Add(Me.groupBox1)
		Me.tabLocalizar.Location = New System.Drawing.Point(4, 25)
		Me.tabLocalizar.Name = "tabLocalizar"
		Me.tabLocalizar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLocalizar.Size = New System.Drawing.Size(712, 408)
		Me.tabLocalizar.TabIndex = 0
		Me.tabLocalizar.Text = "Localizar"
		Me.tabLocalizar.UseVisualStyleBackColor = true
		AddHandler Me.tabLocalizar.Enter, AddressOf Me.TabLocalizarEnter
		'
		'dgv_Produtos
		'
		Me.dgv_Produtos.AllowUserToAddRows = false
		Me.dgv_Produtos.AllowUserToDeleteRows = false
		Me.dgv_Produtos.AllowUserToOrderColumns = true
		Me.dgv_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue
		dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Produtos.DefaultCellStyle = dataGridViewCellStyle16
		Me.dgv_Produtos.Location = New System.Drawing.Point(8, 60)
		Me.dgv_Produtos.MultiSelect = false
		Me.dgv_Produtos.Name = "dgv_Produtos"
		Me.dgv_Produtos.ReadOnly = true
		Me.dgv_Produtos.RowHeadersVisible = false
		Me.dgv_Produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Produtos.Size = New System.Drawing.Size(698, 342)
		Me.dgv_Produtos.TabIndex = 1
		AddHandler Me.dgv_Produtos.DoubleClick, AddressOf Me.Dgv_Produtos_DoubleClick
		AddHandler Me.dgv_Produtos.KeyDown, AddressOf Me.Dgv_ProdutosKeyDown
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_Localizar)
		Me.groupBox1.ForeColor = System.Drawing.Color.Navy
		Me.groupBox1.Location = New System.Drawing.Point(8, 6)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(698, 48)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Digite o Nome do Produto"
		'
		'txt_Localizar
		'
		Me.txt_Localizar.Location = New System.Drawing.Point(8, 20)
		Me.txt_Localizar.Name = "txt_Localizar"
		Me.txt_Localizar.Size = New System.Drawing.Size(346, 20)
		Me.txt_Localizar.TabIndex = 0
		AddHandler Me.txt_Localizar.KeyDown, AddressOf Me.Txt_LocalizarKeyDown
		'
		'tabCadastrar
		'
		Me.tabCadastrar.Controls.Add(Me.tabControl2)
		Me.tabCadastrar.Location = New System.Drawing.Point(4, 25)
		Me.tabCadastrar.Name = "tabCadastrar"
		Me.tabCadastrar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCadastrar.Size = New System.Drawing.Size(712, 408)
		Me.tabCadastrar.TabIndex = 1
		Me.tabCadastrar.Text = "Cadastrar"
		Me.tabCadastrar.UseVisualStyleBackColor = true
		'
		'tabControl2
		'
		Me.tabControl2.Controls.Add(Me.tabPage1)
		Me.tabControl2.Controls.Add(Me.tabPage2)
		Me.tabControl2.Location = New System.Drawing.Point(36, 19)
		Me.tabControl2.Name = "tabControl2"
		Me.tabControl2.SelectedIndex = 0
		Me.tabControl2.Size = New System.Drawing.Size(625, 364)
		Me.tabControl2.TabIndex = 0
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.dgv_Fornecedor)
		Me.tabPage1.Controls.Add(Me.dgv_Categorias)
		Me.tabPage1.Controls.Add(Me.txt_precoVenda)
		Me.tabPage1.Controls.Add(Me.label7)
		Me.tabPage1.Controls.Add(Me.txt_precoCusto)
		Me.tabPage1.Controls.Add(Me.label6)
		Me.tabPage1.Controls.Add(Me.txt_pesquisaFornecedor)
		Me.tabPage1.Controls.Add(Me.label2)
		Me.tabPage1.Controls.Add(Me.txt_Fornecedor)
		Me.tabPage1.Controls.Add(Me.lbl_imagem)
		Me.tabPage1.Controls.Add(Me.panel1)
		Me.tabPage1.Controls.Add(Me.txt_CDB)
		Me.tabPage1.Controls.Add(Me.label1)
		Me.tabPage1.Controls.Add(Me.pictureBox1)
		Me.tabPage1.Controls.Add(Me.txt_pesquisaCategoria)
		Me.tabPage1.Controls.Add(Me.txt_categoria)
		Me.tabPage1.Controls.Add(Me.label5)
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
		Me.tabPage1.Size = New System.Drawing.Size(617, 338)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Cadastro Produtos"
		Me.tabPage1.UseVisualStyleBackColor = true
		'
		'dgv_Fornecedor
		'
		Me.dgv_Fornecedor.AllowUserToAddRows = false
		Me.dgv_Fornecedor.AllowUserToDeleteRows = false
		Me.dgv_Fornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Fornecedor.ColumnHeadersVisible = false
		dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightSlateGray
		dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Fornecedor.DefaultCellStyle = dataGridViewCellStyle17
		Me.dgv_Fornecedor.Location = New System.Drawing.Point(296, 29)
		Me.dgv_Fornecedor.MultiSelect = false
		Me.dgv_Fornecedor.Name = "dgv_Fornecedor"
		Me.dgv_Fornecedor.ReadOnly = true
		dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Fornecedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle18
		Me.dgv_Fornecedor.RowHeadersVisible = false
		Me.dgv_Fornecedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Fornecedor.Size = New System.Drawing.Size(56, 33)
		Me.dgv_Fornecedor.TabIndex = 28
		Me.dgv_Fornecedor.Visible = false
		AddHandler Me.dgv_Fornecedor.DoubleClick, AddressOf Me.Dgv_FornecedorDoubleClick
		AddHandler Me.dgv_Fornecedor.KeyDown, AddressOf Me.Dgv_FornecedorKeyDown
		'
		'dgv_Categorias
		'
		Me.dgv_Categorias.AllowUserToAddRows = false
		Me.dgv_Categorias.AllowUserToDeleteRows = false
		Me.dgv_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Categorias.ColumnHeadersVisible = false
		dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSlateGray
		dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Categorias.DefaultCellStyle = dataGridViewCellStyle19
		Me.dgv_Categorias.Location = New System.Drawing.Point(220, 29)
		Me.dgv_Categorias.MultiSelect = false
		Me.dgv_Categorias.Name = "dgv_Categorias"
		Me.dgv_Categorias.ReadOnly = true
		dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Categorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle20
		Me.dgv_Categorias.RowHeadersVisible = false
		Me.dgv_Categorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Categorias.Size = New System.Drawing.Size(57, 30)
		Me.dgv_Categorias.TabIndex = 10
		Me.dgv_Categorias.Visible = false
		AddHandler Me.dgv_Categorias.DoubleClick, AddressOf Me.Dgv_CategoriasDoubleClick
		AddHandler Me.dgv_Categorias.KeyDown, AddressOf Me.Dgv_CategoriasKeyDown
		'
		'txt_precoVenda
		'
		Me.txt_precoVenda.Enabled = false
		Me.txt_precoVenda.Location = New System.Drawing.Point(114, 232)
		Me.txt_precoVenda.Name = "txt_precoVenda"
		Me.txt_precoVenda.Size = New System.Drawing.Size(253, 20)
		Me.txt_precoVenda.TabIndex = 32
		AddHandler Me.txt_precoVenda.KeyDown, AddressOf Me.Txt_precoVendaKeyDown
		AddHandler Me.txt_precoVenda.Leave, AddressOf Me.Txt_precoVendaLeave
		'
		'label7
		'
		Me.label7.AutoSize = true
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label7.Location = New System.Drawing.Point(15, 236)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(95, 13)
		Me.label7.TabIndex = 31
		Me.label7.Text = "PREÇO VENDA"
		'
		'txt_precoCusto
		'
		Me.txt_precoCusto.Enabled = false
		Me.txt_precoCusto.Location = New System.Drawing.Point(114, 201)
		Me.txt_precoCusto.Name = "txt_precoCusto"
		Me.txt_precoCusto.Size = New System.Drawing.Size(253, 20)
		Me.txt_precoCusto.TabIndex = 30
		AddHandler Me.txt_precoCusto.KeyDown, AddressOf Me.Txt_precoCustoKeyDown
		AddHandler Me.txt_precoCusto.Leave, AddressOf Me.Txt_precoCustoLeave
		'
		'label6
		'
		Me.label6.AutoSize = true
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label6.Location = New System.Drawing.Point(15, 205)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(95, 13)
		Me.label6.TabIndex = 29
		Me.label6.Text = "PREÇO CUSTO"
		'
		'txt_pesquisaFornecedor
		'
		Me.txt_pesquisaFornecedor.Location = New System.Drawing.Point(114, 167)
		Me.txt_pesquisaFornecedor.Name = "txt_pesquisaFornecedor"
		Me.txt_pesquisaFornecedor.Size = New System.Drawing.Size(253, 20)
		Me.txt_pesquisaFornecedor.TabIndex = 27
		Me.txt_pesquisaFornecedor.Visible = false
		AddHandler Me.txt_pesquisaFornecedor.KeyDown, AddressOf Me.Txt_pesquisaFornecedorKeyDown
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label2.Location = New System.Drawing.Point(19, 171)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(92, 13)
		Me.label2.TabIndex = 26
		Me.label2.Text = "FORNECEDOR"
		'
		'txt_Fornecedor
		'
		Me.txt_Fornecedor.Enabled = false
		Me.txt_Fornecedor.Location = New System.Drawing.Point(114, 167)
		Me.txt_Fornecedor.Name = "txt_Fornecedor"
		Me.txt_Fornecedor.ReadOnly = true
		Me.txt_Fornecedor.Size = New System.Drawing.Size(253, 20)
		Me.txt_Fornecedor.TabIndex = 25
		AddHandler Me.txt_Fornecedor.KeyDown, AddressOf Me.Txt_FornecedorKeyDown
		'
		'lbl_imagem
		'
		Me.lbl_imagem.AutoSize = true
		Me.lbl_imagem.Cursor = System.Windows.Forms.Cursors.Hand
		Me.lbl_imagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbl_imagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_imagem.ForeColor = System.Drawing.Color.Navy
		Me.lbl_imagem.Location = New System.Drawing.Point(408, 263)
		Me.lbl_imagem.Name = "lbl_imagem"
		Me.lbl_imagem.Size = New System.Drawing.Size(168, 13)
		Me.lbl_imagem.TabIndex = 24
		Me.lbl_imagem.Text = "Carregar Imagem do Produto"
		AddHandler Me.lbl_imagem.Click, AddressOf Me.Lbl_imagemClick
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.LightSlateGray
		Me.panel1.Controls.Add(Me.panel2)
		Me.panel1.Location = New System.Drawing.Point(13, 285)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(594, 2)
		Me.panel1.TabIndex = 16
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel2.Location = New System.Drawing.Point(0, 159)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(705, 1)
		Me.panel2.TabIndex = 15
		'
		'txt_CDB
		'
		Me.txt_CDB.Location = New System.Drawing.Point(114, 73)
		Me.txt_CDB.Name = "txt_CDB"
		Me.txt_CDB.Size = New System.Drawing.Size(253, 20)
		Me.txt_CDB.TabIndex = 23
		AddHandler Me.txt_CDB.KeyDown, AddressOf Me.Txt_CDBKeyDown
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(58, 77)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(52, 13)
		Me.label1.TabIndex = 22
		Me.label1.Text = "C. D. B."
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default
		Me.pictureBox1.Location = New System.Drawing.Point(379, 20)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(224, 235)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 21
		Me.pictureBox1.TabStop = false
		'
		'txt_pesquisaCategoria
		'
		Me.txt_pesquisaCategoria.Location = New System.Drawing.Point(114, 136)
		Me.txt_pesquisaCategoria.Name = "txt_pesquisaCategoria"
		Me.txt_pesquisaCategoria.Size = New System.Drawing.Size(253, 20)
		Me.txt_pesquisaCategoria.TabIndex = 20
		Me.txt_pesquisaCategoria.Visible = false
		AddHandler Me.txt_pesquisaCategoria.KeyDown, AddressOf Me.Txt_pesquisaCategoriaKeyDown
		'
		'txt_categoria
		'
		Me.txt_categoria.Location = New System.Drawing.Point(114, 136)
		Me.txt_categoria.Name = "txt_categoria"
		Me.txt_categoria.ReadOnly = true
		Me.txt_categoria.Size = New System.Drawing.Size(253, 20)
		Me.txt_categoria.TabIndex = 19
		AddHandler Me.txt_categoria.KeyDown, AddressOf Me.Txt_categoriaKeyDown
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label5.Location = New System.Drawing.Point(33, 139)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(78, 13)
		Me.label5.TabIndex = 16
		Me.label5.Text = "CATEGORIA"
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.LightSlateGray
		Me.panel3.Controls.Add(Me.panel4)
		Me.panel3.Location = New System.Drawing.Point(13, 12)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(594, 2)
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
		Me.bt_salvar.BackColor = System.Drawing.Color.LightSlateGray
		Me.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_salvar.ForeColor = System.Drawing.Color.White
		Me.bt_salvar.Location = New System.Drawing.Point(37, 302)
		Me.bt_salvar.Name = "bt_salvar"
		Me.bt_salvar.Size = New System.Drawing.Size(98, 23)
		Me.bt_salvar.TabIndex = 18
		Me.bt_salvar.Text = "&Salvar"
		Me.bt_salvar.UseVisualStyleBackColor = false
		Me.bt_salvar.Visible = false
		AddHandler Me.bt_salvar.Click, AddressOf Me.Bt_salvarClick
		AddHandler Me.bt_salvar.KeyDown, AddressOf Me.Bt_salvar_KeyDown
		'
		'bt_excluir
		'
		Me.bt_excluir.BackColor = System.Drawing.Color.LightSlateGray
		Me.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_excluir.ForeColor = System.Drawing.Color.White
		Me.bt_excluir.Location = New System.Drawing.Point(168, 302)
		Me.bt_excluir.Name = "bt_excluir"
		Me.bt_excluir.Size = New System.Drawing.Size(75, 23)
		Me.bt_excluir.TabIndex = 12
		Me.bt_excluir.Text = "E&xcluir"
		Me.bt_excluir.UseVisualStyleBackColor = false
		AddHandler Me.bt_excluir.Click, AddressOf Me.Bt_excluirClick
		'
		'bt_editar
		'
		Me.bt_editar.BackColor = System.Drawing.Color.LightSlateGray
		Me.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_editar.ForeColor = System.Drawing.Color.White
		Me.bt_editar.Location = New System.Drawing.Point(92, 302)
		Me.bt_editar.Name = "bt_editar"
		Me.bt_editar.Size = New System.Drawing.Size(75, 23)
		Me.bt_editar.TabIndex = 11
		Me.bt_editar.Text = "&Editar"
		Me.bt_editar.UseVisualStyleBackColor = false
		AddHandler Me.bt_editar.Click, AddressOf Me.Bt_editarClick
		'
		'bt_novo
		'
		Me.bt_novo.BackColor = System.Drawing.Color.LightSlateGray
		Me.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_novo.ForeColor = System.Drawing.Color.White
		Me.bt_novo.Location = New System.Drawing.Point(16, 302)
		Me.bt_novo.Name = "bt_novo"
		Me.bt_novo.Size = New System.Drawing.Size(75, 23)
		Me.bt_novo.TabIndex = 10
		Me.bt_novo.Text = "&Novo"
		Me.bt_novo.UseVisualStyleBackColor = false
		AddHandler Me.bt_novo.Click, AddressOf Me.Bt_novoClick
		'
		'txt_nome
		'
		Me.txt_nome.Location = New System.Drawing.Point(114, 106)
		Me.txt_nome.Name = "txt_nome"
		Me.txt_nome.Size = New System.Drawing.Size(253, 20)
		Me.txt_nome.TabIndex = 6
		AddHandler Me.txt_nome.KeyDown, AddressOf Me.Txt_nomeKeyDown
		'
		'txt_id
		'
		Me.txt_id.Location = New System.Drawing.Point(114, 39)
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
		Me.label4.Location = New System.Drawing.Point(3, 109)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(108, 13)
		Me.label4.TabIndex = 1
		Me.label4.Text = "NOME RPODUTO"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.label3.Location = New System.Drawing.Point(90, 42)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(20, 13)
		Me.label3.TabIndex = 0
		Me.label3.Text = "ID"
		'
		'tabPage2
		'
		Me.tabPage2.Controls.Add(Me.panelEx2)
		Me.tabPage2.Controls.Add(Me.lbl_fornecedor)
		Me.tabPage2.Controls.Add(Me.lbl14)
		Me.tabPage2.Controls.Add(Me.lbl_idProduto)
		Me.tabPage2.Controls.Add(Me.label13)
		Me.tabPage2.Controls.Add(Me.bt_confirmar)
		Me.tabPage2.Controls.Add(Me.label12)
		Me.tabPage2.Controls.Add(Me.label11)
		Me.tabPage2.Controls.Add(Me.numericUpDown1)
		Me.tabPage2.Controls.Add(Me.panel7)
		Me.tabPage2.Controls.Add(Me.panel5)
		Me.tabPage2.Controls.Add(Me.lbl_NomeProduto)
		Me.tabPage2.Controls.Add(Me.label8)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(617, 338)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Loja Produtos"
		Me.tabPage2.UseVisualStyleBackColor = true
		'
		'lbl_fornecedor
		'
		Me.lbl_fornecedor.AutoSize = true
		Me.lbl_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_fornecedor.ForeColor = System.Drawing.Color.Navy
		Me.lbl_fornecedor.Location = New System.Drawing.Point(143, 69)
		Me.lbl_fornecedor.Name = "lbl_fornecedor"
		Me.lbl_fornecedor.Size = New System.Drawing.Size(0, 13)
		Me.lbl_fornecedor.TabIndex = 26
		'
		'lbl14
		'
		Me.lbl14.AutoSize = true
		Me.lbl14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl14.Location = New System.Drawing.Point(25, 68)
		Me.lbl14.Name = "lbl14"
		Me.lbl14.Size = New System.Drawing.Size(96, 16)
		Me.lbl14.TabIndex = 25
		Me.lbl14.Text = "Fornecedor: "
		'
		'lbl_idProduto
		'
		Me.lbl_idProduto.AutoSize = true
		Me.lbl_idProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_idProduto.ForeColor = System.Drawing.Color.Navy
		Me.lbl_idProduto.Location = New System.Drawing.Point(143, 13)
		Me.lbl_idProduto.Name = "lbl_idProduto"
		Me.lbl_idProduto.Size = New System.Drawing.Size(0, 13)
		Me.lbl_idProduto.TabIndex = 24
		'
		'label13
		'
		Me.label13.AutoSize = true
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label13.Location = New System.Drawing.Point(25, 13)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(85, 16)
		Me.label13.TabIndex = 23
		Me.label13.Text = "ID Produto:"
		'
		'bt_confirmar
		'
		Me.bt_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_confirmar.Location = New System.Drawing.Point(277, 286)
		Me.bt_confirmar.Name = "bt_confirmar"
		Me.bt_confirmar.Size = New System.Drawing.Size(107, 31)
		Me.bt_confirmar.TabIndex = 22
		Me.bt_confirmar.Text = "Confirmar"
		Me.bt_confirmar.UseVisualStyleBackColor = true
		AddHandler Me.bt_confirmar.Click, AddressOf Me.Bt_confirmarClick
		'
		'label12
		'
		Me.label12.AutoSize = true
		Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label12.Location = New System.Drawing.Point(151, 246)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(233, 16)
		Me.label12.TabIndex = 21
		Me.label12.Text = "Escolha a quantidade desejada:"
		'
		'label11
		'
		Me.label11.AutoSize = true
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.ForeColor = System.Drawing.Color.Navy
		Me.label11.Location = New System.Drawing.Point(127, 202)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(365, 24)
		Me.label11.TabIndex = 20
		Me.label11.Text = "ADICIONE ESTE PRODUTO NA LOJA"
		'
		'numericUpDown1
		'
		Me.numericUpDown1.Location = New System.Drawing.Point(390, 242)
		Me.numericUpDown1.Name = "numericUpDown1"
		Me.numericUpDown1.Size = New System.Drawing.Size(77, 20)
		Me.numericUpDown1.TabIndex = 19
		'
		'panel7
		'
		Me.panel7.BackColor = System.Drawing.Color.LightSlateGray
		Me.panel7.Controls.Add(Me.panel8)
		Me.panel7.Location = New System.Drawing.Point(11, 186)
		Me.panel7.Name = "panel7"
		Me.panel7.Size = New System.Drawing.Size(594, 2)
		Me.panel7.TabIndex = 18
		'
		'panel8
		'
		Me.panel8.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel8.Location = New System.Drawing.Point(0, 159)
		Me.panel8.Name = "panel8"
		Me.panel8.Size = New System.Drawing.Size(705, 1)
		Me.panel8.TabIndex = 15
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.LightSlateGray
		Me.panel5.Controls.Add(Me.panel6)
		Me.panel5.Location = New System.Drawing.Point(11, 93)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(594, 2)
		Me.panel5.TabIndex = 17
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel6.Location = New System.Drawing.Point(0, 159)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(705, 1)
		Me.panel6.TabIndex = 15
		'
		'lbl_NomeProduto
		'
		Me.lbl_NomeProduto.AutoSize = true
		Me.lbl_NomeProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_NomeProduto.ForeColor = System.Drawing.Color.Navy
		Me.lbl_NomeProduto.Location = New System.Drawing.Point(143, 41)
		Me.lbl_NomeProduto.Name = "lbl_NomeProduto"
		Me.lbl_NomeProduto.Size = New System.Drawing.Size(0, 13)
		Me.lbl_NomeProduto.TabIndex = 1
		'
		'label8
		'
		Me.label8.AutoSize = true
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(25, 40)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(111, 16)
		Me.label8.TabIndex = 0
		Me.label8.Text = "Nome Produto:"
		'
		'panelEx1
		'
		Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
		Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
		Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx1.Location = New System.Drawing.Point(0, 0)
		Me.panelEx1.Name = "panelEx1"
		Me.panelEx1.Size = New System.Drawing.Size(732, 36)
		Me.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelEx1.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
		Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx1.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.panelEx1.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx1.Style.ForeColor.Color = System.Drawing.Color.White
		Me.panelEx1.Style.GradientAngle = 90
		Me.panelEx1.TabIndex = 3
		Me.panelEx1.Text = " CADASTRO DE PRODUTOS"
		'
		'panelEx3
		'
		Me.panelEx3.CanvasColor = System.Drawing.SystemColors.Control
		Me.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
		Me.panelEx3.Controls.Add(Me.bt_Fechar)
		Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx3.Location = New System.Drawing.Point(0, 494)
		Me.panelEx3.Name = "panelEx3"
		Me.panelEx3.Size = New System.Drawing.Size(732, 39)
		Me.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panelEx3.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
		Me.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx3.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.panelEx3.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.panelEx3.Style.ForeColor.Color = System.Drawing.Color.White
		Me.panelEx3.Style.GradientAngle = 90
		Me.panelEx3.TabIndex = 4
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
		Me.bt_Fechar.Location = New System.Drawing.Point(566, 7)
		Me.bt_Fechar.Name = "bt_Fechar"
		Me.bt_Fechar.Size = New System.Drawing.Size(75, 28)
		Me.bt_Fechar.TabIndex = 2
		Me.bt_Fechar.Text = "&Fechar"
		Me.bt_Fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_Fechar.Click, AddressOf Me.Bt_FecharClick
		'
		'OFD
		'
		Me.OFD.FileName = "0"
		'
		'panelEx2
		'
		Me.panelEx2.CanvasColor = System.Drawing.SystemColors.Highlight
		Me.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
		Me.panelEx2.Controls.Add(Me.lbl_qtdLoja)
		Me.panelEx2.Controls.Add(Me.lbl_qtdEstoque)
		Me.panelEx2.Controls.Add(Me.label10)
		Me.panelEx2.Controls.Add(Me.label9)
		Me.panelEx2.Location = New System.Drawing.Point(12, 98)
		Me.panelEx2.Name = "panelEx2"
		Me.panelEx2.Size = New System.Drawing.Size(592, 84)
		Me.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
		Me.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
		Me.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
		Me.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
		Me.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
		Me.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
		Me.panelEx2.Style.GradientAngle = 90
		Me.panelEx2.TabIndex = 27
		'
		'lbl_qtdLoja
		'
		Me.lbl_qtdLoja.AutoSize = true
		Me.lbl_qtdLoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_qtdLoja.ForeColor = System.Drawing.Color.Navy
		Me.lbl_qtdLoja.Location = New System.Drawing.Point(132, 53)
		Me.lbl_qtdLoja.Name = "lbl_qtdLoja"
		Me.lbl_qtdLoja.Size = New System.Drawing.Size(0, 13)
		Me.lbl_qtdLoja.TabIndex = 9
		'
		'lbl_qtdEstoque
		'
		Me.lbl_qtdEstoque.AutoSize = true
		Me.lbl_qtdEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_qtdEstoque.ForeColor = System.Drawing.Color.Navy
		Me.lbl_qtdEstoque.Location = New System.Drawing.Point(132, 13)
		Me.lbl_qtdEstoque.Name = "lbl_qtdEstoque"
		Me.lbl_qtdEstoque.Size = New System.Drawing.Size(0, 13)
		Me.lbl_qtdEstoque.TabIndex = 8
		'
		'label10
		'
		Me.label10.AutoSize = true
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(14, 50)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(82, 16)
		Me.label10.TabIndex = 7
		Me.label10.Text = "QTD Loja: "
		'
		'label9
		'
		Me.label9.AutoSize = true
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(14, 11)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(109, 16)
		Me.label9.TabIndex = 6
		Me.label9.Text = "QTD Estoque: "
		'
		'FormProdutos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(732, 533)
		Me.Controls.Add(Me.panelEx3)
		Me.Controls.Add(Me.panelEx1)
		Me.Controls.Add(Me.tabControl1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = true
		Me.Name = "FormProdutos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PRODUTOS"
		AddHandler Shown, AddressOf Me.FormProdutos_Shown
		AddHandler KeyDown, AddressOf Me.FormProdutosKeyDown
		Me.tabControl1.ResumeLayout(false)
		Me.tabLocalizar.ResumeLayout(false)
		CType(Me.dgv_Produtos,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.tabCadastrar.ResumeLayout(false)
		Me.tabControl2.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.tabPage1.PerformLayout
		CType(Me.dgv_Fornecedor,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dgv_Categorias,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel3.ResumeLayout(false)
		Me.tabPage2.ResumeLayout(false)
		Me.tabPage2.PerformLayout
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel7.ResumeLayout(false)
		Me.panel5.ResumeLayout(false)
		Me.panelEx3.ResumeLayout(false)
		Me.panelEx2.ResumeLayout(false)
		Me.panelEx2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private panelEx2 As DevComponents.DotNetBar.PanelEx
	Private lbl14 As System.Windows.Forms.Label
	Private lbl_fornecedor As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private lbl_idProduto As System.Windows.Forms.Label
	Private numericUpDown1 As System.Windows.Forms.NumericUpDown
	Private label11 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private bt_confirmar As System.Windows.Forms.Button
	Private label8 As System.Windows.Forms.Label
	Private lbl_NomeProduto As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private lbl_qtdEstoque As System.Windows.Forms.Label
	Private lbl_qtdLoja As System.Windows.Forms.Label
	Private panel6 As System.Windows.Forms.Panel
	Private panel5 As System.Windows.Forms.Panel
	Private panel8 As System.Windows.Forms.Panel
	Private panel7 As System.Windows.Forms.Panel
	Private tabPage2 As System.Windows.Forms.TabPage
	Private label7 As System.Windows.Forms.Label
	Private txt_precoVenda As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private txt_precoCusto As System.Windows.Forms.TextBox
	Private dgv_Fornecedor As System.Windows.Forms.DataGridView
	Private txt_Fornecedor As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private txt_pesquisaFornecedor As System.Windows.Forms.TextBox
	Private lbl_imagem As System.Windows.Forms.Label
	Private OFD As System.Windows.Forms.OpenFileDialog
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private txt_CDB As System.Windows.Forms.TextBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private bt_Fechar As System.Windows.Forms.Button
	Private panelEx3 As DevComponents.DotNetBar.PanelEx
	Private panelEx1 As DevComponents.DotNetBar.PanelEx
	Private txt_pesquisaCategoria As System.Windows.Forms.TextBox
	Private dgv_Categorias As System.Windows.Forms.DataGridView
	Private txt_categoria As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private panel4 As System.Windows.Forms.Panel
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
	Private dgv_Produtos As System.Windows.Forms.DataGridView
	Private tabCadastrar As System.Windows.Forms.TabPage
	Private tabLocalizar As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
End Class
