'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Partial Class FormRelatorioVendas
	
	Dim venda As New EntPDV
	Dim cadPDV As New CadPDV
	Dim cadCategorias As New CadCategorias
	Dim cadProdutos As New CadProdutos
	Dim cadFornecedor As New CadFornecedores
	Dim cadCliente As New CadClientes
	Dim cadForma As New CadFormaPagamento
	Dim filtro As String
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()	
	End Sub
	
	
	Sub eXIBEVENDAS		
		If txt_data1.Text = "" Then
			MsgBox("Escolha uma data inicial para efetuar a consulta", vbInformation, "DATA INICIAL EM BRANCO")
			ckb_Detalhe.Checked = False
			txt_data1.Focus
			Exit Sub
		ElseIf txt_data2.Text = "" Then
			MsgBox("Escolha uma data final para efetuar a consulta", vbInformation, "DATA FINAL EM BRANCO")
			ckb_Detalhe.Checked = False
			txt_data2.Focus
			Exit Sub
		Else
			If ckb_Detalhe.Checked = False Then 'Retorna todas as vendas do periodo informado
				venda.Aberta = False
				dgv_InfoVendas.DataSource = cadPDV.RetornaVendasPeriodo_Status(venda.Aberta,CDate(txt_data1.Text),CDate(txt_data2.Text))	
				'         0                       1                 2                 3               4             5                6               7           8            9
				'vendas.idVendas,formapagamentos.Forma,clientes.NomeCliente,vendas.DataVenda, vendas.hora, vendas.Desconto,vendas.ValorTotal,vendas.Pago,vendas.Troco,vendas.Aberta
				dgv_InfoVendas.Columns(0).HeaderText = "ID VENDA"
				dgv_InfoVendas.Columns(1).HeaderText = "FORMA PAGAMENTO"
				dgv_InfoVendas.Columns(2).HeaderText = "CLIENTE"
				dgv_InfoVendas.Columns(3).HeaderText = "DATA"
				dgv_InfoVendas.Columns(4).HeaderText = "HORA"
				dgv_InfoVendas.Columns(5).HeaderText = "DESCONTO"
				dgv_InfoVendas.Columns(6).HeaderText = "VALOR TOTAL"
				dgv_InfoVendas.Columns(7).HeaderText = "PAGO"
				dgv_InfoVendas.Columns(8).HeaderText = "TROCO"
				dgv_InfoVendas.Columns(9).HeaderText = "ABERTA"
				
				'dgv_InfoVendas.Columns(3).Visible = False
				dgv_InfoVendas.Columns(4).Visible = False
				dgv_InfoVendas.Columns(9).Visible = False
				
				dgv_InfoVendas.Columns(5).DefaultCellStyle.Format = ("c2")
				dgv_InfoVendas.Columns(6).DefaultCellStyle.Format = ("c2")
				dgv_InfoVendas.Columns(7).DefaultCellStyle.Format = ("c2")
				dgv_InfoVendas.Columns(8).DefaultCellStyle.Format = ("c2")				
							
				txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(6)),2)
								
			ElseIf ckb_Detalhe.Checked = True Then
				'esta query é para retornar o valor de desconto do periodo selecionado para subtrair do valor total, para não dar diferença dos outros relatórios
				filtro = "select sum(desconto) from 7gfrota.vendas where aberta = false and datavenda between " + "'"+ txt_data1.Text + "'" + " and '"+ txt_data2.Text +"'"
				Dim desconto As Double = cadPDV.RetornaDouble(filtro) 'a variavel desconto recebe o desconto do periodo informado
				
				If rb_categoria.Checked = True Then 'retorna categoria
					filtro = "where aberta = false and datavenda between '" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text + "' and categorias.nome like '%" & txt_pesquisa.Text & "%'"
					dgv_InfoVendas.DataSource = cadCategorias.rELATORIOCATEGORIA(filtro)
					'                        0                   1                    2                   3                              4                             5              6          
					'categorias.Nome As Categoria, produtos.idCategoria, prod_for.idProduto, itemvendas.idVenda, sum(itemvendas.QTD) As QTD, sum(itemvendas.Valor) As Valor, vendas.DataVenda
					dgv_InfoVendas.Columns(0).HeaderText = "CATEGORIA"
					dgv_InfoVendas.Columns(4).HeaderText = "QTD"
					dgv_InfoVendas.Columns(5).HeaderText = "VALOR"
					
					dgv_InfoVendas.Columns(1).Visible = False
					dgv_InfoVendas.Columns(2).Visible = False
					dgv_InfoVendas.Columns(3).Visible = False
					dgv_InfoVendas.Columns(6).Visible = false
					
					dgv_InfoVendas.Columns(5).DefaultCellStyle.Format = ("c2")
					txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(5) - desconto),2) 
					
				ElseIf rb_cliente.Checked = True Then	
					filtro = "where aberta = false and datavenda between '" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text + "' and clientes.NomeCliente like '%" & txt_pesquisa.Text & "%' order by clientes.NomeCliente"
					dgv_InfoVendas.DataSource = cadCliente.rELATORIOVENDACLIENTE(filtro)
					'          0                   1                  2             3                     4                   5              6                      7             8     
					'vendas.idVendas,clientes.NomeCliente,categorias.Nome,produtos.Nome,fornecedores.NomeFantasia,itemvendas.QTD,itemvendas.Valor,formapagamentos.Forma,vendas.DataVenda
					dgv_InfoVendas.Columns(0).HeaderText = "ID VENDA"
					dgv_InfoVendas.Columns(1).HeaderText = "CLIENTE"
					dgv_InfoVendas.Columns(2).HeaderText = "CATEGORIA"
					dgv_InfoVendas.Columns(3).HeaderText = "PRODUTO"
					dgv_InfoVendas.Columns(4).HeaderText = "FORNECEDOR"
					dgv_InfoVendas.Columns(5).HeaderText = "QTD"
					dgv_InfoVendas.Columns(6).HeaderText = "VALOR"
					dgv_InfoVendas.Columns(7).HeaderText = "FORMA PAGAMENTO"
					dgv_InfoVendas.Columns(8).HeaderText = "DATA"
					
					dgv_InfoVendas.Columns(8).Visible = False
					dgv_InfoVendas.Columns(6).DefaultCellStyle.Format = ("c2")

					txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(6) - desconto),2)
					
				ElseIf rb_formaPagamento.Checked = True Then
					filtro = "where aberta = false and datavenda between '" + txt_data1.Text + "'" + " and '" + txt_data2.Text + "' and formapagamentos.Forma like '%" & txt_pesquisa.Text & "%' "
					dgv_InfoVendas.DataSource = cadForma.rELATORIOVENDA_FORMAPAGAMENTO(filtro)
					'                              0                                  1                       
					'formapagamentos.forma As 'Forma de Pagamento' , sum(vendas.valortotal) As Total
					dgv_InfoVendas.Columns(0).HeaderText = "FORMA DE PAGAMENTOS"
					dgv_InfoVendas.Columns(1).HeaderText = "VALOR"
					dgv_InfoVendas.Columns(1).DefaultCellStyle.Format = ("c2")
					txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(1)),2)
					
				ElseIf rb_fornecedor.Checked = True Then		
					filtro = "where aberta = false and datavenda between '" + txt_data1.Text + "'" + " and '" + txt_data2.Text + "' and fornecedores.nomefantasia like '%" & txt_pesquisa.Text & "%' "
					dgv_InfoVendas.DataSource = cadFornecedor.rELATORIOaNALITICOvENDAS_fORNECEDOR(filtro)
					'                   0                      1                               2                              3               4
					'fornecedores.NomeFantasia, prod_for.idFornecedor, sum(itemvendas.QTD) As QTD, sum(itemvendas.Valor) As Valor, vendas.DataVenda
					dgv_InfoVendas.Columns(1).Visible = False
					dgv_InfoVendas.Columns(4).Visible = False
					dgv_InfoVendas.Columns(3).DefaultCellStyle.Format = "c2"
					txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(3) - desconto),2)
								
				ElseIf rb_produto.Checked = True Then	
					filtro = " where aberta = false and vendas.datavenda between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text +  "' and produtos.Nome like '%" & txt_pesquisa.Text & "%'"
					dgv_InfoVendas.DataSource = cadProdutos.rELATORIO_aNALITICO_vENDAS_pRODUTO(filtro)
					'    0        1            2          3        4         5           6           7        8          9        
					'Produto, Fornecedor, PrecoCusto, PrecoVenda, QTD,  ValorGasto, ValorRecebido, Lucro, DataVenda, idProduto								
					
					dgv_InfoVendas.Columns(8).Visible = False
					dgv_InfoVendas.Columns(9).Visible = False
					dgv_InfoVendas.Columns(2).DefaultCellStyle.Format = "c2"
					dgv_InfoVendas.Columns(3).DefaultCellStyle.Format = "c2"
					dgv_InfoVendas.Columns(5).DefaultCellStyle.Format = "c2"
					dgv_InfoVendas.Columns(6).DefaultCellStyle.Format = "c2"
					dgv_InfoVendas.Columns(7).DefaultCellStyle.Format = "c2"
					txt_gasto.Text = CStr(FormatCurrency(CalculaValorGasto(6) - desconto,2))
					
				End If
				
			End If
		End If
	End Sub
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
			Me.Close
	End Sub
	
	
	Sub Rb_categoria_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome da Categoria"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_clienteClick(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Cliente"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_produto_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Produto"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	
	
	Sub Rb_fornecedor_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Fornecedor"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	
	Sub Txt_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_pesquisa.Visible = False
			gb_detalhe.Focus
		End If
		
		
		If e.KeyCode = Keys.Enter Then
			eXIBEPESQUISA
		End If		
		
		If e.KeyCode = Keys.Down Then
			dgv_pesquisa.Focus
		End If
	End Sub
	
	
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_detalhe.Focus
		End If
	End Sub
	
	
	Sub Dgv_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			If dgv_pesquisa.RowCount < 1 Then
				Exit Sub
			Else
				txt_pesquisa.Text = dgv_pesquisa.SelectedCells(0).Value.ToString
				dgv_pesquisa.DataSource = ""
				txt_pesquisa.Focus
			End If		
		ElseIf e.KeyCode = Keys.Escape Then
			txt_pesquisa.Focus
		End If
	End Sub
	
	
	
	Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
		txt_data2.Text = dateTimePicker2.Text
	End Sub
	
	Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
		txt_data1.Text = dateTimePicker1.Text
	End Sub
	
	
	Sub Ckb_Detalhe_Click(sender As Object, e As EventArgs)
		If ckb_Detalhe.Checked = True Then
			If txt_data1.Text = "" Then
				MsgBox("Escolha uma data inicial para efetuar a consulta", vbInformation, "DATA INICIAL EM BRANCO")
				ckb_Detalhe.Checked = False
				txt_data1.Focus
				Exit Sub
			ElseIf txt_data2.Text = "" Then
				MsgBox("Escolha uma data final para efetuar a consulta", vbInformation, "DATA FINAL EM BRANCO")
				ckb_Detalhe.Checked = False
				txt_data2.Focus
				Exit Sub
			Else
				gb_detalhe.Visible = True
			End If
				
		ElseIf ckb_Detalhe.Checked = False Then
			gb_detalhe.Visible = False
			gb_pesquisa.Visible = False
			txt_data1.Text = ""
			txt_data2.Text = ""
		End If
	End Sub
	
	
	Sub eXIBEPESQUISA
		
		If rb_categoria.Checked = True Then
			dgv_pesquisa.DataSource = cadCategorias.RetornaNomeCategoria(txt_pesquisa.Text)	
			dgv_pesquisa.Columns(0).HeaderText = "CATEGORIA"	
		ElseIf rb_cliente.Checked = True Then
			dgv_pesquisa.DataSource = cadCliente.rETORNANOMECLIENTE(txt_pesquisa.Text)	
			dgv_pesquisa.Columns(0).HeaderText = "CLIENTE"
		ElseIf rb_formaPagamento.Checked = True Then
			dgv_pesquisa.DataSource = cadForma.rETORNA_fORMA_pAGAMENTO(txt_pesquisa.Text)
			dgv_pesquisa.Columns(0).HeaderText = "FORMA PAGAMENTO"
		ElseIf rb_produto.Checked = True Then
			dgv_pesquisa.DataSource = cadProdutos.RetornaNomeProduto(txt_pesquisa.Text)	
			'          0                            1
			'produtos.Nome as Produto,categorias.Nome as Categoria
			dgv_pesquisa.Columns(0).HeaderText = "PRODUTO"
			dgv_pesquisa.Columns(1).Visible = False
		ElseIf rb_fornecedor.Checked = True
			dgv_pesquisa.DataSource = cadFornecedor.RetornaNomeFornecedor(txt_pesquisa.Text)
			'     0              1
			'idFornecedor, NomeFantasia
			dgv_pesquisa.Columns(1).HeaderText = "FORNECEDOR"
			dgv_pesquisa.Columns(0).Visible = False
		Else
			Exit Sub
		End If
		dgv_pesquisa.Columns(0).Width = 173
	End Sub
	
	
	Function CalculaValorGasto(coluna As Integer) As Double
		
		Dim linha As Integer = 0
		Dim valor As Double = 0

		while linha <= dgv_InfoVendas.rowcount - 1
			valor = valor + CDbl(dgv_InfoVendas.item(coluna,linha).Value)
			linha +=1
		end while
		Return valor
	End Function
	
	Sub FormRelatorioVendasKeyDown(sender As Object, e As KeyEventArgs)
		If  e.KeyCode = Keys.F1 Then
			dgv_InfoVendas.DataSource = ""
			eXIBEVENDAS
		End If
	End Sub	
	
	Sub Rb_formaPagamentoClick(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite a Forma de Pagamento"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
End Class
