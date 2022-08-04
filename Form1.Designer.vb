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
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.chkMay = New System.Windows.Forms.CheckBox()
      Me.SuspendLayout()
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(215, 91)
      Me.TextBox1.MaxLength = 16
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(125, 23)
      Me.TextBox1.TabIndex = 0
      Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(92, 94)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(117, 15)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "Ingrese un número #"
      '
      'TextBox2
      '
      Me.TextBox2.Location = New System.Drawing.Point(58, 130)
      Me.TextBox2.Multiline = True
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Size = New System.Drawing.Size(696, 130)
      Me.TextBox2.TabIndex = 2
      '
      'chkMay
      '
      Me.chkMay.AutoSize = True
      Me.chkMay.Location = New System.Drawing.Point(388, 93)
      Me.chkMay.Name = "chkMay"
      Me.chkMay.Size = New System.Drawing.Size(88, 19)
      Me.chkMay.TabIndex = 3
      Me.chkMay.Text = "&Mayúsculas"
      Me.chkMay.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(800, 298)
      Me.Controls.Add(Me.chkMay)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.TextBox1)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
   Friend WithEvents chkMay As CheckBox
End Class
