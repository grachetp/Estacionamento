using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
  public partial class frmUsuarios : Form
  {
    public SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    public frmUsuarios()
    {
      InitializeComponent();
    }

    public void CarregaDados()
    {
      var con = new Conexao();
      try
      {
        con.conectar();
        string sql = "SELECT id as ID, login as Login FROM user";
        var da = new SQLiteDataAdapter(sql, con.conn); // realizando a query
        var usuarios = new DataTable();
        da.Fill(usuarios);
        dgvUsuarios.DataSource = usuarios;
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message.ToString(), "Erro", MessageBoxButtons.OK);
      }
      finally
      {
        con.desconectar();
      }
    }


    private void btnNovo_Click(object sender, EventArgs e)
    {
      var form = new frmUsuario(false);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregaDados();
      }
    }

    private void frmUsuarios_Load(object sender, EventArgs e)
    {
      CarregaDados();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      var id = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmUsuario(id, true);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregaDados();
      }
    }

    private void btnVisualizar_Click(object sender, EventArgs e)
    {
      var id = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmUsuario(id, false);
      form.Show();
    }

    private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
    {
      var con = new Conexao();
      try
      {
        con.conectar();
        string sql = $"SELECT id as ID, login as Login FROM user where login like '{txtPesquisa.Text}%'";
        var da = new SQLiteDataAdapter(sql, con.conn); // realizando a query
        var usuarios = new DataTable();
        da.Fill(usuarios);
        dgvUsuarios.DataSource = usuarios;
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message.ToString(), "Erro", MessageBoxButtons.OK);
      }
      finally
      {
        con.desconectar();
      }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }

      var form = new frmExcluir();
      form.ShowDialog();
      if (form.DialogResult == DialogResult.Yes)
      {
        var cmd = new SQLiteCommand($"DELETE FROM USER where id = @id", conn);
        var id = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
        cmd.Parameters.AddWithValue("id", id.Trim());
        try
        {
          cmd.ExecuteNonQuery();
          MessageBox.Show("Excluído com Sucesso!");
          DialogResult = DialogResult.OK;
          CarregaDados();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Erro ao salvar: " + ex);
        }
        finally
        {
          conn.Close();
        }
      }
    }

    private void dgvUsuarios_CellDoubleClick(object sender, EventArgs e)
    {
      var id = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmUsuario(id, false);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregaDados();
      }
    }
  }
}
