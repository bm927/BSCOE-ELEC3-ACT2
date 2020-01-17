<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SSD))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Breadboard = New System.Windows.Forms.PictureBox()
        Me.segA = New System.Windows.Forms.Label()
        Me.segD = New System.Windows.Forms.Label()
        Me.segB = New System.Windows.Forms.Label()
        Me.segC = New System.Windows.Forms.Label()
        Me.segE = New System.Windows.Forms.Label()
        Me.segF = New System.Windows.Forms.Label()
        Me.segG = New System.Windows.Forms.Label()
        Me.Vcc = New System.Windows.Forms.Label()
        Me.WireF = New System.Windows.Forms.Label()
        Me.WireG = New System.Windows.Forms.Label()
        Me.WireA = New System.Windows.Forms.Label()
        Me.WireB = New System.Windows.Forms.Label()
        Me.WireE = New System.Windows.Forms.Label()
        Me.WireD = New System.Windows.Forms.Label()
        Me.WireC = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn = New System.Windows.Forms.Button()
        Me.num = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Breadboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(248, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 234)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Breadboard
        '
        Me.Breadboard.Image = CType(resources.GetObject("Breadboard.Image"), System.Drawing.Image)
        Me.Breadboard.Location = New System.Drawing.Point(-145, -2)
        Me.Breadboard.Name = "Breadboard"
        Me.Breadboard.Size = New System.Drawing.Size(916, 450)
        Me.Breadboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Breadboard.TabIndex = 2
        Me.Breadboard.TabStop = False
        '
        'segA
        '
        Me.segA.BackColor = System.Drawing.Color.Gray
        Me.segA.Location = New System.Drawing.Point(289, 96)
        Me.segA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segA.Name = "segA"
        Me.segA.Size = New System.Drawing.Size(80, 20)
        Me.segA.TabIndex = 1
        '
        'segD
        '
        Me.segD.BackColor = System.Drawing.Color.Gray
        Me.segD.Location = New System.Drawing.Point(289, 282)
        Me.segD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segD.Name = "segD"
        Me.segD.Size = New System.Drawing.Size(80, 20)
        Me.segD.TabIndex = 4
        '
        'segB
        '
        Me.segB.BackColor = System.Drawing.Color.Gray
        Me.segB.Location = New System.Drawing.Point(376, 115)
        Me.segB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segB.Name = "segB"
        Me.segB.Size = New System.Drawing.Size(20, 80)
        Me.segB.TabIndex = 2
        '
        'segC
        '
        Me.segC.BackColor = System.Drawing.Color.Gray
        Me.segC.Location = New System.Drawing.Point(376, 204)
        Me.segC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segC.Name = "segC"
        Me.segC.Size = New System.Drawing.Size(20, 80)
        Me.segC.TabIndex = 3
        '
        'segE
        '
        Me.segE.BackColor = System.Drawing.Color.Gray
        Me.segE.Location = New System.Drawing.Point(262, 204)
        Me.segE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segE.Name = "segE"
        Me.segE.Size = New System.Drawing.Size(20, 80)
        Me.segE.TabIndex = 5
        '
        'segF
        '
        Me.segF.BackColor = System.Drawing.Color.Gray
        Me.segF.Location = New System.Drawing.Point(262, 114)
        Me.segF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segF.Name = "segF"
        Me.segF.Size = New System.Drawing.Size(20, 80)
        Me.segF.TabIndex = 6
        '
        'segG
        '
        Me.segG.BackColor = System.Drawing.Color.Gray
        Me.segG.Location = New System.Drawing.Point(289, 187)
        Me.segG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segG.Name = "segG"
        Me.segG.Size = New System.Drawing.Size(80, 20)
        Me.segG.TabIndex = 7
        '
        'Vcc
        '
        Me.Vcc.BackColor = System.Drawing.Color.Red
        Me.Vcc.Location = New System.Drawing.Point(319, 353)
        Me.Vcc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Vcc.Name = "Vcc"
        Me.Vcc.Size = New System.Drawing.Size(14, 86)
        Me.Vcc.TabIndex = 8
        '
        'WireF
        '
        Me.WireF.BackColor = System.Drawing.Color.Black
        Me.WireF.Location = New System.Drawing.Point(288, -1)
        Me.WireF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireF.Name = "WireF"
        Me.WireF.Size = New System.Drawing.Size(12, 62)
        Me.WireF.TabIndex = 9
        '
        'WireG
        '
        Me.WireG.BackColor = System.Drawing.Color.Black
        Me.WireG.Location = New System.Drawing.Point(258, -1)
        Me.WireG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireG.Name = "WireG"
        Me.WireG.Size = New System.Drawing.Size(12, 62)
        Me.WireG.TabIndex = 10
        '
        'WireA
        '
        Me.WireA.BackColor = System.Drawing.Color.Black
        Me.WireA.Location = New System.Drawing.Point(353, -1)
        Me.WireA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireA.Name = "WireA"
        Me.WireA.Size = New System.Drawing.Size(12, 62)
        Me.WireA.TabIndex = 11
        '
        'WireB
        '
        Me.WireB.BackColor = System.Drawing.Color.Black
        Me.WireB.Location = New System.Drawing.Point(384, -1)
        Me.WireB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireB.Name = "WireB"
        Me.WireB.Size = New System.Drawing.Size(12, 62)
        Me.WireB.TabIndex = 12
        '
        'WireE
        '
        Me.WireE.BackColor = System.Drawing.Color.Black
        Me.WireE.Location = New System.Drawing.Point(258, 353)
        Me.WireE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireE.Name = "WireE"
        Me.WireE.Size = New System.Drawing.Size(12, 86)
        Me.WireE.TabIndex = 13
        '
        'WireD
        '
        Me.WireD.BackColor = System.Drawing.Color.Black
        Me.WireD.Location = New System.Drawing.Point(289, 354)
        Me.WireD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireD.Name = "WireD"
        Me.WireD.Size = New System.Drawing.Size(12, 86)
        Me.WireD.TabIndex = 14
        '
        'WireC
        '
        Me.WireC.BackColor = System.Drawing.Color.Black
        Me.WireC.Location = New System.Drawing.Point(353, 353)
        Me.WireC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WireC.Name = "WireC"
        Me.WireC.Size = New System.Drawing.Size(12, 86)
        Me.WireC.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(384, 353)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 86)
        Me.Label8.TabIndex = 16
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.Maroon
        Me.Btn.Font = New System.Drawing.Font("Gobold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn.ForeColor = System.Drawing.Color.White
        Me.Btn.Location = New System.Drawing.Point(-1, 442)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(636, 74)
        Me.Btn.TabIndex = 17
        Me.Btn.Text = "S T A R T"
        Me.Btn.UseVisualStyleBackColor = False
        '
        'num
        '
        Me.num.BackColor = System.Drawing.Color.Transparent
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(609, 217)
        Me.num.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(16, 18)
        Me.num.TabIndex = 18
        Me.num.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(468, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BMS Fortunato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(73, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "BS CpE 5-4"
        '
        'SSD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 516)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.Btn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.WireC)
        Me.Controls.Add(Me.WireD)
        Me.Controls.Add(Me.WireE)
        Me.Controls.Add(Me.WireB)
        Me.Controls.Add(Me.WireA)
        Me.Controls.Add(Me.WireG)
        Me.Controls.Add(Me.WireF)
        Me.Controls.Add(Me.Vcc)
        Me.Controls.Add(Me.segG)
        Me.Controls.Add(Me.segE)
        Me.Controls.Add(Me.segF)
        Me.Controls.Add(Me.segC)
        Me.Controls.Add(Me.segB)
        Me.Controls.Add(Me.segD)
        Me.Controls.Add(Me.segA)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Breadboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SSD"
        Me.Text = "SSD"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Breadboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Breadboard As PictureBox
    Friend WithEvents segA As Label
    Friend WithEvents segD As Label
    Friend WithEvents segB As Label
    Friend WithEvents segC As Label
    Friend WithEvents segE As Label
    Friend WithEvents segF As Label
    Friend WithEvents segG As Label
    Friend WithEvents Vcc As Label
    Friend WithEvents WireF As Label
    Friend WithEvents WireG As Label
    Friend WithEvents WireA As Label
    Friend WithEvents WireB As Label
    Friend WithEvents WireE As Label
    Friend WithEvents WireD As Label
    Friend WithEvents WireC As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn As Button
    Friend WithEvents num As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
