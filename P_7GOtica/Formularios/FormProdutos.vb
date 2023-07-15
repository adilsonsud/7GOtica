'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'

Public Partial Class FormProdutos
	Dim produto As New EntProdutos
	Dim fornecedor As New EntFornecedores
	Dim prodfor As New EntProdFor
	Dim CadProduto As New CadProdutos
	Dim cadfornecedor As New CadFornecedores
	Dim cadprodFor As New CadProdFor
	Dim v_update As Integer '1 inserir/ 2 editar
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		DesabilitaUpdate
	End Sub
	
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	Sub FormProdutosKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 Then
			tabControl1.SelectTab(0)
			txt_Localizar.Clear
			txt_Localizar.Focus	
		ElseIf e.KeyCode = Keys.F3 Then
			tabControl1.SelectTab(1)
		End If
	End Sub
	
	Sub HabilitaUpdate
		bt_novo.Visible = False
		bt_editar.Visible = False
		bt_excluir.Visible = False
		bt_salvar.Visible = True		
		lbl_imagem.Visible = True
		
		txt_id.Enabled = True
		txt_nome.Enabled = True
		txt_categoria.Enabled = True
		txt_Fornecedor.Enabled = True
		txt_CDB.Enabled = True
		txt_CDB.Focus
		txt_precoCusto.Enabled = True
		txt_precoVenda.Enabled = True
		tabLocalizar.Enabled = False	
		
	End Sub
	
	Sub DesabilitaUpdate
		bt_novo.Visible = True
		bt_editar.Visible = True
		bt_excluir.Visible = True
		bt_salvar.Visible = False
		txt_id.Enabled = False
		txt_CDB.Enabled = False
		txt_nome.Enabled = False	
		txt_categoria.Enabled = False
		txt_Fornecedor.Enabled = False
		txt_precoCusto.Enabled = False
		txt_precoVenda.Enabled = False
		lbl_imagem.Visible = False
		dgv_Categorias.Visible = False
			
		tabLocalizar.Enabled = True
		
	End Sub
	
	Sub Bt_novoClick(sender As Object, e As EventArgs)
		v_update = 1
		HabilitaUpdate
		LimpaCampos		
	    txt_CDB.Focus
	End Sub
	
	Sub Bt_editarClick(sender As Object, e As EventArgs)
		If txt_id.Text = String.Empty Then
			MsgBox("Não há dados para editar")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			
			Exit Sub	
		Else	
			v_update = 2
			HabilitaUpdate
		End If	
	End Sub
	
	
	Sub Bt_salvarClick(sender As Object, e As EventArgs)
		
		If autenticaForm = True Then	
			
			If v_update = 1 Then
				produto.NomeProduto = txt_nome.Text
				produto.IdCategoria = produto.IdCategoria			
				CadProduto.AdicionarProduto(produto) ' salva as informações referente ao produto
				prodfor.IdProduto = CadProduto.RetornaIdProduto 'recupera o idProduto gerado no comando acima, para adiciona-lo na tabela prodFor
				prodfor.CDB = txt_CDB.Text	
				prodfor.IdFornecedor = fornecedor.IdFornecedor
				prodfor.QTD = 0
				prodfor.QTD_Loja = 0
				prodfor.PrecoCusto = CDbl(txt_precoCusto.Text)
				prodfor.PrecoVenda = CDbl(txt_precoVenda.Text)
				cadprodFor.AdicionarProdFor(prodfor) ' Adiciona associação do produto ao fornecedor na tabela prodfor
				LimpaCampos
				
			ElseIf v_update = 2 Then
				produto.IdProduto = CInt (txt_id.Text)
				produto.NomeProduto = txt_nome.Text
				produto.IdCategoria = produto.IdCategoria
				prodfor.CDB = txt_CDB.Text	
				CadProduto.EditarProduto(produto) 'Salva informações referente ao produto
				prodfor.IdProduto = produto.IdProduto
				'prodfor.IdFornecedor = fornecedor.IdFornecedor
				prodfor.PrecoCusto = CDbl(txt_precoCusto.Text)
				prodfor.PrecoVenda = CDbl(txt_precoVenda.Text)
				cadprodFor.EditarProdFor(prodfor) ' salva informações referente a tabela prodfor
				LimpaCampos
			End If
		Else
			Exit Sub
			
		End If
		DesabilitaUpdate
		bt_fechar.Focus
		
	End Sub
	
	Sub Txt_LocalizarKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
