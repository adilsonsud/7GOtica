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

Public Class CadPDV
	
	Dim conexao As CL_Conexao	
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	Dim sql As String
	Dim venda As New EntPDV
	
	
	Public Sub New()
		conexao = New CL_Conexao
	End Sub
	
	Public Function CarregaFormaPagamento As DataTable
		Dim dt As New DataTable
		Try
			sql = "select forma from " + BD.Nome + ".FormaPagamentos"
			Dim da As New MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)    
		Catch ex As MySqlException
			MsgBox("Erro ao listar Formas de Pagamento ->" ,vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try	
		Return dt
	End Function
	
	
	Public Function SelecionaIdFormaPagamento (forma As String) As Integer
		Dim idForma As Integer
		Dim dt As New DataTable
		
		Try
			sql = "select idformapagamento from " + BD.Nome + ".FormaPagamentos where forma = '" + forma + "'"
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
	   		idForma = CInt(dt.Rows(0)(0).ToString)
		Catch ex As MySqlException
			MsgBox("Erro ao selecionar IdFormaPagamento ->" ,vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try	
		Return idForma
	End Function
	
	
	
	
	Public Function RetornaFormaPagamento (idForma As String) As String		
		Dim dt As New DataTable
		Try
			sql = "select forma from " + BD.Nome + ".FormaPagamentos where idFormaPagamento = " + idForma 
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
	   		venda.NomeFormaPagamento = dt.Rows(0)(0).ToString
	   		
		Catch ex As MySqlException
			MsgBox("Erro ao selecionar Forma de Pagamento ->" ,vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try	
		Return venda.NomeFormaPagamento
	End Function
	
	
	Public Function ExibeProdutos  (NomeProduto As String) As DataTable
 	  Dim dt As New DataTable
	 	Try                        '  0                     1                    2                  3                   4                 5                 6                   7
			sql = "Select  produtos.Nome, fornecedores.NomeFantasia, prod_for.idProduto,prod_for.idFornecedor,prod_for.QTD_Loja, prod_for.PrecoCusto, prod_for.precoVenda, prod_for.cdb " & _
				"FROM (" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor))" & _
				"INNER JOIN " + BD.Nome + ".produtos produtos On (prod_for.idProduto = produtos.idProduto) where produtos.Nome like '%" & NomeProduto & "%' "   & _
				" order by produtos.nome, fornecedores.NomeFantasia"
			Dim da As new MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException	
			MsgBox("erro ao tentar localizar produto. ",vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try
   		Return dt 	
	End Function
	
	
	Public Function ExibeProdutosCDB  (CDB As String) As DataTable
 	  Dim dt As New DataTable
	 	Try                        '  0                     1                    2                  3                   4                 5                 6                   7
			sql = "Select  produtos.Nome, fornecedores.NomeFantasia, prod_for.idProduto,prod_for.idFornecedor,prod_for.QTD, prod_for.PrecoCusto, prod_for.precoVenda, prod_for.cdb " & _
				  "FROM (" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor))" & _
				  "INNER JOIN " + BD.Nome + ".produtos produtos On (prod_for.idProduto = produtos.idProduto) where prod_for.cdb = " + CDB 
	
			Dim da As new MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException	
			MsgBox("Produto não localizado. ",vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try
   		Return dt 	
	End Function
	
	
	
	Public Function SelecionaCliente(nome As String) As DataTable		
		Dim dt As New DataTable
		 	Try                                    
				sql = " select idCliente,NomeCliente, CPF_CNPJ from " + BD.Nome + ".clientes where nomecliente like '%"& nome & "%'"	
				Dim da As new MySqlDataAdapter(sql,conexao.conectar)
				da.Fill(dt)	
			 Catch ex As MySqlException	
			  	MsgBox("erro ao tentar Selecionar Cliente ",vbOKOnly,"*** ATENÇÃO ***")
			 Finally
			 	conexao.desconectar
			End Try
   		Return dt 
	End Function
	
	
	Public Function SelecionaIdCliente (cliente As String) As Integer
		Dim idCliente As Integer
		Dim dt As New DataTable
		
		Try
			sql = "select idCliente from " + BD.Nome + ".clientes where NomeCliente = '" + cliente + "'"
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
	   		idCliente = CInt(dt.Rows(0)(0).ToString)
		Catch ex As MySqlException
			MsgBox("Erro ao Selecionar IdCliente",vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try	
		Return idCliente
	End Function
	
	
	
	Public Function RetornaNomeCliente (idCliente As String) As String
		Dim dt As New DataTable
		
		Try
			sql = "select NomeCliente from " + BD.Nome + ".clientes where idCliente = " + idCliente
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
	   		venda.NomeCliente = dt.Rows(0)(0).ToString
		Catch ex As MySqlException
			MsgBox("Erro ao Selecionar NomeCliente.",vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try	
		Return venda.NomeCliente
	End Function
	
	
	
	Public Sub AdicionarVenda (venda As EntPDV)
	    Try
			sql = ("insert into " + BD.Nome + ".vendas (IdFormaPagamento, IdCliente, DataVenda, Hora, desconto, valortotal, pago, troco, aberta) values (@IdFormaPagamento, @IdCliente,@DataVenda, @Hora, @desconto, @valortotal, @pago, @troco, @aberta)")
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@IdFormaPagamento",MySqlDbType.Int32).Value = venda.IdFormaPagamento
			cmd.Parameters.Add("@IdCliente", MySqlDbType.Int32).Value = venda.IdCliente
			cmd.Parameters.Add("@DataVenda", MySqlDbType.Date).Value = venda.DataVenda
			cmd.Parameters.Add("@Hora", MySqlDbType.String).Value = venda.Hora
			cmd.Parameters.Add("@desconto", MySqlDbType.Double).Value = venda.Desconto
			cmd.Parameters.Add("@valortotal", MySqlDbType.Double).Value = venda.ValorTotal
			cmd.Parameters.Add("@pago", MySqlDbType.Double).Value = venda.Pago
			cmd.Parameters.Add("@troco", MySqlDbType.double).Value = venda.Troco
			cmd.Parameters.Add("@aberta", MySqlDbType.Bit).Value = venda.Aberta
			cmd.ExecuteNonQuery					
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir  venda: " ,vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try		
	End Sub
	
	
	
	Public function AdicionarItensVenda(ItensVenda As EntPDV) As Boolean
		Dim insere As Boolean
	
	    Try
			sql = ("insert into " + BD.Nome + ".Itemvendas (idVenda,idProduto, idFornecedor, QTD, Valor) values (@idVenda,@idProduto, @idFornecedor, @QTD, @Valor)")
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@idVenda",MySqlDbType.Int32).Value = ItensVenda.IdVenda
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ItensVenda.IdProduto
			cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = ItensVenda.IdFornecedor
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ItensVenda.Qtd
			cmd.Parameters.Add("@Valor",MySqlDbType.Double).Value = ItensVenda.Valor
			cmd.ExecuteNonQuery		
			insere = True
		Catch ex As MySqlException
			MsgBox("Verifique se este item já foi incluido, caso queira inserir mais quantidades deste item, pressione F5 " & _
				"para mudar a quantidade ao invez de tentar inserir um novo item. ", vbOKOnly, "Erro ao Inserir Item!")	
			insere = False
		Finally
			conexao.desconectar
		End Try		
		Return insere
	End Function
	
	
	
	Public sub AtualizaItemVenda (ItemVenda As EntPDV)	
		Try
			sql = "update " + BD.Nome + ".Itemvendas Set  QTD = @QTD, Valor = @Valor where  idVenda = @idVenda and idProduto = @idProduto and  idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, conexao.conectar)
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ItemVenda.QTD
			cmd.Parameters.Add("@Valor",MySqlDbType.Double).Value = ItemVenda.Valor
			cmd.Parameters.Add("@idVenda",MySqlDbType.Int32).Value = ItemVenda.IdVenda
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ItemVenda.IdProduto
			cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = ItemVenda.IdFornecedor
			cmd.ExecuteNonQuery		
		Catch ex As MySqlException
			MsgBox("Erro ao tentar atualizar este Itens da Venda: ",vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try
	End Sub
	
	
	Public Function RetornaIdVenda As Integer
		Dim dt As New DataTable
		Try
			sql = ("SELECT max(idvendas) from " + BD.Nome + ".vendas")
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
			venda.IdVenda = CInt(dt.Rows(0)(0).ToString)
		Catch erro As MySqlException
			MsgBox("Erro ao tentar retornar IdVenda" ,vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try	
		Return venda.IdVenda
	End Function
	
	
	Public Sub AtualizarInfoVendas (idCliente As Integer, idForma As Integer, idVenda As Integer)'utilizada para alterar forma de pagamento ou o cliente
		Try
			sql = "update " + BD.Nome + ".vendas Set idCliente = @idCliente, idFormaPagamento = @idFormaPagamento where idVendas = @idVendas"			
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@idCliente",MySqlDbType.Int32).Value = idCliente
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = idForma
			cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = idVenda
			cmd.ExecuteNonQuery		
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar alterar informações da venda: " ,vbOKOnly,"*** ATENÇÃO ***")
		Finally
			conexao.desconectar
		End Try
	End Sub
	
	
	Public Sub AtualizarVenda (vendas As EntPDV)'utilizada na hora de finalizar a venda, atualiza valor total, desconto, pago, troco, aberta
		Try
			sql = "update " + BD.Nome + ".vendas Set desconto = @desconto, valorTotal = @valorTotal, pago = @pago, troco = @troco, aberta = @aberta where idVendas = @idVendas and idFormaPagamento = @idFormaPagamento and idCliente = @idCliente"
			
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@desconto",MySqlDbType.Double).Value = vendas.Desconto
			cmd.Parameters.Add("@valorTotal",MySqlDbType.Double).Value = vendas.ValorTotal
			cmd.Parameters.Add("@pago",MySqlDbType.Double).Value = vendas.Pago
			cmd.Parameters.Add("@troco",MySqlDbType.Double).Value = vendas.Troco
			cmd.Parameters.Add("@aberta",MySqlDbType.Bit).Value = vendas.Aberta
			cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = vendas.IdVenda
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = vendas.IdFormaPagamento
			cmd.Parameters.Add("@idCliente",MySqlDbType.Int32).Value = vendas.IdCliente
			cmd.ExecuteNonQuery					
		Catch ex As MySqlException
			MsgBox("Erro ao atualizar informações da venda: " ,vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try
	End Sub
	
	Public Sub AtualizarVendaCancelada (vendas As EntPDV)'utilizada no relatório status_vendas
		Try
			sql = "update " + BD.Nome + ".vendas Set desconto = @desconto, valorTotal = @valorTotal, pago = @pago, troco = @troco, aberta = @aberta, idFormaPagamento = @idFormaPagamento where idVendas = @idVendas "
			
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@desconto",MySqlDbType.Double).Value = vendas.Desconto
			cmd.Parameters.Add("@valorTotal",MySqlDbType.Double).Value = vendas.ValorTotal
			cmd.Parameters.Add("@pago",MySqlDbType.Double).Value = vendas.Pago
			cmd.Parameters.Add("@troco",MySqlDbType.Double).Value = vendas.Troco
			cmd.Parameters.Add("@aberta",MySqlDbType.Bit).Value = vendas.Aberta
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = vendas.IdFormaPagamento
			cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = vendas.IdVenda
			If vendas.IdFormaPagamento = 0 Then
				Exit Sub
			Else
				cmd.ExecuteNonQuery	
			End If
							
		Catch ex As MySqlException
			MsgBox("Erro ao atualizar informações da venda: ",vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try
	End Sub
	
	
	Public Sub ExcluirItenVenda(idVenda As Integer, idProduto As Integer, idFornecedor As Integer)
	  Try 
	  	sql="delete from " + BD.Nome + ".Itemvendas where idVenda = @idVenda and idProduto = @idProduto  and idFornecedor = @idFornecedor " 
	  	cmd = New MySqlCommand(sql,conexao.conectar)	
	  	cmd.Parameters.Add("@idVenda",MySqlDbType.Int32).Value = idVenda
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProduto
		cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = idFornecedor
		cmd.ExecuteNonQuery	
		
	  Catch ex As MySqlException	
	  	MsgBox("erro ao tentar excluir Item ",vbOKOnly,"*** ATENÇÃO ***")
	  Finally
	  	conexao.desconectar
	  End Try	
	End Sub
	
	
	Public function SelecionaEstoque (idProduto As Integer, idFornecedor As Integer) As Integer
		Dim dt As New DataTable
		Try
			sql = "select qtd_Loja from " + BD.Nome + ".prod_for  where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = idFornecedor
			Dim da As New MySqlDataAdapter(cmd)
			da.Fill(dt)
			venda.Estoque = CInt(dt.Rows(0)(0).ToString)
		Catch ex As MySqlException
			MsgBox("Erro ao selecionar estoque: " ,vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try	
		Return venda.Estoque
	End Function
	
	
	
	Public Sub AtualizaEstoque (estoque As Integer,idProduto As Integer, idFornecedor As Integer)
		Try
			sql = "update " + BD.Nome + ".prod_for Set  QTD_Loja = @QTD_Loja  where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@QTD_Loja",MySqlDbType.Int32).Value = estoque
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = IdProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = IdFornecedor
			cmd.ExecuteNonQuery	
		Catch ex As MySqlException
			MsgBox("Erro ao atualizar estoque: ",vbOKOnly,"*** ATENÇÃO ***")	
		Finally
			conexao.desconectar
		End Try	
	End Sub
	
	
	Public Function RetornaVenda (idVenda As String) As EntPDV
		Dim dt As New DataTable
			Try
				sql = "select *  from " + BD.Nome + ".vendas where idVendas = @idVendas"
				cmd = New MySqlCommand(sql,conexao.conectar)
				cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = idVenda
				Dim da As New MySqlDataAdapter(cmd)
				da.Fill(dt)
				If dt.Rows.Count < 1  Then
					MsgBox("Código de orçamento não localizado! ")
				Else
					venda.IdVenda = CInt(dt.Rows(0)(0).ToString)
					venda.IdFormaPagamento = CInt(dt.Rows(0)(1).ToString)
					venda.IdCliente = CInt(dt.Rows(0)(2).ToString)
					venda.DataVenda = CDate(dt.Rows(0)(3).ToString)
					venda.Hora = CStr(dt.Rows(0)(4).ToString)
					venda.Desconto = CDbl(dt.Rows(0)(5).ToString)
					venda.ValorTotal = CDbl(dt.Rows(0)(6).ToString)
					venda.Pago = CDbl(dt.Rows(0)(7).ToString)
					venda.Troco = CDbl(dt.Rows(0)(8).ToString)
					venda.Aberta = CBool(dt.Rows(0)(9).ToString)
				End If
				
			Catch erro As MySqlException
				MsgBox("Erro ao tentar retornar venda. " ,vbInformation,"ERRO")
				venda.IdVenda = 0
			Finally
				conexao.desconectar
			End Try		
			Return venda
	End Function
	
	
	
	Public Function RetornaVendasPeriodo_Status (aberta As Boolean, data1 As Date, data2 As Date) As DataTable ' Usado no form RelatorioVendas_Status
		Dim dt As New DataTable
		Try
				'                      0                       1                2                   3               4             5              6            7            8                9                10
				sql = "Select vendas.idVendas,formapagamentos.Forma,clientes.NomeCliente,vendas.DataVenda, vendas.hora, vendas.Desconto,vendas.ValorTotal,vendas.Pago,vendas.Troco,vendas.Aberta " & _
				      "FROM(" + BD.Nome + ".vendas vendas INNER JOIN " + BD.Nome + ".formapagamentos formapagamentos On (vendas.idFormaPagamento = formapagamentos.idFormaPagamento)) " & _
					  "INNER JOIN " + BD.Nome + ".clientes clientes ON (vendas.idCliente = clientes.idCliente) where aberta =  @aberta and dataVenda between  @data1  and  @data2  order by datavenda , idvendas "	
				cmd = New MySqlCommand(sql,conexao.conectar)
				cmd.Parameters.Add("@aberta",MySqlDbType.Bit).Value = aberta
				cmd.Parameters.Add("@data1",MySqlDbType.Date).Value = data1
				cmd.Parameters.Add("@data2",MySqlDbType.Date).Value = data2
				Dim da As New MySqlDataAdapter
				da.SelectCommand = cmd
				da.Fill(dt)			
			Catch erro As MySqlException
				MsgBox("Erro ao tentar exibir vendas -> " ,vbInformation,"ERRO")
			Finally
				conexao.desconectar
			End Try
			Return dt
	End Function
	
	
	Public Function RetornaItensVenda (idVenda As String) As DataTable
			 Dim dt As New DataTable
	 	Try       '                  0                    1                   2               3                    4                  5                       6                    7
	 		sql = "Select produtos.Nome,fornecedores.NomeFantasia,itemvendas.QTD,prod_for.PrecoVenda, itemvendas.Valor,itemvendas.idProduto,itemvendas.idFornecedor,itemvendas.idVenda " & _
	 			"FROM(((" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".produtos produtos On (prod_for.idProduto = produtos.idProduto)) " & _
	 			"INNER JOIN " + BD.Nome + ".fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor)) " & _
	 			"INNER JOIN " + BD.Nome + ".itemvendas itemvendas On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) " & _
	 			"INNER JOIN " + BD.Nome + ".vendas vendas ON (itemvendas.idVenda = vendas.idVendas) where itemvendas.idVenda = " + idVenda + " order by produtos.Nome"
			Dim da As new MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)	
		 Catch ex As MySqlException	
		 	MsgBox("erro ao tentar exibir Itens da venda ",vbOKOnly,"*** ATENÇÃO ***")
		 Finally
		 	conexao.desconectar
		 End Try
   		Return dt 	
	End Function
	
	
	
	Public Function ExibeEstoque (filtroSql As String)  As DataTable
 	  Dim dt As New DataTable
	 	Try                                       
	 		sql = "Select categorias.Nome,produtos.Nome,fornecedores.NomeFantasia,prod_for.QTD, prod_for.QTD_Loja, prod_for.PrecoCusto,prod_for.PrecoVenda " & _
	 			"FROM ((" + BD.Nome + ".produtos produtos INNER JOIN " + BD.Nome + ".categorias categorias On (produtos.idCategoria = categorias.idCategoria)) " & _
	 			"INNER JOIN " + BD.Nome + ".prod_for prod_for On (prod_for.idProduto = produtos.idProduto)) " & _
	 			"INNER JOIN " + BD.Nome + ".fornecedores fornecedores ON (prod_for.idFornecedor = fornecedores.idFornecedor)" + filtroSql
	 		
			Dim da As new MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)	
		 Catch ex As MySqlException	
		  	MsgBox("erro ao tentar exibir Estoque ",vbOKOnly,"*** ATENÇÃO ***")
		 Finally
		 	conexao.desconectar
		End Try
   		Return dt 	
	End Function
	
	
	Public Function sQLGENERICA(filtro As String) As DataTable
		Dim dt As New DataTable
		Try                                       
	 		sql = filtro
			Dim da As new MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)	
		 Catch ex As MySqlException	
		  	MsgBox("erro na SQL GENERICA ",vbOKOnly,"*** ATENÇÃO ***")
		 Finally
		  	conexao.desconectar
		End Try
   		Return dt 	
	End Function
	
	
	Public Function RetornaValorGasto(filtro As String)  As DataTable
	 Dim dt As New DataTable	
	 Try
	 	sql = "Select vendas.idVendas, vendas.DataVenda, itemvendas.idProduto, itemvendas.idFornecedor, itemvendas.QTD, prod_for.PrecoCusto, " & _
	 		" format(concat(itemvendas.QTD * prod_for.PrecoCusto),2,'de_DE') As ValorGasto  FROM (" + BD.Nome + ".itemvendas itemvendas INNER JOIN  " + BD.Nome + ".vendas vendas On (itemvendas.idVenda = vendas.idVendas)) " & _
	 		" INNER JOIN " + BD.Nome + ".prod_for prod_for ON (itemvendas.idProduto = prod_for.idProduto) AND (itemvendas.idFornecedor = prod_for.idFornecedor)" + filtro 		
	 		
	 		
	 		
'	 		"Select vendas.idVendas, vendas.DataVenda, prod_for.idFornecedor, prod_for.idProduto, sum(itemvendas.QTD) As QTD, prod_for.PrecoVenda, sum(itemvendas.Valor) As ValorRecebido, " & _
'	 		" prod_for.PrecoCusto, format(concat(sum(itemvendas.qtd) * (prod_for.precocusto)),2,'de_DE') as ValorGasto, format(concat((sum(itemvendas.Valor) - (sum(itemvendas.qtd) * (prod_for.precocusto)))),2,'de_DE') as Lucro " & _
'	 		" FROM    (   " + BD.Nome + ".itemvendas itemvendas INNER JOIN " + BD.Nome + ".prod_for prod_for On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) " & _
'	 		" INNER JOIN " + BD.Nome + ".vendas vendas ON (itemvendas.idVenda = vendas.idVendas)  " + filtro + " group by   prod_for.idProduto, prod_for.idFornecedor"
		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
		da.Fill(dt)	
	 Catch ex As MySqlException	
	  	MsgBox("erro ao tentar exibir o Relatório Sintético de Vendas ",vbOKOnly,"*** ATENÇÃO ***")
	 Finally
			conexao.desconectar	
	 End Try  
	  Return dt	
	End Function
	
	Public Function RetornaDouble(filtro As String) As Double	
		Dim valor As Double = 0
		Dim dt As New DataTable
		Try
			sql = filtro
			Dim da As New MySqlDataAdapter(sql,conexao.conectar)
			
			cmd = New MySqlCommand(sql,conexao.conectar)
			valor = CDbl(cmd.ExecuteScalar)
			
		Catch ex As MySqlException	
		  	MsgBox("erro ao retornar Valor ",vbOKOnly,"*** ATENÇÃO ***")
		Finally
		  	conexao.desconectar
	    End Try
   		Return valor
	End Function
	
End Class
