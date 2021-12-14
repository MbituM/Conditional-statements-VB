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
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbloutput
        '
        Me.lbloutput.AutoSize = True
        Me.lbloutput.Location = New System.Drawing.Point(341, 83)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(41, 15)
        Me.lbloutput.TabIndex = 0
        Me.lbloutput.Text = "Label1"
        '
        'btnmultiply
        '
        Me.btnmultiply.Location = New System.Drawing.Point(108, 75)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnmultiply.TabIndex = 1
        Me.btnmultiply.Text = "multiply"
        Me.btnmultiply.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.lbloutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbloutput As Label
    Friend WithEvents btnmultiply As Button
End Class
