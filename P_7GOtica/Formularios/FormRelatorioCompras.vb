'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'

Public Partial Class FormRelatorioCompras
	
	Dim compra As New EntCompras
	Dim cadPDV As New CadPDV
	Dim cadCategorias As New CadCategorias
	Dim cadProdutos As New CadProdutos
	Dim cadFornecedor As New CadFornecedores
	Dim cadCompras As New CadCompras
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
	
	Sub ExibeCompras

			If txt_data1.Text = "" Then
				MsgBox("Escolha uma data inicial para efetuar a consulta", vbInformation, "DATA INICIAL EM BRANCO")
				txt_data1.Focus
				Exit Sub
			ElseIf txt_data2.Text = "" Then
				MsgBox("Escolha uma data final para efetuar a consulta", vbInformation, "DATA FINAL EM BRANCO")
				txt_data2.Focus
				Exit Sub
			ElseIf txt_data1.Text > txt_data2.Text Then
				MsgBox("A data inicial não pode ser posterior à data final", vbInformation, "ERRO NA DATA")
				txt_data1.Text = ""
				txt_data2.Text = ""
				Exit Sub
			Else
				dgv_InfoCompras.DataSource = cadCompras.RetornaCompra(txt_data1.Text, txt_data2.Text)
				
				dgv_InfoCompras.Columns(0).HeaderText = "ID"
				dgv_InfoCompras.Columns(1).HeaderText = "DATA"
				dgv_InfoCompras.Columns(2).HeaderText = "VALOR TOTAL"
				dgv_InfoCompras.Columns(3).HeaderText = "DETALHE"
				
				dgv_InfoCompras.Columns(2).DefaultCellStyle.Format = ("c2")
				
				dgv_InfoCompras.Columns(0).Width = 100
				dgv_InfoCompras.Columns(1).Width = 150
				dgv_InfoCompras.Columns(2).Width = 200
				dgv_InfoCompras.Columns(3).Width = 500
				
				ExibeValorTotal
				dgv_InfoCompras.Focus
			End If
				
	End Sub
	
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
			Me.Close
	End Sub
	
	
	
	Sub Gb_exibirEstoque_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
		If e.KeyCode = Keys.Escape Then
			dgv_Itens.Focus
		End If
	End Sub
	
	
	Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
		txt_data2.Text = dateTimePicker2.Text
	End Sub
	
	
	Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
		txt_data1.Text = dateTimePicker1.Text
	End Sub
	
	
	Sub FormRelatorioCompras_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 Then
			ExibeCompras
			
		ElseIf e.KeyCode = Keys.F3 Then
			If dgv_InfoCompras.RowCount < 1 Then
				MsgBox("Escolha uma compra no painel Informações da Compra para poder exibir os intens da compra",vbInformation,"ATENÇÃO")
				Exit Sub
			Else
				compra.IdCompra = CInt(dgv_InfoCompras.SelectedCells(0).Value.ToString)
				ExibeItensCompra
				bt_imprimir.Visible = True
			End If
		End If
		
		
		If e.KeyCode = Keys.Escape Then
			If dgv_Itens.RowCount > 0 Then
				dgv_Itens.DataSource = ""
				dgv_InfoCompras.Focus
				bt_imprimir.Visible = False
			ElseIf dgv_InfoCompras.RowCount > 0 Then
				dgv_InfoCompras.DataSource = ""
				dgv_Itens.DataSource = ""
				gb_gasto.Visible = False
				bt_imprimir.Visible = False
			End If
		End If
	End Sub
	
	Sub ExibeValorTotal
		gb_gasto.Visible = True
		compra.ValorTotal = cadCompras.RetornaValorCompra(txt_data1.Text, txt_data2.Text)
		txt_gasto.Text = FormatCurrency(CStr(compra.ValorTotal),2)
	End Sub
	
	
	Sub ExibeItensCompra
		
		dgv_Itens.DataSource = cadCompras.RetornaItensCompra(CStr(compra.IdCompra))
		
		dgv_Itens.Columns(0).HeaderText = "ID COMPRA"
	    dgv_Itens.Columns(1).HeaderText = "PRODUTO"
		dgv_Itens.Columns(2).HeaderText = "FORNECEDOR"
		dgv_Itens.Columns(3).HeaderText = "QTD"
		dgv_Itens.Columns(4).HeaderText = "PREÇO CUSTO"
		dgv_Itens.Columns(5).HeaderText = "VALOR"
					
		dgv_Itens.Columns(4).DefaultCellStyle.Format = ("c2")
		dgv_Itens.Columns(5).DefaultCellStyle.Format = ("c2")
					
		dgv_Itens.Columns(0).Width = 150
		dgv_Itens.Columns(1).Width = 250
		dgv_Itens.Columns(2).Width = 250
		dgv_Itens.Columns(3).Width = 100
		dgv_Itens.Columns(4).Width = 250
					
	End Sub
	
	
	
End Class
