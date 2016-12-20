Public Class FormScores


    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonTriAlpha_Click(sender As Object, e As EventArgs) Handles ButtonTriAlpha.Click
        If ListBoxNomTriAlpha.Visible = False Then 'lorsqu'on reclic sur le bouton, réaffiche les listes non triées
            ListBoxNom.Visible = False
            ListBoxScore.Visible = False
            ListBoxJoueur1.Visible = False
            ListBoxJoueur2.Visible = False
            ListBoxTemps.Visible = False

            ListBoxNomTriAlpha.Visible = True
            ListBoxScoreTriAlpha.Visible = True
            ListBoxJoueur1TriAlpha.Visible = True
            ListBoxJoueur2TriAlpha.Visible = True
            ListBoxTempsTriAlpha.Visible = True

            ListBoxNomTriScore.Visible = False
            ListBoxScoreTriScore.Visible = False
            ListBoxJoueur1TriScore.Visible = False
            ListBoxJoueur2TriScore.Visible = False
            ListBoxTempsTriScore.Visible = False
        Else
            ListBoxNom.Visible = True
            ListBoxScore.Visible = True
            ListBoxJoueur1.Visible = True
            ListBoxJoueur2.Visible = True
            ListBoxTemps.Visible = True

            ListBoxNomTriAlpha.Visible = False
            ListBoxScoreTriAlpha.Visible = False
            ListBoxJoueur1TriAlpha.Visible = False
            ListBoxJoueur2TriAlpha.Visible = False
            ListBoxTempsTriAlpha.Visible = False

            ListBoxNomTriScore.Visible = False
            ListBoxScoreTriScore.Visible = False
            ListBoxJoueur1TriScore.Visible = False
            ListBoxJoueur2TriScore.Visible = False
            ListBoxTempsTriScore.Visible = False
        End If
    End Sub

    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For cpt As Integer = 0 To nbJoueurs - 1
            ComboBoxNomCherche.Items.Add(tabJoueurs(cpt).nom)
        Next

        For i As Integer = 0 To nbJoueurs - 1
            ListBoxNom.Items.Add(tabJoueurs(i).nom)
            ListBoxScore.Items.Add(tabJoueurs(i).score)
            ListBoxJoueur1.Items.Add(tabJoueurs(i).nbPartiesJ1)
            ListBoxJoueur2.Items.Add(tabJoueurs(i).nbPartiesJ2)
            ListBoxTemps.Items.Add(tabJoueurs(i).cumulTemps)
        Next

        'tri alpha
        For i As Integer = 0 To nbJoueurs - 1
            ListBoxNomTriAlpha.Items.Add(ListBoxNom.Items(i))
        Next
        ListBoxNomTriAlpha.Sorted = True

        For i As Integer = 0 To nbJoueurs - 1
            ListBoxScoreTriAlpha.Items.Add(ListBoxScore.Items(ListBoxNom.FindString(ListBoxNomTriAlpha.Items(i))).ToString) 'INVERSION SUR LE SCORE ??
            ListBoxJoueur1TriAlpha.Items.Add(ListBoxJoueur1.Items(ListBoxNom.FindString(ListBoxNomTriAlpha.Items(i))).ToString)
            ListBoxJoueur2TriAlpha.Items.Add(ListBoxJoueur2.Items(ListBoxNom.FindString(ListBoxNomTriAlpha.Items(i))).ToString)
            ListBoxTempsTriAlpha.Items.Add(ListBoxTemps.Items(ListBoxNom.FindString(ListBoxNomTriAlpha.Items(i))).ToString)
        Next

        'tri décroissant 'tri par ordre décroissant ? 'problème si deux personnes ont le même score 'peut être pas besoin d'une ListBoxScoreTriScore 
        For i As Integer = 0 To nbJoueurs - 1
            ListBoxScoreTriScore.Items.Add(ListBoxScore.Items(i))
        Next
        ListBoxScoreTriAlpha.Sorted = True

        For i As Integer = 0 To nbJoueurs - 1
            ListBoxNomTriScore.Items.Add(ListBoxNom.Items(ListBoxScore.FindString(ListBoxScoreTriScore.Items(i))).ToString)
            ListBoxJoueur1TriScore.Items.Add(ListBoxJoueur1.Items(ListBoxScore.FindString(ListBoxScoreTriScore.Items(i))).ToString)
            ListBoxJoueur2TriScore.Items.Add(ListBoxJoueur2.Items(ListBoxScore.FindString(ListBoxScoreTriScore.Items(i))).ToString)
            ListBoxTempsTriScore.Items.Add(ListBoxTemps.Items(ListBoxScore.FindString(ListBoxScoreTriScore.Items(i))).ToString)
        Next

        ListBoxNomTriAlpha.Visible = False
        ListBoxScoreTriAlpha.Visible = False
        ListBoxJoueur1TriAlpha.Visible = False
        ListBoxJoueur2TriAlpha.Visible = False
        ListBoxTempsTriAlpha.Visible = False

        ListBoxNomTriScore.Visible = False
        ListBoxScoreTriScore.Visible = False
        ListBoxJoueur1TriScore.Visible = False
        ListBoxJoueur2TriScore.Visible = False
        ListBoxTempsTriScore.Visible = False
    End Sub

    Private Sub ButtonTriScores_Click(sender As Object, e As EventArgs) Handles ButtonTriScores.Click
        If ListBoxNomTriScore.Visible = False Then
            ListBoxNom.Visible = False
            ListBoxScore.Visible = False
            ListBoxJoueur1.Visible = False
            ListBoxJoueur2.Visible = False
            ListBoxTemps.Visible = False

            ListBoxNomTriAlpha.Visible = False
            ListBoxScoreTriAlpha.Visible = False
            ListBoxJoueur1TriAlpha.Visible = False
            ListBoxJoueur2TriAlpha.Visible = False
            ListBoxTempsTriAlpha.Visible = False

            ListBoxNomTriScore.Visible = True
            ListBoxScoreTriScore.Visible = True
            ListBoxJoueur1TriScore.Visible = True
            ListBoxJoueur2TriScore.Visible = True
            ListBoxTempsTriScore.Visible = True
        Else
            ListBoxNom.Visible = True
            ListBoxScore.Visible = True
            ListBoxJoueur1.Visible = True
            ListBoxJoueur2.Visible = True
            ListBoxTemps.Visible = True

            ListBoxNomTriAlpha.Visible = False
            ListBoxScoreTriAlpha.Visible = False
            ListBoxJoueur1TriAlpha.Visible = False
            ListBoxJoueur2TriAlpha.Visible = False
            ListBoxTempsTriAlpha.Visible = False

            ListBoxNomTriScore.Visible = False
            ListBoxScoreTriScore.Visible = False
            ListBoxJoueur1TriScore.Visible = False
            ListBoxJoueur2TriScore.Visible = False
            ListBoxTempsTriScore.Visible = False
        End If
    End Sub

 
    Private Sub ButtonAfficherScore_Click(sender As Object, e As EventArgs) Handles ButtonAfficherScore.Click
        Dim nom As String
        Dim indiceJ As Integer
        nom = ComboBoxNomCherche.Text
        indiceJ = getIndiceJoueur(nom)
        MsgBox("Nom du joueur : " & nom & vbCrLf & "Score : " & tabJoueurs(indiceJ).score & vbCrLf & "Nombre parties joueur 1 : " & tabJoueurs(indiceJ).nbPartiesJ1 & vbCrLf &
               "Nombre parties joueur 2 : " & tabJoueurs(indiceJ).nbPartiesJ2 & vbCrLf & "Durée totale : " & tabJoueurs(indiceJ).cumulTemps, MsgBoxStyle.OkOnly, "Statistiques du joueur " &
               nom)
    End Sub


    Private Sub synchronisation(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxScore.SelectedIndexChanged, ListBoxJoueur1.SelectedIndexChanged,
        ListBoxJoueur2.SelectedIndexChanged, ListBoxTemps.SelectedIndexChanged, ListBoxNomTriAlpha.SelectedIndexChanged, ListBoxScoreTriAlpha.SelectedIndexChanged,
        ListBoxJoueur1TriAlpha.SelectedIndexChanged, ListBoxJoueur2TriAlpha.SelectedIndexChanged, ListBoxTempsTriAlpha.SelectedIndexChanged, ListBoxNomTriScore.SelectedIndexChanged,
        ListBoxScoreTriScore.SelectedIndexChanged, ListBoxJoueur1TriScore.SelectedIndexChanged, ListBoxJoueur2TriScore.SelectedIndexChanged, ListBoxTempsTriScore.SelectedIndexChanged

        ListBoxNom.SelectedIndex = sender.SelectedIndex
        ListBoxScore.SelectedIndex = sender.SelectedIndex
        ListBoxJoueur1.SelectedIndex = sender.SelectedIndex
        ListBoxJoueur2.SelectedIndex = sender.SelectedIndex
        ListBoxTemps.SelectedIndex = sender.SelectedIndex
        ListBoxNomTriAlpha.SelectedIndex = sender.SelectedIndex
        ListBoxScoreTriAlpha.SelectedIndex = sender.SelectedIndex
        ListBoxJoueur1TriAlpha.SelectedIndex = sender.SelectedIndex
        ListBoxJoueur2TriAlpha.SelectedIndex = sender.SelectedIndex
        ListBoxTempsTriAlpha.SelectedIndex = sender.SelectedIndex
        ListBoxNomTriScore.SelectedIndex = sender.SelectedIndex
        ListBoxScoreTriScore.SelectedIndex = sender.SelectedIndex
        ListBoxJoueur1TriScore.SelectedIndex = sender.SelectedIndex
        ListBoxJoueur2TriScore.SelectedIndex = sender.SelectedIndex
        ListBoxTempsTriScore.SelectedIndex = sender.SelectedIndex
    End Sub
End Class