<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MauApaNak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MauApaNak))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nama_jaringan = New System.Windows.Forms.TextBox()
        Me.password_jaringan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HidupkanJaringanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatikanJaringanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Checkbox_Password = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(128, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nama_jaringan
        '
        Me.nama_jaringan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_jaringan.Location = New System.Drawing.Point(128, 32)
        Me.nama_jaringan.Name = "nama_jaringan"
        Me.nama_jaringan.Size = New System.Drawing.Size(217, 21)
        Me.nama_jaringan.TabIndex = 1
        '
        'password_jaringan
        '
        Me.password_jaringan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_jaringan.Location = New System.Drawing.Point(128, 62)
        Me.password_jaringan.Name = "password_jaringan"
        Me.password_jaringan.Size = New System.Drawing.Size(217, 21)
        Me.password_jaringan.TabIndex = 2
        Me.password_jaringan.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Jaringan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(373, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NetworkToolStripMenuItem
        '
        Me.NetworkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HidupkanJaringanToolStripMenuItem, Me.MatikanJaringanToolStripMenuItem})
        Me.NetworkToolStripMenuItem.Image = CType(resources.GetObject("NetworkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NetworkToolStripMenuItem.Name = "NetworkToolStripMenuItem"
        Me.NetworkToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.NetworkToolStripMenuItem.Text = "   Network"
        '
        'HidupkanJaringanToolStripMenuItem
        '
        Me.HidupkanJaringanToolStripMenuItem.Name = "HidupkanJaringanToolStripMenuItem"
        Me.HidupkanJaringanToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.HidupkanJaringanToolStripMenuItem.Text = "Hidupkan Jaringan"
        '
        'MatikanJaringanToolStripMenuItem
        '
        Me.MatikanJaringanToolStripMenuItem.Name = "MatikanJaringanToolStripMenuItem"
        Me.MatikanJaringanToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MatikanJaringanToolStripMenuItem.Text = "Matikan Jaringan"
        '
        'Checkbox_Password
        '
        Me.Checkbox_Password.AutoSize = True
        Me.Checkbox_Password.Location = New System.Drawing.Point(128, 89)
        Me.Checkbox_Password.Name = "Checkbox_Password"
        Me.Checkbox_Password.Size = New System.Drawing.Size(114, 19)
        Me.Checkbox_Password.TabIndex = 8
        Me.Checkbox_Password.Text = "Show Password"
        Me.Checkbox_Password.UseVisualStyleBackColor = True
        '
        'MauApaNak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(373, 161)
        Me.Controls.Add(Me.Checkbox_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password_jaringan)
        Me.Controls.Add(Me.nama_jaringan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MauApaNak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Network Creator | by PoetralesanA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nama_jaringan As System.Windows.Forms.TextBox
    Friend WithEvents password_jaringan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HidupkanJaringanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatikanJaringanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Checkbox_Password As System.Windows.Forms.CheckBox

End Class
