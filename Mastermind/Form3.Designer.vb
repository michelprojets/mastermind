<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeviner
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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonGuess = New System.Windows.Forms.Button()
        Me.LabelMasterMind = New System.Windows.Forms.Label()
        Me.LabelCaracteres = New System.Windows.Forms.Label()
        Me.LabelCaracJouables = New System.Windows.Forms.Label()
        Me.LabelCodeCouleur = New System.Windows.Forms.Label()
        Me.LabelAbsent = New System.Windows.Forms.Label()
        Me.LabelPresent = New System.Windows.Forms.Label()
        Me.LabelPresentPlace = New System.Windows.Forms.Label()
        Me.LabelPrecedents = New System.Windows.Forms.Label()
        Me.LabelTrouve = New System.Windows.Forms.Label()
        Me.LabelPerdu = New System.Windows.Forms.Label()
        Me.ButtonRevanche = New System.Windows.Forms.Button()
        Me.ButtonAccueil = New System.Windows.Forms.Button()
        Me.PanelCaracteres = New System.Windows.Forms.Panel()
        Me.TextBoxCaract1 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract2 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract3 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract4 = New System.Windows.Forms.TextBox()
        Me.TextBoxCaract5 = New System.Windows.Forms.TextBox()
        Me.TimerTpsPassé = New System.Windows.Forms.Timer(Me.components)
        Me.PanelHistorique = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCaracteres.SuspendLayout()
        Me.PanelHistorique.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGuess
        '
        Me.ButtonGuess.Location = New System.Drawing.Point(470, 51)
        Me.ButtonGuess.Name = "ButtonGuess"
        Me.ButtonGuess.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuess.TabIndex = 5
        Me.ButtonGuess.Text = "Guess"
        Me.ButtonGuess.UseVisualStyleBackColor = True
        '
        'LabelMasterMind
        '
        Me.LabelMasterMind.AutoSize = True
        Me.LabelMasterMind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMasterMind.Location = New System.Drawing.Point(285, 9)
        Me.LabelMasterMind.Name = "LabelMasterMind"
        Me.LabelMasterMind.Size = New System.Drawing.Size(76, 13)
        Me.LabelMasterMind.TabIndex = 11
        Me.LabelMasterMind.Text = "Master Mind"
        '
        'LabelCaracteres
        '
        Me.LabelCaracteres.AutoSize = True
        Me.LabelCaracteres.Location = New System.Drawing.Point(419, 289)
        Me.LabelCaracteres.Name = "LabelCaracteres"
        Me.LabelCaracteres.Size = New System.Drawing.Size(57, 13)
        Me.LabelCaracteres.TabIndex = 10
        Me.LabelCaracteres.Text = "# $ £ % @"
        '
        'LabelCaracJouables
        '
        Me.LabelCaracJouables.AutoSize = True
        Me.LabelCaracJouables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaracJouables.Location = New System.Drawing.Point(419, 264)
        Me.LabelCaracJouables.Name = "LabelCaracJouables"
        Me.LabelCaracJouables.Size = New System.Drawing.Size(127, 13)
        Me.LabelCaracJouables.TabIndex = 9
        Me.LabelCaracJouables.Text = "Caractères jouables :"
        '
        'LabelCodeCouleur
        '
        Me.LabelCodeCouleur.AutoSize = True
        Me.LabelCodeCouleur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCodeCouleur.Location = New System.Drawing.Point(419, 152)
        Me.LabelCodeCouleur.Name = "LabelCodeCouleur"
        Me.LabelCodeCouleur.Size = New System.Drawing.Size(90, 13)
        Me.LabelCodeCouleur.TabIndex = 18
        Me.LabelCodeCouleur.Text = "Code couleur :"
        '
        'LabelAbsent
        '
        Me.LabelAbsent.AutoSize = True
        Me.LabelAbsent.Location = New System.Drawing.Point(428, 181)
        Me.LabelAbsent.Name = "LabelAbsent"
        Me.LabelAbsent.Size = New System.Drawing.Size(40, 13)
        Me.LabelAbsent.TabIndex = 19
        Me.LabelAbsent.Text = "Absent"
        '
        'LabelPresent
        '
        Me.LabelPresent.AutoSize = True
        Me.LabelPresent.ForeColor = System.Drawing.Color.Blue
        Me.LabelPresent.Location = New System.Drawing.Point(428, 207)
        Me.LabelPresent.Name = "LabelPresent"
        Me.LabelPresent.Size = New System.Drawing.Size(43, 13)
        Me.LabelPresent.TabIndex = 20
        Me.LabelPresent.Text = "Présent"
        '
        'LabelPresentPlace
        '
        Me.LabelPresentPlace.AutoSize = True
        Me.LabelPresentPlace.ForeColor = System.Drawing.Color.Green
        Me.LabelPresentPlace.Location = New System.Drawing.Point(428, 231)
        Me.LabelPresentPlace.Name = "LabelPresentPlace"
        Me.LabelPresentPlace.Size = New System.Drawing.Size(107, 13)
        Me.LabelPresentPlace.TabIndex = 21
        Me.LabelPresentPlace.Text = "Présent et bien placé"
        '
        'LabelPrecedents
        '
        Me.LabelPrecedents.AutoSize = True
        Me.LabelPrecedents.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecedents.Location = New System.Drawing.Point(91, 124)
        Me.LabelPrecedents.Name = "LabelPrecedents"
        Me.LabelPrecedents.Size = New System.Drawing.Size(118, 13)
        Me.LabelPrecedents.TabIndex = 22
        Me.LabelPrecedents.Text = "Précédents essais :"
        '
        'LabelTrouve
        '
        Me.LabelTrouve.AutoSize = True
        Me.LabelTrouve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTrouve.Location = New System.Drawing.Point(420, 366)
        Me.LabelTrouve.Name = "LabelTrouve"
        Me.LabelTrouve.Size = New System.Drawing.Size(55, 13)
        Me.LabelTrouve.TabIndex = 24
        Me.LabelTrouve.Text = "Trouvé !"
        Me.LabelTrouve.Visible = False
        '
        'LabelPerdu
        '
        Me.LabelPerdu.AutoSize = True
        Me.LabelPerdu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPerdu.Location = New System.Drawing.Point(421, 379)
        Me.LabelPerdu.Name = "LabelPerdu"
        Me.LabelPerdu.Size = New System.Drawing.Size(48, 13)
        Me.LabelPerdu.TabIndex = 25
        Me.LabelPerdu.Text = "Perdu !"
        Me.LabelPerdu.Visible = False
        '
        'ButtonRevanche
        '
        Me.ButtonRevanche.Location = New System.Drawing.Point(397, 502)
        Me.ButtonRevanche.Name = "ButtonRevanche"
        Me.ButtonRevanche.Size = New System.Drawing.Size(91, 32)
        Me.ButtonRevanche.TabIndex = 6
        Me.ButtonRevanche.Text = "Revanche"
        Me.ButtonRevanche.UseVisualStyleBackColor = True
        '
        'ButtonAccueil
        '
        Me.ButtonAccueil.Location = New System.Drawing.Point(495, 502)
        Me.ButtonAccueil.Name = "ButtonAccueil"
        Me.ButtonAccueil.Size = New System.Drawing.Size(88, 32)
        Me.ButtonAccueil.TabIndex = 7
        Me.ButtonAccueil.Text = "Accueil"
        Me.ButtonAccueil.UseVisualStyleBackColor = True
        '
        'PanelCaracteres
        '
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract1)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract2)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract3)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract4)
        Me.PanelCaracteres.Controls.Add(Me.TextBoxCaract5)
        Me.PanelCaracteres.Location = New System.Drawing.Point(105, 38)
        Me.PanelCaracteres.Name = "PanelCaracteres"
        Me.PanelCaracteres.Size = New System.Drawing.Size(358, 51)
        Me.PanelCaracteres.TabIndex = 29
        '
        'TextBoxCaract1
        '
        Me.TextBoxCaract1.Location = New System.Drawing.Point(12, 14)
        Me.TextBoxCaract1.MaxLength = 1
        Me.TextBoxCaract1.Name = "TextBoxCaract1"
        Me.TextBoxCaract1.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxCaract1.TabIndex = 0
        '
        'TextBoxCaract2
        '
        Me.TextBoxCaract2.Location = New System.Drawing.Point(86, 14)
        Me.TextBoxCaract2.MaxLength = 1
        Me.TextBoxCaract2.Name = "TextBoxCaract2"
        Me.TextBoxCaract2.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxCaract2.TabIndex = 1
        '
        'TextBoxCaract3
        '
        Me.TextBoxCaract3.Location = New System.Drawing.Point(157, 14)
        Me.TextBoxCaract3.MaxLength = 1
        Me.TextBoxCaract3.Name = "TextBoxCaract3"
        Me.TextBoxCaract3.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxCaract3.TabIndex = 2
        '
        'TextBoxCaract4
        '
        Me.TextBoxCaract4.Location = New System.Drawing.Point(227, 14)
        Me.TextBoxCaract4.MaxLength = 1
        Me.TextBoxCaract4.Name = "TextBoxCaract4"
        Me.TextBoxCaract4.Size = New System.Drawing.Size(51, 20)
        Me.TextBoxCaract4.TabIndex = 3
        '
        'TextBoxCaract5
        '
        Me.TextBoxCaract5.Location = New System.Drawing.Point(294, 15)
        Me.TextBoxCaract5.MaxLength = 1
        Me.TextBoxCaract5.Name = "TextBoxCaract5"
        Me.TextBoxCaract5.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxCaract5.TabIndex = 4
        '
        'TimerTpsPassé
        '
        '
        'PanelHistorique
        '
        Me.PanelHistorique.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelHistorique.Controls.Add(Me.Panel15)
        Me.PanelHistorique.Controls.Add(Me.Panel14)
        Me.PanelHistorique.Controls.Add(Me.Panel13)
        Me.PanelHistorique.Controls.Add(Me.Panel12)
        Me.PanelHistorique.Controls.Add(Me.Panel11)
        Me.PanelHistorique.Controls.Add(Me.Panel10)
        Me.PanelHistorique.Controls.Add(Me.Panel1)
        Me.PanelHistorique.Controls.Add(Me.Panel9)
        Me.PanelHistorique.Controls.Add(Me.Panel8)
        Me.PanelHistorique.Controls.Add(Me.Panel7)
        Me.PanelHistorique.Controls.Add(Me.Panel6)
        Me.PanelHistorique.Controls.Add(Me.Panel5)
        Me.PanelHistorique.Controls.Add(Me.Panel4)
        Me.PanelHistorique.Controls.Add(Me.Panel3)
        Me.PanelHistorique.Controls.Add(Me.Panel2)
        Me.PanelHistorique.Location = New System.Drawing.Point(69, 152)
        Me.PanelHistorique.Name = "PanelHistorique"
        Me.PanelHistorique.Size = New System.Drawing.Size(243, 382)
        Me.PanelHistorique.TabIndex = 30
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label71)
        Me.Panel15.Controls.Add(Me.Label72)
        Me.Panel15.Controls.Add(Me.Label73)
        Me.Panel15.Controls.Add(Me.Label74)
        Me.Panel15.Controls.Add(Me.Label75)
        Me.Panel15.Location = New System.Drawing.Point(3, 29)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(256, 23)
        Me.Panel15.TabIndex = 33
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(27, 6)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(25, 13)
        Me.Label71.TabIndex = 33
        Me.Label71.Text = "Lab"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(66, 6)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(45, 13)
        Me.Label72.TabIndex = 33
        Me.Label72.Text = "Label72"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(117, 6)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(45, 13)
        Me.Label73.TabIndex = 33
        Me.Label73.Text = "Label73"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(163, 6)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(45, 13)
        Me.Label74.TabIndex = 33
        Me.Label74.Text = "Label74"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(213, 6)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(45, 13)
        Me.Label75.TabIndex = 32
        Me.Label75.Text = "Label75"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label66)
        Me.Panel14.Controls.Add(Me.Label67)
        Me.Panel14.Controls.Add(Me.Label68)
        Me.Panel14.Controls.Add(Me.Label69)
        Me.Panel14.Controls.Add(Me.Label70)
        Me.Panel14.Location = New System.Drawing.Point(3, 52)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(256, 23)
        Me.Panel14.TabIndex = 33
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(27, 9)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(25, 13)
        Me.Label66.TabIndex = 33
        Me.Label66.Text = "Lab"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(66, 7)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(45, 13)
        Me.Label67.TabIndex = 33
        Me.Label67.Text = "Label67"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(117, 7)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(45, 13)
        Me.Label68.TabIndex = 33
        Me.Label68.Text = "Label68"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(163, 7)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(45, 13)
        Me.Label69.TabIndex = 33
        Me.Label69.Text = "Label69"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(213, 7)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(45, 13)
        Me.Label70.TabIndex = 32
        Me.Label70.Text = "Label70"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label61)
        Me.Panel13.Controls.Add(Me.Label62)
        Me.Panel13.Controls.Add(Me.Label63)
        Me.Panel13.Controls.Add(Me.Label64)
        Me.Panel13.Controls.Add(Me.Label65)
        Me.Panel13.Location = New System.Drawing.Point(3, 75)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(256, 23)
        Me.Panel13.TabIndex = 33
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(27, 8)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(25, 13)
        Me.Label61.TabIndex = 33
        Me.Label61.Text = "Lab"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(67, 8)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(45, 13)
        Me.Label62.TabIndex = 33
        Me.Label62.Text = "Label62"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(117, 8)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(45, 13)
        Me.Label63.TabIndex = 33
        Me.Label63.Text = "Label63"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(162, 8)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(45, 13)
        Me.Label64.TabIndex = 33
        Me.Label64.Text = "Label64"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(213, 8)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(45, 13)
        Me.Label65.TabIndex = 32
        Me.Label65.Text = "Label65"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label56)
        Me.Panel12.Controls.Add(Me.Label57)
        Me.Panel12.Controls.Add(Me.Label58)
        Me.Panel12.Controls.Add(Me.Label59)
        Me.Panel12.Controls.Add(Me.Label60)
        Me.Panel12.Location = New System.Drawing.Point(3, 99)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(256, 23)
        Me.Panel12.TabIndex = 33
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(27, 7)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(25, 13)
        Me.Label56.TabIndex = 33
        Me.Label56.Text = "Lab"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(66, 7)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(45, 13)
        Me.Label57.TabIndex = 33
        Me.Label57.Text = "Label57"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(117, 7)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(45, 13)
        Me.Label58.TabIndex = 33
        Me.Label58.Text = "Label58"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(163, 7)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(45, 13)
        Me.Label59.TabIndex = 33
        Me.Label59.Text = "Label59"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(213, 7)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(45, 13)
        Me.Label60.TabIndex = 32
        Me.Label60.Text = "Label60"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label51)
        Me.Panel11.Controls.Add(Me.Label52)
        Me.Panel11.Controls.Add(Me.Label53)
        Me.Panel11.Controls.Add(Me.Label54)
        Me.Panel11.Controls.Add(Me.Label55)
        Me.Panel11.Location = New System.Drawing.Point(4, 122)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(256, 23)
        Me.Panel11.TabIndex = 33
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(26, 7)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(25, 13)
        Me.Label51.TabIndex = 33
        Me.Label51.Text = "Lab"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(65, 7)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(45, 13)
        Me.Label52.TabIndex = 33
        Me.Label52.Text = "Label52"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(117, 7)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(45, 13)
        Me.Label53.TabIndex = 33
        Me.Label53.Text = "Label53"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(162, 7)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(45, 13)
        Me.Label54.TabIndex = 33
        Me.Label54.Text = "Label54"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(212, 7)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(45, 13)
        Me.Label55.TabIndex = 32
        Me.Label55.Text = "Label55"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label46)
        Me.Panel10.Controls.Add(Me.Label47)
        Me.Panel10.Controls.Add(Me.Label48)
        Me.Panel10.Controls.Add(Me.Label49)
        Me.Panel10.Controls.Add(Me.Label50)
        Me.Panel10.Location = New System.Drawing.Point(4, 145)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(256, 23)
        Me.Panel10.TabIndex = 33
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(26, 7)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(25, 13)
        Me.Label46.TabIndex = 33
        Me.Label46.Text = "Lab"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(66, 7)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(45, 13)
        Me.Label47.TabIndex = 33
        Me.Label47.Text = "Label47"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(117, 7)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(45, 13)
        Me.Label48.TabIndex = 33
        Me.Label48.Text = "Label48"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(161, 7)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(45, 13)
        Me.Label49.TabIndex = 33
        Me.Label49.Text = "Label49"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(212, 7)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(45, 13)
        Me.Label50.TabIndex = 32
        Me.Label50.Text = "Label50"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Location = New System.Drawing.Point(3, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 23)
        Me.Panel1.TabIndex = 33
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(27, 7)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(25, 13)
        Me.Label41.TabIndex = 33
        Me.Label41.Text = "Lab"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(67, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(45, 13)
        Me.Label42.TabIndex = 33
        Me.Label42.Text = "Label42"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(118, 7)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(45, 13)
        Me.Label43.TabIndex = 33
        Me.Label43.Text = "Label43"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(163, 7)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(45, 13)
        Me.Label44.TabIndex = 33
        Me.Label44.Text = "Label44"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(213, 7)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(45, 13)
        Me.Label45.TabIndex = 32
        Me.Label45.Text = "Label45"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label36)
        Me.Panel9.Controls.Add(Me.Label37)
        Me.Panel9.Controls.Add(Me.Label38)
        Me.Panel9.Controls.Add(Me.Label39)
        Me.Panel9.Controls.Add(Me.Label40)
        Me.Panel9.Location = New System.Drawing.Point(4, 191)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(256, 23)
        Me.Panel9.TabIndex = 32
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(26, 7)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(25, 13)
        Me.Label36.TabIndex = 33
        Me.Label36.Text = "Lab"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(66, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(45, 13)
        Me.Label37.TabIndex = 33
        Me.Label37.Text = "Label37"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(116, 7)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(45, 13)
        Me.Label38.TabIndex = 33
        Me.Label38.Text = "Label38"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(162, 7)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(45, 13)
        Me.Label39.TabIndex = 33
        Me.Label39.Text = "Label39"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(212, 7)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(45, 13)
        Me.Label40.TabIndex = 32
        Me.Label40.Text = "Label40"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label31)
        Me.Panel8.Controls.Add(Me.Label32)
        Me.Panel8.Controls.Add(Me.Label33)
        Me.Panel8.Controls.Add(Me.Label34)
        Me.Panel8.Controls.Add(Me.Label35)
        Me.Panel8.Location = New System.Drawing.Point(3, 214)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(256, 23)
        Me.Panel8.TabIndex = 32
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(27, 7)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(25, 13)
        Me.Label31.TabIndex = 33
        Me.Label31.Text = "Lab"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(67, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 13)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "Label32"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(117, 8)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 13)
        Me.Label33.TabIndex = 33
        Me.Label33.Text = "Label33"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(162, 10)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 13)
        Me.Label34.TabIndex = 33
        Me.Label34.Text = "Label34"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(213, 10)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 13)
        Me.Label35.TabIndex = 32
        Me.Label35.Text = "Label35"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Controls.Add(Me.Label27)
        Me.Panel7.Controls.Add(Me.Label28)
        Me.Panel7.Controls.Add(Me.Label29)
        Me.Panel7.Controls.Add(Me.Label30)
        Me.Panel7.Location = New System.Drawing.Point(3, 237)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(256, 23)
        Me.Panel7.TabIndex = 32
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(27, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 13)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Lab"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(66, 7)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 13)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Label27"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(118, 7)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 13)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Label28"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(163, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Label29"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(213, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(45, 13)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Label30"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Location = New System.Drawing.Point(3, 260)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(256, 23)
        Me.Panel6.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Lab"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(67, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(118, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Label23"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(163, 7)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Label24"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(213, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Label25"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Location = New System.Drawing.Point(4, 283)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(256, 23)
        Me.Panel5.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Lab"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(66, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(117, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(162, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(212, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Label20"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Location = New System.Drawing.Point(3, 308)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(256, 23)
        Me.Panel4.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Lab"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(66, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(117, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(163, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(213, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Label15"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(4, 331)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 23)
        Me.Panel3.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Lab"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(116, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(212, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Label10"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 23)
        Me.Panel2.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Lab"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Label1"
        '
        'FormDeviner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 570)
        Me.Controls.Add(Me.PanelHistorique)
        Me.Controls.Add(Me.PanelCaracteres)
        Me.Controls.Add(Me.ButtonAccueil)
        Me.Controls.Add(Me.ButtonRevanche)
        Me.Controls.Add(Me.LabelPerdu)
        Me.Controls.Add(Me.LabelTrouve)
        Me.Controls.Add(Me.LabelPrecedents)
        Me.Controls.Add(Me.LabelPresentPlace)
        Me.Controls.Add(Me.LabelPresent)
        Me.Controls.Add(Me.LabelAbsent)
        Me.Controls.Add(Me.LabelCodeCouleur)
        Me.Controls.Add(Me.ButtonGuess)
        Me.Controls.Add(Me.LabelMasterMind)
        Me.Controls.Add(Me.LabelCaracteres)
        Me.Controls.Add(Me.LabelCaracJouables)
        Me.Name = "FormDeviner"
        Me.PanelCaracteres.ResumeLayout(False)
        Me.PanelCaracteres.PerformLayout()
        Me.PanelHistorique.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGuess As System.Windows.Forms.Button
    Friend WithEvents LabelMasterMind As System.Windows.Forms.Label
    Friend WithEvents LabelCaracteres As System.Windows.Forms.Label
    Friend WithEvents LabelCaracJouables As System.Windows.Forms.Label
    Friend WithEvents LabelCodeCouleur As System.Windows.Forms.Label
    Friend WithEvents LabelAbsent As System.Windows.Forms.Label
    Friend WithEvents LabelPresent As System.Windows.Forms.Label
    Friend WithEvents LabelPresentPlace As System.Windows.Forms.Label
    Friend WithEvents LabelPrecedents As System.Windows.Forms.Label
    Friend WithEvents LabelTrouve As System.Windows.Forms.Label
    Friend WithEvents LabelPerdu As System.Windows.Forms.Label
    Friend WithEvents ButtonRevanche As System.Windows.Forms.Button
    Friend WithEvents ButtonAccueil As System.Windows.Forms.Button
    Friend WithEvents PanelCaracteres As System.Windows.Forms.Panel
    Friend WithEvents TextBoxCaract5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCaract1 As System.Windows.Forms.TextBox
    Friend WithEvents TimerTpsPassé As System.Windows.Forms.Timer
    Friend WithEvents PanelHistorique As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
End Class
