Module Module1
    Structure Joueur
        Dim nom As String
        Dim score As Integer
        Dim nbPartiesJ1 As Integer
        Dim nbPartiesJ2 As Integer
        Dim cumulTemps As Integer
    End Structure

    Public numFile As Integer = FreeFile()

    Public NB_JOUEURS_MAX = 10
    Public nbJoueurs = 0
    Public tabJoueurs(NB_JOUEURS_MAX - 1) As Joueur

    Public nbCaract As Integer = 5
    Public aDeviner(nbCaract - 1) As String

    Sub Main()
        ' toutes ces informations seront stockees dans un fichier a la fermeture de l'application, puis automatiquement rechargees lors d'un prochain demarrage de l'application
        FileOpen(numFile, "FichierEnregistrement.txt", OpenMode.Input)
        Dim nbJ As Integer 'juste pour la lecture du fichier (stockage de la taille du tableau) 'ON A PAS DEFINIE LE MAIN COMME POINT DE DEPART 'NE FONCTIONNE PAS AVEC LE MAIN
        Input(numFile, nbJ)
        For cpt As Integer = 0 To nbJ - 1
            Input(numFile, tabJoueurs(cpt).nom)
            Input(numFile, tabJoueurs(cpt).score)
            Input(numFile, tabJoueurs(cpt).nbPartiesJ1)
            Input(numFile, tabJoueurs(cpt).nbPartiesJ2)
            Input(numFile, tabJoueurs(cpt).cumulTemps)
        Next
        FileClose(numFile)
        Application.Run(New FormAccueil())
    End Sub

    Public Sub ajouterJoueur(ByRef j As Joueur)
        tabJoueurs(nbJoueurs).nom = j.nom
        tabJoueurs(nbJoueurs).score = j.score
        tabJoueurs(nbJoueurs).nbPartiesJ1 = j.nbPartiesJ1
        tabJoueurs(nbJoueurs).nbPartiesJ2 = j.nbPartiesJ2
        tabJoueurs(nbJoueurs).cumulTemps = j.cumulTemps
        nbJoueurs = nbJoueurs + 1
    End Sub

    Public Function getIndiceJoueur(ByVal nom As String) As Integer
        Dim cpt As Integer
        For cpt = 0 To nbJoueurs - 1
            If tabJoueurs(cpt).nom = nom Then
                Exit For
            End If
        Next
        Return cpt
    End Function

    Public Function estPresent(ByVal nom As String)
        For i As Integer = 0 To nbJoueurs - 1
            If tabJoueurs(i).nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
