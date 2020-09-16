namespace Estacionamento
{
  partial class frmCliente
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
      this.mskCPF = new System.Windows.Forms.MaskedTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
      this.btnCarros = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnEditar = new System.Windows.Forms.Button();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnRecibos = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // mskCPF
      // 
      this.mskCPF.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mskCPF.Location = new System.Drawing.Point(16, 163);
      this.mskCPF.Mask = "000,000,000-00";
      this.mskCPF.Name = "mskCPF";
      this.mskCPF.Size = new System.Drawing.Size(183, 29);
      this.mskCPF.TabIndex = 54;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(12, 138);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 22);
      this.label5.TabIndex = 53;
      this.label5.Text = "CPF";
      // 
      // mskTelefone
      // 
      this.mskTelefone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mskTelefone.Location = new System.Drawing.Point(16, 226);
      this.mskTelefone.Mask = "(00) 0 0000-0000";
      this.mskTelefone.Name = "mskTelefone";
      this.mskTelefone.Size = new System.Drawing.Size(183, 29);
      this.mskTelefone.TabIndex = 52;
      // 
      // btnCarros
      // 
      this.btnCarros.BackColor = System.Drawing.Color.DarkSlateGray;
      this.btnCarros.BackgroundImage = global::Estacionamento.Properties.Resources.carro;
      this.btnCarros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnCarros.FlatAppearance.BorderSize = 0;
      this.btnCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCarros.Location = new System.Drawing.Point(299, 30);
      this.btnCarros.Name = "btnCarros";
      this.btnCarros.Size = new System.Drawing.Size(97, 82);
      this.btnCarros.TabIndex = 51;
      this.btnCarros.UseVisualStyleBackColor = false;
      this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(309, 115);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 22);
      this.label1.TabIndex = 50;
      this.label1.Text = "Veículos";
      // 
      // btnEditar
      // 
      this.btnEditar.BackColor = System.Drawing.Color.Teal;
      this.btnEditar.FlatAppearance.BorderSize = 0;
      this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEditar.ForeColor = System.Drawing.Color.White;
      this.btnEditar.Location = new System.Drawing.Point(113, 279);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(185, 33);
      this.btnEditar.TabIndex = 49;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = false;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtID.Location = new System.Drawing.Point(14, 41);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(52, 29);
      this.txtID.TabIndex = 48;
      // 
      // txtNome
      // 
      this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNome.Location = new System.Drawing.Point(14, 106);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(170, 29);
      this.txtNome.TabIndex = 47;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(10, 201);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 22);
      this.label4.TabIndex = 46;
      this.label4.Text = "Telefone";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(10, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 22);
      this.label3.TabIndex = 45;
      this.label3.Text = "Nome";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(10, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 22);
      this.label2.TabIndex = 44;
      this.label2.Text = "ID";
      // 
      // btnSalvar
      // 
      this.btnSalvar.BackColor = System.Drawing.Color.Teal;
      this.btnSalvar.FlatAppearance.BorderSize = 0;
      this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalvar.ForeColor = System.Drawing.Color.White;
      this.btnSalvar.Location = new System.Drawing.Point(113, 318);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(185, 33);
      this.btnSalvar.TabIndex = 43;
      this.btnSalvar.Text = "Salvar Alterações";
      this.btnSalvar.UseVisualStyleBackColor = false;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnRecibos
      // 
      this.btnRecibos.BackColor = System.Drawing.Color.DarkSlateGray;
      this.btnRecibos.BackgroundImage = global::Estacionamento.Properties.Resources.valores;
      this.btnRecibos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnRecibos.FlatAppearance.BorderSize = 0;
      this.btnRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRecibos.Location = new System.Drawing.Point(297, 141);
      this.btnRecibos.Name = "btnRecibos";
      this.btnRecibos.Size = new System.Drawing.Size(97, 82);
      this.btnRecibos.TabIndex = 56;
      this.btnRecibos.UseVisualStyleBackColor = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new System.Drawing.Point(307, 226);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 22);
      this.label6.TabIndex = 55;
      this.label6.Text = "Recibos";
      // 
      // frmCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSlateGray;
      this.ClientSize = new System.Drawing.Size(406, 380);
      this.Controls.Add(this.btnRecibos);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.mskCPF);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.mskTelefone);
      this.Controls.Add(this.btnCarros);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnSalvar);
      this.Name = "frmCliente";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FrmCliente";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox mskCPF;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.MaskedTextBox mskTelefone;
    private System.Windows.Forms.Button btnCarros;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnRecibos;
    private System.Windows.Forms.Label label6;
  }
}