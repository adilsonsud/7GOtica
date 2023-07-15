'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'

Public Partial Class FormRelatorioVendas_Status
	
	Dim venda As New EntPDV
	Dim cadPDV As New CadPDV
	Dim cadCategorias As New CadCategorias
	Dim cadformapagamento As New CadFormaPagamento
'	Dim cadProdutos As New CadProdutos
'	Dim cadFornecedor As New CadFornecedores
'	Dim cadCompras As New CadCompras
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
	
	Sub ExibeVendas
		Dim aberta As Boolean
		Dim data1 As Date
		Dim data2 As Date

		If txt_data1.Text = "" Then
			MsgBox("Escolha uma data inicial para efetuar a consulta", vbInformation, "DATA INICIAL EM BRANCO")
			txt_data1.Focus
			Exit Sub
		ElseIf txt_data2.Text = "" Then
			MsgBox("Escolha uma data final para efetuar a consulta", vbInformation, "DATA FINAL EM BRANCO")
			txt_data2.Focus
			Exit Sub
		ElseIf txt_data1.Text > txt_data2.Text Then
			MsgBox("A data inicial não pode ser posterior à data final", vbInformation, "ERRO NA DATA")
			txt_data1.Text = ""
			txt_data2.Text = ""
			Exit Sub
		Else
			If rb_Aberta.Checked = True Then
				aberta = True
				pnl_cancelarVenda.Visible = True
			Else If rb_Aberta.Checked = False
				aberta = False
				pnl_cancelarVenda.Visible = False
			End If
				
			data1 = CDate(txt_data1.Text)
			data2 = CDate(txt_data2.Text)
			
			dgv_vendas.DataSource = cadPDV.RetornaVendasPeriodo_Status(aberta,data1,data2)
			
			'     0          1              2        3        4     5          6       7    8     9
			'idVendas,formapagamentos,NomeCliente,DataVenda,hora,Desconto,ValorTotal,Pago,Troco,Aberta
			
			dgv_vendas.Columns(0).HeaderText = "ID VENDA"
			dgv_vendas.Columns(1).HeaderText = "FORMA PAGAMENTO"
			dgv_vendas.Columns(2).HeaderText = "CLIENTE"
			dgv_vendas.Columns(3).HeaderText = "DATA VENDA"
			dgv_vendas.Columns(4).HeaderText = "HORA"
			dgv_vendas.Columns(5).HeaderText = "DESCONTO"
			dgv_vendas.Columns(6).HeaderText = "VALOR TOTAL"
			dgv_vendas.Columns(7).HeaderText = "PAGO"
			dgv_vendas.Columns(8).HeaderText = "TROCO"
			dgv_vendas.Columns(9).HeaderText = "ABERTA"	
			dgv_vendas.Columns(5).DefaultCellStyle.Format = ("c2")
			dgv_vendas.Columns(6).DefaultCellStyle.Format = ("c2")
			dgv_vendas.Columns(7).DefaultCellStyle.Format = ("c2")
			dgv_vendas.Columns(8).DefaultCellStyle.Format = ("c2")
			
