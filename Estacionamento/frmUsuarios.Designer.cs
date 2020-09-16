namespace Estacionamento
{
  partial class frmUsuarios
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPesquisa = new System.Windows.Forms.TextBox();
      this.btnVisualizar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnNovo = new System.Windows.Forms.Button();
      this.dgvUsuarios = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
      this.SuspendLayout();
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
      this.panel1.Size = new System.Drawing.Size(582, 91);
      this.panel1.TabIndex = 27;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.label1.Location = new System.Drawing.Point(140, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Funcionarios";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Estacionamento.Properties.Resources.funcionario;
      this.pictureBox1.Location = new System.Drawing.Point(29, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(105, 85);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(76, 114);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(86, 22);
      this.label2.TabIndex = 34;
      this.label2.Text = "Pesquisa:";
      // 
      // txtPesquisa
      // 
      this.txtPesquisa.Location = new System.Drawing.Point(170, 116);
      this.txtPesquisa.Name = "txtPesquisa";
      this.txtPesquisa.Size = new System.Drawing.Size(221, 20);
      this.txtPesquisa.TabIndex = 33;
      this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
      // 
      // btnVisualizar
      // 
      this.btnVisualizar.BackColor = System.Drawing.Color.Teal;
      this.btnVisualizar.FlatAppearance.BorderSize = 0;
      this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnVisualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnVisualizar.ForeColor = System.Drawing.Color.White;
      this.btnVisualizar.Location = new System.Drawing.Point(301, 335);
      this.btnVisualizar.Name = "btnVisualizar";
      this.btnVisualizar.Size = new System.Drawing.Size(105, 33);
      this.btnVisualizar.TabIndex = 32;
      this.btnVisualizar.Text = "Visualizar";
      this.btnVisualizar.UseVisualStyleBackColor = false;
      this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.BackColor = System.Drawing.Color.Teal;
      this.btnExcluir.FlatAppearance.BorderSize = 0;
      this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExcluir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExcluir.ForeColor = System.Drawing.Color.White;
      this.btnExcluir.Location = new System.Drawing.Point(432, 335);
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
      this.btnEditar.Location = new System.Drawing.Point(170, 335);
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
      this.btnNovo.Location = new System.Drawing.Point(44, 335);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(105, 33);
      this.btnNovo.TabIndex = 29;
      this.btnNovo.Text = "Novo";
      this.btnNovo.UseVisualStyleBackColor = false;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // dgvUsuarios
      // 
      this.dgvUsuarios.AllowUserToAddRows = false;
      this.dgvUsuarios.AllowUserToDeleteRows = false;
      this.dgvUsuarios.AllowUserToResizeColumns = false;
      this.dgvUsuarios.AllowUserToResizeRows = false;
      this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvUsuarios.EnableHeadersVisualStyles = false;
      this.dgvUsuarios.Location = new System.Drawing.Point(170, 160);
      this.dgvUsuarios.MultiSelect = false;
      this.dgvUsuarios.Name = "dgvUsuarios";
      this.dgvUsuarios.ReadOnly = true;
      this.dgvUsuarios.RowHeadersVisible = false;
      this.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvUsuarios.Size = new System.Drawing.Size(221, 120);
      this.dgvUsuarios.TabIndex = 28;
      this.dgvUsuarios.DoubleClick += new System.EventHandler(this.dgvUsuarios_CellDoubleClick);
      // 
      // frmUsuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSlateGray;
      this.ClientSize = new System.Drawing.Size(583, 403);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPesquisa);
      this.Controls.Add(this.btnVisualizar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.dgvUsuarios);
      this.Name = "frmUsuarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmUsuarios";
      this.Load += new System.EventHandler(this.frmUsuarios_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPesquisa;
    private System.Windows.Forms.Button btnVisualizar;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnNovo;
    private System.Windows.Forms.DataGridView dgvUsuarios;
  }
}