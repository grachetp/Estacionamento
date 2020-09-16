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
  public partial class frmRecibos : Form
  {
    public SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");
    public frmRecibos(string id)
    {
      InitializeComponent();


      try
      {
        if (conn.State == ConnectionState.Closed)
        {
          conn.Open();
        }
        SQLiteCommand cmd = new SQLiteCommand($"select * from recibos where idDono={id}", conn);
        SQLiteDataReader dr = cmd.ExecuteReader();
        string frase = "";
        while (dr.Read())
        {
          frase += Convert.ToString(dr["descCarro"]);
          frase += " - ";
          frase += Convert.ToString(dr["checkin"]);
          frase += " às ";
          frase += Convert.ToString(dr["checkout"]);
          frase += " - R$ ";
          frase += Convert.ToString(dr["valor"]);
          frase += "\n";
          rtbRecibos.AppendText(frase);
          frase = "";
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
