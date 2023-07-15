'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 14/3/2014
' Hora: 18:28
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class CadProdFor
	Dim conexao As  CL_Conexao	
	Dim ProdFor As New EntProdFor
	Dim cadProduto As New CadProdutos
	Dim cmd 	As MySqlCommand
	Dim dr 		As MySqlDataReader
	Dim sql 	As String
	
	Public Sub New()
		conexao = New CL_Conexao
	End Sub
	
  Public Sub AdicionarProdFor (ProdFor As EntProdFor)
	
	 Try
		sql = "insert into " + BD.Nome + ".prod_for (idProduto, idFornecedor, QTD,QTD_Loja, PrecoCusto, PrecoVenda, cdb, foto) values (@idProduto, @idFornecedor, @QTD, @QTD_Loja, @PrecoCusto, @PrecoVenda, @cdb, @foto)"
		cmd = New MySqlCommand(sql, conexao.conectar)	
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ProdFor.IdProduto
		cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = ProdFor.IdFornecedor
		cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ProdFor.QTD
		cmd.Parameters.Add("@QTD_Loja",MySqlDbType.Int32).Value = ProdFor.QTD_Loja
		cmd.Parameters.Add("@PrecoCusto",MySqlDbType.Double).Value = ProdFor.PrecoCusto
		cmd.Parameters.Add("@PrecoVenda",MySqlDbType.Double).Value = ProdFor.PrecoVenda
		cmd.Parameters.Add("@cdb",MySqlDbType.String).Value = ProdFor.CDB
		cmd.Parameters.Add("@foto",MySqlDbType.String).Value = ProdFor.Foto
		cmd.ExecuteNonQuery		
		'MsgBox("O produto foi associado ao referido fornecedor com sucesso",vbOKOnly,"Produto do Fornecedor")				
	 Catch ex As MySqlException
	 	MsgBox("Erro ao tentar inserir o Produto na tabela ProdFor: " + ex.Message)		 	
	 Finally
	 	conexao.desconectar
	 End Try		
  End Sub
  
  Public Sub EditarProdFor (ProdFor As EntProdFor)
		Try
			sql = "update " + BD.Nome + ".prod_for Set  QTD = @QTD, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, cdb = @cdb, foto = @foto where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ProdFor.QTD
			cmd.Parameters.Add("@PrecoCusto",MySqlDbType.Double).Value = ProdFor.PrecoCusto
			cmd.Parameters.Add("@PrecoVenda",MySqlDbType.Double).Value = ProdFor.PrecoVenda
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ProdFor.IdProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = ProdFor.IdFornecedor
			cmd.Parameters.Add("@cdb", MySqlDbType.String).Value = ProdFor.CDB
			cmd.Parameters.Add("@foto", MySqlDbType.String).Value = ProdFor.Foto
			cmd.ExecuteNonQuery	
			'MsgBox("Alterado com sucesso",vbOKOnly, "Produto do Fornecedor")	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados na tabela ProdFor: " + ex.Message)
		Finally
	 		conexao.desconectar
	 End Try			
  End Sub
  
  Public Sub EditarProdFor_Produto (ProdFor As EntProdFor)
		Try
			sql = "update " + BD.Nome + ".prod_for Set  QTD = @QTD, QTD_Loja = @QTD_Loja, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, idFornecedor = @idFornecedor  where idProduto = @idProduto"
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ProdFor.QTD
			cmd.Parameters.Add("@QTD_Loja",MySqlDbType.Int32).Value = ProdFor.QTD_Loja
			cmd.Parameters.Add("@PrecoCusto",MySqlDbType.Double).Value = ProdFor.PrecoCusto
			cmd.Parameters.Add("@PrecoVenda",MySqlDbType.Double).Value = ProdFor.PrecoVenda
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = ProdFor.IdFornecedor
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ProdFor.IdProduto
			cmd.ExecuteNonQuery	
			'MsgBox("Alterado com sucesso",vbOKOnly, "Produto do Fornecedor")	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados na tabela ProdFor: " + ex.Message)
		Finally
	 		conexao.desconectar
	 End Try			
  End Sub
  
  
   Public Sub Inserir_QTD_Loja (qtd As Integer, qtdLoja As Integer, idProduto As Integer, idFornecedor As Integer)
		Try
			sql = "update " + BD.Nome + ".prod_for Set  QTD = @QTD, QTD_Loja = @QTD_Loja  where prod_for.idProduto = @idProduto and prod_for.idFornecedor = @idFornecedor" 
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = qtd
			cmd.Parameters.Add("@QTD_Loja",MySqlDbType.Int32).Value = qtdLoja
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = idFornecedor
			cmd.ExecuteNonQuery	
			'MsgBox("Alterado com sucesso",vbOKOnly, "Produto do Fornecedor")	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir qtd_Loja na tabela ProdFor: " + ex.Message)
		Finally
	 		conexao.desconectar
	 End Try			
  End Sub
  
  
  Public Sub ExcluirProdFor(idProd As String, idFor As String)
	  Try 
		sql="delete from " + BD.Nome + ".prod_for where idProduto = @idProduto and idFornecedor = @idFornecedor"
		cmd = New MySqlCommand(sql,conexao.conectar)	
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProd
		cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = idFor
		cmd.ExecuteNonQuery	
		'MsgBox("Exclusão bem sucedida", vbOKOnly, "Produto do Fornecedor")	
	  Catch ex As MySqlException	
	  	MsgBox("erro ao tentar excluir este Produto na tabela ProdFor "+ ex.Message)
	  Finally
	 	conexao.desconectar
	  End Try		  
  End Sub
  
 'Sub para preencher o gride 
 Public Function ExibeProdutosFornecedor  (idForn As String) As DataTable
 	Dim dt As New DataTable
 	Try                            '  0                     1                2                  3                   4                 5                 6                     7
		sql = "Select  fornecedores.NomeFantasia, produtos.Nome, prod_for.idProduto,prod_for.idFornecedor,prod_for.QTD, prod_for.QTD_Loja ,prod_for.PrecoCusto, prod_for.precoVenda " & _
			"FROM (" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor))" & _
			"INNER JOIN " + BD.Nome + ".produtos produtos On (prod_for.idProduto = produtos.idProduto) where prod_for.idFornecedor = "  & idForn	
		Dim da As new MySqlDataAdapter(sql,conexao.conectar)
		da.Fill(dt)	
	 Catch ex As MySqlException	
	  	MsgBox("erro ao tentar exibir Produtos "+ ex.Message)
	 Finally
	 	conexao.desconectar
	 End Try	
     Return dt
 End Function
 
 
