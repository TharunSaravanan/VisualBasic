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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShowText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(249, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(296, 54)
        Me.txtName.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(273, 77)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(253, 64)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(602, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 54)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShowText
        '
        Me.lblShowText.AutoSize = True
        Me.lblShowText.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowText.Location = New System.Drawing.Point(29, 282)
        Me.lblShowText.Name = "lblShowText"
        Me.lblShowText.Size = New System.Drawing.Size(0, 45)
        Me.lblShowText.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblShowText)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblShowText As Label
End Class
