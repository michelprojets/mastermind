<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScores
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ButtonTriAlpha = New System.Windows.Forms.Button()
        Me.ButtonTriScores = New System.Windows.Forms.Button()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueur1 = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueur2 = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelJoueur1 = New System.Windows.Forms.Label()
        Me.LabelJoueur2 = New System.Windows.Forms.Label()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.ComboBoxNomCherche = New System.Windows.Forms.ComboBox()
        Me.LabelNomCherche = New System.Windows.Forms.Label()
        Me.ButtonAfficherScore = New System.Windows.Forms.Button()
        Me.ListBoxScoreTriAlpha = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueur1TriAlpha = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueur2TriAlpha = New System.Windows.Forms.ListBox()
        Me.ListBoxTempsTriAlpha = New System.Windows.Forms.ListBox()
        Me.ListBoxScoreTriScore = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueur1TriScore = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueur2TriScore = New System.Windows.Forms.ListBox()
        Me.ListBoxTempsTriScore = New System.Windows.Forms.ListBox()
        Me.ListBoxNomTriAlpha = New System.Windows.Forms.ListBox()
        Me.ListBoxNomTriScore = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(133, 355)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(92, 33)
        Me.ButtonRetour.TabIndex = 0
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ButtonTriAlpha
        '
        Me.ButtonTriAlpha.Location = New System.Drawing.Point(3, 342)
        Me.ButtonTriAlpha.Name = "ButtonTriAlpha"
        Me.ButtonTriAlpha.Size = New System.Drawing.Size(102, 23)
        Me.ButtonTriAlpha.TabIndex = 1
        Me.ButtonTriAlpha.Text = "Tri alphabétique"
        Me.ButtonTriAlpha.UseVisualStyleBackColor = True
        '
        'ButtonTriScores
        '
        Me.ButtonTriScores.Location = New System.Drawing.Point(252, 342)
        Me.ButtonTriScores.Name = "ButtonTriScores"
        Me.ButtonTriScores.Size = New System.Drawing.Size(102, 23)
        Me.ButtonTriScores.TabIndex = 2
        Me.ButtonTriScores.Text = "Tri scores"
        Me.ButtonTriScores.UseVisualStyleBackColor = True
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(3, 91)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(143, 238)
        Me.ListBoxNom.TabIndex = 3
        '
        'ListBoxScore
        '
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.Location = New System.Drawing.Point(152, 90)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(27, 238)
        Me.ListBoxScore.TabIndex = 4
        '
        'ListBoxJoueur1
        '
        Me.ListBoxJoueur1.FormattingEnabled = True
        Me.ListBoxJoueur1.Location = New System.Drawing.Point(185, 90)
        Me.ListBoxJoueur1.Name = "ListBoxJoueur1"
        Me.ListBoxJoueur1.Size = New System.Drawing.Size(27, 238)
        Me.ListBoxJoueur1.TabIndex = 5
        '
        'ListBoxJoueur2
        '
        Me.ListBoxJoueur2.FormattingEnabled = True
        Me.ListBoxJoueur2.Location = New System.Drawing.Point(218, 91)
        Me.ListBoxJoueur2.Name = "ListBoxJoueur2"
        Me.ListBoxJoueur2.Size = New System.Drawing.Size(26, 238)
        Me.ListBoxJoueur2.TabIndex = 6
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.Location = New System.Drawing.Point(252, 90)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(102, 238)
        Me.ListBoxTemps.TabIndex = 7
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(-1, 75)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(36, 13)
        Me.LabelNom.TabIndex = 8
        Me.LabelNom.Text = "Nom:"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScore.Location = New System.Drawing.Point(148, 74)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(44, 13)
        Me.LabelScore.TabIndex = 9
        Me.LabelScore.Text = "Score:"
        '
        'LabelJoueur1
        '
        Me.LabelJoueur1.AutoSize = True
        Me.LabelJoueur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJoueur1.Location = New System.Drawing.Point(187, 74)
        Me.LabelJoueur1.Name = "LabelJoueur1"
        Me.LabelJoueur1.Size = New System.Drawing.Size(24, 13)
        Me.LabelJoueur1.TabIndex = 10
        Me.LabelJoueur1.Text = "J1:"
        '
        'LabelJoueur2
        '
        Me.LabelJoueur2.AutoSize = True
        Me.LabelJoueur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJoueur2.Location = New System.Drawing.Point(214, 74)
        Me.LabelJoueur2.Name = "LabelJoueur2"
        Me.LabelJoueur2.Size = New System.Drawing.Size(24, 13)
        Me.LabelJoueur2.TabIndex = 11
        Me.LabelJoueur2.Text = "J2:"
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemps.Location = New System.Drawing.Point(249, 74)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(82, 13)
        Me.LabelTemps.TabIndex = 12
        Me.LabelTemps.Text = "Cumul temps:"
        '
        'ComboBoxNomCherche
        '
        Me.ComboBoxNomCherche.AllowDrop = True
        Me.ComboBoxNomCherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNomCherche.FormattingEnabled = True
        Me.ComboBoxNomCherche.Location = New System.Drawing.Point(12, 28)
        Me.ComboBoxNomCherche.Name = "ComboBoxNomCherche"
        Me.ComboBoxNomCherche.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNomCherche.TabIndex = 13
        '
        'LabelNomCherche
        '
        Me.LabelNomCherche.AutoSize = True
        Me.LabelNomCherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomCherche.Location = New System.Drawing.Point(12, 9)
        Me.LabelNomCherche.Name = "LabelNomCherche"
        Me.LabelNomCherche.Size = New System.Drawing.Size(97, 13)
        Me.LabelNomCherche.TabIndex = 14
        Me.LabelNomCherche.Text = "Nom du joueur :"
        '
        'ButtonAfficherScore
        '
        Me.ButtonAfficherScore.Location = New System.Drawing.Point(139, 26)
        Me.ButtonAfficherScore.Name = "ButtonAfficherScore"
        Me.ButtonAfficherScore.Size = New System.Drawing.Size(112, 23)
        Me.ButtonAfficherScore.TabIndex = 15
        Me.ButtonAfficherScore.Text = "Afficher son score"
        Me.ButtonAfficherScore.UseVisualStyleBackColor = True
        '
        'ListBoxScoreTriAlpha
        '
        Me.ListBoxScoreTriAlpha.FormattingEnabled = True
        Me.ListBoxScoreTriAlpha.Location = New System.Drawing.Point(152, 90)
        Me.ListBoxScoreTriAlpha.Name = "ListBoxScoreTriAlpha"
        Me.ListBoxScoreTriAlpha.Size = New System.Drawing.Size(27, 238)
        Me.ListBoxScoreTriAlpha.TabIndex = 17
        '
        'ListBoxJoueur1TriAlpha
        '
        Me.ListBoxJoueur1TriAlpha.FormattingEnabled = True
        Me.ListBoxJoueur1TriAlpha.Location = New System.Drawing.Point(185, 91)
        Me.ListBoxJoueur1TriAlpha.Name = "ListBoxJoueur1TriAlpha"
        Me.ListBoxJoueur1TriAlpha.Size = New System.Drawing.Size(27, 238)
        Me.ListBoxJoueur1TriAlpha.TabIndex = 18
        '
        'ListBoxJoueur2TriAlpha
        '
        Me.ListBoxJoueur2TriAlpha.FormattingEnabled = True
        Me.ListBoxJoueur2TriAlpha.Location = New System.Drawing.Point(218, 91)
        Me.ListBoxJoueur2TriAlpha.Name = "ListBoxJoueur2TriAlpha"
        Me.ListBoxJoueur2TriAlpha.Size = New System.Drawing.Size(26, 238)
        Me.ListBoxJoueur2TriAlpha.TabIndex = 19
        '
        'ListBoxTempsTriAlpha
        '
        Me.ListBoxTempsTriAlpha.FormattingEnabled = True
        Me.ListBoxTempsTriAlpha.Location = New System.Drawing.Point(252, 91)
        Me.ListBoxTempsTriAlpha.Name = "ListBoxTempsTriAlpha"
        Me.ListBoxTempsTriAlpha.Size = New System.Drawing.Size(102, 238)
        Me.ListBoxTempsTriAlpha.TabIndex = 20
        '
        'ListBoxScoreTriScore
        '
        Me.ListBoxScoreTriScore.FormattingEnabled = True
        Me.ListBoxScoreTriScore.Location = New System.Drawing.Point(152, 90)
        Me.ListBoxScoreTriScore.Name = "ListBoxScoreTriScore"
        Me.ListBoxScoreTriScore.Size = New System.Drawing.Size(27, 238)
        Me.ListBoxScoreTriScore.TabIndex = 22
        '
        'ListBoxJoueur1TriScore
        '
        Me.ListBoxJoueur1TriScore.FormattingEnabled = True
        Me.ListBoxJoueur1TriScore.Location = New System.Drawing.Point(185, 91)
        Me.ListBoxJoueur1TriScore.Name = "ListBoxJoueur1TriScore"
        Me.ListBoxJoueur1TriScore.Size = New System.Drawing.Size(27, 238)
        Me.ListBoxJoueur1TriScore.TabIndex = 23
        '
        'ListBoxJoueur2TriScore
        '
        Me.ListBoxJoueur2TriScore.FormattingEnabled = True
        Me.ListBoxJoueur2TriScore.Location = New System.Drawing.Point(218, 91)
        Me.ListBoxJoueur2TriScore.Name = "ListBoxJoueur2TriScore"
        Me.ListBoxJoueur2TriScore.Size = New System.Drawing.Size(26, 238)
        Me.ListBoxJoueur2TriScore.TabIndex = 24
        '
        'ListBoxTempsTriScore
        '
        Me.ListBoxTempsTriScore.FormattingEnabled = True
        Me.ListBoxTempsTriScore.Location = New System.Drawing.Point(252, 91)
        Me.ListBoxTempsTriScore.Name = "ListBoxTempsTriScore"
        Me.ListBoxTempsTriScore.Size = New System.Drawing.Size(102, 238)
        Me.ListBoxTempsTriScore.TabIndex = 25
        '
        'ListBoxNomTriAlpha
        '
        Me.ListBoxNomTriAlpha.FormattingEnabled = True
        Me.ListBoxNomTriAlpha.Location = New System.Drawing.Point(2, 90)
        Me.ListBoxNomTriAlpha.Name = "ListBoxNomTriAlpha"
        Me.ListBoxNomTriAlpha.Size = New System.Drawing.Size(143, 238)
        Me.ListBoxNomTriAlpha.TabIndex = 26
        '
        'ListBoxNomTriScore
        '
        Me.ListBoxNomTriScore.FormattingEnabled = True
        Me.ListBoxNomTriScore.Location = New System.Drawing.Point(2, 90)
        Me.ListBoxNomTriScore.Name = "ListBoxNomTriScore"
        Me.ListBoxNomTriScore.Size = New System.Drawing.Size(143, 238)
        Me.ListBoxNomTriScore.TabIndex = 27
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 400)
        Me.Controls.Add(Me.ListBoxNomTriScore)
        Me.Controls.Add(Me.ListBoxNomTriAlpha)
        Me.Controls.Add(Me.ListBoxTempsTriScore)
        Me.Controls.Add(Me.ListBoxJoueur2TriScore)
        Me.Controls.Add(Me.ListBoxJoueur1TriScore)
        Me.Controls.Add(Me.ListBoxScoreTriScore)
        Me.Controls.Add(Me.ListBoxTempsTriAlpha)
        Me.Controls.Add(Me.ListBoxJoueur2TriAlpha)
        Me.Controls.Add(Me.ListBoxJoueur1TriAlpha)
        Me.Controls.Add(Me.ListBoxScoreTriAlpha)
        Me.Controls.Add(Me.ButtonAfficherScore)
        Me.Controls.Add(Me.LabelNomCherche)
        Me.Controls.Add(Me.ComboBoxNomCherche)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.LabelJoueur2)
        Me.Controls.Add(Me.LabelJoueur1)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ListBoxTemps)
        Me.Controls.Add(Me.ListBoxJoueur2)
        Me.Controls.Add(Me.ListBoxJoueur1)
        Me.Controls.Add(Me.ListBoxScore)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.ButtonTriScores)
        Me.Controls.Add(Me.ButtonTriAlpha)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Name = "FormScores"
        Me.Text = "Tableau des scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonRetour As System.Windows.Forms.Button
    Friend WithEvents ButtonTriAlpha As System.Windows.Forms.Button
    Friend WithEvents ButtonTriScores As System.Windows.Forms.Button
    Friend WithEvents ListBoxNom As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxScore As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxJoueur1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxJoueur2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxTemps As System.Windows.Forms.ListBox
    Friend WithEvents LabelNom As System.Windows.Forms.Label
    Friend WithEvents LabelScore As System.Windows.Forms.Label
    Friend WithEvents LabelJoueur1 As System.Windows.Forms.Label
    Friend WithEvents LabelJoueur2 As System.Windows.Forms.Label
    Friend WithEvents LabelTemps As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNomCherche As System.Windows.Forms.ComboBox
    Friend WithEvents LabelNomCherche As System.Windows.Forms.Label
    Friend WithEvents ButtonAfficherScore As System.Windows.Forms.Button
    Friend WithEvents ListBoxScoreTriAlpha As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxJoueur1TriAlpha As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxJoueur2TriAlpha As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxTempsTriAlpha As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxScoreTriScore As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxJoueur1TriScore As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxJoueur2TriScore As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxTempsTriScore As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNomTriAlpha As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNomTriScore As System.Windows.Forms.ListBox
End Class
