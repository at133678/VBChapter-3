<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnMinuse = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnMOD = New System.Windows.Forms.Button()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(306, 105)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(54, 46)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(484, 105)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(54, 46)
        Me.btnTimes.TabIndex = 10
        Me.btnTimes.Text = "*"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnMinuse
        '
        Me.btnMinuse.Location = New System.Drawing.Point(394, 105)
        Me.btnMinuse.Name = "btnMinuse"
        Me.btnMinuse.Size = New System.Drawing.Size(54, 46)
        Me.btnMinuse.TabIndex = 11
        Me.btnMinuse.Text = "-"
        Me.btnMinuse.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(571, 105)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(54, 46)
        Me.btnDivide.TabIndex = 12
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(412, 182)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(54, 46)
        Me.btnPower.TabIndex = 14
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnMOD
        '
        Me.btnMOD.Location = New System.Drawing.Point(484, 182)
        Me.btnMOD.Name = "btnMOD"
        Me.btnMOD.Size = New System.Drawing.Size(54, 46)
        Me.btnMOD.TabIndex = 15
        Me.btnMOD.Text = "MOD"
        Me.btnMOD.UseVisualStyleBackColor = True
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(54, 53)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(53, 13)
        Me.lblNumber1.TabIndex = 16
        Me.lblNumber1.Text = "Number 1"
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Location = New System.Drawing.Point(54, 153)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(53, 13)
        Me.lblOperation.TabIndex = 17
        Me.lblOperation.Text = "Operation"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(54, 257)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(53, 13)
        Me.lblNumber2.TabIndex = 18
        Me.lblNumber2.Text = "Number 2"
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(54, 329)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(37, 13)
        Me.Result.TabIndex = 19
        Me.Result.Text = "Result"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(306, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 35)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(484, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 35)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(412, 46)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 22
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(394, 322)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 23
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(394, 250)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 492)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.btnMOD)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMinuse)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnPlus)
        Me.Name = "Form1"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnMinuse As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnMOD As System.Windows.Forms.Button
    Friend WithEvents lblNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents lblNumber2 As System.Windows.Forms.Label
    Friend WithEvents Result As System.Windows.Forms.Label

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'This event handler preforms addition.
        'Declare a varible to hold the result.
        Dim dblResult As Double
        ' Indicate "+" as the operaton.
        lblOperation.Text = "+"
        'Add the two numbers and store the result in dblResult
        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)
        'Desplay the result.
        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
