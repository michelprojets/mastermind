Public Class FormCacher


    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).nom = FormAccueil.ComboBoxJoueur1.Text
        tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).nom = FormAccueil.ComboBoxJoueur2.Text

    End Sub

    Private Sub TextBoxCaract1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCaract1.KeyPress, TextBoxCaract2.KeyPress,
        TextBoxCaract3.KeyPress, TextBoxCaract4.KeyPress, TextBoxCaract5.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        Else
            If e.KeyChar <> "#" And e.KeyChar <> "$" And e.KeyChar <> "£" And e.KeyChar <> "%" And e.KeyChar <> "@" Then
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        Dim valide As Boolean
        valide = True

        If TextBoxCaract1.Text = "" Or TextBoxCaract2.Text = "" Or TextBoxCaract3.Text = "" Or TextBoxCaract4.Text = "" Or
            TextBoxCaract5.Text = "" Then
            MsgBox("Ne pas laisser de trou !", MsgBoxStyle.OkOnly, "Attention")
            valide = False
        End If

        '    For cpt As Integer = 0 To nbCaract - 1
        '       For Each Textbox In PanelCaracteres.Controls
        '           Module1.aDeviner(cpt) = TextBox.Text
        '       Next
        '   Next
        For cpt As Integer = 0 To nbCaract - 1
            Module1.aDeviner(cpt) = PanelCaracteres.Controls(cpt).Text
        Next

        If valide Then
            Me.Hide()
            Dim f As New FormDeviner()
            f.Show()
        End If
    End Sub

End Class