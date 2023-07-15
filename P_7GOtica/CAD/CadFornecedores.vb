'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 6/3/2014
' Hora: 18:35
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadFornecedores
	
	Dim conexao As CL_Conexao	
	Dim cmd 	As MySqlCommand
	Dim dr		As MySqlDataReader	
	Dim sql 	As String
	
	Public Sub New()
		conexao = New CL_Conexao
	End Sub
	
	Public Sub AdicionarFornecedor (fornecedor As EntFornecedores)
	
		Try
			sql = ("insert into " + BD.Nome + ".fornecedores (P_FisicaJuridica, CPF_CNPJ, InscricaoEstadual, NomeFantasia, RazaoSocial, Endereco, Complemento, Bairro, Cep, Cidade, Estado, Fone1, Fone2, Fone3, Fone4, Email1, Email2, site) values (@P_FisicaJuridica, @CPF_CNPJ, @InscricaoEstadual, @NomeFantasia, @RazaoSocial, @Endereco, @Complemento, @Bairro, @Cep, @Cidade, @Estado, @Fone1, @Fone2, @Fone3, @Fone4, @Email1, @Email2, @site)")
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = fornecedor.P_FisicaJuridica
			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = fornecedor.CPF_CNPJ
			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = fornecedor.InscricaoEstadual
			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = fornecedor.NomeFantasia
			cmd.Parameters.Add("@RazaoSocial",MySqlDbType.String).Value = fornecedor.RazaoSocial
			cmd.Parameters.Add("@Endereco",MySqlDbType.String).Value = fornecedor.Endereco
			cmd.Parameters.Add("@Complemento",MySqlDbType.String).Value = fornecedor.Complemento
			cmd.Parameters.Add("@Bairro",MySqlDbType.String).Value = fornecedor.Bairro
			cmd.Parameters.Add("@Cep",MySqlDbType.String).Value = fornecedor.Cep
			cmd.Parameters.Add("@Cidade",MySqlDbType.String).Value = fornecedor.Cidade
			cmd.Parameters.Add("@Estado",MySqlDbType.String).Value = fornecedor.Estado
			cmd.Parameters.Add("@Fone1",MySqlDbType.String).Value = fornecedor.Fone1
			cmd.Parameters.Add("@Fone2",MySqlDbType.String).Value = fornecedor.Fone2
			cmd.Parameters.Add("@Fone3",MySqlDbType.String).Value = fornecedor.Fone3
			cmd.Parameters.Add("@Fone4",MySqlDbType.String).Value = fornecedor.Fone4
			cmd.Parameters.Add("@Email1",MySqlDbType.String).Value = fornecedor.Email1
			cmd.Parameters.Add("@Email2",MySqlDbType.String).Value = fornecedor.Email2
			cmd.Parameters.Add("@site", MySqlDbType.String).Value = fornecedor.Site
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Fornecedores")			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		Finally
			conexao.desconectar
		End Try		
	End Sub
	
	
	Public Sub EditarFornecedor (fornecedor As EntFornecedores)
		Try
			sql = "update " + BD.Nome + ".fornecedores Set P_FisicaJuridica = @P_FisicaJuridica, CPF_CNPJ = @CPF_CNPJ, InscricaoEstadual = @InscricaoEstadual," & _
				"			NomeFantasia = @NomeFantasia, RazaoSocial = @RazaoSocial," & _
				"			Endereco = @Endereco, Complemento = @Complemento, Bairro = @Bairro, Cep = @Cep, Cidade = @Cidade, Estado = @Estado, " & _
				"			Fone1 = @Fone1, Fone2 = @Fone2, Fone3 = @Fone3, Fone4 = @Fone4, Email1 = @Email1, Email2 = @Email2, site = @site" & _
				"			where idfornecedor = @idfornecedor"	
			
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = fornecedor.P_FisicaJuridica
			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = fornecedor.CPF_CNPJ
			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = fornecedor.InscricaoEstadual
			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = fornecedor.NomeFantasia
			cmd.Parameters.Add("@RazaoSocial",MySqlDbType.String).Value = fornecedor.RazaoSocial
			cmd.Parameters.Add("@Endereco",MySqlDbType.String).Value = fornecedor.Endereco
			cmd.Parameters.Add("@Complemento",MySqlDbType.String).Value = fornecedor.Complemento
			cmd.Parameters.Add("@Bairro",MySqlDbType.String).Value = fornecedor.Bairro
			cmd.Parameters.Add("@Cep",MySqlDbType.String).Value = fornecedor.Cep
			cmd.Parameters.Add("@Cidade",MySqlDbType.String).Value = fornecedor.Cidade
			cmd.Parameters.Add("@Estado",MySqlDbType.String).Value = fornecedor.Estado
			cmd.Parameters.Add("@Fone1",MySqlDbType.String).Value = fornecedor.Fone1
			cmd.Parameters.Add("@Fone2",MySqlDbType.String).Value = fornecedor.Fone2
			cmd.Parameters.Add("@Fone3",MySqlDbType.String).Value = fornecedor.Fone3
			cmd.Parameters.Add("@Fone4",MySqlDbType.String).Value = fornecedor.Fone4
			cmd.Parameters.Add("@Email1",MySqlDbType.String).Value = fornecedor.Email1
			cmd.Parameters.Add("@Email2",MySqlDbType.String).Value = fornecedor.Email2
			cmd.Parameters.Add("@site",MySqlDbType.String).Value = fornecedor.Site
			cmd.Parameters.Add("@idfornecedor",MySqlDbType.Int32).Value = fornecedor.IdFornecedor
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Fornecedores")			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try	
	End Sub
	
	Public Sub ExcluirFornecedor(idfornecedor As String)
		Try 
			sql="delete from " + BD.Nome + ".fornecedores where idfornecedor = " + idfornecedor
			cmd = New MySqlCommand(sql,conexao.conectar)	
			cmd.ExecuteNonQuery	
			MsgBox("Exclusão bem sucedida")		
		Catch ex As MySqlException	
			MsgBox("erro ao tentar excluir fornecedor "+ ex.Message)
		Finally
			conexao.desconectar	
		End Try		
	End Sub
	
	
	Public Function LocalizarFornecedor(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  * from " + BD.Nome + ".fornecedores where nomeFantasia like '%"& nome & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader			
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar fornecedor no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return dt
	End Function
	
	
	Public Function RetornaNomeFornecedor(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  idFornecedor, NomeFantasia from " + BD.Nome + ".fornecedores where nomeFantasia like '%"& nome & "%'"				
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar nome do fornecedor : " + ex.Message)
		Finally
			conexao.desconectar
		End Try
		Return dt
	End Function
	
	Public Function rELATORIOaNALITICOvENDAS_fORNECEDOR(filtro As String) As DataTable
		Dim dt As New DataTable
		Try
			sql = "Select fornecedores.NomeFantasia, prod_for.idFornecedor, sum(itemvendas.QTD) As QTD, sum(itemvendas.Valor) As Valor, vendas.DataVenda " & _
				  "FROM((`" + BD.Nome + "`.itemvendas itemvendas INNER JOIN `" + BD.Nome + "`.vendas vendas On (itemvendas.idVenda = vendas.idVendas)) INNER JOIN `" + BD.Nome + "`.prod_for prod_for " & _
				  "On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) INNER JOIN `" + BD.Nome + "`.fornecedores fornecedores " & _
				  "ON (prod_for.idFornecedor = fornecedores.idFornecedor) " + filtro + " group by fornecedores.NomeFantasia"
			Dim da As  New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)
		Catch err As MySqlException
			MsgBox("Erro ao tentar localizar dados de vendas de fornecedores" + err.Message, vbOKOnly, " ATENÇÃO ")
		Finally
			conexao.desconectar			
		End Try
		Return dt
		
	End Function
	
End Class
