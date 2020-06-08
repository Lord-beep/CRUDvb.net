Public Class Form1

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Create("INSERT INTO Utilizadores (nome, utilizador, senha, nivel)VALUES
         ('" & txtNome.Text & "','" & txtUtilizador.Text & "','" & txtSenha.Text & "'," &
        CbNivel.SelectedIndex + 1 & ")")

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Try
            Reload("SELECT * FROM Utilizadores ORDER BY ID ASC", DgLista)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "ERRo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Updates("UPDATE Utilizadores SET nome='" & txtNome.Text & "'," & "utilizador='" &
                 txtUtilizador.Text & "'," & "senha='" & txtSenha.Text & "'," & "nivel=" & CbNivel.SelectedIndex & "WHERE ID =" & LblID.Text)

        Catch ex As Exception

            MessageBox.Show("ERRO" & ex.Message, "ERRo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        StrConexao.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Delete("DELETE FROM Utilizadores WHERE ID =" & LblID.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "ERRo!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        StrConexao.Close()
    End Sub

    Private Sub DgLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgLista.CellContentClick
        LblID.Text = DgLista.CurrentRow.Cells(0).Value
        txtNome.Text = DgLista.CurrentRow.Cells(1).Value
        txtUtilizador.Text = DgLista.CurrentRow.Cells(2).Value
        txtSenha.Text = DgLista.CurrentRow.Cells(3).Value
        CbNivel.SelectedIndex = DgLista.CurrentRow.Cells(4).Value
    End Sub


End Class
