'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 31/3/2014
' Hora: 13:21
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
Public Partial Class FormRelatoriosSinteticoVendas	
Dim cadpdv As New CadPDV	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		'
		'
	End Sub
	
	Sub Bt_CalcularClick(sender As Object, e As EventArgs)
		vALIDACAO_TXT
		
	End Sub
	
	
	
	
	Sub DateTimePicker1ValueChanged(sender As Object, e As EventArgs)
		txt_DataInicial.Text = dateTimePicker1.Text
	End Sub
	
	Sub DateTimePicker2ValueChanged(sender As Object, e As EventArgs)
		txt_DataFinal.Text = dateTimePicker2.Text
	End Sub
	
	Private Sub vALIDACAO_TXT
		If txt_DataInicial.Text = "" Then
			MsgBox("O campo Data inicial não pode ficar em branco.",vbOKOnly,"ATENÇÃO")
			txt_DataInicial.Focus
		ElseIf txt_DataFinal.Text = "" Then
			MsgBox("O campo Data Final não pode ficar em branco.",vbOKOnly,"ATENÇÃO")
		Else
			Dim filtro As String = " where vendas.datavenda between " + "'" + txt_DataInicial.Text +  "'" + " and '" + txt_DataFinal.Text + "'"		
			dgv_vendas.DataSource = cadpdv.RetornaValorGasto(filtro)
			
			'           0                1                      2                      3                    4                5             6
			' vendas.idVendas, vendas.DataVenda, itemvendas.idProduto, itemvendas.idFornecedor, itemvendas.QTD, prod_for.PrecoCusto,  ValorGasto
			
			Dim linha As Integer = 0
			Dim valorGasto As Double = 0
			Dim valorRecebido As Double = 0
			Dim lucro As Double = 0		
			
			dgv_vendas.Columns(6).DefaultCellStyle.Format = "c2"

			While linha <= dgv_vendas.rowcount - 1		
				valorGasto += Cdbl(dgv_vendas.item(6,linha).value)
				linha +=1
			End While
			
			filtro = "SELECT sum(valortotal) FROM 7gfrota.vendas where aberta = false and datavenda between " + "'" + txt_DataInicial.Text +  "'" + " and '" + txt_DataFinal.Text + "'"
			valorRecebido = cadpdv.RetornaDouble(filtro)
			lucro = valorRecebido - valorGasto
			
			lbl_lucro.Visible = True
			lbl_gasto.Visible = True
			lbl_recebido.Visible = True
			
			
			lbl_gasto.Text = CStr(FormatCurrency((valorGasto),2))
			lbl_recebido.Text = CStr(FormatCurrency((valorRecebido),2))
			lbl_lucro.Text = CStr(FormatCurrency(lucro,2))
		End If
	End Sub
	

	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
End Class
