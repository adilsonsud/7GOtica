'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 10/3/2014
' Hora: 19:20
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadProdutos
	
	Dim conexao As CL_Conexao	
	Dim cmd 	As MySqlCommand
	Dim dr 		As MySqlDataReader
	Dim sql 	As String
	
	
	
	Public Sub New()
		conexao = New CL_Conexao
	End Sub
	
	Public Sub AdicionarProduto (produto As EntProdutos)
		Try
			sql = ("insert into " + BD.Nome + ".produtos (nome, idCategoria) values (@nome, @idCategoria)")
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = produto.NomeProduto
			cmd.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = produto.IdCategoria
			cmd.ExecuteNonQuery		
			'MsgBox("Produto inserido com sucesso",vbOKOnly,"Cadastro de Produtos")
				
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados na Tabela Produtos: " + ex.Message)
		Finally
			conexao.desconectar
		End Try		
	End Sub
	
	
	Public Sub EditarProduto (produto As EntProdutos)
		Try
			sql = "update " + BD.Nome + ".produtos Set nome = @nome, idcategoria = @idcategoria  where idProduto = @idProduto"
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = produto.NomeProduto
			cmd.Parameters.Add("@idcategoria", MySqlDbType.Int32).Value = produto.IdCategoria
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = produto.IdProduto
			cmd.ExecuteNonQuery		
			'MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Produtos")			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
	End Sub
	
	
	Public Sub ExcluirProduto(idProduto As String)
		Try 
			sql="delete from " + BD.Nome + ".produtos where idproduto = " + idProduto
			cmd = New MySqlCommand(sql,conexao.conectar)	
			cmd.ExecuteNonQuery	
			'MsgBox("Exclusão bem sucedida", vbOKOnly, "Cadastro de Produtos")
			
		Catch ex As MySqlException	
			MsgBox("erro ao tentar excluir produto "+ ex.Message)
		Finally
			conexao.desconectar	
		End Try
	End Sub
	
	
	Public Function LocalizarProduto As List(Of EntProdutos)
		
		Dim Listaproduto As New List(Of EntProdutos)
		
		Try
			sql = " select  * from " + BD.Nome + ".produtos"
			cmd = New MySqlCommand(sql, conexao.conectar)
			dr = cmd.ExecuteReader
			While dr.Read
				Dim produto As New EntProdutos
				produto.IdProduto =  dr.GetInt32(0)
				produto.NomeProduto = dr.GetString(1)
				produto.IdCategoria = dr.GetInt32(2)
				Listaproduto.Add(produto)					
			End While
			dr.Close
			'Return Listaproduto
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar produto no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar
		End Try
		Return Listaproduto
	End Function


'lista tds os produtos da tb produtos e faz um join com tb categorias, usado no gride
Public Function LocalizarProduto (nome As String) As DataTable
	Dim dt As New DataTable
	Try
		sql = "Select produtos.idProduto, produtos.Nome as PRODUTO, produtos.idCategoria, prod_for.CDB, prod_for.Foto, categorias.Nome as CATEGORIA, prod_for.idFornecedor, prod_for.QTD, prod_for.QTD_Loja, prod_for.PrecoCusto, prod_for.PrecoVenda, fornecedores.NomeFantasia as FORNECEDOR" & _
			  " FROM (( " + BD.Nome + ".produtos produtos INNER JOIN " + BD.Nome + ".categorias categorias On (produtos.idCategoria = categorias.idCategoria)) INNER JOIN  " + BD.Nome + ".prod_for prod_for" & _
			  " ON (prod_for.idProduto = produtos.idProduto)) INNER JOIN " + BD.Nome + ".fornecedores fornecedores ON (prod_for.idFornecedor = fornecedores.idFornecedor)  WHERE produtos.nome like '%" & nome & "%' order by produtos.nome" 
		
		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
		da.Fill(dt)	
		
		If dt.Rows.Count < 1  Then
			sql = "Select produtos.idProduto, produtos.Nome as PRODUTO, produtos.idCategoria, prod_for.cdb, prod_for.Foto, categorias.Nome as CATEGORIA, prod_for.idFornecedor, prod_for.QTD, prod_for.PrecoCusto, prod_for.PrecoVenda, fornecedores.NomeFantasia as FORNECEDOR" & _
			" FROM (( " + BD.Nome + ".produtos produtos INNER JOIN " + BD.Nome + ".categorias categorias On (produtos.idCategoria = categorias.idCategoria)) INNER JOIN  " + BD.Nome + ".prod_for prod_for" & _
			" ON (prod_for.idProduto = produtos.idProduto)) INNER JOIN " + BD.Nome + ".fornecedores fornecedores ON (prod_for.idFornecedor = fornecedores.idFornecedor)  WHERE prod_for.cdb ="  + nome
			da.SelectCommand.CommandText = sql
			da.Fill(dt)	
		End If	
	Catch ex As MySqlException
		MsgBox("Produto não localizddo.", vbOKOnly,"*** ATENÇÃO ***")
	Finally
		conexao.desconectar	
	End Try
    Return dt
End Function

