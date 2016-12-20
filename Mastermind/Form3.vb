Public Class FormDeviner

    Dim nbChances As Integer = 15
    Dim cptChances As Integer = 0

    Dim nbCasesValides As Integer = 0

    Dim tpsDepart As Date
    Dim tpsActuel As Date
    Dim duree As Integer
    Dim minutes As Integer = -1
    'Dim minutes As Integer = 0
    Dim uneMinute As Integer = 60

    Private Sub ButtonAccueil_Click(sender As Object, e As EventArgs) Handles ButtonAccueil.Click
        Me.Hide()
        Dim f As New FormAccueil()
        f.Show()
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To nbChances - 1
            PanelHistorique.Controls(i).Hide()
        Next

        TimerTpsPassé.Interval = 3000
        TimerTpsPassé.Start()
        tpsDepart = TimeOfDay
        TimerTpsPassé_Tick(sender, e)

    End Sub

    Private Sub ButtonGuess_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        If TextBoxCaract1.Text = "" Or TextBoxCaract2.Text = "" Or TextBoxCaract3.Text = "" Or TextBoxCaract4.Text = "" Or
            TextBoxCaract5.Text = "" Then
            MsgBox("Ne pas laisser de trou !", MsgBoxStyle.OkOnly, "Attention")
            Exit Sub
        End If

        cptChances = cptChances + 1

        For i As Integer = 0 To nbCaract - 1
            PanelCaracteres.Controls(i).BackColor = Color.White
        Next

        For i As Integer = 0 To nbCaract - 1
            For j As Integer = 0 To nbCaract - 1
                If PanelCaracteres.Controls(i).Text = Module1.aDeviner(j) Then
                    If i = j Then
                        PanelCaracteres.Controls(i).BackColor = Color.Green
                        nbCasesValides = nbCasesValides + 1
                        Exit For
                    Else
                        PanelCaracteres.Controls(i).BackColor = Color.Blue
                    End If
                End If
            Next
        Next

        For i As Integer = 0 To nbCaract - 1
            PanelHistorique.Controls(cptChances - 1).Controls(i).ForeColor = PanelCaracteres.Controls(i).BackColor
            PanelHistorique.Controls(cptChances - 1).Controls(i).Text = PanelCaracteres.Controls(i).Text
            PanelHistorique.Controls(cptChances - 1).Show()
        Next

        If cptChances = nbChances And nbCasesValides <> nbCaract Then
            TimerTpsPassé.Stop()
            LabelPerdu.Visible = True
            ButtonGuess.Visible = False 'il ne peut plus clic sur le bouton Guess
            Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).score = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).score + 1
            Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).nbPartiesJ1 = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).nbPartiesJ1 + 1
            Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).nbPartiesJ2 = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).nbPartiesJ2 + 1
        Else
            If cptChances <= nbChances And nbCasesValides = nbCaract Then
                TimerTpsPassé_Tick(sender, e)
                TimerTpsPassé.Stop()
                Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).cumulTemps = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).cumulTemps + (minutes * uneMinute) + duree
                LabelTrouve.Visible = True
                ButtonGuess.Visible = False
                Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).score = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).score + 1
                Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).nbPartiesJ1 = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur1.Text)).nbPartiesJ1 + 1
                Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).nbPartiesJ2 = Module1.tabJoueurs(getIndiceJoueur(FormAccueil.ComboBoxJoueur2.Text)).nbPartiesJ2 + 1
            End If
        End If

        Me.Text = "Il vous reste " & nbChances - cptChances & " coup(s)..." & "   /   Vous avez passé : " & minutes & " minute(s) et " & duree & " seconde(s)"
        nbCasesValides = 0
    End Sub

    Private Sub ButtonRevanche_Click(sender As Object, e As EventArgs) Handles ButtonRevanche.Click
        Me.Hide()
        Dim f As New FormAccueil() 'problème instanciation
        f.ComboBoxJoueur1.Text = FormAccueil.ComboBoxJoueur2.Text
        f.ComboBoxJoueur2.Text = FormAccueil.ComboBoxJoueur1.Text
        f.Show()
    End Sub


    Private Sub TimerTpsPassé_Tick(sender As Object, e As EventArgs) Handles TimerTpsPassé.Tick
        tpsActuel = TimeOfDay
        duree = (tpsActuel - tpsDepart).Seconds 'Date-Date renvoie un TimeSPan
        If duree = 0 Then
            minutes = minutes + 1
        End If
        Me.Text = "Il vous reste " & nbChances - cptChances & " coup(s)..." & "   /   Vous avez passé : " & minutes & " minute(s) et " & duree & " seconde(s)"
    End Sub

End Class