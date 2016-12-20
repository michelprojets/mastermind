Public Class FormAccueil

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim res As Integer
        res = MsgBox("Voulez-vous arreter l'application ?", MsgBoxStyle.YesNo, "Avertissement")
        If res = vbYes Then
            FileOpen(numFile, "FichierEnregistrement.txt", OpenMode.Output)
            Write(numFile, nbJoueurs)
            For cpt As Integer = 0 To nbJoueurs - 1
                Write(numFile, tabJoueurs(cpt).nom)
                Write(numFile, tabJoueurs(cpt).score)
                Write(numFile, tabJoueurs(cpt).nbPartiesJ1)
                Write(numFile, tabJoueurs(cpt).nbPartiesJ2)
                Write(numFile, tabJoueurs(cpt).cumulTemps)
            Next
            FileClose(numFile)
                Close()
        End If
    End Sub

    Private Sub ButtonLancer_Click(sender As Object, e As EventArgs) Handles ButtonLancer.Click
        Dim valide As Boolean
        valide = True
        If ComboBoxJoueur1.Text = "" Or ComboBoxJoueur2.Text = "" Then
            MsgBox("Saisir deux noms !", MsgBoxStyle.OkOnly, "Attention")
            LabelJoueur1.BackColor = Color.Red
            LabelJoueur2.BackColor = Color.Red
            valide = False
        Else
            If ComboBoxJoueur1.Text = ComboBoxJoueur2.Text Then
                MsgBox("Les deux joueurs doivent être différents !", MsgBoxStyle.OkOnly, "Attention")
                LabelJoueur1.BackColor = Color.Red
                LabelJoueur2.BackColor = Color.Red
                ComboBoxJoueur1.Text = ""
                ComboBoxJoueur2.Text = ""
                valide = False
            Else
                LabelJoueur1.BackColor = LabelJoueur1.Tag()
                LabelJoueur2.BackColor = LabelJoueur2.Tag()
            End If
        End If

        If valide Then
            ComboBoxJoueur1.Items.Add(ComboBoxJoueur1.Text)
            ComboBoxJoueur2.Items.Add(ComboBoxJoueur2.Text)
            If (estPresent(ComboBoxJoueur1.Text) = False) Then
                tabJoueurs(nbJoueurs) = New Joueur()
                tabJoueurs(nbJoueurs).nom = ComboBoxJoueur1.Text
                nbJoueurs = nbJoueurs + 1
            End If
            If (estPresent(ComboBoxJoueur2.Text) = False) Then
                tabJoueurs(nbJoueurs) = New Joueur()
                tabJoueurs(nbJoueurs).nom = ComboBoxJoueur2.Text
                nbJoueurs = nbJoueurs + 1
            End If
            Me.Hide()
            Dim f As New FormCacher()
            f.Show()
        End If
    End Sub

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelJoueur1.Tag() = LabelJoueur1.BackColor
        LabelJoueur2.Tag() = LabelJoueur2.BackColor

        For cpt As Integer = 0 To nbJoueurs - 1
            ComboBoxJoueur1.Items.Add(tabJoueurs(cpt).nom)
            ComboBoxJoueur2.Items.Add(tabJoueurs(cpt).nom)
        Next
    End Sub

    Private Sub ButtonScores_Click(sender As Object, e As EventArgs) Handles ButtonScores.Click
        Me.Hide()
        Dim f As New FormScores()
        f.Show()
    End Sub
End Class
