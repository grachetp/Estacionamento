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
  public partial class frmVeiculos : Form
  {
    private static SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    private static string id;

    public frmVeiculos(string ID)
    {
      id = ID;
      InitializeComponent();
      CarregarDados();
    }

    public void CarregarDados()
    {
      try
      {
        if (conn.State == ConnectionState.Closed)
        {
          conn.Open();
        }
        string sql = $"SELECT id as ID, model as MODELO, brand as MARCA, board as PLACA, color as COR FROM car where owner = {id}";
        var da = new SQLiteDataAdapter(sql, conn); // realizando a query
        var carros = new DataTable();
        da.Fill(carros);
        dgvCarros.DataSource = carros;
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message.ToString(), "Erro", MessageBoxButtons.OK);
      }
      finally
      {
        conn.Close();
      }
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
      var form = new frmVeiculo(id, false);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregarDados();
      }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      string id = dgvCarros.SelectedRows[0].Cells[0].Value.ToString();
      var form = new frmVeiculo(id, true);
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        CarregarDados();
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
        var cmd = new SQLiteCommand($"DELETE FROM car where id = @id", conn);
        var id = dgvCarros.SelectedRows[0].Cells[0].Value.ToString();
        cmd.Parameters.AddWithValue("id", id.Trim());
        try
        {
          cmd.ExecuteNonQuery();
          MessageBox.Show("Excluído com Sucesso!");
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
  }
}
