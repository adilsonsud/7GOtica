'
' Criado por SharpDevelop.
' Usuário: adilson
' Data: 2015-11-12
' Hora: 19:00
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class Codigos
	
	'Carregar um dataReader e preencher um list(of )
'		Public Function LocalizarProduto As List(Of EntProdutos)
'		
'		Dim Listaproduto As New List(Of EntProdutos)
'		
'		Try
'			sql = " select  * from 7gfrota.produtos"
'			cmd = New MySqlCommand(sql, conexao.conectar)
'			dr = cmd.ExecuteReader
'			While dr.Read
'				Dim produto As New EntProdutos
'				produto.IdProduto =  dr.GetInt32(0)
'				produto.NomeProduto = dr.GetString(1)
'				produto.IdCategoria = dr.GetInt32(2)
'				Listaproduto.Add(produto)					
'			End While
'			dr.Close
'			'Return Listaproduto
'			
'		Catch ex As MySqlException
'			MsgBox("Erro ao tentar localizar produto no Banco de dados: " + ex.Message)
'		Finally
'			conexao.desconectar
'		End Try
'		Return Listaproduto
'	End Function
	
	
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''	
	
	'Percorrer um list(of ) e preencher um dataGridView 
	'OBS: para que o datagrid possa ordenar as colunas ao clicar no cabeçalho, deve-se criar as colunas no datagrid, caso não deseje esse recurso é so jogar o list direto para o dataSorce do datagride
	
'		 Dim ListaProduto As New List(Of entProdutos)
'
'		 ListaProduto = cadprodutos.LocalizarProduto
'		 dgvTeste.Rows.Clear	
'		 Dim linha As Integer = 0
'		
'		 While   linha < ListaProduto.Count
'		 	dgvTeste.Rows.Add(ListaProduto(linha).IdProduto, ListaProduto(linha).NomeProduto, ListaProduto(linha).IdCategoria)
'		 	linha += 1
'		 End While
'		 ListaProduto.Clear
	
End Class
