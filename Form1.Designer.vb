<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Calc = New Button()
        kilobytes = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        sTsime = New TextBox()
        SuspendLayout()
        ' 
        ' Calc
        ' 
        Calc.Location = New Point(344, 349)
        Calc.Name = "Calc"
        Calc.Size = New Size(112, 89)
        Calc.TabIndex = 0
        Calc.Text = "Calculate"
        Calc.UseVisualStyleBackColor = True
        ' 
        ' kilobytes
        ' 
        kilobytes.Location = New Point(182, 43)
        kilobytes.Name = "kilobytes"
        kilobytes.Size = New Size(150, 31)
        kilobytes.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 2
        Label1.Text = "Data(In Kilobytes):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 25)
        Label2.TabIndex = 4
        Label2.Text = "Time(In seconds):"
        ' 
        ' sTsime
        ' 
        sTsime.Location = New Point(182, 74)
        sTsime.Name = "sTsime"
        sTsime.Size = New Size(150, 31)
        sTsime.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(sTsime)
        Controls.Add(Label1)
        Controls.Add(kilobytes)
        Controls.Add(Calc)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Calc As Button
    Friend WithEvents kilobytes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sTsime As TextBox

End Class
