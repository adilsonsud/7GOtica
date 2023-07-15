'
' Criado por SharpDevelop.
' Usuário: adilson
' Data: 2015-11-14
' Hora: 18:08
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Partial Class FormCreditos
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	
	End Sub
	
	
	
	Sub FormCreditosShown(sender As Object, e As EventArgs)
		txt_infromacao.HideSelection = True
		bt_fechar.Focus
	End Sub
End Class
