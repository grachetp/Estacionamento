namespace Estacionamento
{
  partial class ucVeiculos
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
      this.dgvCarros = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvCarros
      // 
      this.dgvCarros.AllowUserToAddRows = false;
      this.dgvCarros.AllowUserToDeleteRows = false;
      this.dgvCarros.AllowUserToResizeColumns = false;
      this.dgvCarros.AllowUserToResizeRows = false;
      this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCarros.EnableHeadersVisualStyles = false;
      this.dgvCarros.Location = new System.Drawing.Point(3, 3);
      this.dgvCarros.MultiSelect = false;
      this.dgvCarros.Name = "dgvCarros";
      this.dgvCarros.ReadOnly = true;
      this.dgvCarros.RowHeadersVisible = false;
      this.dgvCarros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvCarros.Size = new System.Drawing.Size(423, 113);
      this.dgvCarros.TabIndex = 28;
      this.dgvCarros.DoubleClick += new System.EventHandler(this.dgvCarros_DoubleClick);
      // 
      // ucVeiculos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgvCarros);
      this.Name = "ucVeiculos";
      this.Size = new System.Drawing.Size(429, 120);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCarros;
  }
}
