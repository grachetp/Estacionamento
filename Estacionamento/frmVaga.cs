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
using Humanizer;

namespace Estacionamento
{
  public partial class frmVaga : Form
  {
    private string idCliente = "";
    private string nomeCliente = "";
    private string idCarro = "";
    private string nomeCarro = "";
    private int idVaga;
    private bool ocupado = false;
    private SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    public frmVaga()
    {
      InitializeComponent();
      //ucClientes.Visible = false;
    }

    public frmVaga(bool ocupado, int idVaga)
    {
      InitializeComponent();
      this.ocupado = ocupado;
      this.idVaga = idVaga;
      if(this.ocupado == false)
      {
        btnFinalizar.Enabled = false;
      }else if(this.ocupado == true)
      {
        btnIniciar.Enabled = false;
        txtIDCarro.Enabled = false;
        txtIDCliente.Enabled = false;
        txtNomeCliente.Enabled = false;
        txtModeloCarro.Enabled = false;
        CarregarDados();
      }
    }

    private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        ucCliente.Visible = true;
        ucCliente.txtPesquisa.Focus();
      }
    }

    private void ucCliente_VisibleChanged(object sender, EventArgs e)
    {
      idCliente = ucCliente.obterIDCliente();
      nomeCliente = ucCliente.obterNomeCliente();
      txtIDCliente.Text = idCliente;
      txtNomeCliente.Text = nomeCliente;
    }



    private void txtIDCarro_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        ucVeiculos.id = txtIDCliente.Text;
        ucVeiculos.Visible = true;
        ucVeiculos.CarregarDados();
      }
    }

    private void ucVeiculos_VisibleChanged(object sender, EventArgs e)
    {
      idCarro = ucVeiculos.ObterIDCarro();
      nomeCarro = ucVeiculos.ObterNomeCarro();
      txtIDCarro.Text = idCarro;
      txtModeloCarro.Text = nomeCarro;
    }

    private void textBox2_DoubleClick(object sender, EventArgs e)
    {

    }

    private void textBox3_DoubleClick(object sender, EventArgs e)
    {

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
    }

    private void btnFinalizar_Click(object sender, EventArgs e)
    {
      string hora = DateTime.Now.ToString("HH:mm:ss");
      txtCheckout.Text = hora;

      var t1 = TimeSpan.Parse(txtCheckin.Text);
      var t2 = TimeSpan.Parse(txtCheckout.Text);
      TimeSpan diff = t2 - t1;
      var tempo = diff.Hours * 60 + diff.Minutes;
      var valor = tempo * 0.075;
      valor = Math.Round(valor, 1);
      MessageBox.Show($"O valor do seu estacionamento ficou: R$ {valor}", "Valor à Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);

      //finalizar a vaga
      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }

      var cmd = new SQLiteCommand($"UPDATE vagas set checkout = @checkout, valor = @valor where id = @idVaga", conn);
      cmd.Parameters.AddWithValue("checkout", txtCheckout.Text.Trim());
      cmd.Parameters.AddWithValue("valor", valor);
      cmd.Parameters.AddWithValue("idVaga", idVaga);
      try
      {
        cmd.ExecuteNonQuery();
        MessageBox.Show("Obrigado pela preferencia!\nVolte Sempre");
        DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao estacionar: " + ex.Message);
      }
      finally
      {
        conn.Close();
      }


      //Salvar recibo

      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }

      var cmd1 = new SQLiteCommand($"insert into recibos(idDono, idCarro, checkin, checkout, valor, nomeCliente, descCarro)" +
        $" select idDono, idCarro, checkin, checkout, valor, nomeCliente, descCarro from vagas where id = @idVaga; ", conn);
      cmd1.Parameters.AddWithValue("idVaga", idVaga);
      try
      {
        cmd1.ExecuteNonQuery();
        DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao estacionar: " + ex.Message);
      }
      finally
      {
        conn.Close();
      }


      //resetar a vaga
      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }

      var cmd2 = new SQLiteCommand($"UPDATE vagas set estado = 0, idDono = null, idCarro = null, checkin = null, checkout = null," +
        $" valor = null, nomeCliente = null, descCarro = null where id = @idVaga", conn);
      cmd2.Parameters.AddWithValue("idVaga", idVaga);
      try
      {
        cmd2.ExecuteNonQuery();
        DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao estacionar: " + ex.Message);
      }
      finally
      {
        conn.Close();
      }

    }


    public void CarregarDados()
    {
      try
      {
        if (conn.State == ConnectionState.Closed)
        {
          conn.Open();
        }
        SQLiteCommand cmd = new SQLiteCommand($"select * from vagas where id={idVaga}", conn);
        SQLiteDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
          txtIDCliente.Text = Convert.ToString(dr["idDono"]);
          txtNomeCliente.Text = Convert.ToString(dr["nomeCliente"]);
          txtIDCarro.Text = Convert.ToString(dr["idCarro"]);
          txtModeloCarro.Text = Convert.ToString(dr["descCarro"]);
          txtCheckin.Text = Convert.ToString(dr["checkin"]);
        }
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

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      string hora = DateTime.Now.ToString("HH:mm:ss");
      txtCheckin.Text = hora;

      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }

      var cmd = new SQLiteCommand($"UPDATE vagas set estado = @estado, idDono = @idDono, idCarro = @idCarro, checkin = @checkin, nomeCliente = @nomeDono, descCarro = @descCarro where id = @idVaga", conn);
      cmd.Parameters.AddWithValue("estado", 1);
      cmd.Parameters.AddWithValue("idDono", txtIDCliente.Text.Trim());
      cmd.Parameters.AddWithValue("idCarro", txtIDCarro.Text.Trim());
      cmd.Parameters.AddWithValue("checkin", txtCheckin.Text.Trim());
      cmd.Parameters.AddWithValue("idVaga", idVaga);
      cmd.Parameters.AddWithValue("nomeDono", txtNomeCliente.Text.Trim());
      cmd.Parameters.AddWithValue("descCarro", txtModeloCarro.Text.Trim());
      try
      {
        cmd.ExecuteNonQuery();
        MessageBox.Show("Estacionado com Sucesso!");
        DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao estacionar: " + ex.Message);
      }
      finally
      {
        conn.Close();
      }
    }
  }
}
