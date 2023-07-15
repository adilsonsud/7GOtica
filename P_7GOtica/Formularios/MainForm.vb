'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 27/2/2014
' Hora: 23:36
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports System.Windows.Forms.Application
Public Partial Class MainForm
	'CADASTROS
	Private clientes As FormClientes
	Private fornecedores As FormFornecedores
	Public categorias As FormCategorias
	Private produtos As FormProdutos
	Private formaPagamento As FormFormaPagamento
	'COMPRAS
	Private compras As FormCompras
	Private cotacao As FormCotacao
	Private relatorioCompras As FormRelatorioCompras
	Private relatorioComprasDetalhe As FormRelatorioComprasDetalhe
	'VENDAS
	Private PDV As FormPDV2
	Private prevenda As FormPreVenda
	Private orcamento As FormOrcamento
	Private relatorioVendaStatus As FormRelatorioVendas_Status
	Private relatorioVendas As FormRelatorioVendas
	'ESTOQUE
	Private estoque As FormEstoque
	
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub MenuItemClientes_Click(sender As Object, e As EventArgs)		
'		
'		If IsNothing(clientes) = False Then
'			MsgBox("O Formulário de Clientes já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			clientes = New FormClientes()
			clientes.Show	
'		End If
	End Sub

	
	Sub MenuItemFornecedores_Click(sender As Object, e As EventArgs)
'		If IsNothing(fornecedores) = False Then
'			MsgBox("O Formulário de Fornecedores já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			fornecedores = New FormFornecedores
			fornecedores.Show	
'		End If
	End Sub
	
	Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs)
'		If IsNothing(categorias) = False Then
'			MsgBox("O Formulário de Categorias já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			categorias = New FormCategorias
			categorias.Show	
'		End If
	End Sub
	
	Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)
'		If IsNothing(produtos) = False Then
'			MsgBox("O Formulário de Produtos já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			produtos = New FormProdutos
			produtos.Show	
'		End If
	End Sub
	
	Sub InserirComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)
'		If IsNothing(compras) = False Then
'			MsgBox("O Formulário de Compras já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			compras = New FormCompras
			compras.Show	
'		End If
	End Sub
	
	Sub FormaDePagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs)
'		If IsNothing(formaPagamento) = False Then
'			MsgBox("O Formulário de Formas de Pagamento já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			formaPagamento = New FormFormaPagamento		
			formaPagamento.Show	
'		End If
	End Sub
	
	Sub OrçamentoToolStripMenuItem1Click(sender As Object, e As EventArgs)
'		If IsNothing(cotacao) = False Then
'			MsgBox("O Formulário de Cotação de Compras já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			cotacao = New FormCotacao		
			cotacao.Show	
'		End If
	End Sub
	
	
	
	Sub RelatórioDeToolStripMenuItemClick(sender As Object, e As EventArgs)
'		If IsNothing(relatorioCompras) = False Then
'			MsgBox("O Formulário de Relatório Sintético de Compras já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			relatorioCompras = New FormRelatorioCompras		
			relatorioCompras.Show	
'		End If
	End Sub
	
	Sub ComprasDetalheToolStripMenuItemClick(sender As Object, e As EventArgs)
'		If IsNothing(relatorioComprasDetalhe) = False Then
'			MsgBox("O Formulário de Relatório Analítico de Compras já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			relatorioComprasDetalhe = New FormRelatorioComprasDetalhe		
			relatorioComprasDetalhe.Show	
'		End If
	End Sub
	
	Sub PréVendaToolStripMenuItemClick(sender As Object, e As EventArgs)
'		If IsNothing(prevenda) = False Then
'			MsgBox("O Formulário de Pré Venda já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			prevenda = New FormPreVenda		
			prevenda.Show	
'		End If
	End Sub
	
	Sub PDVToolStripMenuItemClick(sender As Object, e As EventArgs)
'		If IsNothing(PDV) = False Then
'			MsgBox("O Formulário de PDV já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			PDV = New FormPDV2		
			PDV.Show	
'		End If
	End Sub
	
	Sub OrçamentoToolStripMenuItemClick(sender As Object, e As EventArgs)
'		If IsNothing(orcamento) = False Then
'			MsgBox("O Formulário de Orçamento já está aberto", MsgBoxStyle.Exclamation,"*** Atenção ***")
'		Else
			orcamento = New FormOrcamento		
			orcamento.Show	
'		End If
	End Sub
	
	Sub EstoqueToolStripMenuItemClick(sender As Object, e As EventArgs)
		estoque = New FormEstoque
		estoque.Show
	End Sub
	
	Sub StatusToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioVendas_Status
		form.ShowDialog
	End Sub
	
	Sub AnalíticoToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioVendas
		form.Show
	End Sub
	
	Sub SintéticoToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatoriosSinteticoVendas
		form.Show
	End Sub
	
	Sub CréditosToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim form As New FormCreditos
		form.Show
	End Sub
End Class
