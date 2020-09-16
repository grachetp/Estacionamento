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
  public enum TipoVarreduraBotoes
  {
    LerValor,
    AtribuirValor
  }

  public partial class frmEstacionamento : Form
  {
    public static SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    public frmEstacionamento()
    {
      InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      string hora = DateTime.Now.ToString("HH:mm:ss");
      lblHoras.Text = hora;
      VarrerButtons(TipoVarreduraBotoes.LerValor);

    }

    private void CarregaDados()
    {
      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }

    }

    private void frmEstacionamento_Load(object sender, EventArgs e)
    {
      VarrerButtons(TipoVarreduraBotoes.LerValor);
    }

    private void Define_Ocupacao(int idButton)
    {
      if (conn.State == ConnectionState.Closed)
      {
        conn.Open();
      }
      SQLiteCommand cmd = new SQLiteCommand($"select estado from vagas where id={idButton}", conn);
      SQLiteDataReader dr = cmd.ExecuteReader();

      while (dr.Read())
      {
        if (dr["estado"].ToString() == "0")
        {
          VarrerButtons(TipoVarreduraBotoes.AtribuirValor, idButton, 0);
        }
        if (dr["estado"].ToString() == "1")
        {
          VarrerButtons(TipoVarreduraBotoes.AtribuirValor, idButton, 1);
        }
      }
    }

    private void Define_Informacao(int estadoVaga, Control c)
    {
      if (estadoVaga == 0)
      {
        c.BackColor = Color.Green;
        c.Text = "VAGA LIVRE";
      }
      else
      {
        c.BackColor = Color.Red;
        c.Text = "VAGA OCUPADA";
      }
    }

    private void VarrerButtons(TipoVarreduraBotoes tipo, int id = 0, int estado = 0)
    {
      foreach (Control item in this.Controls)
      {
        if (item.Name.IndexOf("Vaga") > 0)
        {

          if (tipo == TipoVarreduraBotoes.LerValor)
          {
            Console.WriteLine(item.Name.Substring(7, 2));
            int idd = int.Parse(item.Name.Substring(7, 2));
            Define_Ocupacao(idd);
          }
          else if (tipo == TipoVarreduraBotoes.AtribuirValor)
          {
            if (item.Name.Substring(7, 2) == id.ToString("00"))
            {
              Define_Informacao(estado, item);
            }
          }
        }
      }
    }

    private void btnVaga01_Click(object sender, EventArgs e)
    {
      if (btnVaga01.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 1);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 1);
        form.ShowDialog();
      }
    }

    private void btnVaga02_Click(object sender, EventArgs e)
    {
      if (btnVaga02.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 2);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 2);
        form.ShowDialog();
      }
    }

    private void btnVaga03_Click(object sender, EventArgs e)
    {
      if (btnVaga03.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 3);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 3);
        form.ShowDialog();
      }
    }

    private void btnVaga04_Click(object sender, EventArgs e)
    {
      if (btnVaga04.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 4);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 4);
        form.ShowDialog();
      }
    }

    private void btnVaga05_Click(object sender, EventArgs e)
    {
      if (btnVaga05.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 5);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 5);
        form.ShowDialog();
      }
    }

    private void btnVaga06_Click(object sender, EventArgs e)
    {
      if (btnVaga06.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 6);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 6);
        form.ShowDialog();
      }
    }

    private void btnVaga07_Click(object sender, EventArgs e)
    {
      if (btnVaga07.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 7);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 7);
        form.ShowDialog();
      }
    }

    private void btnVaga08_Click(object sender, EventArgs e)
    {
      if (btnVaga08.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 8);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 8);
        form.ShowDialog();
      }
    }

    private void btnVaga09_Click(object sender, EventArgs e)
    {
      if (btnVaga09.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 9);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 9);
        form.ShowDialog();
      }
    }

    private void btnVaga10_Click(object sender, EventArgs e)
    {
      if (btnVaga10.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 10);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 10);
        form.ShowDialog();
      }
    }

    private void btnVaga11_Click(object sender, EventArgs e)
    {
      if (btnVaga11.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 11);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 11);
        form.ShowDialog();
      }
    }

    private void btnVaga12_Click(object sender, EventArgs e)
    {
      if (btnVaga12.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 12);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 12);
        form.ShowDialog();
      }
    }

    private void btnVaga13_Click(object sender, EventArgs e)
    {
      if (btnVaga13.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 13);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 13);
        form.ShowDialog();
      }
    }

    private void btnVaga14_Click(object sender, EventArgs e)
    {
      if (btnVaga14.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 14);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 14);
        form.ShowDialog();
      }
    }

    private void btnVaga15_Click(object sender, EventArgs e)
    {
      if (btnVaga15.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 15);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 15);
        form.ShowDialog();
      }
    }

    private void btnVaga16_Click(object sender, EventArgs e)
    {
      if (btnVaga16.BackColor == Color.Green)
      {
        var form = new frmVaga(false, 16);
        form.ShowDialog();
      }
      else
      {
        var form = new frmVaga(true, 16);
        form.ShowDialog();
      }
    }
  }
}