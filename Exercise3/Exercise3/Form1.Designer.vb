<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sumfrm
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
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.sumBtn = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(46, 12)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(100, 22)
        Me.txtFirstNum.TabIndex = 0
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Location = New System.Drawing.Point(46, 40)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(100, 22)
        Me.txtSecondNum.TabIndex = 1
        '
        'sumBtn
        '
        Me.sumBtn.Location = New System.Drawing.Point(46, 112)
        Me.sumBtn.Name = "sumBtn"
        Me.sumBtn.Size = New System.Drawing.Size(100, 32)
        Me.sumBtn.TabIndex = 2
        Me.sumBtn.Text = "Sum Numbers"
        Me.sumBtn.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(46, 68)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 22)
        Me.txtResult.TabIndex = 3
        '
        'Sumfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 189)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.sumBtn)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(222, 236)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(222, 236)
        Me.Name = "Sumfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sum Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents sumBtn As Button
    Friend WithEvents txtResult As TextBox
End Class
