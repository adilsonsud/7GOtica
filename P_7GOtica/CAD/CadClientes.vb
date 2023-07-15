﻿'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 2/3/2014
' Hora: 23:47
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports	MySql.Data.MySqlClient
Imports System.Data
Public Class CadClientes
	
	Dim conexao As CL_Conexao	
	Dim cmd 	As MySqlCommand
	Dim dr 	 	As MySqlDataReader	
	Dim sql 	As String
	
	Public Sub New()
		conexao = New CL_Conexao	
	End Sub
	
	Public Sub AdicionarCliente (cliente As EntClientes)
	
	Try
			sql = ("insert into " + BD.Nome + ".clientes (P_FisicaJuridica, CPF_CNPJ, InscricaoEstadual, NomeFantasia, RazaoSocial, NomeCliente, DatNascimento, Endereco, Complemento, Bairro, Cep, Cidade, Estado, Fone1, Fone2, Fone3, Fone4, Email1, Email2) values (@P_FisicaJuridica, @CPF_CNPJ, @InscricaoEstadual, @NomeFantasia, @RazaoSocial, @NomeCliente, @DatNascimento, @Endereco, @Complemento, @Bairro, @Cep, @Cidade, @Estado, @Fone1, @Fone2, @Fone3, @Fone4, @Email1, @Email2)")
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = cliente.P_FisicaJuridica
			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = cliente.CPF_CNPJ
			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = cliente.InscricaoEstadual
			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = cliente.NomeFantasia
			cmd.Parameters.Add("@RazaoSocial",MySqlDbType.String).Value = cliente.RazaoSocial
			cmd.Parameters.Add("@NomeCliente",MySqlDbType.String).Value = cliente.NomeCliente
			cmd.Parameters.Add("@DatNascimento",MySqlDbType.Date).Value = cliente.DatNascimento
			cmd.Parameters.Add("@Endereco",MySqlDbType.String).Value = cliente.Endereco
			cmd.Parameters.Add("@Complemento",MySqlDbType.String).Value = cliente.Complemento
			cmd.Parameters.Add("@Bairro",MySqlDbType.String).Value = cliente.Bairro
			cmd.Parameters.Add("@Cep",MySqlDbType.String).Value = cliente.Cep
			cmd.Parameters.Add("@Cidade",MySqlDbType.String).Value = cliente.Cidade
			cmd.Parameters.Add("@Estado",MySqlDbType.String).Value = cliente.Estado
			cmd.Parameters.Add("@Fone1",MySqlDbType.String).Value = cliente.Fone1
			cmd.Parameters.Add("@Fone2",MySqlDbType.String).Value = cliente.Fone2
			cmd.Parameters.Add("@Fone3",MySqlDbType.String).Value = cliente.Fone3
			cmd.Parameters.Add("@Fone4",MySqlDbType.String).Value = cliente.Fone4
			cmd.Parameters.Add("@Email1",MySqlDbType.String).Value = cliente.Email1
			cmd.Parameters.Add("@Email2",MySqlDbType.String).Value = cliente.Email2
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Clientes")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		Finally
			conexao.desconectar
		End Try		
	End Sub
	
	
	Public Sub EditarCliente (cliente As EntClientes)
		Try
			sql = "update " + BD.Nome + ".clientes Set P_FisicaJuridica = @P_FisicaJuridica, CPF_CNPJ = @CPF_CNPJ, InscricaoEstadual = @InscricaoEstadual," & _
				"			NomeFantasia = @NomeFantasia, RazaoSocial = @RazaoSocial, NomeCliente = @NomeCliente, DatNascimento = @DatNascimento," & _
				"			Endereco = @Endereco, Complemento = @Complemento, Bairro = @Bairro, Cep = @Cep, Cidade = @Cidade, Estado = @Estado, " & _
				"			Fone1 = @Fone1, Fone2 = @Fone2, Fone3 = @Fone3, Fone4 = @Fone4, Email1 = @Email1, Email2 = @Email2" & _
				"			where idcliente = @idcliente"	
			
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = cliente.P_FisicaJuridica
			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = cliente.CPF_CNPJ
			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = cliente.InscricaoEstadual
			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = cliente.NomeFantasia
			cmd.Parameters.Add("@RazaoSocial",MySqlDbType.String).Value = cliente.RazaoSocial
			cmd.Parameters.Add("@NomeCliente",MySqlDbType.String).Value = cliente.NomeCliente
			cmd.Parameters.Add("@DatNascimento",MySqlDbType.Date).Value = cliente.DatNascimento
			cmd.Parameters.Add("@Endereco",MySqlDbType.String).Value = cliente.Endereco
			cmd.Parameters.Add("@Complemento",MySqlDbType.String).Value = cliente.Complemento
			cmd.Parameters.Add("@Bairro",MySqlDbType.String).Value = cliente.Bairro
			cmd.Parameters.Add("@Cep",MySqlDbType.String).Value = cliente.Cep
			cmd.Parameters.Add("@Cidade",MySqlDbType.String).Value = cliente.Cidade
			cmd.Parameters.Add("@Estado",MySqlDbType.String).Value = cliente.Estado
			cmd.Parameters.Add("@Fone1",MySqlDbType.String).Value = cliente.Fone1
			cmd.Parameters.Add("@Fone2",MySqlDbType.String).Value = cliente.Fone2
			cmd.Parameters.Add("@Fone3",MySqlDbType.String).Value = cliente.Fone3
			cmd.Parameters.Add("@Fone4",MySqlDbType.String).Value = cliente.Fone4
			cmd.Parameters.Add("@Email1",MySqlDbType.String).Value = cliente.Email1
			cmd.Parameters.Add("@Email2",MySqlDbType.String).Value = cliente.Email2
			cmd.Parameters.Add("@idcliente",MySqlDbType.Int32).Value = cliente.IdCliente
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Clientes")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		
	End Sub
	
	Public Sub ExcluirCliente(idCliente As String)
		Try 
			sql="delete from " + BD.Nome + ".clientes where idcliente = " + idCliente
			cmd = New MySqlCommand(sql,conexao.conectar)	
			cmd.ExecuteNonQuery	
			MsgBox("Exclusão bem sucedida")		
		Catch ex As MySqlException	
			MsgBox("erro ao tentar excluir cliente "+ ex.Message)
		Finally
			conexao.desconectar	
		End Try	
	End Sub	
	
	
	Public Function LocalizarCliente(nome As String) As DataTable
		Dim dt As New DataTable	
		Try
			sql = " select NomeCliente, NomeFantasia, RazaoSocial, Endereco, Fone1, Fone2,  Email1, idCliente, P_FisicaJuridica, CPF_CNPJ, InscricaoEstadual,  DatNascimento, Complemento, Bairro, Cep, Cidade, Estado, Fone3, Fone4, Email2 from " + BD.Nome + ".clientes where nomecliente like '%"& nome & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar cliente no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return dt
	End Function
	
	
	
