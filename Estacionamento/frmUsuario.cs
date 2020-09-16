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
  public partial class frmUsuario : Form
  {
    public SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    private static bool editar = false;

    public frmUsuario()
    {
      InitializeComponent();
      txtSenha.PasswordChar = '*';
    }

    public frmUsuario(string id, bool edit)
    {
      InitializeComponent();
      txtSenha.PasswordChar = '*';
      editar = edit;

      try
      {
        if (conn.State == ConnectionState.Closed)
        {
          conn.Open();
        }
        SQLiteCommand cmd = new SQLiteCommand($"select * from user where id={id}", conn);
        SQLiteDataReader dr = cmd.ExecuteReader();
        var usuario = new User();
        while (dr.Read())
        {
          usuario.id = Convert.ToString(dr["id"]);
          usuario.login = Convert.ToString(dr["login"]);
          usuario.password = Convert.ToString(dr["password"]);
        }
        txtID.Text = usuario.id;
        txtUsuario.Text = usuario.login;
        txtSenha.Text = usuario.password;

      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK);
      }
      finally
      {
        conn.Close();
      }
      if (edit == false)
      {
        txtID.Enabled = false;
        txtSenha.Enabled = false;
        txtUsuario.Enabled = false;
        btnSalvar.Enabled = false;
      }
      if (edit == true)
      {
        txtID.Enabled = false;
        txtSenha.Enabled = true;
        txtUsuario.Enabled = true;
        btnSalvar.Enabled = true;
        btnEditar.Enabled = false;
      }

    }

    public frmUsuario(bool edit)
    {
      InitializeComponent();
      txtSenha.PasswordChar = '*';
      editar = edit;
      if (edit == false)
      {
        txtID.Enabled = false;
        txtSenha.Enabled = true;
        txtUsuario.Enabled = true;
        btnSalvar.Enabled = true;
        btnEditar.Enabled = false;
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
        var cmd = new SQLiteCommand($"INSERT INTO USER (login, password) values (@login, @password)", conn);
        cmd.Parameters.AddWithValue("login", txtUsuario.Text.Trim());
        cmd.Parameters.AddWithValue("password", txtSenha.Text.Trim());
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
        var cmd = new SQLiteCommand($"UPDATE USER set login = @login, password = @password where id = @id", conn);
        cmd.Parameters.AddWithValue("login", txtUsuario.Text.Trim());
        cmd.Parameters.AddWithValue("password", txtSenha.Text.Trim());
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
      txtSenha.Enabled = true;
      txtUsuario.Enabled = true;
      btnSalvar.Enabled = true;
      btnEditar.Enabled = false;
    }
  }
}