'			If rb_teclado.Checked = True Then
'				dgv_Produtos.DataSource = CadProduto.LocalizarProduto(txt_Localizar.Text)
'			ElseIf rb_cdb.Checked = True Then
'			dgv_Produtos.DataSource = CadProduto.LocalizarProduto_CDB(txt_Localizar.Text)
'			End If
			dgv_Produtos.DataSource = CadProduto.LocalizarProduto(txt_Localizar.Text)
			If dgv_Produtos.RowCount < 1 Then
				dgv_Produtos.DataSource = ""
				MsgBox("Verifique se os dados estão corretos.",vbOKOnly,"Produto não Encontrado")	
				Exit Sub
			End If
				'dgv_Produtos.DataSource = CadProduto.LocalizarProduto_CDB(txt_Localizar.Text)
'				If dgv_Produtos.RowCount < 1 Then
'					MsgBox("Produto não encontrado")
'					txt_Localizar.Clear
'					txt_Localizar.Focus
'					dgv_Produtos.DataSource = ""
'					Exit Sub
'				End If
'			End If

            
			'            0                  1                  2                3              4                5                 6                  7                8                    9                  10                          11
			'produtos.idProduto, produtos.Nome, produtos.idCategoria, prod_for.CDB, prod_for.Foto, categorias.Nome, prod_for.idFornecedor, prod_for.QTD, prod_for.QTD_Loja, prod_for.PrecoCusto, prod_for.PrecoVenda, fornecedores.NomeFantasia
			
			dgv_Produtos.Columns(0).Visible = False
			dgv_Produtos.Columns(1).Visible = True
			dgv_Produtos.Columns(2).Visible = False
			dgv_Produtos.Columns(3).Visible = False
			dgv_Produtos.Columns(4).Visible = False
			dgv_Produtos.Columns(5).Visible = True
			dgv_Produtos.Columns(6).Visible = False
			dgv_Produtos.Columns(7).Visible = False
			dgv_Produtos.Columns(8).Visible = False			
			dgv_Produtos.Columns(9).Visible = True	
			dgv_Produtos.Columns(10).Visible = True	
			dgv_Produtos.columns(11).Visible = True
			
			dgv_Produtos.Columns(7).HeaderText = "ESTOQUE"
			dgv_Produtos.Columns(8).HeaderText = "EST_LOJA"
			
			dgv_Produtos.Columns(9).DefaultCellStyle.Format = "c2"
			dgv_Produtos.Columns(10).DefaultCellStyle.Format = "c2"		
			
			dgv_Produtos.Columns(1).Width = 200