'Public Function LocalizarProduto_CDB (cdb As String) As DataTable
'	Dim dt As New DataTable
'	Try		
'		sql = "Select produtos.idProduto, produtos.Nome as PRODUTO, produtos.idCategoria, produtos.CDB, produtos.Foto, categorias.Nome as CATEGORIA, prod_for.idFornecedor, prod_for.QTD, prod_for.PrecoCusto, prod_for.PrecoVenda, fornecedores.NomeFantasia as FORNECEDOR" & _
'			  " FROM (( " + BD.Nome + ".produtos produtos INNER JOIN " + BD.Nome + ".categorias categorias On (produtos.idCategoria = categorias.idCategoria)) INNER JOIN  " + BD.Nome + ".prod_for prod_for" & _
'			  " ON (prod_for.idProduto = produtos.idProduto)) INNER JOIN " + BD.Nome + ".fornecedores fornecedores ON (prod_for.idFornecedor = fornecedores.idFornecedor)  WHERE produtos.cdb ="  + cdb
'		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
'		da.Fill(dt)	
'	Catch ex As MySqlException
'		MsgBox("Produto não localizado ", vbOKOnly, "*** ATENÇÃO ***")
'	Finally
'		conexao.desconectar	
'	End Try
'    Return dt
'End Function
	
	
'usada p/selecionar tds os nomes de categorias e armazenar em algum componente como ComboBox
Public	function CarregaNomeCategoria(nome As String) As DataTable
	Dim dt As New DataTable
	sql = "select idCategoria, nome from " + BD.Nome + ".categorias  WHERE nome like '%" & nome & "%' order by nome" 
		Try
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
		Catch ex As MySqlException
			MsgBox("Erro ao listar categorias ->" + ex.ToString)
		Finally
			conexao.desconectar	
		End Try	
	Return dt
End Function


Public Function RetornaNomeProduto (nome As String)  As DataTable
	Dim dt As New DataTable
	Try
		'sql="select produtos.nome as Produto from " + BD.Nome + ".produtos where produtos.nome like '%"& nome & "%'"
		sql = "Select produtos.Nome as Produto,categorias.Nome as Categoria FROM " + BD.Nome + ".produtos produtos INNER JOIN " + BD.Nome + ".categorias categorias On (produtos.idCategoria = categorias.idCategoria)" & _
		"		 WHERE produtos.nome like '%" & nome & "%' order by produtos.nome"
		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
		da.Fill(dt)			
	Catch ex As MySqlException	
	  	MsgBox("erro ao tentar exibir o Produto "+ ex.Message)
	Finally
		conexao.desconectar	
	End Try  
	Return dt	
End Function


Public Function RetornaProduto (nome As String)  As DataTable
	Dim dt As New DataTable	
	 Try
		sql = "Select " + BD.Nome + ".produtos.nome Produto, " + BD.Nome + ".categorias.nome Categoria, " + BD.Nome + ".prod_for.PrecoCusto, " + BD.Nome + ".prod_for.PrecoVenda " & _
			  "from (" + BD.Nome + ".produtos inner join " + BD.Nome + ".categorias On(categorias.idCategoria = produtos.idProduto)) " & _
			  "inner join " + BD.Nome + ".prod_for On(" + BD.Nome + ".produtos.idProduto = " + BD.Nome + ".prod_for.idProduto) where " + BD.Nome + ".produtos.nome like '%" & nome & "%'"
		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
		da.Fill(dt)	
	 Catch ex As MySqlException	
	  	MsgBox("erro ao tentar exibir o Produto "+ ex.Message)
	 Finally
			conexao.desconectar	
	 End Try  
	  Return dt	
End Function


Public Function rELATORIO_aNALITICO_vENDAS_pRODUTO(filtro As String)  As DataTable
	Dim dt As New DataTable	
	 Try
	 	sql = "Select produtos.Nome as Produto, fornecedores.NomeFantasia as Fornecedor, prod_for.PrecoCusto, prod_for.PrecoVenda, sum(itemvendas.QTD) As QTD, format(concat((prod_for.PrecoCusto) * sum(itemvendas.QTD)),2,'de_DE') As ValorGasto, " & _
	 		"  sum(itemvendas.Valor) as ValorRecebido, format(concat(sum(itemvendas.Valor) - ((prod_for.PrecoCusto) * sum(itemvendas.QTD))),2,'de_DE') as Lucro, vendas.DataVenda, prod_for.idProduto " & _
	    	"  FROM (((" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor)) INNER JOIN " + BD.Nome + ".produtos produtos " & _
	    	"  On (prod_for.idProduto = produtos.idProduto)) INNER JOIN " + BD.Nome + ".itemvendas itemvendas On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) " & _
	    	"  INNER JOIN " + BD.Nome + ".vendas vendas ON (itemvendas.idVenda = vendas.idVendas) " + filtro + " group by prod_for.idproduto , prod_for.idfornecedor"
		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
		da.Fill(dt)	
	 Catch ex As MySqlException	
	  	MsgBox("erro ao tentar exibir o Relatório de Produtos "+ ex.Message)
	 Finally
			conexao.desconectar	
	 End Try  
	  Return dt	
 End Function
 
 Public Function RetornaIdProduto As Integer
 	Dim idProduto As Integer
 	Try
 		sql = "SELECT max(idProduto) from produtos"
 		cmd = New MySqlCommand(sql, conexao.conectar)
 		idProduto = CInt(cmd.ExecuteScalar)
 	Catch erro As MySqlException
 		MsgBox("erro ao tentar retornar o idProduto" + erro.Message) 		
 	Finally	
 		conexao.desconectar
 	End Try
 	Return idProduto
 End Function
 
	
End Class
