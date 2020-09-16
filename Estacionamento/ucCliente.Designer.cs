namespace Estacionamento
{
  partial class ucCliente
  {
    /// <summary> 
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtPesquisa = new System.Windows.Forms.TextBox();
      this.dgvClientes = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPesquisa
      // 
      this.txtPesquisa.Location = new System.Drawing.Point(18, 18);
      this.txtPesquisa.Name = "txtPesquisa";
      this.txtPesquisa.Size = new System.Drawing.Size(342, 20);
      this.txtPesquisa.TabIndex = 43;
      this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
      // 
      // dgvClientes
      // 
      this.dgvClientes.AllowUserToAddRows = false;
      this.dgvClientes.AllowUserToDeleteRows = false;
      this.dgvClientes.AllowUserToResizeColumns = false;
      this.dgvClientes.AllowUserToResizeRows = false;
      this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvClientes.EnableHeadersVisualStyles = false;
      this.dgvClientes.Location = new System.Drawing.Point(18, 44);
      this.dgvClientes.MultiSelect = false;
      this.dgvClientes.Name = "dgvClientes";
      this.dgvClientes.ReadOnly = true;
      this.dgvClientes.RowHeadersVisible = false;
      this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvClientes.Size = new System.Drawing.Size(342, 120);
      this.dgvClientes.TabIndex = 42;
      this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
      this.dgvClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvClientes_KeyPress);
      // 
      // ucCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtPesquisa);
      this.Controls.Add(this.dgvClientes);
      this.Name = "ucCliente";
      this.Size = new System.Drawing.Size(378, 181);
      this.Load += new System.EventHandler(this.ucCliente_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView dgvClientes;
    public System.Windows.Forms.TextBox txtPesquisa;
  }
}
