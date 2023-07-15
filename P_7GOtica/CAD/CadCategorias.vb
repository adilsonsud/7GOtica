'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 7/3/2014
' Hora: 23:02
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'

	
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadCategorias
	Dim conexao As CL_Conexao
	Dim cmd 	As MySqlCommand
	Dim dr 		As MySqlDataReader
	Dim dt 		As New DataTable
	Dim sql		As String
	
	Public Sub New()
		conexao = New CL_Conexao
	End Sub
	
	Public Sub AdicionarCategoria (categoria As EntCategorias)	
		Try
			sql = ("insert into " + BD.Nome + ".categorias (nome) values (@nome)")
			cmd = New MySqlCommand(sql,conexao.conectar )	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = categoria.Nome
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Categorias")
				
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		Finally
			conexao.desconectar
		End Try		
	End Sub
	
	
	Public Sub EditarCategoria (categoria As EntCategorias)
		Try
			sql = "update " + BD.Nome + ".categorias Set nome = @nome where idcategoria = @idcategoria"
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = categoria.Nome
			cmd.Parameters.Add("@idcategoria",MySqlDbType.Int32).Value = categoria.IdCategoria
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Categorias")			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		Finally
			conexao.desconectar
		End Try
		
	End Sub
	
	Public Sub ExcluirCategoria(idCategoria As String)
	  Try 
		sql="delete from " + BD.Nome + ".categorias where idcategoria = " + idCategoria
		cmd = New MySqlCommand(sql,conexao.conectar)	
		cmd.ExecuteNonQuery	
		MsgBox("Exclusão bem sucedida", vbOKOnly, "Cadastro de Categorias")
		
	  Catch ex As MySqlException	
	  	MsgBox("erro ao tentar excluir categoria "+ ex.Message)
	  Finally
			conexao.desconectar	
	  End Try	
	End Sub
	
	Public Function LocalizarCategoria(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  * from " + BD.Nome + ".categorias where nome like '%"& nome & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			'con = conexao.conectar
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar categoria no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar
		End Try
		
		Return dt
	End Function
	
	
	
	Public Function RetornaNomeCategoria(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select nome from " + BD.Nome + ".categorias where nome like '%"& nome & "%'"
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar categoria no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return dt
	End Function
		
		
	Public Function RetornaNomeCategoria()As DataTable
		Dim dt As New DataTable
		Try
			sql = "select nome from " + BD.Nome + ".categorias" 
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar categoria no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return dt
	End Function
		
		
		
	
	Public Function rELATORIOCATEGORIA(filtroSql As String) As DataTable
		Dim dt As New DataTable
		Try       
			sql = "Select categorias.Nome As Categoria, produtos.idCategoria, prod_for.idProduto, itemvendas.idVenda, sum(itemvendas.QTD) As QTD, sum(itemvendas.Valor) As Valor, vendas.DataVenda " & _
				"  FROM(((" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".produtos produtos On (prod_for.idProduto = produtos.idProduto)) INNER JOIN " + BD.Nome + ".itemvendas itemvendas " & _
				"  On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) INNER JOIN " + BD.Nome + ".vendas vendas " & _
				"  ON (itemvendas.idVenda = vendas.idVendas)) INNER JOIN " + BD.Nome + ".categorias categorias ON (produtos.idCategoria = categorias.idCategoria)" + filtroSql + " group by categorias.nome"
			Dim da As new MySqlDataAdapter(sql,conexao.conectar)
			da.Fill(dt)	
		  Catch ex As MySqlException	
		  	MsgBox("Erro ao tentar exibir Consulta por Categoria "+ ex.Message)
		  Finally
			conexao.desconectar	
		End Try
   		Return dt 	
	End Function
	
	
End Class
