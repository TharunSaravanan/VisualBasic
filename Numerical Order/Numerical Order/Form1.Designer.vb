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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.rtMain = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 500)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(1043, 53)
        Me.lblAnswer.TabIndex = 0
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(12, 12)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(1043, 46)
        Me.txtNumbers.TabIndex = 1
        Me.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(70, 109)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(215, 83)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'rtMain
        '
        Me.rtMain.Location = New System.Drawing.Point(541, 109)
        Me.rtMain.Name = "rtMain"
        Me.rtMain.Size = New System.Drawing.Size(206, 174)
        Me.rtMain.TabIndex = 3
        Me.rtMain.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 40.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 605)
        Me.Controls.Add(Me.rtMain)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtNumbers)
        Me.Controls.Add(Me.lblAnswer)
        Me.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "Form1"
        Me.Text = "Number Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents rtMain As RichTextBox
End Class
