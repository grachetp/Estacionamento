namespace Estacionamento
{
  partial class frmVeiculos
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculos));
      this.dgvCarros = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
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
      this.dgvCarros.Location = new System.Drawing.Point(12, 127);
      this.dgvCarros.MultiSelect = false;
      this.dgvCarros.Name = "dgvCarros";
      this.dgvCarros.ReadOnly = true;
      this.dgvCarros.RowHeadersVisible = false;
      this.dgvCarros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvCarros.Size = new System.Drawing.Size(505, 129);
      this.dgvCarros.TabIndex = 27;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.label1.Location = new System.Drawing.Point(157, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Veículos";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Estacionamento.Properties.Resources.carro;
      this.pictureBox1.Location = new System.Drawing.Point(46, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(105, 85);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnExcluir
      // 
      this.btnExcluir.BackColor = System.Drawing.Color.Teal;
      this.btnExcluir.FlatAppearance.BorderSize = 0;
      this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExcluir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExcluir.ForeColor = System.Drawing.Color.White;
      this.btnExcluir.Location = new System.Drawing.Point(330, 271);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(105, 33);
      this.btnExcluir.TabIndex = 31;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = false;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.BackColor = System.Drawing.Color.Teal;
      this.btnEditar.FlatAppearance.BorderSize = 0;
      this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEditar.ForeColor = System.Drawing.Color.White;
      this.btnEditar.Location = new System.Drawing.Point(219, 271);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(105, 33);
      this.btnEditar.TabIndex = 30;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = false;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.BackColor = System.Drawing.Color.Teal;
      this.btnNovo.FlatAppearance.BorderSize = 0;
      this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNovo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNovo.ForeColor = System.Drawing.Color.White;
      this.btnNovo.Location = new System.Drawing.Point(108, 271);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(105, 33);
      this.btnNovo.TabIndex = 29;
      this.btnNovo.Text = "Novo";
      this.btnNovo.UseVisualStyleBackColor = false;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Location = new System.Drawing.Point(0, 1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(538, 91);
      this.panel1.TabIndex = 28;
      // 
      // frmVeiculos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSlateGray;
      this.ClientSize = new System.Drawing.Size(538, 331);
      this.Controls.Add(this.dgvCarros);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmVeiculos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Estacionamento 24H - Veículos";
      ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvCarros;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnNovo;
    private System.Windows.Forms.Panel panel1;
  }
}