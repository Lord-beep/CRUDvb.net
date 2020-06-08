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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtUtilizador = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.CbNivel = New System.Windows.Forms.ComboBox()
        Me.DgLista = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.BackColor = System.Drawing.Color.Transparent
        Me.LblID.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.Color.Salmon
        Me.LblID.Location = New System.Drawing.Point(256, 25)
        Me.LblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(26, 19)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Salmon
        Me.Label2.Location = New System.Drawing.Point(14, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selecione o seu Nível Acesso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Salmon
        Me.Label3.Location = New System.Drawing.Point(14, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Insira a Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Salmon
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Insira o seu nome de Utilizador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Salmon
        Me.Label5.Location = New System.Drawing.Point(14, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Insira o seu Nome"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.DarkBlue
        Me.txtNome.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Salmon
        Me.txtNome.Location = New System.Drawing.Point(260, 66)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(190, 25)
        Me.txtNome.TabIndex = 5
        '
        'txtUtilizador
        '
        Me.txtUtilizador.BackColor = System.Drawing.Color.DarkBlue
        Me.txtUtilizador.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilizador.ForeColor = System.Drawing.Color.Salmon
        Me.txtUtilizador.Location = New System.Drawing.Point(260, 99)
        Me.txtUtilizador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUtilizador.Name = "txtUtilizador"
        Me.txtUtilizador.Size = New System.Drawing.Size(190, 25)
        Me.txtUtilizador.TabIndex = 6
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.DarkBlue
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.Salmon
        Me.txtSenha.Location = New System.Drawing.Point(260, 138)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(190, 25)
        Me.txtSenha.TabIndex = 7
        '
        'CbNivel
        '
        Me.CbNivel.BackColor = System.Drawing.Color.DarkBlue
        Me.CbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNivel.ForeColor = System.Drawing.Color.Salmon
        Me.CbNivel.FormattingEnabled = True
        Me.CbNivel.Items.AddRange(New Object() {"Visitante", "Equipa", "Administrador"})
        Me.CbNivel.Location = New System.Drawing.Point(260, 177)
        Me.CbNivel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CbNivel.Name = "CbNivel"
        Me.CbNivel.Size = New System.Drawing.Size(190, 21)
        Me.CbNivel.TabIndex = 8
        '
        'DgLista
        '
        Me.DgLista.AllowUserToAddRows = False
        Me.DgLista.AllowUserToResizeColumns = False
        Me.DgLista.AllowUserToResizeRows = False
        Me.DgLista.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgLista.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgLista.Location = New System.Drawing.Point(146, 244)
        Me.DgLista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgLista.Name = "DgLista"
        Me.DgLista.RowHeadersVisible = False
        Me.DgLista.RowHeadersWidth = 51
        Me.DgLista.RowTemplate.Height = 24
        Me.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgLista.Size = New System.Drawing.Size(378, 88)
        Me.DgLista.TabIndex = 9
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCreate.BackgroundImage = CType(resources.GetObject("BtnCreate.BackgroundImage"), System.Drawing.Image)
        Me.BtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.PanNE
        Me.BtnCreate.Location = New System.Drawing.Point(541, 31)
        Me.BtnCreate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(97, 46)
        Me.BtnCreate.TabIndex = 10
        Me.BtnCreate.UseVisualStyleBackColor = False
        Me.BtnCreate.Visible = False
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnReload.Cursor = System.Windows.Forms.Cursors.PanNE
        Me.BtnReload.Location = New System.Drawing.Point(541, 81)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(97, 42)
        Me.BtnReload.TabIndex = 11
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.PanNE
        Me.BtnUpdate.Location = New System.Drawing.Point(541, 127)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(97, 42)
        Me.BtnUpdate.TabIndex = 12
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.PanNE
        Me.BtnDelete.Location = New System.Drawing.Point(541, 177)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(97, 41)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(662, 366)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.DgLista)
        Me.Controls.Add(Me.CbNivel)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUtilizador)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblID)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtUtilizador As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents CbNivel As ComboBox
    Friend WithEvents DgLista As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
