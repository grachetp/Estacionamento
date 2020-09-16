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
  public partial class frmLogin : Form
  {

    public frmLogin()
    {
      InitializeComponent();
      txtPass.PasswordChar = '*';
      txtUsuario.Focus();
      txtPass.Text = "";
      txtUsuario.Text = "";
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
      if (txtUsuario.Text == "" || txtPass.Text == "")
      {
        MessageBox.Show("Dados incompletos", "Formulário Imcompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtPass.Clear();
        txtUsuario.Focus();
      }
      else
      {
        var con = new Conexao();
        try
        {
          con.conectar();

          string sql = $"SELECT * FROM user WHERE login ='{txtUsuario.Text}' AND password ='{txtPass.Text}'";

          var dados = new SQLiteDataAdapter(sql, con.conn); // realizando a query
          var user = new DataTable();

          dados.Fill(user); //passando os dados do dataadapter para datatable

          if (user.Rows.Count <= 0)
          {
            MessageBox.Show("Dados Incorretos", "Usuario não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtPass.Clear();
            txtUsuario.Focus();
          }
          else
          {
            DialogResult = DialogResult.OK;
          }


        }
        catch (Exception err)
        {
          MessageBox.Show(err.Message.ToString(), "Erro", MessageBoxButtons.OK);
        }

      }
    }
  }
}
