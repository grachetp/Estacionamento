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
  public partial class frmVeiculo : Form
  {
    private static SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    private static string idDono;
    private static string idCarro;
    private static bool editar;


    public frmVeiculo(string ID)
    {
      InitializeComponent();
      idDono = ID;
      txtCor.Enabled = true;
      txtMarca.Enabled = true;
      txtModelo.Enabled = true;
      txtPlaca.Enabled = true;
      btnSalvar.Enabled = true;
      btnEditar.Enabled = false;
    }

    public frmVeiculo(string ID, bool edit)
    {
      InitializeComponent();
      editar = edit;
      if (editar == false)
      {
        idDono = ID;
        txtCor.Enabled = true;
        txtMarca.Enabled = true;
        txtModelo.Enabled = true;
        txtPlaca.Enabled = true;
        btnSalvar.Enabled = true;
        btnEditar.Enabled = false;
      }
      else
      {
        idCarro = ID;
        txtCor.Enabled = true;
        txtMarca.Enabled = true;
        txtModelo.Enabled = true;
        txtPlaca.Enabled = true;
        btnSalvar.Enabled = true;
        btnEditar.Enabled = false;
        CarregarDados();
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
        var cmd = new SQLiteCommand($"INSERT INTO car (model, brand, board, color, owner) values " +
          $"(@model, @brand, @board, @color, @owner)", conn);
        cmd.Parameters.AddWithValue("model", txtModelo.Text.Trim());
        cmd.Parameters.AddWithValue("brand", txtMarca.Text.Trim());
        cmd.Parameters.AddWithValue("board", txtPlaca.Text.Trim());
        cmd.Parameters.AddWithValue("color", txtCor.Text.Trim());
        cmd.Parameters.AddWithValue("owner", idDono);

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
        var cmd = new SQLiteCommand($"UPDATE car set model = @model, brand = @brand, color = @color," +
          $"board = @board where id = @id", conn);
        cmd.Parameters.AddWithValue("model", txtModelo.Text.Trim());
        cmd.Parameters.AddWithValue("brand", txtMarca.Text.Trim());
        cmd.Parameters.AddWithValue("board", txtPlaca.Text.Trim());
        cmd.Parameters.AddWithValue("color", txtCor.Text.Trim());
        cmd.Parameters.AddWithValue("id", idCarro);
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
    private void CarregarDados()
    {
      try
      {
        if (conn.State == ConnectionState.Closed)
        {
          conn.Open();
        }
        SQLiteCommand cmd = new SQLiteCommand($"select * from car where id={idCarro}", conn);
        SQLiteDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
          txtCor.Text = Convert.ToString(dr["color"]);
          txtMarca.Text = Convert.ToString(dr["brand"]);
          txtModelo.Text = Convert.ToString(dr["model"]);
          txtPlaca.Text = Convert.ToString(dr["board"]);
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
  }
}
