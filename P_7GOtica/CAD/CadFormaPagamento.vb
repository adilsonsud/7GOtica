'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 12:17
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'	
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadFormaPagamento

	Dim conexao As  CL_Conexao	
	Dim cmd 	As MySqlCommand
	Dim dr 		As MySqlDataReader
	Dim sql		As String
	
	Public Sub New()
		conexao = New CL_Conexao
	End Sub
	
	Public Sub AdicionarFormaPagamento (FormaPagamento As EntFormaPagamento)
		Try
			sql = ("insert into " + BD.Nome + ".FormaPagamentos (forma) values (@nome)")
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = FormaPagamento.NomeFormaPagamento
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Forma de Pagamento")				
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		Finally
			conexao.desconectar
		End Try		
	End Sub
	
	
	Public Sub EditarFormaPagamento (FormaPagamento As EntFormaPagamento)
		Try
			sql = "update " + BD.Nome + ".FormaPagamentos Set forma = @forma where idFormaPagamento = @idFormaPagamento"			
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.Parameters.Add("@forma",MySqlDbType.String).Value = FormaPagamento.NomeFormaPagamento
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = FormaPagamento.IdFormaPagamento
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Forma de Pagamento")			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		Finally
			conexao.desconectar	
		End Try
	End Sub
	
	
	Public Sub ExcluirFormaPagamento(idFormaPagamento As String)
		Try 
			sql="delete from " + BD.Nome + ".FormaPagamentos where idFormaPagamento = " + idFormaPagamento
			cmd = New MySqlCommand(sql, conexao.conectar)	
			cmd.ExecuteNonQuery	
			MsgBox("Exclusão bem sucedida", vbOKOnly, "Cadastro de Forma de Pagamento")	
		 Catch ex As MySqlException	
	  		MsgBox("erro ao tentar excluir forma de pagamento! "+ ex.Message)
		 Finally
			conexao.desconectar	
		 End Try	
	End Sub
	
	
	Public Function LocalizarFormaPagamento(nomeForma As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  * from " + BD.Nome + ".FormaPagamentos where forma like '%"& nomeForma & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar Forma de Pagamento no Banco de dados: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try		
		Return dt
	End Function
	
	
	Public Function rETORNA_fORMA_pAGAMENTO(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select forma from " + BD.Nome + ".formapagamentos where forma like '%"& nome & "%'"	
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar forma de pagamento: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return dt
	End Function
	
	Public Function rETORNA_fORMA_pAGAMENTO As Integer
		Dim dt As New DataTable
		Dim VendaCancelada As Integer
		Try
			sql = " select idFormaPagamento from " + BD.Nome + ".formapagamentos where forma = 'VENDA CANCELADA'"
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
			If dt.Rows.Count < 1 Then
				MsgBox("Erro ao tentar localizar VENDA CANCELADA, certifique-se de que esta opção existe no cadastro de formas de pagamento, caso não exista, você deve inseri-la: ",vbOKOnly,"*** ATENÇÃO ***" )	
				Return 0
				Exit Function		
			Else
				VendaCancelada = CInt(dt.Rows(0)(0).ToString)	
			End If
		Catch ex As MySqlException
			MsgBox("Erro ao tentar retornar o idFormaPagamento. ",vbOKOnly,"*** ATENÇÃO ***" + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return VendaCancelada
	End Function
	
	
	Public Function rELATORIOVENDA_FORMAPAGAMENTO(filtro As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = "Select formapagamentos.forma As 'Forma de Pagamento' , sum(vendas.valortotal) As Total " & _
				  "FROM  vendas inner join  formapagamentos on(vendas.idformapagamento = formapagamentos.idformapagamento) " + filtro + " group by formapagamentos.forma"
			Dim da As New MySqlDataAdapter(sql, conexao.conectar)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar forma de pagamento: " + ex.Message)
		Finally
			conexao.desconectar	
		End Try
		Return dt
	End Function
	
	
End Class