Public Function rETORNANOMECLIENTE(nome As String)As DataTable
	Dim dt As New DataTable
	Try
		sql = " select NomeCliente from " + BD.Nome + ".clientes where nomecliente like '%"& nome & "%'"	
		Dim da As New MySqlDataAdapter(sql, conexao.conectar)
		da.Fill(dt)	
	Catch ex As MySqlException
		MsgBox("Erro ao retornar o Nome do Cliente " + ex.Message)
	Finally
		conexao.desconectar	
	End Try
	Return dt
End Function
			
		
Public Function rELATORIOVENDACLIENTE(filtroSql As String) As DataTable
	Dim dt As New DataTable
	Try                                       
		sql = "Select vendas.idVendas,clientes.NomeCliente,categorias.Nome,produtos.Nome,fornecedores.NomeFantasia,itemvendas.QTD,itemvendas.Valor,formapagamentos.Forma,vendas.DataVenda " & _
			"FROM ((((((" + BD.Nome + ".prod_for prod_for INNER JOIN " + BD.Nome + ".fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor)) " & _
			"INNER JOIN " + BD.Nome + ".itemvendas itemvendas On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) " & _
			"INNER JOIN" + BD.Nome + ".vendas vendas On (itemvendas.idVenda = vendas.idVendas)) INNER JOIN " + BD.Nome + ".clientes clientes On (vendas.idCliente = clientes.idCliente))" & _
			"INNER JOIN " + BD.Nome + ".formapagamentos formapagamentos On (vendas.idFormaPagamento = formapagamentos.idFormaPagamento)) INNER JOIN " + BD.Nome + ".produtos produtos " & _
			"ON (prod_for.idProduto = produtos.idProduto)) INNER JOIN " + BD.Nome + ".categorias categorias ON (produtos.idCategoria = categorias.idCategoria)"+ filtroSql
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
