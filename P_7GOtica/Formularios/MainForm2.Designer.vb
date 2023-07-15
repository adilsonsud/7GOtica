'
' Criado por SharpDevelop.
' Usuário: adilson
' Data: 2015-11-18
' Hora: 23:03
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class MainForm2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm2))
		Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
		Me.ribbonPanel5 = New DevComponents.DotNetBar.RibbonPanel()
		Me.ribbonBar14 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_Creditos = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonPanel4 = New DevComponents.DotNetBar.RibbonPanel()
		Me.ribbonBar13 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_Estoque = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
		Me.ribbonBar12 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_status = New DevComponents.DotNetBar.ButtonItem()
		Me.bti_sintetico = New DevComponents.DotNetBar.ButtonItem()
		Me.bti_analitico = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar11 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_PDV = New DevComponents.DotNetBar.ButtonItem()
		Me.bti_PDV2 = New DevComponents.DotNetBar.ButtonItem()
		Me.bti_PDV3 = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar10 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_PreVenda = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar9 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_orcamento = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
		Me.ribbonBar5 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_formaPagamento = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar2 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_fornecedores = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_Clientes = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar4 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_Produtos = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar3 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_Categorias = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
		Me.ribbonBar8 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_RelatorioSintetico = New DevComponents.DotNetBar.ButtonItem()
		Me.bti_relatorioAnalitico = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar7 = New DevComponents.DotNetBar.RibbonBar()
		Me.bit_inserirCompras = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonBar6 = New DevComponents.DotNetBar.RibbonBar()
		Me.bti_Cotacao = New DevComponents.DotNetBar.ButtonItem()
		Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
		Me.ribbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem()
		Me.ribbonTabItem3 = New DevComponents.DotNetBar.RibbonTabItem()
		Me.ribbonTabItem4 = New DevComponents.DotNetBar.RibbonTabItem()
		Me.ribbonTabItem5 = New DevComponents.DotNetBar.RibbonTabItem()
		Me.applicationButton1 = New DevComponents.DotNetBar.ApplicationButton()
		Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer()
		Me.itemContainer2 = New DevComponents.DotNetBar.ItemContainer()
		Me.itemContainer3 = New DevComponents.DotNetBar.ItemContainer()
		Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
		Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
		Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
		Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
		Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
		Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
		Me.bt_Fechar = New DevComponents.DotNetBar.ButtonItem()
		Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
		Me.qatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
		Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
		Me.ribbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
		Me.ribbonControl1.SuspendLayout
		Me.ribbonPanel5.SuspendLayout
		Me.ribbonPanel4.SuspendLayout
		Me.ribbonPanel3.SuspendLayout
		Me.ribbonPanel1.SuspendLayout
		Me.ribbonPanel2.SuspendLayout
		Me.SuspendLayout
		'
		'ribbonControl1
		'
		'
		'
		'
		Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonControl1.CaptionVisible = true
		Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
		Me.ribbonControl1.Controls.Add(Me.ribbonPanel3)
		Me.ribbonControl1.Controls.Add(Me.ribbonPanel4)
		Me.ribbonControl1.Controls.Add(Me.ribbonPanel5)
		Me.ribbonControl1.Controls.Add(Me.ribbonPanel2)
		Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
		Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribbonTabItem1, Me.ribbonTabItem2, Me.ribbonTabItem3, Me.ribbonTabItem4, Me.ribbonTabItem5})
		Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7!)
		Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
		Me.ribbonControl1.MdiSystemItemVisible = false
		Me.ribbonControl1.Name = "ribbonControl1"
		Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
		Me.ribbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.applicationButton1, Me.buttonItem1, Me.qatCustomizeItem1})
		Me.ribbonControl1.Size = New System.Drawing.Size(967, 136)
		Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
		Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
		Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
		Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
		Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
		Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
		Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
		Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
		Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
		Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
		Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
		Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
		Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
		Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
		Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
		Me.ribbonControl1.TabGroupHeight = 14
		Me.ribbonControl1.TabIndex = 1
		Me.ribbonControl1.Text = "ribbonControl1"
		Me.ribbonControl1.UseCustomizeDialog = false
		'
		'ribbonPanel5
		'
		Me.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonPanel5.Controls.Add(Me.ribbonBar14)
		Me.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ribbonPanel5.Location = New System.Drawing.Point(0, 56)
		Me.ribbonPanel5.Name = "ribbonPanel5"
		Me.ribbonPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.ribbonPanel5.Size = New System.Drawing.Size(967, 77)
		'
		'
		'
		Me.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonPanel5.TabIndex = 5
		Me.ribbonPanel5.Visible = false
		'
		'ribbonBar14
		'
		Me.ribbonBar14.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar14.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar14.ContainerControlProcessDialogKey = true
		Me.ribbonBar14.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar14.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_Creditos})
		Me.ribbonBar14.Location = New System.Drawing.Point(3, 0)
		Me.ribbonBar14.Name = "ribbonBar14"
		Me.ribbonBar14.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar14.TabIndex = 0
		Me.ribbonBar14.Text = "Sobre"
		'
		'
		'
		Me.ribbonBar14.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar14.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_Creditos
		'
		Me.bti_Creditos.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_Creditos.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_Creditos.Image = CType(resources.GetObject("bti_Creditos.Image"),System.Drawing.Image)
		Me.bti_Creditos.Name = "bti_Creditos"
		Me.bti_Creditos.Stretch = true
		Me.bti_Creditos.SubItemsExpandWidth = 14
		AddHandler Me.bti_Creditos.Click, AddressOf Me.Bti_CreditosClick
		'
		'ribbonPanel4
		'
		Me.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonPanel4.Controls.Add(Me.ribbonBar13)
		Me.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ribbonPanel4.Location = New System.Drawing.Point(0, 56)
		Me.ribbonPanel4.Name = "ribbonPanel4"
		Me.ribbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.ribbonPanel4.Size = New System.Drawing.Size(967, 77)
		'
		'
		'
		Me.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonPanel4.TabIndex = 4
		Me.ribbonPanel4.Visible = false
		'
		'ribbonBar13
		'
		Me.ribbonBar13.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar13.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar13.ContainerControlProcessDialogKey = true
		Me.ribbonBar13.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar13.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_Estoque})
		Me.ribbonBar13.Location = New System.Drawing.Point(3, 0)
		Me.ribbonBar13.Name = "ribbonBar13"
		Me.ribbonBar13.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar13.TabIndex = 0
		Me.ribbonBar13.Text = "Visualizar Estoque"
		'
		'
		'
		Me.ribbonBar13.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar13.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_Estoque
		'
		Me.bti_Estoque.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_Estoque.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_Estoque.Image = CType(resources.GetObject("bti_Estoque.Image"),System.Drawing.Image)
		Me.bti_Estoque.Name = "bti_Estoque"
		Me.bti_Estoque.SubItemsExpandWidth = 14
		AddHandler Me.bti_Estoque.Click, AddressOf Me.Bti_EstoqueClick
		'
		'ribbonPanel3
		'
		Me.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonPanel3.Controls.Add(Me.ribbonBar12)
		Me.ribbonPanel3.Controls.Add(Me.ribbonBar11)
		Me.ribbonPanel3.Controls.Add(Me.ribbonBar10)
		Me.ribbonPanel3.Controls.Add(Me.ribbonBar9)
		Me.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ribbonPanel3.Location = New System.Drawing.Point(0, 56)
		Me.ribbonPanel3.Name = "ribbonPanel3"
		Me.ribbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.ribbonPanel3.Size = New System.Drawing.Size(967, 77)
		'
		'
		'
		Me.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonPanel3.TabIndex = 3
		Me.ribbonPanel3.Visible = false
		'
		'ribbonBar12
		'
		Me.ribbonBar12.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar12.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar12.ContainerControlProcessDialogKey = true
		Me.ribbonBar12.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar12.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_status, Me.bti_sintetico, Me.bti_analitico})
		Me.ribbonBar12.Location = New System.Drawing.Point(540, 0)
		Me.ribbonBar12.Name = "ribbonBar12"
		Me.ribbonBar12.Size = New System.Drawing.Size(317, 74)
		Me.ribbonBar12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar12.TabIndex = 3
		Me.ribbonBar12.Text = "Relatórios"
		'
		'
		'
		Me.ribbonBar12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar12.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_status
		'
		Me.bti_status.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_status.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_status.Image = CType(resources.GetObject("bti_status.Image"),System.Drawing.Image)
		Me.bti_status.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
		Me.bti_status.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
		Me.bti_status.Name = "bti_status"
		Me.bti_status.SubItemsExpandWidth = 14
		Me.bti_status.Text = "Status"
		AddHandler Me.bti_status.Click, AddressOf Me.Bti_statusClick
		'
		'bti_sintetico
		'
		Me.bti_sintetico.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_sintetico.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_sintetico.Image = CType(resources.GetObject("bti_sintetico.Image"),System.Drawing.Image)
		Me.bti_sintetico.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
		Me.bti_sintetico.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
		Me.bti_sintetico.Name = "bti_sintetico"
		Me.bti_sintetico.SubItemsExpandWidth = 14
		Me.bti_sintetico.Text = "Sintético"
		AddHandler Me.bti_sintetico.Click, AddressOf Me.Bti_sinteticoClick
		'
		'bti_analitico
		'
		Me.bti_analitico.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_analitico.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_analitico.Image = CType(resources.GetObject("bti_analitico.Image"),System.Drawing.Image)
		Me.bti_analitico.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
		Me.bti_analitico.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
		Me.bti_analitico.Name = "bti_analitico"
		Me.bti_analitico.SubItemsExpandWidth = 14
		Me.bti_analitico.Text = "Analítico"
		AddHandler Me.bti_analitico.Click, AddressOf Me.Bti_analiticoClick
		'
		'ribbonBar11
		'
		Me.ribbonBar11.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar11.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar11.ContainerControlProcessDialogKey = true
		Me.ribbonBar11.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar11.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_PDV, Me.bti_PDV2, Me.bti_PDV3})
		Me.ribbonBar11.Location = New System.Drawing.Point(223, 0)
		Me.ribbonBar11.Name = "ribbonBar11"
		Me.ribbonBar11.Size = New System.Drawing.Size(317, 74)
		Me.ribbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar11.TabIndex = 2
		Me.ribbonBar11.Text = "P D V"
		'
		'
		'
		Me.ribbonBar11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar11.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_PDV
		'
		Me.bti_PDV.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_PDV.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_PDV.Image = CType(resources.GetObject("bti_PDV.Image"),System.Drawing.Image)
		Me.bti_PDV.Name = "bti_PDV"
		Me.bti_PDV.SubItemsExpandWidth = 14
		AddHandler Me.bti_PDV.Click, AddressOf Me.Bti_PDVClick
		'
		'bti_PDV2
		'
		Me.bti_PDV2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_PDV2.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_PDV2.Image = CType(resources.GetObject("bti_PDV2.Image"),System.Drawing.Image)
		Me.bti_PDV2.Name = "bti_PDV2"
		Me.bti_PDV2.SubItemsExpandWidth = 14
		AddHandler Me.bti_PDV2.Click, AddressOf Me.Bti_PDV2Click
		'
		'bti_PDV3
		'
		Me.bti_PDV3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_PDV3.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_PDV3.Image = CType(resources.GetObject("bti_PDV3.Image"),System.Drawing.Image)
		Me.bti_PDV3.Name = "bti_PDV3"
		Me.bti_PDV3.SubItemsExpandWidth = 14
		'
		'ribbonBar10
		'
		Me.ribbonBar10.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar10.ContainerControlProcessDialogKey = true
		Me.ribbonBar10.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar10.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_PreVenda})
		Me.ribbonBar10.Location = New System.Drawing.Point(113, 0)
		Me.ribbonBar10.Name = "ribbonBar10"
		Me.ribbonBar10.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar10.TabIndex = 1
		Me.ribbonBar10.Text = "Pré - Venda"
		'
		'
		'
		Me.ribbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_PreVenda
		'
		Me.bti_PreVenda.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_PreVenda.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_PreVenda.Image = CType(resources.GetObject("bti_PreVenda.Image"),System.Drawing.Image)
		Me.bti_PreVenda.Name = "bti_PreVenda"
		Me.bti_PreVenda.SubItemsExpandWidth = 14
		AddHandler Me.bti_PreVenda.Click, AddressOf Me.Bti_PreVendaClick
		'
		'ribbonBar9
		'
		Me.ribbonBar9.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar9.ContainerControlProcessDialogKey = true
		Me.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar9.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_orcamento})
		Me.ribbonBar9.Location = New System.Drawing.Point(3, 0)
		Me.ribbonBar9.Name = "ribbonBar9"
		Me.ribbonBar9.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar9.TabIndex = 0
		Me.ribbonBar9.Text = "Orçamento"
		'
		'
		'
		Me.ribbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_orcamento
		'
		Me.bti_orcamento.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_orcamento.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_orcamento.Image = CType(resources.GetObject("bti_orcamento.Image"),System.Drawing.Image)
		Me.bti_orcamento.Name = "bti_orcamento"
		Me.bti_orcamento.SubItemsExpandWidth = 14
		AddHandler Me.bti_orcamento.Click, AddressOf Me.Bti_orcamentoClick
		'
		'ribbonPanel1
		'
		Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonPanel1.Controls.Add(Me.ribbonBar5)
		Me.ribbonPanel1.Controls.Add(Me.ribbonBar2)
		Me.ribbonPanel1.Controls.Add(Me.ribbonBar1)
		Me.ribbonPanel1.Controls.Add(Me.ribbonBar4)
		Me.ribbonPanel1.Controls.Add(Me.ribbonBar3)
		Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ribbonPanel1.Location = New System.Drawing.Point(0, 56)
		Me.ribbonPanel1.Name = "ribbonPanel1"
		Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.ribbonPanel1.Size = New System.Drawing.Size(967, 77)
		'
		'
		'
		Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonPanel1.TabIndex = 1
		'
		'ribbonBar5
		'
		Me.ribbonBar5.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar5.ContainerControlProcessDialogKey = true
		Me.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_formaPagamento})
		Me.ribbonBar5.Location = New System.Drawing.Point(443, 0)
		Me.ribbonBar5.Name = "ribbonBar5"
		Me.ribbonBar5.Size = New System.Drawing.Size(123, 74)
		Me.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar5.TabIndex = 6
		Me.ribbonBar5.Text = "Formas de Pagamento"
		'
		'
		'
		Me.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_formaPagamento
		'
		Me.bti_formaPagamento.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_formaPagamento.FixedSize = New System.Drawing.Size(114, 54)
		Me.bti_formaPagamento.Image = CType(resources.GetObject("bti_formaPagamento.Image"),System.Drawing.Image)
		Me.bti_formaPagamento.Name = "bti_formaPagamento"
		Me.bti_formaPagamento.SubItemsExpandWidth = 14
		AddHandler Me.bti_formaPagamento.Click, AddressOf Me.Bti_formaPagamentoClick
		'
		'ribbonBar2
		'
		Me.ribbonBar2.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar2.ContainerControlProcessDialogKey = true
		Me.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_fornecedores})
		Me.ribbonBar2.Location = New System.Drawing.Point(333, 0)
		Me.ribbonBar2.Name = "ribbonBar2"
		Me.ribbonBar2.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar2.TabIndex = 5
		Me.ribbonBar2.Text = "Fornecedores"
		'
		'
		'
		Me.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_fornecedores
		'
		Me.bti_fornecedores.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_fornecedores.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_fornecedores.Image = CType(resources.GetObject("bti_fornecedores.Image"),System.Drawing.Image)
		Me.bti_fornecedores.Name = "bti_fornecedores"
		Me.bti_fornecedores.SubItemsExpandWidth = 14
		AddHandler Me.bti_fornecedores.Click, AddressOf Me.Bti_fornecedoresClick
		'
		'ribbonBar1
		'
		Me.ribbonBar1.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar1.ContainerControlProcessDialogKey = true
		Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_Clientes})
		Me.ribbonBar1.Location = New System.Drawing.Point(223, 0)
		Me.ribbonBar1.Name = "ribbonBar1"
		Me.ribbonBar1.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar1.TabIndex = 4
		Me.ribbonBar1.Text = "Clientes"
		'
		'
		'
		Me.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_Clientes
		'
		Me.bti_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_Clientes.Description = "Clientes"
		Me.bti_Clientes.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_Clientes.GlobalName = "Clientes"
		Me.bti_Clientes.Image = CType(resources.GetObject("bti_Clientes.Image"),System.Drawing.Image)
		Me.bti_Clientes.Name = "bti_Clientes"
		Me.bti_Clientes.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
		Me.bti_Clientes.SubItemsExpandWidth = 14
		AddHandler Me.bti_Clientes.Click, AddressOf Me.Bti_ClientesClick
		'
		'ribbonBar4
		'
		Me.ribbonBar4.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar4.ContainerControlProcessDialogKey = true
		Me.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_Produtos})
		Me.ribbonBar4.Location = New System.Drawing.Point(113, 0)
		Me.ribbonBar4.Name = "ribbonBar4"
		Me.ribbonBar4.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar4.TabIndex = 3
		Me.ribbonBar4.Text = "Produtos"
		'
		'
		'
		Me.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_Produtos
		'
		Me.bti_Produtos.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_Produtos.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_Produtos.Image = CType(resources.GetObject("bti_Produtos.Image"),System.Drawing.Image)
		Me.bti_Produtos.Name = "bti_Produtos"
		Me.bti_Produtos.SubItemsExpandWidth = 14
		AddHandler Me.bti_Produtos.Click, AddressOf Me.Bti_ProdutosClick
		'
		'ribbonBar3
		'
		Me.ribbonBar3.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar3.ContainerControlProcessDialogKey = true
		Me.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_Categorias})
		Me.ribbonBar3.Location = New System.Drawing.Point(3, 0)
		Me.ribbonBar3.Name = "ribbonBar3"
		Me.ribbonBar3.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar3.TabIndex = 2
		Me.ribbonBar3.Text = "Categorias"
		'
		'
		'
		Me.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_Categorias
		'
		Me.bti_Categorias.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_Categorias.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_Categorias.Image = CType(resources.GetObject("bti_Categorias.Image"),System.Drawing.Image)
		Me.bti_Categorias.Name = "bti_Categorias"
		Me.bti_Categorias.SubItemsExpandWidth = 14
		AddHandler Me.bti_Categorias.Click, AddressOf Me.Bti_CategoriasClick
		'
		'ribbonPanel2
		'
		Me.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonPanel2.Controls.Add(Me.ribbonBar8)
		Me.ribbonPanel2.Controls.Add(Me.ribbonBar7)
		Me.ribbonPanel2.Controls.Add(Me.ribbonBar6)
		Me.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ribbonPanel2.Location = New System.Drawing.Point(0, 56)
		Me.ribbonPanel2.Name = "ribbonPanel2"
		Me.ribbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.ribbonPanel2.Size = New System.Drawing.Size(828, 77)
		'
		'
		'
		Me.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonPanel2.TabIndex = 2
		Me.ribbonPanel2.Visible = false
		'
		'ribbonBar8
		'
		Me.ribbonBar8.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar8.ContainerControlProcessDialogKey = true
		Me.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_RelatorioSintetico, Me.bti_relatorioAnalitico})
		Me.ribbonBar8.Location = New System.Drawing.Point(223, 0)
		Me.ribbonBar8.Name = "ribbonBar8"
		Me.ribbonBar8.Size = New System.Drawing.Size(214, 74)
		Me.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar8.TabIndex = 2
		Me.ribbonBar8.Text = "Relatórios"
		'
		'
		'
		Me.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_RelatorioSintetico
		'
		Me.bti_RelatorioSintetico.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.bti_RelatorioSintetico.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_RelatorioSintetico.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_RelatorioSintetico.Image = CType(resources.GetObject("bti_RelatorioSintetico.Image"),System.Drawing.Image)
		Me.bti_RelatorioSintetico.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.[Default]
		Me.bti_RelatorioSintetico.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
		Me.bti_RelatorioSintetico.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
		Me.bti_RelatorioSintetico.Name = "bti_RelatorioSintetico"
		Me.bti_RelatorioSintetico.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
		Me.bti_RelatorioSintetico.SubItemsExpandWidth = 14
		Me.bti_RelatorioSintetico.Text = "Sintético"
		AddHandler Me.bti_RelatorioSintetico.Click, AddressOf Me.Bti_RelatorioSinteticoClick
		'
		'bti_relatorioAnalitico
		'
		Me.bti_relatorioAnalitico.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_relatorioAnalitico.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_relatorioAnalitico.Image = CType(resources.GetObject("bti_relatorioAnalitico.Image"),System.Drawing.Image)
		Me.bti_relatorioAnalitico.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
		Me.bti_relatorioAnalitico.Name = "bti_relatorioAnalitico"
		Me.bti_relatorioAnalitico.SubItemsExpandWidth = 14
		Me.bti_relatorioAnalitico.Text = "Analítico"
		AddHandler Me.bti_relatorioAnalitico.Click, AddressOf Me.Bti_relatorioAnaliticoClick
		'
		'ribbonBar7
		'
		Me.ribbonBar7.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar7.ContainerControlProcessDialogKey = true
		Me.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bit_inserirCompras})
		Me.ribbonBar7.Location = New System.Drawing.Point(113, 0)
		Me.ribbonBar7.Name = "ribbonBar7"
		Me.ribbonBar7.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar7.TabIndex = 1
		Me.ribbonBar7.Text = "Inserir Compra"
		'
		'
		'
		Me.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bit_inserirCompras
		'
		Me.bit_inserirCompras.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bit_inserirCompras.FixedSize = New System.Drawing.Size(102, 54)
		Me.bit_inserirCompras.Image = CType(resources.GetObject("bit_inserirCompras.Image"),System.Drawing.Image)
		Me.bit_inserirCompras.Name = "bit_inserirCompras"
		Me.bit_inserirCompras.SubItemsExpandWidth = 14
		AddHandler Me.bit_inserirCompras.Click, AddressOf Me.Bit_inserirComprasClick
		'
		'ribbonBar6
		'
		Me.ribbonBar6.AutoOverflowEnabled = true
		'
		'
		'
		Me.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBar6.ContainerControlProcessDialogKey = true
		Me.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left
		Me.ribbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bti_Cotacao})
		Me.ribbonBar6.Location = New System.Drawing.Point(3, 0)
		Me.ribbonBar6.Name = "ribbonBar6"
		Me.ribbonBar6.Size = New System.Drawing.Size(110, 74)
		Me.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
		Me.ribbonBar6.TabIndex = 0
		Me.ribbonBar6.Text = "Cotação"
		'
		'
		'
		Me.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'bti_Cotacao
		'
		Me.bti_Cotacao.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bti_Cotacao.FixedSize = New System.Drawing.Size(102, 54)
		Me.bti_Cotacao.Image = CType(resources.GetObject("bti_Cotacao.Image"),System.Drawing.Image)
		Me.bti_Cotacao.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.[Default]
		Me.bti_Cotacao.ImagePaddingVertical = 8
		Me.bti_Cotacao.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
		Me.bti_Cotacao.Name = "bti_Cotacao"
		Me.bti_Cotacao.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
		Me.bti_Cotacao.SubItemsExpandWidth = 14
		AddHandler Me.bti_Cotacao.Click, AddressOf Me.Bti_CotacaoClick
		'
		'ribbonTabItem1
		'
		Me.ribbonTabItem1.Checked = true
		Me.ribbonTabItem1.Name = "ribbonTabItem1"
		Me.ribbonTabItem1.Panel = Me.ribbonPanel1
		Me.ribbonTabItem1.Text = "CADASTROS"
		'
		'ribbonTabItem2
		'
		Me.ribbonTabItem2.Name = "ribbonTabItem2"
		Me.ribbonTabItem2.Panel = Me.ribbonPanel2
		Me.ribbonTabItem2.Text = "COMPRAS"
		'
		'ribbonTabItem3
		'
		Me.ribbonTabItem3.Name = "ribbonTabItem3"
		Me.ribbonTabItem3.Panel = Me.ribbonPanel3
		Me.ribbonTabItem3.Text = "V E N D A S "
		'
		'ribbonTabItem4
		'
		Me.ribbonTabItem4.Name = "ribbonTabItem4"
		Me.ribbonTabItem4.Panel = Me.ribbonPanel4
		Me.ribbonTabItem4.Text = "ESTOQUE"
		'
		'ribbonTabItem5
		'
		Me.ribbonTabItem5.Name = "ribbonTabItem5"
		Me.ribbonTabItem5.Panel = Me.ribbonPanel5
		Me.ribbonTabItem5.Text = "CREDITOS"
		'
		'applicationButton1
		'
		Me.applicationButton1.AutoExpandOnClick = true
		Me.applicationButton1.CanCustomize = false
		Me.applicationButton1.ClickRepeatInterval = 800
		Me.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
		Me.applicationButton1.Image = CType(resources.GetObject("applicationButton1.Image"),System.Drawing.Image)
		Me.applicationButton1.ImageFixedSize = New System.Drawing.Size(30, 30)
		Me.applicationButton1.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.[Default]
		Me.applicationButton1.ImagePaddingHorizontal = 2
		Me.applicationButton1.ImagePaddingVertical = 2
		Me.applicationButton1.Name = "applicationButton1"
		Me.applicationButton1.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
		Me.applicationButton1.ShowSubItems = false
		Me.applicationButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer1, Me.bt_Fechar})
		Me.applicationButton1.Text = "&Menu"
		'
		'itemContainer1
		'
		'
		'
		'
		Me.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
		Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
		Me.itemContainer1.Name = "itemContainer1"
		Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer2})
		'
		'
		'
		Me.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'itemContainer2
		'
		'
		'
		'
		Me.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
		Me.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.itemContainer2.ItemSpacing = 0
		Me.itemContainer2.Name = "itemContainer2"
		Me.itemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer3})
		'
		'
		'
		Me.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'itemContainer3
		'
		'
		'
		'
		Me.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
		Me.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
		Me.itemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
		Me.itemContainer3.Name = "itemContainer3"
		Me.itemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.buttonItem5, Me.buttonItem6, Me.buttonItem7})
		'
		'
		'
		Me.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'buttonItem2
		'
		Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.buttonItem2.Image = CType(resources.GetObject("buttonItem2.Image"),System.Drawing.Image)
		Me.buttonItem2.Name = "buttonItem2"
		Me.buttonItem2.SubItemsExpandWidth = 24
		Me.buttonItem2.Text = "&New"
		'
		'buttonItem3
		'
		Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.buttonItem3.Image = CType(resources.GetObject("buttonItem3.Image"),System.Drawing.Image)
		Me.buttonItem3.Name = "buttonItem3"
		Me.buttonItem3.SubItemsExpandWidth = 24
		Me.buttonItem3.Text = "&Open..."
		'
		'buttonItem4
		'
		Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.buttonItem4.Image = CType(resources.GetObject("buttonItem4.Image"),System.Drawing.Image)
		Me.buttonItem4.Name = "buttonItem4"
		Me.buttonItem4.SubItemsExpandWidth = 24
		Me.buttonItem4.Text = "&Save..."
		'
		'buttonItem5
		'
		Me.buttonItem5.BeginGroup = true
		Me.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.buttonItem5.Image = CType(resources.GetObject("buttonItem5.Image"),System.Drawing.Image)
		Me.buttonItem5.Name = "buttonItem5"
		Me.buttonItem5.SubItemsExpandWidth = 24
		Me.buttonItem5.Text = "S&hare..."
		'
		'buttonItem6
		'
		Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.buttonItem6.Image = CType(resources.GetObject("buttonItem6.Image"),System.Drawing.Image)
		Me.buttonItem6.Name = "buttonItem6"
		Me.buttonItem6.SubItemsExpandWidth = 24
		Me.buttonItem6.Text = "&Print..."
		'
		'buttonItem7
		'
		Me.buttonItem7.BeginGroup = true
		Me.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.buttonItem7.Image = CType(resources.GetObject("buttonItem7.Image"),System.Drawing.Image)
		Me.buttonItem7.Name = "buttonItem7"
		Me.buttonItem7.SubItemsExpandWidth = 24
		Me.buttonItem7.Text = "&Close"
		'
		'bt_Fechar
		'
		Me.bt_Fechar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
		Me.bt_Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
		Me.bt_Fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_Fechar.Image = CType(resources.GetObject("bt_Fechar.Image"),System.Drawing.Image)
		Me.bt_Fechar.Name = "bt_Fechar"
		Me.bt_Fechar.SubItemsExpandWidth = 24
		Me.bt_Fechar.Text = "&Sair do Sistema"
		AddHandler Me.bt_Fechar.Click, AddressOf Me.Bt_FecharClick
		'
		'buttonItem1
		'
		Me.buttonItem1.Name = "buttonItem1"
		'
		'qatCustomizeItem1
		'
		Me.qatCustomizeItem1.Name = "qatCustomizeItem1"
		'
		'styleManager1
		'
		Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
		Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(87,Byte),Integer), CType(CType(154,Byte),Integer)))
		'
		'ribbonBarMergeContainer1
		'
		Me.ribbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
		Me.ribbonBarMergeContainer1.Location = New System.Drawing.Point(6, 3)
		Me.ribbonBarMergeContainer1.Name = "ribbonBarMergeContainer1"
		Me.ribbonBarMergeContainer1.Size = New System.Drawing.Size(195, 53)
		'
		'
		'
		Me.ribbonBarMergeContainer1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBarMergeContainer1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
		'
		'
		'
		Me.ribbonBarMergeContainer1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
		Me.ribbonBarMergeContainer1.TabIndex = 2
		Me.ribbonBarMergeContainer1.Visible = false
		'
		'MainForm2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(967, 446)
		Me.Controls.Add(Me.ribbonControl1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.IsMdiContainer = true
		Me.Name = "MainForm2"
		Me.Text = "7 Estoque e PDV"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ribbonControl1.ResumeLayout(false)
		Me.ribbonControl1.PerformLayout
		Me.ribbonPanel5.ResumeLayout(false)
		Me.ribbonPanel4.ResumeLayout(false)
		Me.ribbonPanel3.ResumeLayout(false)
		Me.ribbonPanel1.ResumeLayout(false)
		Me.ribbonPanel2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private bti_Creditos As DevComponents.DotNetBar.ButtonItem
	Private ribbonTabItem5 As DevComponents.DotNetBar.RibbonTabItem
	Private ribbonTabItem4 As DevComponents.DotNetBar.RibbonTabItem
	Private ribbonBar14 As DevComponents.DotNetBar.RibbonBar
	Private ribbonPanel5 As DevComponents.DotNetBar.RibbonPanel
	Private bti_Estoque As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar13 As DevComponents.DotNetBar.RibbonBar
	Private ribbonPanel4 As DevComponents.DotNetBar.RibbonPanel
	Private bti_PDV3 As DevComponents.DotNetBar.ButtonItem
	Private bti_PDV2 As DevComponents.DotNetBar.ButtonItem
	Private bti_analitico As DevComponents.DotNetBar.ButtonItem
	Private bti_sintetico As DevComponents.DotNetBar.ButtonItem
	Private bti_status As DevComponents.DotNetBar.ButtonItem
	Private bti_orcamento As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar9 As DevComponents.DotNetBar.RibbonBar
	Private bti_PreVenda As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar10 As DevComponents.DotNetBar.RibbonBar
	Private bti_PDV As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar11 As DevComponents.DotNetBar.RibbonBar
	Private ribbonBar12 As DevComponents.DotNetBar.RibbonBar
	Private ribbonTabItem3 As DevComponents.DotNetBar.RibbonTabItem
	Private ribbonPanel3 As DevComponents.DotNetBar.RibbonPanel
	Private bti_relatorioAnalitico As DevComponents.DotNetBar.ButtonItem
	Private bti_RelatorioSintetico As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar8 As DevComponents.DotNetBar.RibbonBar
	Private bti_Cotacao As DevComponents.DotNetBar.ButtonItem
	Private bit_inserirCompras As DevComponents.DotNetBar.ButtonItem
	Private ribbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
	Private ribbonBar6 As DevComponents.DotNetBar.RibbonBar
	Private ribbonBar7 As DevComponents.DotNetBar.RibbonBar
	Private bti_formaPagamento As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar5 As DevComponents.DotNetBar.RibbonBar
	Private bti_Produtos As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar4 As DevComponents.DotNetBar.RibbonBar
	Private bti_Categorias As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar3 As DevComponents.DotNetBar.RibbonBar
	Private bti_fornecedores As DevComponents.DotNetBar.ButtonItem
	Private ribbonBar2 As DevComponents.DotNetBar.RibbonBar
	Private bti_Clientes As DevComponents.DotNetBar.ButtonItem
	Private styleManager1 As DevComponents.DotNetBar.StyleManager
	Private qatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
	Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
	Private bt_Fechar As DevComponents.DotNetBar.ButtonItem
	Private buttonItem7 As DevComponents.DotNetBar.ButtonItem
	Private buttonItem6 As DevComponents.DotNetBar.ButtonItem
	Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
	Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
	Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
	Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
	Private itemContainer3 As DevComponents.DotNetBar.ItemContainer
	Private itemContainer2 As DevComponents.DotNetBar.ItemContainer
	Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
	Private applicationButton1 As DevComponents.DotNetBar.ApplicationButton
	Private ribbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
	Private ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
	Private ribbonPanel2 As DevComponents.DotNetBar.RibbonPanel
	Private ribbonBar1 As DevComponents.DotNetBar.RibbonBar
	Private ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
	Private ribbonControl1 As DevComponents.DotNetBar.RibbonControl
	
End Class
