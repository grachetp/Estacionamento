using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void btnClientes_Click(object sender, EventArgs e)
    {
      var form = new frmClientes();
      form.Show();
    }

    private void btnFuncionarios_Click(object sender, EventArgs e)
    {
      var form = new frmUsuarios();
      form.Show();
    }

    private void btnEstacionamento_Click(object sender, EventArgs e)
    {
      var form = new frmEstacionamento();
      form.Show();
    }
  }
}
