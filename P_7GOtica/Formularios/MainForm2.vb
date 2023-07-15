'
' Criado por SharpDevelop.
' Usuário: adilson
' Data: 2015-11-18
' Hora: 23:03
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports P_7GFrota
Public Partial Class MainForm2
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
	Sub Bti_ClientesClick(sender As Object, e As EventArgs)
		Dim form As New FormClientes
		form.MdiParent = Me
		form.Show
	End Sub
	
	Sub Bt_FecharClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	Sub Bti_fornecedoresClick(sender As Object, e As EventArgs)
		Dim form As New FormFornecedores
		form.MdiParent = Me
		form.Show
	End Sub
	
	Sub Bti_CategoriasClick(sender As Object, e As EventArgs)
		Dim form As New FormCategorias
		form.MdiParent = Me
		form.Show
	End Sub
	
	Sub Bti_formaPagamentoClick(sender As Object, e As EventArgs)
		Dim form As New FormFormaPagamento
		form.MdiParent = Me
		form.Show
	End Sub
	
	Sub Bti_ProdutosClick(sender As Object, e As EventArgs)
		Dim form As New FormProdutos
		form.MdiParent = Me
		form.Show
	End Sub
	
	Sub Bti_CotacaoClick(sender As Object, e As EventArgs)
		Dim form As New FormCotacao
		form.Show
	End Sub
	
	Sub Bit_inserirComprasClick(sender As Object, e As EventArgs)
		Dim form As New FormCompras
		form.MdiParent = Me
		form.Show
	End Sub
	
	Sub Bti_RelatorioSinteticoClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioCompras
		form.Show
	End Sub
	
	Sub Bti_relatorioAnaliticoClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioComprasDetalhe
		form.Show
	End Sub
	
	Sub Bti_orcamentoClick(sender As Object, e As EventArgs)
		Dim form As New FormOrcamento
		form.Show
	End Sub
	
	Sub Bti_PreVendaClick(sender As Object, e As EventArgs)
		Dim form As New FormPreVenda
		form.Show
	End Sub
	
	Sub Bti_PDVClick(sender As Object, e As EventArgs)
		Dim form As New FormPDV
		form.Show		
	End Sub
	
	Sub Bti_sinteticoClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatoriosSinteticoVendas
		form.MdiParent = Me
		form.Show	
	End Sub
	
	Sub Bti_analiticoClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioVendas
		form.Show	
	End Sub
	
	Sub Bti_statusClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioVendas_Status
		form.Show	
	End Sub
	
	Sub Bti_PDV2Click(sender As Object, e As EventArgs)
		Dim form As New FormPDV2
		form.Show
	End Sub
	
	Sub Bti_EstoqueClick(sender As Object, e As EventArgs)
		Dim form As New FormEstoque
		form.Show
	End Sub
	
	Sub Bti_CreditosClick(sender As Object, e As EventArgs)
		Dim form As New FormCreditos
		form.MdiParent = Me
		form.Show
	End Sub
End Class
