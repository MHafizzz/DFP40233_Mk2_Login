<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class webForm
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
        lblId = New Label()
        lblPass = New Label()
        txtId = New TextBox()
        txtPass = New TextBox()
        BtnLogin = New Button()
        lblLogmasuk = New Label()
        SuspendLayout()
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(12, 74)
        lblId.Name = "lblId"
        lblId.Size = New Size(75, 15)
        lblId.TabIndex = 1
        lblId.Text = "ID Pengguna"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(12, 119)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(68, 15)
        lblPass.TabIndex = 2
        lblPass.Text = "Kata Laluan"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(110, 71)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(110, 116)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(100, 23)
        txtPass.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(75, 150)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblLogmasuk
        ' 
        lblLogmasuk.AutoSize = True
        lblLogmasuk.Location = New Point(76, 29)
        lblLogmasuk.Name = "lblLogmasuk"
        lblLogmasuk.Size = New Size(73, 15)
        lblLogmasuk.TabIndex = 6
        lblLogmasuk.Text = "LOG MASUK"
        ' 
        ' webForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(224, 181)
        Controls.Add(lblLogmasuk)
        Controls.Add(BtnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtId)
        Controls.Add(lblPass)
        Controls.Add(lblId)
        Name = "webForm"
        Text = "Web_form"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblId As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents lblLogmasuk As Label

End Class