'			dgv_Produtos.Columns(7).Width = 100
'			dgv_Produtos.Columns(8).Width = 100
'			dgv_Produtos.Columns(9).Width = 80
'			dgv_Produtos.Columns(10).Width = 100
			
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_Produtos.Focus
		End If
	End Sub
	
	
	Sub Dgv_ProdutosKeyDown(sender As Object, e As KeyEventArgs)	
		If e.KeyCode = Keys.Enter Then
			If dgv_Produtos.RowCount < 1 Then
				MsgBox("Escolha um produto válido",vbOKOnly,"ATENÇÃO")
				txt_Localizar.Focus
			Else		
				'            0                  1                  2                3              4                5                 6                  7                8                    9                  10                          11
				'produtos.idProduto, produtos.Nome, produtos.idCategoria, prod_for.CDB, prod_for.Foto, categorias.Nome, prod_for.idFornecedor, prod_for.QTD, prod_for.QTD_Loja, prod_for.PrecoCusto, prod_for.PrecoVenda, fornecedores.NomeFantasia
				txt_nome.Text = dgv_Produtos.SelectedCells(1).Value.ToString
				txt_categoria.Text = dgv_Produtos.SelectedCells(5).Value.ToString	
				txt_id.Text = dgv_Produtos.SelectedCells(0).Value.ToString
				produto.IdCategoria = CInt(dgv_Produtos.SelectedCells(2).Value.ToString)
				prodfor.QTD = CInt(dgv_Produtos.SelectedCells(7).Value.ToString)
				prodfor.QTD_Loja = CInt(dgv_Produtos.SelectedCells(8).Value.ToString)
				prodfor.IdProduto = CInt(dgv_Produtos.SelectedCells(0).Value.ToString)
				prodfor.IdFornecedor = CInt(dgv_Produtos.SelectedCells(6).Value.ToString)
				txt_CDB.Text = dgv_Produtos.SelectedCells(3).Value.ToString
				prodfor.Foto = dgv_Produtos.SelectedCells(4).Value.ToString		
				txt_Fornecedor.Text = dgv_Produtos.SelectedCells(11).Value.ToString
				txt_precoCusto.Text = FormatCurrency(dgv_Produtos.SelectedCells(9).Value.ToString,2)
				txt_precoVenda.Text = FormatCurrency(dgv_Produtos.SelectedCells(10).Value.ToString,2)
				fornecedor.IdFornecedor = CInt(dgv_Produtos.SelectedCells(6).Value.ToString)
				pictureBox1.ImageLocation = prodfor.Foto	
				
				'Dados Loja
				lbl_idProduto.Text = txt_id.Text
				lbl_NomeProduto.Text = txt_nome.Text
				lbl_fornecedor.Text = txt_Fornecedor.Text
				lbl_qtdEstoque.Text = CStr(prodfor.QTD)
				lbl_qtdLoja.Text = CStr(prodfor.QTD_Loja)
				
				dgv_Produtos.DataSource =""
				tabControl1.SelectTab(1)
				tabControl2.SelectTab(0)
			End If
		End If
		
	End Sub
	
	Sub TabLocalizarEnter(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	
	Sub Bt_excluirClick(sender As Object, e As EventArgs)
		
		If txt_id.Text = String.Empty Then
			MsgBox("Não há dados para excluir")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			Exit Sub
		
		Else
			If MsgBox("Confirme a exclusão!",vbYesNo , "Excluir")= vbYes Then
				cadprodFor.ExcluirProdFor(CStr(prodfor.IdProduto),CStr(prodfor.IdFornecedor))
				CadProduto.ExcluirProduto(txt_id.Text)
				LimpaCampos
			Else
				Exit Sub
			End If		
		End If		
	End Sub
	
	Sub LimpaCampos
		txt_id.Clear
		txt_nome.Clear	
		txt_CDB.Clear
		txt_categoria.Clear
		txt_Fornecedor.Clear
		txt_precoVenda.Clear
		txt_precoCusto.Clear
		txt_pesquisaCategoria.Clear
		txt_pesquisaFornecedor.Clear
		pictureBox1.Image = Nothing
		lbl_idProduto.Text = ""
		lbl_NomeProduto.Text = ""
		lbl_fornecedor.Text = ""
		lbl_qtdEstoque.Text = ""
		lbl_qtdLoja.Text = ""
		numericUpDown1.Value = 0
	End Sub
	
	'chama a sub carregaNomeCategoria na classe cadProdutos e armazena no dataReader
	'Objetivo, preencher o combo categoria
'	Sub carregaCb_categoria
		
		'cb_Categoria.Items.Add = CadProduto.CarregaNomeCategoria
'		While categoria.Read
'			cb_Categoria.Items.Add(categoria(0))
'		End While
'		categoria.Close	
	'End Sub
	

	
	
	Function autenticaForm As Boolean
		Dim Aform As Boolean = False 'true Aform ok, false objeto em branco 		
	
		If txt_nome.Text = "" Then
			MsgBox("Digite o nome do Produto",vbOKOnly,"ATENÇÃO - CAMPO EM BRANCO")
			txt_nome.Focus
		ElseIf txt_categoria.Text = "" Then
			MsgBox("Digite o nome da Categoria",vbOKOnly,"ATENÇÃO - CAMPO EM BRANCO")
			txt_categoria.Focus
		ElseIf txt_Fornecedor.Text = "" Then
			MsgBox("Digite o nome do Fornecedor",vbOKOnly,"ATENÇÃO - CAMPO EM BRANCO")
		ElseIf txt_precoCusto.Text = "" Then
			MsgBox("Digite o Preço de Custo",vbOKOnly,"ATENÇÃO - CAMPO EM BRANCO")
			txt_precoCusto.Focus
		ElseIf Not IsNumeric(txt_precocusto.Text) Then
		 	MsgBox("Digite um número valido para Preço custo", vbOKOnly, "Digito incorreto")
		 	txt_precocusto.Focus 		
		ElseIf txt_precoVenda.Text = "" Then
			MsgBox("Digite o Preço de Venda",vbOKOnly,"ATENÇÃO - CAMPO EM BRANCO")
			txt_precoVenda.Focus
		ElseIf Not IsNumeric (txt_precoVenda.Text) Then
		 	MsgBox("Digite um número valido para Preço venda", vbOKOnly, "Digito incorreto")
		 	txt_precoVenda.Focus	
		Else
			Aform = True
		End If
		
		Return Aform
	End Function
	
	
	Sub Bt_salvar_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode= Keys.Escape Then
			txt_precoVenda.Focus
		End If
	End Sub
	
	Sub FormProdutos_Shown(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	
	Sub Dgv_Produtos_DoubleClick(sender As Object, e As EventArgs)
		If dgv_Produtos.RowCount < 1 Then
			MsgBox("Escolha um produto válido",vbOKOnly,"ATENÇÃO")
			txt_Localizar.Focus
		Else
			
		    '           0                  1                  2                3              4                5                 6                  7                8                    9                  10                          11
			'produtos.idProduto, produtos.Nome, produtos.idCategoria, prod_for.CDB, prod_for.Foto, categorias.Nome, prod_for.idFornecedor, prod_for.QTD, prod_for.QTD_Loja, prod_for.PrecoCusto, prod_for.PrecoVenda, fornecedores.NomeFantasia
			txt_nome.Text = dgv_Produtos.SelectedCells(1).Value.ToString
			txt_categoria.Text = dgv_Produtos.SelectedCells(5).Value.ToString	
			txt_id.Text = dgv_Produtos.SelectedCells(0).Value.ToString
			produto.IdCategoria = CInt(dgv_Produtos.SelectedCells(2).Value.ToString)
			prodfor.QTD = CInt(dgv_Produtos.SelectedCells(7).Value.ToString)
			prodfor.QTD_Loja = CInt(dgv_Produtos.SelectedCells(8).Value.ToString)
			prodfor.IdProduto = CInt(dgv_Produtos.SelectedCells(0).Value.ToString)
			prodfor.IdFornecedor = CInt(dgv_Produtos.SelectedCells(6).Value.ToString)
			txt_CDB.Text = dgv_Produtos.SelectedCells(3).Value.ToString
			prodfor.Foto = dgv_Produtos.SelectedCells(4).Value.ToString		
			txt_Fornecedor.Text = dgv_Produtos.SelectedCells(11).Value.ToString
			txt_precoCusto.Text = FormatCurrency(dgv_Produtos.SelectedCells(9).Value.ToString,2)
			txt_precoVenda.Text = FormatCurrency(dgv_Produtos.SelectedCells(10).Value.ToString,2)
			fornecedor.IdFornecedor = CInt(dgv_Produtos.SelectedCells(6).Value.ToString)
			pictureBox1.ImageLocation = prodfor.Foto	
			
			'Dados Loja
			lbl_idProduto.Text = txt_id.Text
			lbl_NomeProduto.Text = txt_nome.Text
			lbl_fornecedor.Text = txt_Fornecedor.Text
			lbl_qtdEstoque.Text = CStr(prodfor.QTD)
			lbl_qtdLoja.Text = CStr(prodfor.QTD_Loja)
			
			dgv_Produtos.DataSource =""
			tabControl1.SelectTab(1)
			tabControl2.SelectTab(0)	
		End If	
	End Sub
	
	
	
	Sub Txt_categoriaKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_pesquisaCategoria.Visible = True
			txt_pesquisaCategoria.Clear
			dgv_Categorias.DataSource = ""
			txt_pesquisaCategoria.Focus
		ElseIf e.KeyCode = Keys.Escape Then
			txt_nome.Focus
			txt_pesquisaCategoria.Visible = False
			txt_pesquisaFornecedor.Visible = False
			dgv_Fornecedor.Visible = False
			dgv_Categorias.Visible = False	
		End If
	End Sub
	
	Sub Txt_pesquisaCategoriaKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			dgv_Categorias.DataSource = CadProduto.CarregaNomeCategoria(txt_pesquisaCategoria.Text)	
			dgv_Categorias.Visible = True
			dgv_Categorias.Location = New Point(115,158)
			dgv_Categorias.Size = New Size(253,131)			
			dgv_Categorias.Columns(1).Width = 220
			dgv_Categorias.Columns(0).Visible = False
		ElseIf e.KeyCode = Keys.Escape Then
			dgv_Categorias.Visible = False
			txt_pesquisaCategoria.Visible = False
			txt_nome.Focus
		ElseIf e.KeyCode = Keys.Down Then
			dgv_Categorias.Focus
		End If
	End Sub
	
	Sub Txt_nomeKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_pesquisaCategoria.Visible = True
			txt_pesquisaCategoria.Clear
			dgv_Categorias.DataSource = ""
			txt_pesquisaCategoria.Focus
		ElseIf e.KeyCode = Keys.Escape Then
			txt_CDB.Focus
		End If
	End Sub
	
	Sub Dgv_CategoriasKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then			
			If dgv_categorias.RowCount < 1 Then 
				MsgBox("Digete o nome da categoria desejada",vbOKOnly, "ATENÇÃO")
				txt_pesquisaCategoria.Focus
			Else
				txt_categoria.Text =  dgv_Categorias.SelectedCells(1).Value.ToString
				produto.IdCategoria = CInt(dgv_Categorias.SelectedCells(0).Value.ToString)
				txt_pesquisaCategoria.Visible = False
				dgv_Categorias.Visible = False
				txt_pesquisaFornecedor.Visible = True
				txt_pesquisaFornecedor.Focus
			End If	
			
		ElseIf e.KeyCode = Keys.Escape Then
			txt_pesquisaCategoria.Focus
		End If
		
	End Sub
	
	Sub Dgv_CategoriasDoubleClick(sender As Object, e As EventArgs)
		If dgv_categorias.RowCount < 1 Then 
			MsgBox("Digete o nome da categoria desejada",vbOKOnly, "ATENÇÃO")
			txt_pesquisaCategoria.Focus
		Else
			txt_categoria.Text =  dgv_Categorias.SelectedCells(1).Value.ToString
			produto.IdCategoria = CInt(dgv_Categorias.SelectedCells(0).Value.ToString)
			txt_pesquisaCategoria.Visible = False
			dgv_Categorias.Visible = False
			txt_pesquisaFornecedor.Visible = True
			txt_pesquisaFornecedor.Focus
		End If	
	End Sub
	
	
	
	Sub Lbl_imagemClick(sender As Object, e As EventArgs)
		If OFD.ShowDialog = DialogResult.OK Then
			pictureBox1.Load(OFD.FileName)
			prodfor.Foto = OFD.FileName
		End If
	End Sub
	
	Sub Txt_CDBKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_nome.Focus
		End If
	End Sub
	
	
	Sub Txt_pesquisaFornecedorKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			dgv_Fornecedor.DataSource = cadfornecedor.RetornaNomeFornecedor(txt_pesquisaFornecedor.Text)
			'    0               1
			'idFornecedor, NomeFantasia
			dgv_Fornecedor.Visible = True
			dgv_Fornecedor.Location = New Point(115,189)
			dgv_Fornecedor.Size = New Size(253,125)
			dgv_Fornecedor.Columns(0).Visible = False
			prodfor.IdFornecedor = CInt(dgv_Fornecedor.SelectedCells(0).Value.ToString)
		ElseIf e.KeyCode = Keys.Escape Then
			txt_categoria.Focus
			txt_pesquisaFornecedor.Visible = False
			dgv_Categorias.DataSource = ""
			dgv_Fornecedor.Visible = False
			
		ElseIf e.KeyCode = Keys.Down Then
			dgv_Fornecedor.Focus
		End If
	End Sub
	
	Sub Dgv_FornecedorKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			If dgv_Fornecedor.RowCount < 1 Then 
				MsgBox("Digete o nome do Fornecedor desejado",vbOKOnly, "ATENÇÃO")
				txt_pesquisaFornecedor.Focus
			Else	
				'    0               1
				'idFornecedor, NomeFantasia
				txt_Fornecedor.Text = dgv_Fornecedor.SelectedCells(1).Value.ToString
				fornecedor.IdFornecedor = CInt(dgv_Fornecedor.SelectedCells(0).Value.ToString)
				dgv_Fornecedor.Visible = False
				txt_pesquisaFornecedor.Visible = False		
				txt_precoCusto.Focus
			End If	
		ElseIf e.KeyCode = Keys.Escape Then
			txt_pesquisaFornecedor.Focus
		End If
	End Sub
	
	Sub Dgv_FornecedorDoubleClick(sender As Object, e As EventArgs)
		If dgv_Fornecedor.RowCount < 1 Then 
				MsgBox("Digete o nome do Fornecedor desejado",vbOKOnly, "ATENÇÃO")
				txt_pesquisaFornecedor.Focus
			Else	
				txt_Fornecedor.Text = dgv_Fornecedor.SelectedCells(1).Value.ToString
				fornecedor.IdFornecedor = CInt(dgv_Fornecedor.SelectedCells(0).Value.ToString)
				dgv_Fornecedor.Visible = False
				txt_pesquisaFornecedor.Visible = False				
			End If	
	End Sub
	
	Sub Txt_FornecedorKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_pesquisaFornecedor.Visible = True
			txt_pesquisaFornecedor.Clear
			dgv_Fornecedor.DataSource = ""
			txt_pesquisaFornecedor.Focus		
		ElseIf e.KeyCode = Keys.Escape Then
			txt_categoria.Focus
			txt_pesquisaCategoria.Visible = False
			txt_pesquisaFornecedor.Visible = False
			dgv_Fornecedor.Visible = False
			dgv_Categorias.Visible = False
		ElseIf e.KeyCode = Keys.Down Then
			dgv_Fornecedor.Focus
		End If
	End Sub
	
	Sub Txt_precoCustoKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_precoVenda.Focus
		ElseIf e.KeyCode = Keys.Escape Then			
			dgv_Fornecedor.DataSource = ""
			txt_Fornecedor.Focus			
		End If
	End Sub
	
	Sub Txt_precoVendaKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			bt_salvar.Focus
		ElseIf e.KeyCode = Keys.Escape Then
			txt_precoCusto.Focus
		End If
	End Sub
	
	Sub Txt_precoCustoLeave(sender As Object, e As EventArgs)	
		 If txt_precocusto.Text <> ""
		 	txt_precocusto.Text = FormatCurrency(txt_precocusto.Text,2)
		 	Dim pvenda As Decimal = CDec(txt_precoCusto.Text + 120)
		 	txt_precoVenda.Text = FormatCurrency(pvenda)
		 End If	
	End Sub
	
	Sub Txt_precoVendaLeave(sender As Object, e As EventArgs)
		If txt_precoVenda.Text <> "" Then
		   txt_precoVenda.Text = FormatCurrency(txt_precoVenda.Text,2)
		End If
	End Sub
	
	Sub Bt_confirmarClick(sender As Object, e As EventArgs)
		If numericUpDown1.Value > prodfor.QTD Then
			MsgBox("Quantidade superior ao Estoque",vbOKOnly, "ATENÇÃO")
			Exit Sub
		Else
			If MsgBox("Deseja Confirmar !",vbYesNo , "Incluir na Loja")= vbYes Then
				Calcula_Estoque(prodfor.QTD,prodfor.QTD_Loja)	
				cadprodFor.Inserir_QTD_Loja(prodfor.QTD, prodfor.QTD_Loja, prodfor.IdProduto, prodfor.IdFornecedor)
				LimpaCampos
			Else
				Exit Sub
			End If
		End If
	End Sub
	
	Sub Calcula_Estoque (qtd_E As Integer, qtd_L As Integer)
		Dim qtd As Integer = CInt(numericUpDown1.Value)
		prodfor.QTD = qtd_E - qtd
		prodfor.QTD_Loja = qtd_L + qtd
	End Sub
End Class

