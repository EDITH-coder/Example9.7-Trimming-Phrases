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
        Button1 = New Button()
        TextTrim = New TextBox()
        Label1 = New Label()
        btnTrimR = New Button()
        btnTrimL = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.Location = New Point(41, 235)
        Button1.Margin = New Padding(5, 3, 5, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 56)
        Button1.TabIndex = 0
        Button1.Text = "Trim"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextTrim
        ' 
        TextTrim.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        TextTrim.Location = New Point(248, 93)
        TextTrim.Margin = New Padding(5, 3, 5, 3)
        TextTrim.Name = "TextTrim"
        TextTrim.Size = New Size(229, 23)
        TextTrim.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 93)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 16)
        Label1.TabIndex = 2
        Label1.Text = "Trim Results"
        ' 
        ' btnTrimR
        ' 
        btnTrimR.BackColor = Color.Green
        btnTrimR.Location = New Point(248, 235)
        btnTrimR.Margin = New Padding(5, 3, 5, 3)
        btnTrimR.Name = "btnTrimR"
        btnTrimR.Size = New Size(188, 56)
        btnTrimR.TabIndex = 3
        btnTrimR.Text = "Trim Right"
        btnTrimR.UseVisualStyleBackColor = False
        ' 
        ' btnTrimL
        ' 
        btnTrimL.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnTrimL.Location = New Point(465, 235)
        btnTrimL.Margin = New Padding(5, 3, 5, 3)
        btnTrimL.Name = "btnTrimL"
        btnTrimL.Size = New Size(170, 56)
        btnTrimL.TabIndex = 4
        btnTrimL.Text = "Trim Left"
        btnTrimL.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(376, 36)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 16)
        Label2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(339, 31)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 16)
        Label3.TabIndex = 6
        Label3.Text = "Trimming Phrases"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(1159, 480)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnTrimL)
        Controls.Add(btnTrimR)
        Controls.Add(Label1)
        Controls.Add(TextTrim)
        Controls.Add(Button1)
        Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.White
        Margin = New Padding(5, 3, 5, 3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextTrim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTrimR As Button
    Friend WithEvents btnTrimL As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
