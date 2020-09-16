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
  public partial class ucCliente : UserControl
  {
    public SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    private string idCliente = "";
    private string nomeCliente = "";
    public ucCliente()
    {
      InitializeComponent();
      CarregarDados();
    }

    public string obterIDCliente()
    {
      return idCliente;
    }

    public string obterNomeCliente()
    {
      return nomeCliente;
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

    private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
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

    private void dgvClientes_DoubleClick(object sender, EventArgs e)
    {
      idCliente = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
      nomeCliente = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
      this.Visible = false;
    }

    private void dgvClientes_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        idCliente = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
        nomeCliente = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
        this.Visible = false;
      }
    }

    private void ucCliente_Load(object sender, EventArgs e)
    {
      
    }
  }
}