'			dgv_vendas.Columns(0).Width = 80
'			dgv_vendas.Columns(1).Width = 180
'			dgv_vendas.Columns(2).Width = 200
'			dgv_vendas.Columns(3).Width = 110
'			dgv_vendas.Columns(4).Width = 120
'			dgv_vendas.Columns(5).Width = 120
'			dgv_vendas.Columns(6).Width = 120
'			dgv_vendas.Columns(7).Width = 120
'			dgv_vendas.Columns(8).Width = 70			
			dgv_vendas.Focus
		End If	
	End Sub
	
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	
	
	
	Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
		txt_data2.Text = dateTimePicker2.Text
	End Sub
	
	
	Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
		txt_data1.Text = dateTimePicker1.Text
	End Sub
	
	
	Sub FormRelatorioCompras_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 Then
			pnl_Itens.Visible = False
			ExibeVendas
		End If	
		
		If e.KeyCode = Keys.Escape Then
			pnl_Itens.Visible = False
		End If
		
		
		If e.KeyCode = Keys.F3 And pnl_Itens.Visible = False Then
			If dgv_vendas.RowCount < 1 Then
				MsgBox("Não exite informações de venda, escolha o período desejado e aperte F1",vbInformation,"ATENÇÃO")
			Else
				pnl_Itens.Visible = True
				ExibeItensDaVenda
			End If	
		End If
		
	
		
	End Sub
	
	
	
	Sub ExibeItensDaVenda		
		'     0          1              2        3        4     5          6       7    8     9
		'idVendas,formapagamentos,NomeCliente,DataVenda,hora,Desconto,ValorTotal,Pago,Troco,Aberta
		
		'Exibe dados da venda
		lbl_idvenda.Text = dgv_vendas.SelectedCells(0).Value.ToString
		lbl_pagamento.Text = dgv_vendas.SelectedCells(1).Value.ToString
		lbl_cliente.Text = dgv_vendas.SelectedCells(2).Value.ToString
		lbl_data.Text = dgv_vendas.SelectedCells(3).Value.ToString
		lbl_hora.Text = dgv_vendas.SelectedCells(4).Value.ToString
		lbl_Desconto.Text = FormatCurrency(dgv_vendas.SelectedCells(5).Value.ToString,2)
		lbl_total.Text = FormatCurrency(dgv_vendas.SelectedCells(6).Value.ToString,2)
		lbl_pago.Text = FormatCurrency(dgv_vendas.SelectedCells(7).Value.ToString,2)
		lbl_troco.Text = FormatCurrency(dgv_vendas.SelectedCells(8).Value.ToString,2)
		lbl_status.Text = dgv_vendas.SelectedCells(9).Value.ToString
		If lbl_status.Text = "True" Then
			lbl_status.Text = "ABERTA"
		Else
			lbl_status.Text = "FECHADA"
		End If
		
		dgv_Itens.DataSource = cadPDV.RetornaItensVenda(lbl_idvenda.Text)
	   '          0                    1                    2               3                   4                 5                        6                    7  
       'produtos.Nome,fornecedores.NomeFantasia,itemvendas.QTD,prod_for.PrecoVenda, itemvendas.Valor,itemvendas.idProduto,itemvendas.idFornecedor,itemvendas.idVenda "
		dgv_Itens.Columns(0).HeaderText = "PRODUTO"
	    dgv_Itens.Columns(1).HeaderText = "FORNECEDOR"
		dgv_Itens.Columns(2).HeaderText = "QTD"
		dgv_Itens.Columns(3).HeaderText = "PREÇO UNIT"
		dgv_Itens.Columns(4).HeaderText = "VALOR"
		
		dgv_Itens.Columns(3).DefaultCellStyle.Format = ("c2")
		dgv_Itens.Columns(4).DefaultCellStyle.Format = ("c2")
					
		dgv_Itens.Columns(0).Width = 250
		dgv_Itens.Columns(1).Width = 250
		dgv_Itens.Columns(2).Width = 100
		dgv_Itens.Columns(3).Width = 200
		dgv_Itens.Columns(4).Width = 200
		
		dgv_Itens.Columns(5).Visible = False
		dgv_Itens.Columns(6).Visible = False
		dgv_Itens.Columns(7).Visible = False					
	End Sub
	
	
	
	Sub Bt_cancelarClick(sender As Object, e As EventArgs)
		cANCELARvENDA
	End Sub
	
	Sub cANCELARvENDA
		venda.IdFormaPagamento = cadformapagamento.rETORNA_fORMA_pAGAMENTO ' recebe o idformapagamento do item venda cancelada para atualizar na tabela de vendas
		venda.IdVenda = CInt(lbl_idvenda.Text) ' armazena o idvenda para atualizar na tabela de vendas como venda cancelada
		venda.ValorTotal = CDbl("0")
		venda.Desconto = CDbl("0")
		venda.Pago = CDbl("0")
		venda.Troco = CDbl("0")
		venda.Aberta = False
		cadPDV.AtualizarVendaCancelada(venda)
		dEVOLVE_eSTOQUE
		pnl_Itens.Visible = False
		ExibeVendas
	End Sub
	
	Sub dEVOLVE_eSTOQUE
		If dgv_Itens.RowCount < 1 Then
			Exit Sub
		Else		
			
			Dim linha As Integer = 0
			Dim qtdItem As Integer = 0
			Dim qtdEstoque = 0		
	
			While linha <= dgv_Itens.rowcount - 1		
				qtdItem = CInt(dgv_Itens.item(2,linha).value)
				venda.IdProduto = CInt(dgv_Itens.Item(5,linha).Value)
				venda.IdFornecedor = CInt(dgv_Itens.Item(6,linha).Value)
				qtdEstoque = cadPDV.SelecionaEstoque(venda.IdProduto, venda.IdFornecedor)
				cadPDV.AtualizaEstoque(qtdEstoque + qtdItem, venda.IdProduto, venda.IdFornecedor)
				venda.IdVenda = CInt(lbl_idvenda.Text)
				venda.QTD = CInt("0")
				venda.Valor = 0
				cadPDV.AtualizaItemVenda(venda)				
				linha +=1
			end while
			
		End If
	End Sub
	
End Class
