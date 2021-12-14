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
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.lstitems = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(91, 73)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(75, 23)
        Me.btndisplay.TabIndex = 0
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'lstitems
        '
        Me.lstitems.FormattingEnabled = True
        Me.lstitems.ItemHeight = 15
        Me.lstitems.Location = New System.Drawing.Point(442, 73)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(120, 244)
        Me.lstitems.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstitems)
        Me.Controls.Add(Me.btndisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btndisplay As Button
    Friend WithEvents lstitems As ListBox
End Class