' 'Sub para preencher o combo
' Public Function ExibeProdutos  As MySqlDataReader
' 	Try 
'		sql="select * from " + BD.Nome + ".produtos " 
'		cmd = New MySqlCommand(sql,conexao.conectar)	
'		dr = cmd.ExecuteReader	
'		
'	  Catch ex As MySqlException	
'		MsgBox("erro ao tentar exibir Produtos "+ ex.Message)
'	  Finally
'	 	conexao.desconectar
'	 End Try
'	  Return dr 	
'	  dr.Close
' End Function
 
 
Public Function selecionaIdProduto (NomeProduto As String) As Integer	
	Dim dt As New DataTable
	Try
		sql = "select idProduto from " + BD.Nome + ".produtos where Nome = '" + NomeProduto + "'"	
		Dim da As New MySqlDataAdapter (sql, conexao.conectar)
		da.Fill(dt)
		ProdFor.IdProduto = CInt(dt.Rows(0)(0).ToString) '1º parentese é a linha, 2º parentese é o indice da coluna ou nome do campo ex:("idProduto")
	Catch ex As Exception
		MsgBox("erro ao selecionar IdProduto na Tabela Produtos"+ ex.ToString)
	Finally
		conexao.desconectar
	End Try
	
	Return ProdFor.IdProduto
End Function 
 
End Class
 
 
 
