using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
  class Conexao
  {
    public SQLiteConnection conn = new SQLiteConnection("Data Source=sqlite.db");

    public void conectar()
    {
      conn.Open();
    }

    public void desconectar()
    {
      conn.Close();
    }
  }
}
