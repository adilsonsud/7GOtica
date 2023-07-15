'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports System.Data
Public Partial Class FormPDV2
	
	Dim venda As New EntPDV
	Dim cadPDV As New CadPDV
	Dim opcaoPDV As Integer ' 1 insere cliente, 2 insere produto - usado para controla oq o pnl_produto irá exibir (1 cliente / 2 produto)
	Dim v_updateItem As Integer ' 1 inserir, 2 atualizar, 3 deletar, realiza o calculo do vt e preçoUnit
	Dim v_updateVenda As Integer '1 insere venda , 2 atualiza idCliente ou idFormaPagamento ou os dois
	Dim v_Finaliza As Boolean = False ' tem por finalidade evitar que outras teclas de função sejam ativadas na hora de finalizar a venda(false permite utilização das teclas de função, true não permite)
	Dim v_orcamento As Boolean = False 'tem por finalidade evitar que mais produtos sejam inseridos em caso de abertura de orçamento, permite somente trocar cliente, forma pagamento e valor pago
	Dim v_valorTotal As Double
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		lbl_rodape.Visible = False
		pnl_principal.Visible = False
		pnl_lateral.Visible = False
		lbl_central.Visible = True
		
	End Sub
	
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
		If MsgBox("Deseja fechar a tela de PDV?",vbYesNo,"FECHAR PDV") = vbYes Then
			Me.Close
		Else
			Exit Sub
		End If
	End Sub
	
	
	
	Sub FormPDV_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 And v_Finaliza = False  And pnl_orcamento.Visible = False Then
			
			If lbl_central.Visible = True And pnl_principal.Visible = False  Then 'abre o sistema para  nova venda	
				lbl_central.Visible = False
				txt_FormaPagamento.Visible = False
				cb_formaPagamento.Visible = True
				pnl_principal.Visible = True
				gb_venda.Visible = True
				dgv_Itens.Visible = False
				txt_cliente.Focus
				v_updateVenda = 1
			 ElseIf lbl_central.Visible = False And  pnl_principal.Visible = True   And txt_FormaPagamento.Visible = True And v_orcamento = False'mostra pnl_produto
		 		lbl_cliente.Visible = False
				txt_produto.Clear
				txt_produto.Focus
				dgv_clientes.DataSource = ""
				opcaoPDV = 2 'dgv_produto exibirá os produtos
			 End If
				
		End If
		
		
		If e.KeyCode = Keys.Escape   And v_Finaliza = False Then
			
			If pnl_orcamento.Visible = True Then
				pnl_orcamento.Visible = False
				lbl_central.Visible = True
			End If
			
		End If
		
		
		If e.KeyCode = Keys.F5  And lbl_central.Visible = False  And v_Finaliza = False And dgv_Itens.RowCount > 0 And dgv_Itens.Visible = True Then
			venda.IdProduto = CInt(dgv_Itens.SelectedCells(5).Value.ToString)
			venda.IdFornecedor = CInt(dgv_Itens.SelectedCells(6).Value.ToString)
			venda.QTD = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			
			'Procedimentos para atualizar o estoque (campo qtd da tabela prod_for)
			venda.Estoque = cadPDV.SelecionaEstoque(venda.IdProduto,venda.IdFornecedor)'pega o valor atual do estoque
			venda.Estoque += venda.QTD 'soma o valor que esta no campo qtd do grid com o que ta no estoque
			cadPDV.AtualizaEstoque(venda.Estoque,venda.IdProduto,venda.IdFornecedor)'devolve ao estoque o valor antigo
			
			venda.Precovenda = CDbl(dgv_Itens.SelectedCells(3).Value.ToString)
			v_updateItem = 2
		End If
		
		
		If e.KeyCode = Keys.F7 And lbl_central.Visible = False  And pnl_principal.Visible = True  And v_Finaliza = False Then
			Select Case venda.Aberta
				Case True
					v_updateVenda = 2
					dgv_Itens.Visible = False
					txt_cliente.ReadOnly = False
					txt_FormaPagamento.Visible = False
					cb_formaPagamento.Visible = True
					txt_cliente.Focus
				Case False
					MsgBox("Não é possivel alterar informações de uma venda Fechada ou vazia!",vbInformation,"ATENÇÃO!")
					Exit Sub
				End Select
		End If
		
		
		
		If e.KeyCode = Keys.F3 And v_Finaliza = False  Then
			If lbl_central.Visible = True Then 'chama pnl_orçamento
				v_orcamento = True
				pnl_orcamento.Visible = True
				lbl_central.Visible = False
				txt_Norcamento.Focus
			ElseIf dgv_Itens.RowCount < 1 and lbl_central.Visible = False And pnl_orcamento.Visible = False And dgv_Itens.Visible = True Then
				MsgBox("Você não pode finalizar uma compra sem adicionar no minimo um item , adicione um item pressionando a tecla (F1).",vbOKOnly,"ATENÇÃO")
				Exit Sub
			ElseIf dgv_Itens.RowCount > 0  and lbl_central.Visible = False And txt_cliente.ReadOnly = True And pnl_orcamento.Visible = False Then
			    If	MsgBox("Deseja finalizar esta compra?",vbYesNo,"Finalizar Compra") = vbYes Then
			    	venda.ValorTotal = CDbl(txt_valorTotal.Text)
			    	cadPDV.AtualizarVenda(venda)
					v_Finaliza = True ' venda sendo finalizada, nenhuma tecla de função poderá ser usada
					txt_desconto.ReadOnly = False
					txt_desconto.Focus
					v_valorTotal = CDbl(txt_valorTotal.Text)
				Else
					Exit Sub	
				End If
			End If
			
		End If
		
	End Sub
	

	
	Sub Txt_produto_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			calculoPDV
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_clientes.Focus
		End If
		
	End Sub
	
	
	
    Sub dgv_clientes_KeyDown(sender As Object, e As KeyEventArgs)
    	If e.KeyCode = Keys.Enter Then
    		
				If opcaoPDV = 1 Then 'processa informações do cliente
					txt_cliente.Text = dgv_clientes.SelectedCells(1).Value.ToString
					venda.IdCliente = CInt(dgv_clientes.SelectedCells(0).Value.ToString)
					lbl_cliente.Visible = False
					dgv_clientes.Visible = False
					
					'carrega cb_formaPagamento
					cb_formaPagamento.DataSource = cadPDV.CarregaFormaPagamento
					cb_formaPagamento.ValueMember = "forma"
					cb_formaPagamento.DisplayMember = "forma"
					cb_formaPagamento.Focus
					
				ElseIf opcaoPDV = 2 Then 'processa informações dos produtos
					
					If dgv_clientes.RowCount < 1 Then
						MsgBox("Digite o nome do produto desejado",vbOKOnly,"Escolha um Produto")
						txt_produto.Clear
						txt_produto.Focus
						Exit Sub	
					Else
						venda.Estoque = CInt(dgv_clientes.SelectedCells(4).Value.ToString)
						
						If venda.Estoque < 1 Then
							MsgBox("Não tem estoque para este produto!",vbInformation,"ESTOQUE ZERADO")
							Exit Sub
						Else
							venda.NomeProduto = dgv_clientes.SelectedCells(0).Value.ToString
							venda.NomeFantasia = dgv_clientes.SelectedCells(1).Value.ToString
							venda.IdProduto = CInt(dgv_clientes.SelectedCells(2).Value.ToString)
							venda.IdFornecedor = CInt(dgv_clientes.SelectedCells(3).Value.ToString)
							venda.Precovenda = CDbl(dgv_clientes.SelectedCells(6).Value.ToString)
							v_updateItem = 1
						End If	
							
					End If
				End If	
		End If
	End Sub
	
		
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_cliente.Focus
		End If
		
		
		If e.KeyCode = Keys.Delete Then
			v_updateItem = 3
			venda.IdProduto = CInt(dgv_Itens.SelectedCells(5).Value.ToString)
			venda.IdFornecedor = CInt(dgv_Itens.SelectedCells(6).Value.ToString)
			venda.QTD = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			venda.ValorTotal = CDbl(txt_valorTotal.Text)
			venda.Valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
			'calculoPDV(venda.QTD,venda.Precovenda,venda.ValorTotal)
		End If
	End Sub
	
	
	
	Public Sub calculoPDV
		Dim dt As New DataTable 
		Dim cdb As String
		'           0                       1                     2                    3                4                 5                   6                 7
		'produtos.Nome, fornecedores.NomeFantasia, prod_for.idProduto ,prod_for.idFornecedor, prod_for.QTD, prod_for.PrecoCusto, prod_for.precoVenda, prod_for.cdb
		dt = cadPDV.ExibeProdutosCDB(txt_produto.Text)	
		venda.IdProduto = CInt(dt.Rows(0)(2))
		venda.IdFornecedor = CInt(dt.Rows(0)(3))
		venda.NomeProduto = CStr(dt.Rows(0)(0))
		venda.NomeFantasia = CStr(dt.Rows(0)(1))
		venda.Precovenda = CDbl(dt.Rows(0)(6))
		venda.cdb = dt.Rows(0)(7).ToString
		venda.QTD = 1
		venda.Valor = venda.QTD * venda.Precovenda
		If dgv_Itens.RowCount < 1 Then
			dgv_Itens.Rows.Add(venda.NomeProduto,venda.NomeFantasia,venda.QTD,venda.Precovenda,venda.Valor, venda.IdProduto, venda.IdFornecedor, venda.cdb)
			cadPDV.AdicionarItensVenda(venda)
		Else
			
			dgv_Itens.Rows.Add(venda.NomeProduto,venda.NomeFantasia,venda.QTD,venda.Precovenda,venda.Valor, venda.IdProduto, venda.IdFornecedor)
		End If
		
		txt_produto.Clear
		txt_produto.Focus	
		
	End Sub
	
	
	
	Sub Txt_cliente_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter  And cb_formaPagamento.Visible = True Then			
			lbl_cliente.Visible = True
			dgv_clientes.Visible = True
			'       0        1           2
			' idCliente,NomeCliente, CPF_CNPJ
			dgv_clientes.DataSource = cadPDV.SelecionaCliente(txt_cliente.Text)
			dgv_clientes.Columns(1).HeaderText = "CLIENTE"
			dgv_clientes.Columns(2).HeaderText = "CPF/CNPJ"			
			dgv_clientes.Columns(0).Visible = False  'Id Cliente
			dgv_clientes.Columns(1).Visible = True  'Nome Cliente
			dgv_clientes.Columns(2).Visible = True 'Cpf/Cnpj	
			dgv_clientes.Columns(1).Width = 100
			dgv_clientes.Columns(2).Width = 100		
			opcaoPDV = 1 'dgv_produtos exibirá os clientes
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_clientes.Focus
		End If
		
	End Sub
	
	
	
	Sub Cb_formaPagamento_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Escape Then
			txt_cliente.Focus
		End If		
		
		If e.KeyCode = Keys.Enter Then
			If txt_cliente.Text = "" Then
				MsgBox("Escolha um cliente",vbOKOnly,"ATENÇÃO")
				txt_cliente.Focus
				Exit Sub
				
			ElseIf cb_formaPagamento.Text = "" Then
				MsgBox("Escolha a forma de pagamento",vbOKOnly,"ATENÇÃO")
				cb_formaPagamento.Focus
				Exit Sub
				
			Else
			 If v_orcamento	= False Then 'se for venda executa o select, se for orçamento passa para o else
				Select Case v_updateVenda
					Case 1 'insere informações na tabela venda
						
						lbl_rodape.Visible = True
						pnl_principal.Visible = True
						dgv_Itens.Visible = True
						pnl_lateral.Visible = True
						lbl_central.Visible = False
						venda.DataVenda = CDate(Today)
						lbl_data.Text = CStr(venda.DataVenda)
						venda.Hora = CStr(TimeOfDay)
						lbl_hora.Text = venda.Hora
						
						lbl_status.Text = "Aberta"						
						lbl_status.ForeColor = Color.Lime
						lbl_status.Visible = True
						lbl_data.Visible = True
						lbl_hora.Visible = True
						txt_valorTotal.Text = "0"
						txt_desconto.Text = "0"
						txt_pago.Text = "0"
						txt_troco.Text = "0"
						
						lbl_cliente.Visible = False
						txt_FormaPagamento.Visible = True
						txt_FormaPagamento.Text = cb_formaPagamento.Text
						cb_formaPagamento.Visible = False
						txt_cliente.ReadOnly = True
						txt_FormaPagamento.ReadOnly = True
						txt_produto.Clear
						txt_produto.Focus
					
						dgv_clientes.DataSource = ""
						opcaoPDV = 2 'dgv_produto exibirá os produtos
						
						venda.Desconto = CDbl(txt_desconto.Text)
						venda.ValorTotal = CDbl(txt_valorTotal.Text)
						venda.Pago = CDbl(txt_pago.Text)
						venda.Troco = CDbl(txt_troco.Text)
						venda.Aberta = True
						
						venda.IdFormaPagamento = cadPDV.SelecionaIdFormaPagamento(cb_formaPagamento.Text)
						venda.IdCliente = cadPDV.SelecionaIdCliente(txt_cliente.Text)
						cadPDV.AdicionarVenda(venda)
						venda.IdVenda = cadPDV.RetornaIdVenda
						lbl_idvenda.Visible = True
						lbl_idvenda.Text = CStr(venda.IdVenda)
						lbl_codigovenda.Visible = True
						lbl_codigovenda.Text = "Código da Venda: "
						
						
					Case 2 'faz um update na tabela venda, nos campos IdformaPagamento e IdCliente
						venda.IdFormaPagamento = cadPDV.SelecionaIdFormaPagamento(cb_formaPagamento.Text)
						venda.IdCliente = cadPDV.SelecionaIdCliente(txt_cliente.Text)
						
						dgv_Itens.Visible = True
						lbl_cliente.Visible = False
						txt_FormaPagamento.Visible = True
						txt_FormaPagamento.Text = cb_formaPagamento.Text
						cb_formaPagamento.Visible = False
						txt_cliente.ReadOnly = True
						txt_FormaPagamento.ReadOnly = True
						txt_produto.Clear
						txt_produto.Focus
					
						dgv_clientes.DataSource = ""
						opcaoPDV = 2 'dgv_produto exibirá os produtos
						cadPDV.AtualizarInfoVendas(venda.IdCliente,venda.IdFormaPagamento,venda.IdVenda)
				End Select
			 ElseIf v_orcamento = True 'executa em caso de ser orçamento
			 	venda.IdFormaPagamento = cadPDV.SelecionaIdFormaPagamento(cb_formaPagamento.Text)
				venda.IdCliente = cadPDV.SelecionaIdCliente(txt_cliente.Text)
				cadPDV.AtualizarInfoVendas(venda.IdCliente,venda.IdFormaPagamento,venda.IdVenda)
				
			 	txt_FormaPagamento.Visible = True
			 	txt_FormaPagamento.Text = cb_formaPagamento.Text
				cb_formaPagamento.Visible = False
				pnl_principal.Visible = True
				pnl_lateral.Visible = True
				gb_venda.Visible = True
				dgv_Itens.Visible = True
				lbl_rodape.Visible = True
				v_updateVenda = 2
				lbl_data.Text = CStr(venda.DataVenda)
				txt_valorTotal.Text = FormatCurrency(CStr(venda.ValorTotal),2)
				txt_desconto.Text = FormatCurrency(CStr(venda.Desconto),2)
				txt_pago.Text = FormatCurrency(CStr(venda.Pago),2)
				txt_troco.Text = FormatCurrency(CStr(venda.Troco),2)
				txt_cliente.ReadOnly = True
				
				lbl_status.Text = "Aberta"
				lbl_status.ForeColor = Color.Lime
				lbl_status.Visible = True
				txt_pago.ReadOnly = False
				txt_pago.Focus	
			 End If	
			End If
		End If
		
	End Sub
	
	
	
	Sub Txt_desconto_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter And txt_desconto.ReadOnly = False Then
			txt_valorTotal.Text = FormatCurrency(CalculoDesconto,2)
		End If
		
		
		If e.KeyCode = keys.Back And txt_desconto.ReadOnly = False Then
			txt_desconto.ReadOnly = False
			txt_pago.ReadOnly = True
			txt_desconto.Clear
			txt_desconto.Focus
		End If
	End Sub
	
	
	Public Function CalculoDesconto As Double
		If Not IsNumeric(txt_desconto.Text) Then
		   txt_desconto.Text = "0"	
		End If
		
		venda.ValorTotal = CDbl(txt_valorTotal.Text)
		venda.Desconto = CDbl(txt_desconto.Text)
		txt_desconto.Text = CStr(FormatCurrency (txt_desconto.Text,2))
		
		If venda.Desconto > venda.ValorTotal Then
			MsgBox("O valor do desconto não pode ser maior do que o valor total", vbInformation,"ATENÇÃO")
			txt_desconto.ReadOnly = False
			txt_pago.ReadOnly = True
			txt_desconto.Clear
			txt_desconto.Focus
			
		Else
			venda.ValorTotal = venda.ValorTotal - venda.Desconto
			txt_desconto.ReadOnly = True
			txt_pago.ReadOnly = False
			txt_pago.Focus
		End If
		Return venda.ValorTotal
	End Function
	

	
	Sub Txt_desconto_KeyPress(sender As Object, e As KeyPressEventArgs)

		If Not Char.IsNumber(e.KeyChar)  And Not  e.KeyChar = "," Then
    		 e.Handled = True
		End If
	End Sub
	
	
	
	Sub Txt_pago_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = keys.Back And txt_pago.ReadOnly = False Then
			txt_pago.Clear
			txt_pago.Focus
		End If
		
		
		If e.KeyCode = keys.Enter And txt_pago.ReadOnly = False Then
				If Not IsNumeric(txt_pago.Text) Then
					MsgBox("Digite um valor numérico valido",vbOKOnly,"ATENÇÃO")
					txt_pago.Clear
					txt_pago.Focus		
				Else
					CalculoTroco					
				End If
		End If		
	End Sub
	
	
	
	Public sub CalculoTroco 
		venda.ValorTotal = CDbl(txt_valorTotal.Text)
		venda.Pago = CDbl(txt_pago.Text)
		
		If venda.Pago < venda.ValorTotal Then
			MsgBox("O valor pago é menor do que o valor total, digite o valor correto.",vbOKOnly,"ATENÇÃO")
			txt_pago.Clear
			txt_pago.Focus
		Else
			venda.ValorTotal = CDbl(txt_valorTotal.Text)
			venda.Pago = CDbl(txt_pago.Text)
			venda.Troco = venda.Pago - venda.ValorTotal
			txt_troco.Text = CStr(FormatCurrency(venda.Troco,2))
			txt_pago.ReadOnly = True
			txt_pago.Text = FormatCurrency(txt_pago.Text,2)
			
			If MsgBox("Confirme a finalização da venda", vbYesNo,"FINALIZAÇÃO DE VENDA") = vbYes Then
				v_Finaliza = False
				venda.Aberta = False
				lbl_rodape.Visible = False
				pnl_principal.Visible = False
				pnl_lateral.Visible = False
				pnl_orcamento.Visible = False
				lbl_central.Visible = True
				lbl_codigovenda.Visible = False
				lbl_idvenda.Visible = False
				lbl_hora.Text = ""
				lbl_data.Text = ""
				lbl_status.Text = ""
				txt_cliente.Clear
				cb_formaPagamento.DataSource = Nothing
				dgv_itens.Rows.Clear
				venda.Aberta = False
				cadPDV.AtualizarVenda(venda)
				txt_pago.ReadOnly = True
				v_orcamento = False
			Else
				If v_orcamento = True Then 'verifica se é orçamento para não alterar o valor do desconto da pré venda
					txt_desconto.ReadOnly = True
					txt_pago.Clear
					txt_troco.Clear
					txt_pago.Focus
					txt_pago.ReadOnly = False
						
				Elseif v_orcamento = False Then ' em caso de venda normal faz isto
					txt_valorTotal.Text = CStr(FormatCurrency(v_valorTotal,2))
					txt_desconto.Clear
					txt_pago.Clear
					txt_troco.Clear
					txt_desconto.ReadOnly = False
					txt_desconto.Focus
				End If
			End If
		End If
	End Sub
	
	
	Sub Txt_pago_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Not Char.IsNumber(e.KeyChar)  And Not  e.KeyChar = "," Then 'Tratamento feito para evitar que o usuario digete um valor invalido (não numerico, negativo etc) exeção para permitir virgula
    		 e.Handled = True
		End If
	End Sub
	
	Sub Txt_Norcamento_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Not Char.IsNumber(e.KeyChar)  Then 'Tratamento feito para evitar que o usuario digete um valor invalido (não numerico, negativo etc)
    		 e.Handled = True
		End If
	End Sub
	
	Sub Txt_Norcamento_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Back Then
			txt_Norcamento.Clear
			txt_Norcamento.Focus
		
		ElseIf e.KeyCode = Keys.Enter Then
			If txt_Norcamento.Text = "" Then
				MsgBox("Digite o número do orçamento",vbInformation,"VALOR EM BRANCO")
				Exit Sub
			Else
				venda = cadPDV.RetornaVenda(txt_Norcamento.Text)
				If venda.IdVenda = 0 Then 'caso a sub RetornaVenda seja zero no idVenda
					pnl_orcamento.Visible = True
					txt_Norcamento.Clear
					txt_Norcamento.Focus
					Exit Sub
				Else
					If venda.Aberta = False Then
						MsgBox("ATENÇÃO - A referida venda está fechada e será aberta somente para leitura!",vbInformation,"VENDA FECHADA")
						
						txt_FormaPagamento.Visible = True
						cb_formaPagamento.Visible = False
						pnl_principal.Visible = True
						pnl_lateral.Visible = True
						gb_venda.Visible = True
						lbl_rodape.Visible = False
						lbl_codigovenda.Visible = True
						lbl_codigovenda.Text = "Código da Venda: "
						lbl_idvenda.Visible = True
						lbl_idvenda.Text = CStr(venda.IdVenda)
						
						v_updateVenda = 2
						lbl_data.Text = CStr(venda.DataVenda)
						lbl_hora.Text = venda.Hora
						txt_valorTotal.Text = FormatCurrency(CStr(venda.ValorTotal),2)
						txt_desconto.Text = FormatCurrency(CStr(venda.Desconto),2)
						txt_pago.Text = FormatCurrency(CStr(venda.Pago),2)
						txt_troco.Text = FormatCurrency(CStr(venda.Troco),2)
						txt_Norcamento.Clear
						txt_cliente.ReadOnly = True
						txt_FormaPagamento.ReadOnly = True
						
						txt_cliente.Text = cadPDV.RetornaNomeCliente(CStr(venda.IdCliente))
						txt_FormaPagamento.Text = cadPDV.RetornaFormaPagamento(CStr(venda.IdFormaPagamento))
						
						lbl_status.Text = "Fechada"
						lbl_status.ForeColor = Color.Red
						lbl_status.Visible = True
						txt_pago.ReadOnly = True
						txt_produto.Focus
											
					ElseIf venda.Aberta = True Then
					   'carrega cb_formaPagamento			
						cb_formaPagamento.DataSource = cadPDV.CarregaFormaPagamento
						cb_formaPagamento.ValueMember = "forma"
						cb_formaPagamento.DisplayMember = "forma"
						
						txt_FormaPagamento.Visible = True
						cb_formaPagamento.Visible = False
						pnl_principal.Visible = True
						pnl_lateral.Visible = True
						gb_venda.Visible = True
						lbl_rodape.Visible = True
						lbl_codigovenda.Visible = True
						lbl_idvenda.Visible = True
						lbl_idvenda.Text = CStr(venda.IdVenda)
						
						v_updateVenda = 2
						lbl_data.Text = CStr(venda.DataVenda)
						lbl_hora.Text = venda.Hora
						txt_valorTotal.Text = FormatCurrency(CStr(venda.ValorTotal),2)
						txt_desconto.Text = FormatCurrency(CStr(venda.Desconto),2)
						txt_pago.Text = FormatCurrency(CStr(venda.Pago),2)
						txt_troco.Text = FormatCurrency(CStr(venda.Troco),2)
						txt_Norcamento.Clear
						txt_cliente.ReadOnly = True
						txt_FormaPagamento.ReadOnly = True
						
						txt_cliente.Text = cadPDV.RetornaNomeCliente(CStr(venda.IdCliente))
						txt_FormaPagamento.Text = cadPDV.RetornaFormaPagamento(CStr(venda.IdFormaPagamento))
						
						lbl_status.Text = "Aberta"
						lbl_status.ForeColor = Color.Lime
						lbl_status.Visible = True
						txt_pago.ReadOnly = False
						txt_pago.Focus							
					End If						
				End If
			End If		
		End If
	End Sub
	
	
End Class
