Public Class frmPSTest
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLeftClick As System.Windows.Forms.Button
    Friend WithEvents btnRightClick As System.Windows.Forms.Button
    Friend WithEvents picTestBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMouseCoord As System.Windows.Forms.Label
    Friend WithEvents txtXpos As System.Windows.Forms.TextBox
    Friend WithEvents txtYpos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPSTest))
        Me.picTestBox = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnLeftClick = New System.Windows.Forms.Button
        Me.btnRightClick = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblMouseCoord = New System.Windows.Forms.Label
        Me.txtXpos = New System.Windows.Forms.TextBox
        Me.txtYpos = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picTestBox
        '
        Me.picTestBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTestBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picTestBox.Location = New System.Drawing.Point(8, 16)
        Me.picTestBox.Name = "picTestBox"
        Me.picTestBox.Size = New System.Drawing.Size(496, 280)
        Me.picTestBox.TabIndex = 1
        Me.picTestBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "F1 - Restart"
        '
        'btnLeftClick
        '
        Me.btnLeftClick.Location = New System.Drawing.Point(16, 312)
        Me.btnLeftClick.Name = "btnLeftClick"
        Me.btnLeftClick.Size = New System.Drawing.Size(75, 40)
        Me.btnLeftClick.TabIndex = 3
        Me.btnLeftClick.Text = "LEFT CLICK"
        '
        'btnRightClick
        '
        Me.btnRightClick.Location = New System.Drawing.Point(112, 312)
        Me.btnRightClick.Name = "btnRightClick"
        Me.btnRightClick.Size = New System.Drawing.Size(75, 40)
        Me.btnRightClick.TabIndex = 4
        Me.btnRightClick.Text = "RIGHT CLICK"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(424, 344)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "F10 - Exit"
        '
        'lblMouseCoord
        '
        Me.lblMouseCoord.AutoSize = True
        Me.lblMouseCoord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMouseCoord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMouseCoord.Location = New System.Drawing.Point(8, 8)
        Me.lblMouseCoord.Name = "lblMouseCoord"
        Me.lblMouseCoord.Size = New System.Drawing.Size(123, 21)
        Me.lblMouseCoord.TabIndex = 7
        Me.lblMouseCoord.Text = "Mouse Coordinates"
        Me.lblMouseCoord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtXpos
        '
        Me.txtXpos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtXpos.Location = New System.Drawing.Point(32, 32)
        Me.txtXpos.Name = "txtXpos"
        Me.txtXpos.Size = New System.Drawing.Size(32, 20)
        Me.txtXpos.TabIndex = 8
        Me.txtXpos.Text = ""
        Me.txtXpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYpos
        '
        Me.txtYpos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtYpos.Location = New System.Drawing.Point(96, 32)
        Me.txtYpos.Name = "txtYpos"
        Me.txtYpos.Size = New System.Drawing.Size(32, 20)
        Me.txtYpos.TabIndex = 9
        Me.txtYpos.Text = ""
        Me.txtYpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Y:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "X:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblMouseCoord)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtXpos)
        Me.Panel1.Controls.Add(Me.txtYpos)
        Me.Panel1.Location = New System.Drawing.Point(200, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 64)
        Me.Panel1.TabIndex = 12
        '
        'frmPSTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 382)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRightClick)
        Me.Controls.Add(Me.btnLeftClick)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picTestBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPSTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unicomp PS Test"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bit As New Bitmap(1000, 1000)
    Private g As Graphics = Graphics.FromImage(bit)
    Private br As New Pen(Color.Red)
    Private dwn As Boolean
    Private lst As Point
    Private firstrun As Boolean = True
    Private bTestMode As Boolean = False
    Private iLastPosX, iLastPosY As Integer

    Private bDrawingMode As Boolean


    Private Sub picTestBox_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTestBox.MouseMove
        Dim s As Integer
        Dim xy As Point
        Dim br2 As New SolidBrush(Color.Black)

        If bDrawingMode Then
            'If dwn = True Then

            s = 1
            br.Color = Color.Black
            br.Width = 1
            xy.X = e.X
            xy.Y = e.Y
            'iLastPosX = lst.X
            'iLastPosY = xy.Y
            If firstrun = True Then
                lst = xy
                firstrun = False
            End If
            g.FillEllipse(br2, xy.X - CLng(s / 2), xy.Y - CLng(s / 2), s, s)
            g.DrawLine(br, lst, xy)
            lst = xy
            picTestBox.Image = bit
        End If

        txtXpos.Text = xy.X
        txtYpos.Text = xy.Y
    End Sub


    Protected Overrides Function ProcessDialogKey(ByVal keydata As System.Windows.Forms.Keys) As Boolean
        Dim key As System.Windows.Forms.Keys = keydata


        Select Case key
            Case Keys.F1
                Call Clear()
            Case Keys.F10
                Call ExitAndClose()
        End Select

        'If key = Keys.F10 Then
        '    'If txtBoxBigTLI.Focused Then
        '    '    'Call ProcessBoxInput()
        '    '    keydata = Keys.Tab
        '    'End If
        '    'If txtPRTSerial.Focused Then
        '    '    'Call ProcessPrinterInput()
        '    '    keydata = Keys.Tab
        '    'End If
        '    MsgBox("EXIT")
        'End If


        Return MyBase.ProcessDialogKey(keydata)
    End Function

    Private Sub Clear()
        btnRightClick.Text = "RIGHT CLICK"
        btnRightClick.BackColor = Color.White
        btnLeftClick.Text = "LEFT CLICK"
        btnLeftClick.BackColor = Color.White

        Cursor.Position = New Point(frmPSTest.ActiveForm.Location.X + 296, frmPSTest.ActiveForm.Location.Y + 226)

        g.Clear(Color.Empty)
        picTestBox.Refresh()
        picTestBox.Refresh()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Clear()
    End Sub

    'Private Sub picTestBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTestBox.MouseLeave
    '    'firstrun = True
    '    'MsgBox(Cursor.Position.Y)
    '    'MousePosition.X = 935

    '    If bDrawingMode Then

    '        If Cursor.Position.X >= frmPSTest.ActiveForm.Location.X + 600 Then
    '            Cursor.Position = New Point(frmPSTest.ActiveForm.Location.X + 600, Cursor.Position.Y)
    '        End If

    '        If Cursor.Position.X <= frmPSTest.ActiveForm.Location.X + 14 Then
    '            Cursor.Position = New Point(frmPSTest.ActiveForm.Location.X + 15, Cursor.Position.Y)
    '        End If

    '        If Cursor.Position.Y <= frmPSTest.ActiveForm.Location.Y + 50 Then
    '            Cursor.Position = New Point(Cursor.Position.X, frmPSTest.ActiveForm.Location.Y + 50)
    '        End If

    '        If Cursor.Position.Y >= frmPSTest.ActiveForm.Location.Y + 395 Then
    '            Cursor.Position = New Point(Cursor.Position.X, frmPSTest.ActiveForm.Location.Y + 395)
    '        End If
    '    End If
    '    '  Console.WriteLine(Cursor.Position.Y & vbTab & frmPSTest.ActiveForm.Location.Y)
    'End Sub

    Private Sub frmPSTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bDrawingMode = True
    End Sub

    Private Sub btnLeftClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeftClick.Click
        Console.WriteLine(frmPSTest.ActiveForm.Location.X)
    End Sub

    Private Sub picTestBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTestBox.MouseDown
        bDrawingMode = False

        If e.Button = MouseButtons.Right Then
            Console.WriteLine("RIGHT")

            btnRightClick.BackColor = Color.Red
            btnRightClick.Text = "DOWN"
        End If

        If e.Button = MouseButtons.Left Then
            Console.WriteLine("LEFT")
            btnLeftClick.BackColor = Color.Red
            btnLeftClick.Text = "DOWN"
        End If

        bDrawingMode = True
    End Sub

    Private Sub picTestBox_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTestBox.MouseUp
        bDrawingMode = False

        If e.Button = MouseButtons.Right Then
            Console.WriteLine("RIGHT UP")
            btnRightClick.BackColor = Color.LimeGreen
            btnRightClick.Text = "RIGHT PASS"
        End If

        If e.Button = MouseButtons.Left Then
            Console.WriteLine("LEFT UP")
            btnLeftClick.BackColor = Color.LimeGreen
            btnLeftClick.Text = "LEFT PASS"
        End If

        bDrawingMode = True
    End Sub

    Private Sub ExitAndClose()
        Me.Close()
    End Sub

    Private Sub txtYpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYpos.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtXpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtXpos.KeyPress
        e.Handled = True
    End Sub

    Private Sub picTestBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTestBox.Click

    End Sub
End Class
