using Estacionamento.Classes;
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
  public partial class frmCliente : Form
  {
    private SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    private bool editar = false;
    public frmCliente()
    {
      InitializeComponent();
    }

    public frmCliente(bool edit)
    {
      InitializeComponent();
      editar = edit;
      btnCarros.Enabled = false;
      btnEditar.Enabled = false;
      btnSalvar.Enabled = true;
    }

    public frmCliente(string id, bool edit)
    {
      InitializeComponent();
      editar = edit;
      if (edit == true)
      {
        btnCarros.Enabled = true;
        btnEditar.Enabled = false;
        btnSalvar.Enabled = true;
        txtNome.Enabled = true;
        mskTelefone.Enabled = true;
        mskCPF.Enabled = true;
      }
      else
      {
        btnCarros.Enabled = true;
        btnEditar.Enabled = true;
        btnSalvar.Enabled = false;
        txtNome.Enabled = false;
        mskTelefone.Enabled = false;
        mskCPF.Enabled = false;
      }

      try
      {
        if (conn.State == ConnectionState.Closed)
        {
          conn.Open();
        }
        SQLiteCommand cmd = new SQLiteCommand($"select * from client where id={id}", conn);
        SQLiteDataReader dr = cmd.ExecuteReader();
        var cliente = new Client();
        while (dr.Read())
        {
          cliente.id = Convert.ToString(dr["id"]);
          cliente.nome = Convert.ToString(dr["name"]);
          cliente.telefone = Convert.ToString(dr["tell"]);
          cliente.cpf = Convert.ToString(dr["cpf"]);
        }
        txtID.Text = cliente.id;
        txtNome.Text = cliente.nome;
        mskCPF.Text = cliente.cpf;
        mskTelefone.Text = cliente.telefone;

      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK);
      }
      finally
      {
        conn.Close();
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }
      if (editar == false)
      {
        var cmd = new SQLiteCommand($"INSERT INTO CLIENT (name, tell, cpf) values (@name, @tell, @cpf)", conn);
        cmd.Parameters.AddWithValue("name", txtNome.Text.Trim());
        cmd.Parameters.AddWithValue("tell", mskTelefone.Text.Trim());
        cmd.Parameters.AddWithValue("cpf", mskCPF.Text.Trim());
        try
        {
          cmd.ExecuteNonQuery();
          MessageBox.Show("Cadastrado com Sucesso!");
          DialogResult = DialogResult.OK;
          this.Close();
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
      if (editar == true)
      {
        var cmd = new SQLiteCommand($"UPDATE client set name = @name, tell = @tell, cpf=@cpf where id = @id", conn);
        cmd.Parameters.AddWithValue("name", txtNome.Text.Trim());
        cmd.Parameters.AddWithValue("tell", mskTelefone.Text.Trim());
        cmd.Parameters.AddWithValue("cpf", mskCPF.Text.Trim());
        cmd.Parameters.AddWithValue("id", txtID.Text.Trim());
        try
        {
          cmd.ExecuteNonQuery();
          MessageBox.Show("Editado com Sucesso!");
          DialogResult = DialogResult.OK;
          this.Close();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Erro ao editar: " + ex.Message);
        }
        finally
        {
          conn.Close();
        }
      }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      editar = true;
      btnCarros.Enabled = true;
      btnEditar.Enabled = false;
      btnSalvar.Enabled = true;
      txtNome.Enabled = true;
      mskTelefone.Enabled = true;
      mskCPF.Enabled = true;
    }

    private void btnCarros_Click(object sender, EventArgs e)
    {
      var id = txtID.Text;
      var form = new frmVeiculos(id);
      form.ShowDialog();
    }

    private void btnRecibos_Click(object sender, EventArgs e)
    {
      var id = txtID.Text;
      var form = new frmRecibos(id);
      form.ShowDialog();
    }
  }
}
