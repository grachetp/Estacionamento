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
  public partial class frmClientes : Form
  {
    public SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    public frmClientes()
    {
      InitializeComponent();
    }

    public void CarregarDados()
    {
      var con = new Conexao();
      try
      {
        con.conectar();
        string sql = "SELECT id as ID, name as Nome, cpf as CPF, tell as Telefone FROM client";
        var da = new SQLiteDataAdapter(sql, con.conn); // realizando a query
        var usuarios = new DataTable();
        da.Fill(usuarios);
        dgvClientes.DataSource = usuarios;
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

    private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var id = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmCliente(id, false);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregarDados();
      }
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      var form = new frmCliente(false);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregarDados();
      }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      var id = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmCliente(id, true);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregarDados();
      }
    }

    private void frmClientes_Load(object sender, EventArgs e)
    {
      CarregarDados();
    }

    private void btnVisualizar_Click(object sender, EventArgs e)
    {
      var id = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmCliente(id, false);
      form.ShowDialog();
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
        var cmd = new SQLiteCommand($"DELETE FROM client where id = @id", conn);
        var id = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
        cmd.Parameters.AddWithValue("id", id.Trim());
        try
        {
          cmd.ExecuteNonQuery();
          MessageBox.Show("Excluído com Sucesso!");
          DialogResult = DialogResult.OK;
          CarregarDados();
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

    private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
    {
      var con = new Conexao();
      try
      {
        con.conectar();
        string sql = $"SELECT id as ID, name as Nome, cpf as CPF, tell as Telefone FROM client where name like '{txtPesquisa.Text}%'";
        var da = new SQLiteDataAdapter(sql, con.conn); // realizando a query
        var usuarios = new DataTable();
        da.Fill(usuarios);
        dgvClientes.DataSource = usuarios;
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
  }
}
