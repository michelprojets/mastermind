<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCacher
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
        Me.LabelCaracJouables = New System.Windows.Forms.Label()
        Me.LabelCaracteres = New System.Windows.Forms.Label()
        Me.LabelMasterMind = New System.Windows.Forms.Label()
        Me.ButtonHide = New System.Windows.Forms.Button()
        Me.PanelCaracteres = New System.Windows.Forms.Panel()
        Me.TextBoxCaract1 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract2 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract3 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract4 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract5 = New System.Windows.Forms.TextBox()
        Me.PanelCaracteres.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCaracJouables
        '
        Me.LabelCaracJouables.AutoSize = True
        Me.LabelCaracJouables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaracJouables.Location = New System.Drawing.Point(314, 97)
        Me.LabelCaracJouables.Name = "LabelCaracJouables"
        Me.LabelCaracJouables.Size = New System.Drawing.Size(127, 13)
        Me.LabelCaracJouables.TabIndex = 0
        Me.LabelCaracJouables.Text = "Caractères jouables :"
        '
        'LabelCaracteres
        '
        Me.LabelCaracteres.AutoSize = True
        Me.LabelCaracteres.Location = New System.Drawing.Point(314, 122)
        Me.LabelCaracteres.Name = "LabelCaracteres"
        Me.LabelCaracteres.Size = New System.Drawing.Size(57, 13)
        Me.LabelCaracteres.TabIndex = 1
        Me.LabelCaracteres.Text = "# $ £ % @"
        '
        'LabelMasterMind
        '
        Me.LabelMasterMind.AutoSize = True
        Me.LabelMasterMind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMasterMind.Location = New System.Drawing.Point(169, 9)
        Me.LabelMasterMind.Name = "LabelMasterMind"
        Me.LabelMasterMind.Size = New System.Drawing.Size(76, 13)
        Me.LabelMasterMind.TabIndex = 2
        Me.LabelMasterMind.Text = "Master Mind"
        '
        'ButtonHide
        '
        Me.ButtonHide.Location = New System.Drawing.Point(385, 54)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHide.TabIndex = 5
        Me.ButtonHide.Text = "Hide"
        Me.ButtonHide.UseVisualStyleBackColor = True
        '
        'PanelCaracteres
        '
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract1)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract2)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract3)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract4)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract5)
        Me.PanelCaracteres.Location = New System.Drawing.Point(12, 43)
        Me.PanelCaracteres.Name = "PanelCaracteres"
        Me.PanelCaracteres.Size = New System.Drawing.Size(358, 51)
        Me.PanelCaracteres.TabIndex = 9
        '
        'TextBoxCaract1
        '
        Me.TextBoxCaract1.Location = New System.Drawing.Point(14, 14)
        Me.TextBoxCaract1.MaxLength = 1
        Me.TextBoxCaract1.Name = "TextBoxCaract1"
        Me.TextBoxCaract1.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxCaract1.TabIndex = 0
        '
        'TextBoxCaract2
        '
        Me.TextBoxCaract2.Location = New System.Drawing.Point(84, 14)
        Me.TextBoxCaract2.MaxLength = 1
        Me.TextBoxCaract2.Name = "TextBoxCaract2"
        Me.TextBoxCaract2.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxCaract2.TabIndex = 1
        '
        'TextBoxCaract3
        '
        Me.TextBoxCaract3.Location = New System.Drawing.Point(153, 14)
        Me.TextBoxCaract3.MaxLength = 1
        Me.TextBoxCaract3.Name = "TextBoxCaract3"
        Me.TextBoxCaract3.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxCaract3.TabIndex = 2
        '
        'TextBoxCaract4
        '
        Me.TextBoxCaract4.Location = New System.Drawing.Point(223, 14)
        Me.TextBoxCaract4.MaxLength = 1
        Me.TextBoxCaract4.Name = "TextBoxCaract4"
        Me.TextBoxCaract4.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxCaract4.TabIndex = 3
        '
        'TextBoxCaract5
        '
        Me.TextBoxCaract5.Location = New System.Drawing.Point(293, 14)
        Me.TextBoxCaract5.MaxLength = 1
        Me.TextBoxCaract5.Name = "TextBoxCaract5"
        Me.TextBoxCaract5.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxCaract5.TabIndex = 4
        '
        'FormCacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 160)
        Me.Controls.Add(Me.PanelCaracteres)
        Me.Controls.Add(Me.ButtonHide)
        Me.Controls.Add(Me.LabelMasterMind)
        Me.Controls.Add(Me.LabelCaracteres)
        Me.Controls.Add(Me.LabelCaracJouables)
        Me.Name = "FormCacher"
        Me.Text = "Pattern à deviner"
        Me.PanelCaracteres.ResumeLayout(False)
        Me.PanelCaracteres.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCaracJouables As System.Windows.Forms.Label
    Friend WithEvents LabelCaracteres As System.Windows.Forms.Label
    Friend WithEvents LabelMasterMind As System.Windows.Forms.Label
    Friend WithEvents ButtonHide As System.Windows.Forms.Button
    Friend WithEvents PanelCaracteres As System.Windows.Forms.Panel
    Friend WithEvents TextBoxCaract1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract5 As System.Windows.Forms.TextBox
End Class
