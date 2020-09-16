using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Estacionamento
{
  public partial class ucVeiculos : UserControl
  {
    private static SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    public static string id;
    private string carroID = "";
    private string carroNome = "";


    public ucVeiculos()
    {
      InitializeComponent();
    }

    public ucVeiculos(string ID)
    {
      id = ID;
      InitializeComponent();
      CarregarDados();
    }

    public string ObterIDCarro()
    {
      return carroID;
    }

    public string ObterNomeCarro()
    {
      return carroNome;
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

    private void dgvCarros_DoubleClick(object sender, EventArgs e)
    {
      carroID = dgvCarros.SelectedRows[0].Cells[0].Value.ToString();
      carroNome = dgvCarros.SelectedRows[0].Cells[1].Value.ToString() + " - " +dgvCarros.SelectedRows[0].Cells[3].Value.ToString();
      this.Visible = false;
    }
  }
}
