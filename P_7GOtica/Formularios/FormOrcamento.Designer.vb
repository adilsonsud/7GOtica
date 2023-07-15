'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormOrcamento
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
		Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrcamento))
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.lbl_rodape = New System.Windows.Forms.Label()
		Me.pnl_principal = New System.Windows.Forms.Panel()
		Me.pnl_qtd = New System.Windows.Forms.Panel()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me.txt_qtd = New System.Windows.Forms.TextBox()
		Me.pnl_produto = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.dgv_produtos = New System.Windows.Forms.DataGridView()
		Me.gb_Nomeproduto = New System.Windows.Forms.GroupBox()
		Me.txt_produto = New System.Windows.Forms.TextBox()
		Me.dgv_Itens = New System.Windows.Forms.DataGridView()
		Me.PRODUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FORNECEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PRECOUNITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.idProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.idFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_valorTotal = New System.Windows.Forms.TextBox()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pnl_lateral = New System.Windows.Forms.Panel()
		Me.bt_imprimir = New System.Windows.Forms.Button()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.pnl_principal.SuspendLayout
		Me.pnl_qtd.SuspendLayout
		Me.panel4.SuspendLayout
		Me.groupBox5.SuspendLayout
		Me.pnl_produto.SuspendLayout
		Me.panel3.SuspendLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gb_Nomeproduto.SuspendLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_lateral.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.Indigo
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(1292, 49)
		Me.panel1.TabIndex = 0
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Verdana", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.Yellow
		Me.label1.Location = New System.Drawing.Point(12, 5)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(215, 38)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Orçamento"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.Indigo
		Me.panel2.Controls.Add(Me.bt_fechar)
		Me.panel2.Controls.Add(Me.lbl_rodape)
		Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel2.Location = New System.Drawing.Point(0, 709)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(1292, 42)
		Me.panel2.TabIndex = 1
		'
		'bt_fechar
		'
		Me.bt_fechar.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.ForeColor = System.Drawing.Color.Yellow
		Me.bt_fechar.Location = New System.Drawing.Point(1214, 11)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(75, 23)
		Me.bt_fechar.TabIndex = 1
		Me.bt_fechar.Text = "&Fechar"
		Me.bt_fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fechar_Click
		'
		'lbl_rodape
		'
		Me.lbl_rodape.AutoSize = true
		Me.lbl_rodape.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_rodape.ForeColor = System.Drawing.Color.Yellow
		Me.lbl_rodape.Location = New System.Drawing.Point(9, 16)
		Me.lbl_rodape.Name = "lbl_rodape"
		Me.lbl_rodape.Size = New System.Drawing.Size(155, 18)
		Me.lbl_rodape.TabIndex = 0
		Me.lbl_rodape.Text = "F1 - Adicionar Item "
		Me.lbl_rodape.Visible = false
		'
		'pnl_principal
		'
		Me.pnl_principal.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_principal.Controls.Add(Me.pnl_qtd)
		Me.pnl_principal.Controls.Add(Me.pnl_produto)
		Me.pnl_principal.Controls.Add(Me.dgv_Itens)
		Me.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_principal.Location = New System.Drawing.Point(0, 49)
		Me.pnl_principal.Name = "pnl_principal"
		Me.pnl_principal.Size = New System.Drawing.Size(1292, 660)
		Me.pnl_principal.TabIndex = 2
		Me.pnl_principal.Visible = false
		'
		'pnl_qtd
		'
		Me.pnl_qtd.BackColor = System.Drawing.Color.Indigo
		Me.pnl_qtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_qtd.Controls.Add(Me.panel4)
		Me.pnl_qtd.Location = New System.Drawing.Point(441, 109)
		Me.pnl_qtd.Name = "pnl_qtd"
		Me.pnl_qtd.Size = New System.Drawing.Size(218, 104)
		Me.pnl_qtd.TabIndex = 5
		Me.pnl_qtd.Visible = false
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.panel4.Controls.Add(Me.groupBox5)
		Me.panel4.Location = New System.Drawing.Point(4, 3)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(209, 96)
		Me.panel4.TabIndex = 1
		'
		'groupBox5
		'
		Me.groupBox5.BackColor = System.Drawing.Color.Indigo
		Me.groupBox5.Controls.Add(Me.txt_qtd)
		Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox5.ForeColor = System.Drawing.Color.Yellow
		Me.groupBox5.Location = New System.Drawing.Point(7, 3)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(193, 85)
		Me.groupBox5.TabIndex = 0
		Me.groupBox5.TabStop = false
		Me.groupBox5.Text = "DIGITE A QUANTIDADE"
		'
		'txt_qtd
		'
		Me.txt_qtd.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.txt_qtd.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_qtd.ForeColor = System.Drawing.Color.LavenderBlush
		Me.txt_qtd.Location = New System.Drawing.Point(23, 36)
		Me.txt_qtd.Name = "txt_qtd"
		Me.txt_qtd.Size = New System.Drawing.Size(146, 30)
		Me.txt_qtd.TabIndex = 0
		AddHandler Me.txt_qtd.KeyDown, AddressOf Me.Txt_qtd_KeyDown
		'
		'pnl_produto
		'
		Me.pnl_produto.BackColor = System.Drawing.Color.Indigo
		Me.pnl_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_produto.Controls.Add(Me.panel3)
		Me.pnl_produto.Location = New System.Drawing.Point(212, 142)
		Me.pnl_produto.Name = "pnl_produto"
		Me.pnl_produto.Size = New System.Drawing.Size(682, 477)
		Me.pnl_produto.TabIndex = 4
		Me.pnl_produto.Visible = false
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.panel3.Controls.Add(Me.dgv_produtos)
		Me.panel3.Controls.Add(Me.gb_Nomeproduto)
		Me.panel3.Location = New System.Drawing.Point(5, 5)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(672, 465)
		Me.panel3.TabIndex = 1
		'
		'dgv_produtos
		'
		Me.dgv_produtos.AllowUserToAddRows = false
		Me.dgv_produtos.AllowUserToDeleteRows = false
		Me.dgv_produtos.AllowUserToOrderColumns = true
		Me.dgv_produtos.AllowUserToResizeRows = false
		Me.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_produtos.BackgroundColor = System.Drawing.Color.Indigo
		Me.dgv_produtos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgv_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.Purple
		dataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Yellow
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8
		Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.Indigo
		dataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gold
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_produtos.DefaultCellStyle = dataGridViewCellStyle9
		Me.dgv_produtos.EnableHeadersVisualStyles = false
		Me.dgv_produtos.GridColor = System.Drawing.Color.White
		Me.dgv_produtos.Location = New System.Drawing.Point(8, 80)
		Me.dgv_produtos.Name = "dgv_produtos"
		Me.dgv_produtos.ReadOnly = true
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10
		Me.dgv_produtos.RowHeadersVisible = false
		Me.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_produtos.Size = New System.Drawing.Size(648, 374)
		Me.dgv_produtos.TabIndex = 2
		AddHandler Me.dgv_produtos.KeyDown, AddressOf Me.Dgv_produtos_KeyDown
		'
		'gb_Nomeproduto
		'
		Me.gb_Nomeproduto.BackColor = System.Drawing.Color.Indigo
		Me.gb_Nomeproduto.Controls.Add(Me.txt_produto)
		Me.gb_Nomeproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_Nomeproduto.ForeColor = System.Drawing.Color.Yellow
		Me.gb_Nomeproduto.Location = New System.Drawing.Point(7, 7)
		Me.gb_Nomeproduto.Name = "gb_Nomeproduto"
		Me.gb_Nomeproduto.Size = New System.Drawing.Size(649, 64)
		Me.gb_Nomeproduto.TabIndex = 3
		Me.gb_Nomeproduto.TabStop = false
		Me.gb_Nomeproduto.Text = "DIGITE O NOME DO PRODUTO"
		'
		'txt_produto
		'
		Me.txt_produto.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.txt_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_produto.ForeColor = System.Drawing.Color.Yellow
		Me.txt_produto.Location = New System.Drawing.Point(11, 28)
		Me.txt_produto.Name = "txt_produto"
		Me.txt_produto.Size = New System.Drawing.Size(632, 20)
		Me.txt_produto.TabIndex = 0
		AddHandler Me.txt_produto.KeyDown, AddressOf Me.Txt_produto_KeyDown
		'
		'dgv_Itens
		'
		Me.dgv_Itens.AllowUserToAddRows = false
		Me.dgv_Itens.AllowUserToResizeRows = false
		Me.dgv_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Itens.BackgroundColor = System.Drawing.Color.Indigo
		Me.dgv_Itens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgv_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle11.BackColor = System.Drawing.Color.Purple
		dataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Yellow
		dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11
		Me.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUTO, Me.FORNECEDOR, Me.QTD, Me.PRECOUNITARIO, Me.VALOR, Me.idProduto, Me.idFornecedor})
		dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle14.BackColor = System.Drawing.Color.Indigo
		dataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SkyBlue
		dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Itens.DefaultCellStyle = dataGridViewCellStyle14
		Me.dgv_Itens.EnableHeadersVisualStyles = false
		Me.dgv_Itens.GridColor = System.Drawing.Color.DarkSlateBlue
		Me.dgv_Itens.Location = New System.Drawing.Point(3, 4)
		Me.dgv_Itens.MultiSelect = false
		Me.dgv_Itens.Name = "dgv_Itens"
		Me.dgv_Itens.ReadOnly = true
		Me.dgv_Itens.RowHeadersVisible = false
		Me.dgv_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Itens.Size = New System.Drawing.Size(991, 646)
		Me.dgv_Itens.TabIndex = 3
		AddHandler Me.dgv_Itens.KeyDown, AddressOf Me.Dgv_Itens_KeyDown
		'
		'PRODUTO
		'
		Me.PRODUTO.HeaderText = "PRODUTO"
		Me.PRODUTO.Name = "PRODUTO"
		Me.PRODUTO.ReadOnly = true
		'
		'FORNECEDOR
		'
		Me.FORNECEDOR.HeaderText = "FORNECEDOR"
		Me.FORNECEDOR.Name = "FORNECEDOR"
		Me.FORNECEDOR.ReadOnly = true
		'
		'QTD
		'
		Me.QTD.HeaderText = "QTD (F5)"
		Me.QTD.Name = "QTD"
		Me.QTD.ReadOnly = true
		'
		'PRECOUNITARIO
		'
		dataGridViewCellStyle12.Format = "C2"
		dataGridViewCellStyle12.NullValue = "0"
		Me.PRECOUNITARIO.DefaultCellStyle = dataGridViewCellStyle12
		Me.PRECOUNITARIO.HeaderText = "PREÇO UNIT"
		Me.PRECOUNITARIO.Name = "PRECOUNITARIO"
		Me.PRECOUNITARIO.ReadOnly = true
		'
		'VALOR
		'
		dataGridViewCellStyle13.Format = "C2"
		dataGridViewCellStyle13.NullValue = "0"
		Me.VALOR.DefaultCellStyle = dataGridViewCellStyle13
		Me.VALOR.HeaderText = "VALOR"
		Me.VALOR.Name = "VALOR"
		Me.VALOR.ReadOnly = true
		'
		'idProduto
		'
		Me.idProduto.HeaderText = "idProduto"
		Me.idProduto.Name = "idProduto"
		Me.idProduto.ReadOnly = true
		Me.idProduto.Visible = false
		'
		'idFornecedor
		'
		Me.idFornecedor.HeaderText = "idFornecedor"
		Me.idFornecedor.Name = "idFornecedor"
		Me.idFornecedor.ReadOnly = true
		Me.idFornecedor.Visible = false
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_valorTotal)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.ForeColor = System.Drawing.Color.Yellow
		Me.groupBox1.Location = New System.Drawing.Point(12, 1)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(330, 110)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "VALOR TOTAL"
		'
		'txt_valorTotal
		'
		Me.txt_valorTotal.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.txt_valorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_valorTotal.ForeColor = System.Drawing.Color.Pink
		Me.txt_valorTotal.Location = New System.Drawing.Point(11, 43)
		Me.txt_valorTotal.Name = "txt_valorTotal"
		Me.txt_valorTotal.ReadOnly = true
		Me.txt_valorTotal.Size = New System.Drawing.Size(310, 49)
		Me.txt_valorTotal.TabIndex = 0
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(74, 388)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(214, 207)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pictureBox1.TabIndex = 4
		Me.pictureBox1.TabStop = false
		'
		'pnl_lateral
		'
		Me.pnl_lateral.BackColor = System.Drawing.Color.Indigo
		Me.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_lateral.Controls.Add(Me.bt_imprimir)
		Me.pnl_lateral.Controls.Add(Me.pictureBox1)
		Me.pnl_lateral.Controls.Add(Me.groupBox1)
		Me.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Right
		Me.pnl_lateral.Location = New System.Drawing.Point(932, 49)
		Me.pnl_lateral.Name = "pnl_lateral"
		Me.pnl_lateral.Size = New System.Drawing.Size(360, 660)
		Me.pnl_lateral.TabIndex = 3
		Me.pnl_lateral.Visible = false
		'
		'bt_imprimir
		'
		Me.bt_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.bt_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
		Me.bt_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray
		Me.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bt_imprimir.ForeColor = System.Drawing.Color.Yellow
		Me.bt_imprimir.Image = CType(resources.GetObject("bt_imprimir.Image"),System.Drawing.Image)
		Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_imprimir.Location = New System.Drawing.Point(12, 128)
		Me.bt_imprimir.Name = "bt_imprimir"
		Me.bt_imprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_imprimir.Size = New System.Drawing.Size(330, 43)
		Me.bt_imprimir.TabIndex = 5
		Me.bt_imprimir.Text = "&Imprimir Orçamento"
		Me.bt_imprimir.UseVisualStyleBackColor = true
		'
		'FormOrcamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1292, 751)
		Me.Controls.Add(Me.pnl_lateral)
		Me.Controls.Add(Me.pnl_principal)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormOrcamento"
		Me.Text = "PRÉ VENDA"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler KeyDown, AddressOf Me.FormOrcamento_KeyDown
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.pnl_principal.ResumeLayout(false)
		Me.pnl_qtd.ResumeLayout(false)
		Me.panel4.ResumeLayout(false)
		Me.groupBox5.ResumeLayout(false)
		Me.groupBox5.PerformLayout
		Me.pnl_produto.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).EndInit
		Me.gb_Nomeproduto.ResumeLayout(false)
		Me.gb_Nomeproduto.PerformLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_lateral.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private bt_imprimir As System.Windows.Forms.Button
	Private idFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
	Private idProduto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private txt_qtd As System.Windows.Forms.TextBox
	Private panel4 As System.Windows.Forms.Panel
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private pnl_qtd As System.Windows.Forms.Panel
	Private VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
	Private PRECOUNITARIO As System.Windows.Forms.DataGridViewTextBoxColumn
	Private QTD As System.Windows.Forms.DataGridViewTextBoxColumn
	Private FORNECEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
	Private PRODUTO As System.Windows.Forms.DataGridViewTextBoxColumn
	Private panel3 As System.Windows.Forms.Panel
	Private dgv_produtos As System.Windows.Forms.DataGridView
	Private txt_produto As System.Windows.Forms.TextBox
	Private gb_Nomeproduto As System.Windows.Forms.GroupBox
	Private pnl_produto As System.Windows.Forms.Panel
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private txt_valorTotal As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private bt_fechar As System.Windows.Forms.Button
	Private dgv_Itens As System.Windows.Forms.DataGridView
	Private lbl_rodape As System.Windows.Forms.Label
	Private pnl_lateral As System.Windows.Forms.Panel
	Private pnl_principal As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

End Class
