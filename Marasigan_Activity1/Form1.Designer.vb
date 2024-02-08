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
        txtFirstnum = New TextBox()
        Label1 = New Label()
        txtSecondnum = New TextBox()
        Label2 = New Label()
        btnAdd = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(124, 36)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(120, 23)
        txtFirstnum.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 1
        Label1.Text = "First Number:"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(124, 71)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(120, 23)
        txtSecondnum.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second Number:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(145, 111)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(167, 147)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(31, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Sum"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 294)
        Controls.Add(lblResult)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(txtSecondnum)
        Controls.Add(Label1)
        Controls.Add(txtFirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblResult As Label
End Class
