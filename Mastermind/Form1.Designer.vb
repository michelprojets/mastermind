<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.ComboBoxJoueur1 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxJoueur2 = New System.Windows.Forms.ComboBox()
        Me.LabelJoueur1 = New System.Windows.Forms.Label()
        Me.LabelJoueur2 = New System.Windows.Forms.Label()
        Me.ButtonLancer = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxJoueur1
        '
        Me.ComboBoxJoueur1.AllowDrop = True
        Me.ComboBoxJoueur1.FormattingEnabled = True
        Me.ComboBoxJoueur1.Location = New System.Drawing.Point(24, 45)
        Me.ComboBoxJoueur1.Name = "ComboBoxJoueur1"
        Me.ComboBoxJoueur1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxJoueur1.TabIndex = 0
        '
        'ComboBoxJoueur2
        '
        Me.ComboBoxJoueur2.AllowDrop = True
        Me.ComboBoxJoueur2.FormattingEnabled = True
        Me.ComboBoxJoueur2.Location = New System.Drawing.Point(195, 45)
        Me.ComboBoxJoueur2.Name = "ComboBoxJoueur2"
        Me.ComboBoxJoueur2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxJoueur2.TabIndex = 1
        '
        'LabelJoueur1
        '
        Me.LabelJoueur1.AutoSize = True
        Me.LabelJoueur1.Location = New System.Drawing.Point(24, 26)
        Me.LabelJoueur1.Name = "LabelJoueur1"
        Me.LabelJoueur1.Size = New System.Drawing.Size(54, 13)
        Me.LabelJoueur1.TabIndex = 2
        Me.LabelJoueur1.Text = "Joueur 1 :"
        '
        'LabelJoueur2
        '
        Me.LabelJoueur2.AutoSize = True
        Me.LabelJoueur2.Location = New System.Drawing.Point(195, 26)
        Me.LabelJoueur2.Name = "LabelJoueur2"
        Me.LabelJoueur2.Size = New System.Drawing.Size(54, 13)
        Me.LabelJoueur2.TabIndex = 3
        Me.LabelJoueur2.Text = "Joueur 2 :"
        '
        'ButtonLancer
        '
        Me.ButtonLancer.Location = New System.Drawing.Point(227, 173)
        Me.ButtonLancer.Name = "ButtonLancer"
        Me.ButtonLancer.Size = New System.Drawing.Size(89, 33)
        Me.ButtonLancer.TabIndex = 4
        Me.ButtonLancer.Text = "Lancer"
        Me.ButtonLancer.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(24, 173)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(84, 33)
        Me.ButtonQuitter.TabIndex = 5
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonScores
        '
        Me.ButtonScores.Location = New System.Drawing.Point(121, 106)
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.Size = New System.Drawing.Size(95, 41)
        Me.ButtonScores.TabIndex = 6
        Me.ButtonScores.Text = "Tableau des scores"
        Me.ButtonScores.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 222)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonLancer)
        Me.Controls.Add(Me.LabelJoueur2)
        Me.Controls.Add(Me.LabelJoueur1)
        Me.Controls.Add(Me.ComboBoxJoueur2)
        Me.Controls.Add(Me.ComboBoxJoueur1)
        Me.Name = "FormAccueil"
        Me.Text = "Bienvenu sur le jeu !"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxJoueur1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxJoueur2 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelJoueur1 As System.Windows.Forms.Label
    Friend WithEvents LabelJoueur2 As System.Windows.Forms.Label
    Friend WithEvents ButtonLancer As System.Windows.Forms.Button
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents ButtonScores As System.Windows.Forms.Button

End Class
