'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormPDV2
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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPDV2))
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.lbl_idvenda = New System.Windows.Forms.Label()
		Me.lbl_codigovenda = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.txt_produto = New System.Windows.Forms.TextBox()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.lbl_rodape = New System.Windows.Forms.Label()
		Me.pnl_principal = New System.Windows.Forms.Panel()
		Me.dgv_clientes = New System.Windows.Forms.DataGridView()
		Me.gb_status = New System.Windows.Forms.GroupBox()
		Me.lbl_status = New System.Windows.Forms.Label()
		Me.gb_venda = New System.Windows.Forms.GroupBox()
		Me.lbl_cliente = New System.Windows.Forms.Label()
		Me.lbl_hora = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.cb_formaPagamento = New System.Windows.Forms.ComboBox()
		Me.txt_FormaPagamento = New System.Windows.Forms.TextBox()
		Me.lbl_data = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.txt_cliente = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.dgv_Itens = New System.Windows.Forms.DataGridView()
		Me.PRODUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FORNECEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PRECOUNITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.idProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.idFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cdb = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.lbl_central = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_valorTotal = New System.Windows.Forms.TextBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.txt_desconto = New System.Windows.Forms.TextBox()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.txt_pago = New System.Windows.Forms.TextBox()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.txt_troco = New System.Windows.Forms.TextBox()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pnl_lateral = New System.Windows.Forms.Panel()
		Me.pnl_orcamento = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.groupBox6 = New System.Windows.Forms.GroupBox()
		Me.txt_Norcamento = New System.Windows.Forms.TextBox()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.pnl_principal.SuspendLayout
		CType(Me.dgv_clientes,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gb_status.SuspendLayout
		Me.gb_venda.SuspendLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.groupBox4.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_lateral.SuspendLayout
		Me.pnl_orcamento.SuspendLayout
		Me.panel6.SuspendLayout
		Me.groupBox6.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.DarkSlateGray
		Me.panel1.Controls.Add(Me.lbl_idvenda)
		Me.panel1.Controls.Add(Me.lbl_codigovenda)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(1284, 49)
		Me.panel1.TabIndex = 0
		'
		'lbl_idvenda
		'
		Me.lbl_idvenda.AutoSize = true
		Me.lbl_idvenda.BackColor = System.Drawing.Color.Transparent
		Me.lbl_idvenda.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_idvenda.ForeColor = System.Drawing.Color.White
		Me.lbl_idvenda.Location = New System.Drawing.Point(915, 9)
		Me.lbl_idvenda.Name = "lbl_idvenda"
		Me.lbl_idvenda.Size = New System.Drawing.Size(0, 33)
		Me.lbl_idvenda.TabIndex = 2
		Me.lbl_idvenda.Visible = false
		'
		'lbl_codigovenda
		'
		Me.lbl_codigovenda.AutoSize = true
		Me.lbl_codigovenda.BackColor = System.Drawing.Color.Transparent
		Me.lbl_codigovenda.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_codigovenda.ForeColor = System.Drawing.Color.White
		Me.lbl_codigovenda.Location = New System.Drawing.Point(649, 8)
		Me.lbl_codigovenda.Name = "lbl_codigovenda"
		Me.lbl_codigovenda.Size = New System.Drawing.Size(254, 32)
		Me.lbl_codigovenda.TabIndex = 1
		Me.lbl_codigovenda.Text = "Código da venda:"
		Me.lbl_codigovenda.Visible = false
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Verdana", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(12, 5)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(303, 38)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Ponto De Venda"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.DarkSlateGray
		Me.panel2.Controls.Add(Me.txt_produto)
		Me.panel2.Controls.Add(Me.bt_fechar)
		Me.panel2.Controls.Add(Me.lbl_rodape)
		Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel2.Location = New System.Drawing.Point(0, 709)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(1284, 42)
		Me.panel2.TabIndex = 1
		'
		'txt_produto
		'
		Me.txt_produto.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_produto.ForeColor = System.Drawing.Color.White
		Me.txt_produto.Location = New System.Drawing.Point(371, 10)
		Me.txt_produto.Name = "txt_produto"
		Me.txt_produto.Size = New System.Drawing.Size(568, 20)
		Me.txt_produto.TabIndex = 0
		AddHandler Me.txt_produto.KeyDown, AddressOf Me.Txt_produto_KeyDown
		'
		'bt_fechar
		'
		Me.bt_fechar.BackColor = System.Drawing.Color.DarkSlateGray
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.ForeColor = System.Drawing.Color.White
		Me.bt_fechar.Location = New System.Drawing.Point(1284, 13)
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
		Me.lbl_rodape.ForeColor = System.Drawing.Color.White
		Me.lbl_rodape.Location = New System.Drawing.Point(9, 16)
		Me.lbl_rodape.Name = "lbl_rodape"
		Me.lbl_rodape.Size = New System.Drawing.Size(315, 18)
		Me.lbl_rodape.TabIndex = 0
		Me.lbl_rodape.Text = "F1 - Adicionar Item / F3 - Finalizar Venda"
		Me.lbl_rodape.Visible = false
		'
		'pnl_principal
		'
		Me.pnl_principal.BackColor = System.Drawing.Color.DarkSlateGray
		Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_principal.Controls.Add(Me.dgv_clientes)
		Me.pnl_principal.Controls.Add(Me.gb_status)
		Me.pnl_principal.Controls.Add(Me.gb_venda)
		Me.pnl_principal.Controls.Add(Me.dgv_Itens)
		Me.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_principal.Location = New System.Drawing.Point(0, 49)
		Me.pnl_principal.Name = "pnl_principal"
		Me.pnl_principal.Size = New System.Drawing.Size(924, 660)
		Me.pnl_principal.TabIndex = 2
		Me.pnl_principal.Visible = false
		'
		'dgv_clientes
		'
		Me.dgv_clientes.AllowUserToAddRows = false
		Me.dgv_clientes.AllowUserToDeleteRows = false
		Me.dgv_clientes.AllowUserToOrderColumns = true
		Me.dgv_clientes.AllowUserToResizeRows = false
		Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_clientes.BackgroundColor = System.Drawing.Color.DarkSlateGray
		Me.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_clientes.DefaultCellStyle = dataGridViewCellStyle2
		Me.dgv_clientes.EnableHeadersVisualStyles = false
		Me.dgv_clientes.GridColor = System.Drawing.Color.White
		Me.dgv_clientes.Location = New System.Drawing.Point(20, 72)
		Me.dgv_clientes.Name = "dgv_clientes"
		Me.dgv_clientes.ReadOnly = true
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_clientes.RowHeadersVisible = false
		Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_clientes.Size = New System.Drawing.Size(314, 167)
		Me.dgv_clientes.TabIndex = 2
		Me.dgv_clientes.Visible = false
		AddHandler Me.dgv_clientes.KeyDown, AddressOf Me.dgv_clientes_KeyDown
		'
		'gb_status
		'
		Me.gb_status.Controls.Add(Me.lbl_status)
		Me.gb_status.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 9!)
		Me.gb_status.ForeColor = System.Drawing.Color.White
		Me.gb_status.Location = New System.Drawing.Point(824, 6)
		Me.gb_status.Name = "gb_status"
		Me.gb_status.Size = New System.Drawing.Size(170, 77)
		Me.gb_status.TabIndex = 2
		Me.gb_status.TabStop = false
		Me.gb_status.Text = "Status da venda"
		'
		'lbl_status
		'
		Me.lbl_status.AutoSize = true
		Me.lbl_status.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_status.ForeColor = System.Drawing.Color.Red
		Me.lbl_status.Location = New System.Drawing.Point(44, 34)
		Me.lbl_status.Name = "lbl_status"
		Me.lbl_status.Size = New System.Drawing.Size(84, 22)
		Me.lbl_status.TabIndex = 0
		Me.lbl_status.Text = "Fechada"
		Me.lbl_status.Visible = false
		'
		'gb_venda
		'
		Me.gb_venda.BackColor = System.Drawing.Color.DarkSlateGray
		Me.gb_venda.Controls.Add(Me.lbl_cliente)
		Me.gb_venda.Controls.Add(Me.lbl_hora)
		Me.gb_venda.Controls.Add(Me.label5)
		Me.gb_venda.Controls.Add(Me.cb_formaPagamento)
		Me.gb_venda.Controls.Add(Me.txt_FormaPagamento)
		Me.gb_venda.Controls.Add(Me.lbl_data)
		Me.gb_venda.Controls.Add(Me.label4)
		Me.gb_venda.Controls.Add(Me.label3)
		Me.gb_venda.Controls.Add(Me.txt_cliente)
		Me.gb_venda.Controls.Add(Me.label2)
		Me.gb_venda.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_venda.ForeColor = System.Drawing.Color.White
		Me.gb_venda.Location = New System.Drawing.Point(3, 6)
		Me.gb_venda.Name = "gb_venda"
		Me.gb_venda.Size = New System.Drawing.Size(815, 77)
		Me.gb_venda.TabIndex = 1
		Me.gb_venda.TabStop = false
		Me.gb_venda.Text = "Informações da venda (F7)"
		'
		'lbl_cliente
		'
		Me.lbl_cliente.AutoSize = true
		Me.lbl_cliente.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_cliente.ForeColor = System.Drawing.Color.Yellow
		Me.lbl_cliente.Location = New System.Drawing.Point(75, 18)
		Me.lbl_cliente.Name = "lbl_cliente"
		Me.lbl_cliente.Size = New System.Drawing.Size(190, 22)
		Me.lbl_cliente.TabIndex = 5
		Me.lbl_cliente.Text = "ESCOLHA UM CLIENTE"
		Me.lbl_cliente.Visible = false
		'
		'lbl_hora
		'
		Me.lbl_hora.AutoSize = true
		Me.lbl_hora.BackColor = System.Drawing.Color.DarkSlateGray
		Me.lbl_hora.ForeColor = System.Drawing.Color.Cyan
		Me.lbl_hora.Location = New System.Drawing.Point(712, 44)
		Me.lbl_hora.Name = "lbl_hora"
		Me.lbl_hora.Size = New System.Drawing.Size(0, 14)
		Me.lbl_hora.TabIndex = 27
		Me.lbl_hora.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Location = New System.Drawing.Point(712, 22)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(35, 14)
		Me.label5.TabIndex = 26
		Me.label5.Text = "Hora"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'cb_formaPagamento
		'
		Me.cb_formaPagamento.BackColor = System.Drawing.Color.DarkSlateGray
		Me.cb_formaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cb_formaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cb_formaPagamento.ForeColor = System.Drawing.Color.Cyan
		Me.cb_formaPagamento.FormattingEnabled = true
		Me.cb_formaPagamento.Location = New System.Drawing.Point(365, 42)
		Me.cb_formaPagamento.Name = "cb_formaPagamento"
		Me.cb_formaPagamento.Size = New System.Drawing.Size(211, 22)
		Me.cb_formaPagamento.TabIndex = 25
		AddHandler Me.cb_formaPagamento.KeyDown, AddressOf Me.Cb_formaPagamento_KeyDown
		'
		'txt_FormaPagamento
		'
		Me.txt_FormaPagamento.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_FormaPagamento.ForeColor = System.Drawing.Color.Cyan
		Me.txt_FormaPagamento.Location = New System.Drawing.Point(366, 43)
		Me.txt_FormaPagamento.Name = "txt_FormaPagamento"
		Me.txt_FormaPagamento.Size = New System.Drawing.Size(211, 21)
		Me.txt_FormaPagamento.TabIndex = 24
		Me.txt_FormaPagamento.Visible = false
		'
		'lbl_data
		'
		Me.lbl_data.AutoSize = true
		Me.lbl_data.BackColor = System.Drawing.Color.DarkSlateGray
		Me.lbl_data.ForeColor = System.Drawing.Color.Cyan
		Me.lbl_data.Location = New System.Drawing.Point(599, 44)
		Me.lbl_data.Name = "lbl_data"
		Me.lbl_data.Size = New System.Drawing.Size(0, 14)
		Me.lbl_data.TabIndex = 23
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(599, 23)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(35, 14)
		Me.label4.TabIndex = 22
		Me.label4.Text = "Data"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(366, 23)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(133, 14)
		Me.label3.TabIndex = 20
		Me.label3.Text = "Forma de Pagamento"
		'
		'txt_cliente
		'
		Me.txt_cliente.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_cliente.ForeColor = System.Drawing.Color.Cyan
		Me.txt_cliente.Location = New System.Drawing.Point(17, 43)
		Me.txt_cliente.Name = "txt_cliente"
		Me.txt_cliente.Size = New System.Drawing.Size(314, 21)
		Me.txt_cliente.TabIndex = 19
		AddHandler Me.txt_cliente.KeyDown, AddressOf Me.Txt_cliente_KeyDown
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(14, 23)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(56, 14)
		Me.label2.TabIndex = 18
		Me.label2.Text = "Cliente"
		'
		'dgv_Itens
		'
		Me.dgv_Itens.AllowUserToAddRows = false
		Me.dgv_Itens.AllowUserToResizeRows = false
		Me.dgv_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgv_Itens.BackgroundColor = System.Drawing.Color.DarkSlateGray
		Me.dgv_Itens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgv_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUTO, Me.FORNECEDOR, Me.QTD, Me.PRECOUNITARIO, Me.VALOR, Me.idProduto, Me.idFornecedor, Me.cdb})
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Itens.DefaultCellStyle = dataGridViewCellStyle7
		Me.dgv_Itens.EnableHeadersVisualStyles = false
		Me.dgv_Itens.Location = New System.Drawing.Point(3, 88)
		Me.dgv_Itens.MultiSelect = false
		Me.dgv_Itens.Name = "dgv_Itens"
		Me.dgv_Itens.ReadOnly = true
		Me.dgv_Itens.RowHeadersVisible = false
		Me.dgv_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Itens.Size = New System.Drawing.Size(991, 559)
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
		Me.QTD.HeaderText = "QTD"
		Me.QTD.Name = "QTD"
		Me.QTD.ReadOnly = true
		'
		'PRECOUNITARIO
		'
		dataGridViewCellStyle5.Format = "C2"
		dataGridViewCellStyle5.NullValue = "0"
		Me.PRECOUNITARIO.DefaultCellStyle = dataGridViewCellStyle5
		Me.PRECOUNITARIO.HeaderText = "PREÇO UNIT"
		Me.PRECOUNITARIO.Name = "PRECOUNITARIO"
		Me.PRECOUNITARIO.ReadOnly = true
		'
		'VALOR
		'
		dataGridViewCellStyle6.Format = "C2"
		dataGridViewCellStyle6.NullValue = "0"
		Me.VALOR.DefaultCellStyle = dataGridViewCellStyle6
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
		'cdb
		'
		Me.cdb.HeaderText = "cdb"
		Me.cdb.Name = "cdb"
		Me.cdb.ReadOnly = true
		Me.cdb.Visible = false
		'
		'lbl_central
		'
		Me.lbl_central.AutoSize = true
		Me.lbl_central.BackColor = System.Drawing.SystemColors.Control
		Me.lbl_central.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_central.ForeColor = System.Drawing.Color.Black
		Me.lbl_central.Location = New System.Drawing.Point(301, 333)
		Me.lbl_central.Name = "lbl_central"
		Me.lbl_central.Size = New System.Drawing.Size(717, 42)
		Me.lbl_central.TabIndex = 6
		Me.lbl_central.Text = "F1 - Nova Venda / F3 - Abrir Orçamento"
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_valorTotal)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.ForeColor = System.Drawing.Color.Lime
		Me.groupBox1.Location = New System.Drawing.Point(12, 1)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(330, 110)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "VALOR TOTAL"
		'
		'txt_valorTotal
		'
		Me.txt_valorTotal.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_valorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_valorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_valorTotal.ForeColor = System.Drawing.Color.Lime
		Me.txt_valorTotal.Location = New System.Drawing.Point(11, 43)
		Me.txt_valorTotal.Name = "txt_valorTotal"
		Me.txt_valorTotal.ReadOnly = true
		Me.txt_valorTotal.Size = New System.Drawing.Size(310, 49)
		Me.txt_valorTotal.TabIndex = 0
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.txt_desconto)
		Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox2.ForeColor = System.Drawing.Color.White
		Me.groupBox2.Location = New System.Drawing.Point(12, 118)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(330, 110)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "DESCONTO"
		'
		'txt_desconto
		'
		Me.txt_desconto.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_desconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_desconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_desconto.ForeColor = System.Drawing.Color.White
		Me.txt_desconto.Location = New System.Drawing.Point(10, 49)
		Me.txt_desconto.Name = "txt_desconto"
		Me.txt_desconto.ReadOnly = true
		Me.txt_desconto.Size = New System.Drawing.Size(310, 49)
		Me.txt_desconto.TabIndex = 0
		AddHandler Me.txt_desconto.KeyDown, AddressOf Me.Txt_desconto_KeyDown
		AddHandler Me.txt_desconto.KeyPress, AddressOf Me.Txt_desconto_KeyPress
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.txt_pago)
		Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox3.ForeColor = System.Drawing.Color.Aqua
		Me.groupBox3.Location = New System.Drawing.Point(12, 233)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(330, 110)
		Me.groupBox3.TabIndex = 2
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "PAGO"
		'
		'txt_pago
		'
		Me.txt_pago.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_pago.ForeColor = System.Drawing.Color.Cyan
		Me.txt_pago.Location = New System.Drawing.Point(9, 46)
		Me.txt_pago.Name = "txt_pago"
		Me.txt_pago.ReadOnly = true
		Me.txt_pago.Size = New System.Drawing.Size(310, 49)
		Me.txt_pago.TabIndex = 0
		AddHandler Me.txt_pago.KeyDown, AddressOf Me.Txt_pago_KeyDown
		AddHandler Me.txt_pago.KeyPress, AddressOf Me.Txt_pago_KeyPress
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.txt_troco)
		Me.groupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox4.ForeColor = System.Drawing.Color.Red
		Me.groupBox4.Location = New System.Drawing.Point(12, 348)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(330, 110)
		Me.groupBox4.TabIndex = 3
		Me.groupBox4.TabStop = false
		Me.groupBox4.Text = "TROCO"
		'
		'txt_troco
		'
		Me.txt_troco.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_troco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_troco.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_troco.ForeColor = System.Drawing.Color.Red
		Me.txt_troco.Location = New System.Drawing.Point(9, 41)
		Me.txt_troco.Name = "txt_troco"
		Me.txt_troco.ReadOnly = true
		Me.txt_troco.Size = New System.Drawing.Size(310, 49)
		Me.txt_troco.TabIndex = 0
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(84, 469)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(194, 175)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pictureBox1.TabIndex = 4
		Me.pictureBox1.TabStop = false
		'
		'pnl_lateral
		'
		Me.pnl_lateral.BackColor = System.Drawing.Color.DarkSlateGray
		Me.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_lateral.Controls.Add(Me.pictureBox1)
		Me.pnl_lateral.Controls.Add(Me.groupBox4)
		Me.pnl_lateral.Controls.Add(Me.groupBox3)
		Me.pnl_lateral.Controls.Add(Me.groupBox2)
		Me.pnl_lateral.Controls.Add(Me.groupBox1)
		Me.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Right
		Me.pnl_lateral.Location = New System.Drawing.Point(924, 49)
		Me.pnl_lateral.Name = "pnl_lateral"
		Me.pnl_lateral.Size = New System.Drawing.Size(360, 660)
		Me.pnl_lateral.TabIndex = 3
		Me.pnl_lateral.Visible = false
		'
		'pnl_orcamento
		'
		Me.pnl_orcamento.BackColor = System.Drawing.Color.Gray
		Me.pnl_orcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_orcamento.Controls.Add(Me.panel6)
		Me.pnl_orcamento.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.pnl_orcamento.Location = New System.Drawing.Point(431, 261)
		Me.pnl_orcamento.Name = "pnl_orcamento"
		Me.pnl_orcamento.Size = New System.Drawing.Size(330, 104)
		Me.pnl_orcamento.TabIndex = 7
		Me.pnl_orcamento.Visible = false
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.DarkSlateGray
		Me.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel6.Controls.Add(Me.groupBox6)
		Me.panel6.Location = New System.Drawing.Point(4, 3)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(321, 96)
		Me.panel6.TabIndex = 1
		'
		'groupBox6
		'
		Me.groupBox6.Controls.Add(Me.txt_Norcamento)
		Me.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.groupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox6.ForeColor = System.Drawing.Color.White
		Me.groupBox6.Location = New System.Drawing.Point(7, 6)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(309, 85)
		Me.groupBox6.TabIndex = 0
		Me.groupBox6.TabStop = false
		Me.groupBox6.Text = "DIGITE O NÚMERO DO ORÇAMENTO"
		'
		'txt_Norcamento
		'
		Me.txt_Norcamento.BackColor = System.Drawing.Color.DarkSlateGray
		Me.txt_Norcamento.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_Norcamento.ForeColor = System.Drawing.Color.White
		Me.txt_Norcamento.Location = New System.Drawing.Point(15, 31)
		Me.txt_Norcamento.Name = "txt_Norcamento"
		Me.txt_Norcamento.Size = New System.Drawing.Size(277, 30)
		Me.txt_Norcamento.TabIndex = 0
		AddHandler Me.txt_Norcamento.KeyDown, AddressOf Me.Txt_Norcamento_KeyDown
		AddHandler Me.txt_Norcamento.KeyPress, AddressOf Me.Txt_Norcamento_KeyPress
		'
		'FormPDV2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1284, 751)
		Me.Controls.Add(Me.pnl_principal)
		Me.Controls.Add(Me.pnl_lateral)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.lbl_central)
		Me.Controls.Add(Me.pnl_orcamento)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormPDV2"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "VENDAS"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler KeyDown, AddressOf Me.FormPDV_KeyDown
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.pnl_principal.ResumeLayout(false)
		CType(Me.dgv_clientes,System.ComponentModel.ISupportInitialize).EndInit
		Me.gb_status.ResumeLayout(false)
		Me.gb_status.PerformLayout
		Me.gb_venda.ResumeLayout(false)
		Me.gb_venda.PerformLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.groupBox4.ResumeLayout(false)
		Me.groupBox4.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_lateral.ResumeLayout(false)
		Me.pnl_orcamento.ResumeLayout(false)
		Me.panel6.ResumeLayout(false)
		Me.groupBox6.ResumeLayout(false)
		Me.groupBox6.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cdb As System.Windows.Forms.DataGridViewTextBoxColumn
	Private label5 As System.Windows.Forms.Label
	Private lbl_hora As System.Windows.Forms.Label
	Private lbl_idvenda As System.Windows.Forms.Label
	Private lbl_codigovenda As System.Windows.Forms.Label
	Private txt_Norcamento As System.Windows.Forms.TextBox
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private panel6 As System.Windows.Forms.Panel
	Private pnl_orcamento As System.Windows.Forms.Panel
	Private cb_formaPagamento As System.Windows.Forms.ComboBox
	Private txt_FormaPagamento As System.Windows.Forms.TextBox
	Private idFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
	Private idProduto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private lbl_cliente As System.Windows.Forms.Label
	Private VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
	Private PRECOUNITARIO As System.Windows.Forms.DataGridViewTextBoxColumn
	Private QTD As System.Windows.Forms.DataGridViewTextBoxColumn
	Private FORNECEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
	Private PRODUTO As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dgv_clientes As System.Windows.Forms.DataGridView
	Private txt_produto As System.Windows.Forms.TextBox
	Private lbl_central As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private txt_valorTotal As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private txt_desconto As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private txt_pago As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private txt_troco As System.Windows.Forms.TextBox
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private bt_fechar As System.Windows.Forms.Button
	Private dgv_Itens As System.Windows.Forms.DataGridView
	Private lbl_status As System.Windows.Forms.Label
	Private gb_status As System.Windows.Forms.GroupBox
	Private lbl_rodape As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txt_cliente As System.Windows.Forms.TextBox
	Private lbl_data As System.Windows.Forms.Label
	Private gb_venda As System.Windows.Forms.GroupBox
	Private pnl_lateral As System.Windows.Forms.Panel
	Private pnl_principal As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

End Class
