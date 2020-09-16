namespace Estacionamento
{
  partial class frmLogin
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnFechar = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.btnEntrar = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPass = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.btnFechar);
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(329, 90);
      this.panel1.TabIndex = 17;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Estacionamento.Properties.Resources.login;
      this.pictureBox1.Location = new System.Drawing.Point(55, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(85, 78);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(146, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 46);
      this.label1.TabIndex = 20;
      this.label1.Text = "Login";
      // 
      // btnFechar
      // 
      this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
      this.btnFechar.FlatAppearance.BorderSize = 0;
      this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFechar.ForeColor = System.Drawing.Color.White;
      this.btnFechar.Location = new System.Drawing.Point(290, 3);
      this.btnFechar.Name = "btnFechar";
      this.btnFechar.Size = new System.Drawing.Size(35, 29);
      this.btnFechar.TabIndex = 4;
      this.btnFechar.Text = "X";
      this.btnFechar.UseVisualStyleBackColor = false;
      this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
      // 
      // btnSair
      // 
      this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
      this.btnSair.FlatAppearance.BorderSize = 0;
      this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSair.ForeColor = System.Drawing.Color.White;
      this.btnSair.Location = new System.Drawing.Point(169, 257);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(105, 33);
      this.btnSair.TabIndex = 14;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = false;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // btnEntrar
      // 
      this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
      this.btnEntrar.FlatAppearance.BorderSize = 0;
      this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEntrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEntrar.ForeColor = System.Drawing.Color.White;
      this.btnEntrar.Location = new System.Drawing.Point(58, 257);
      this.btnEntrar.Name = "btnEntrar";
      this.btnEntrar.Size = new System.Drawing.Size(105, 33);
      this.btnEntrar.TabIndex = 13;
      this.btnEntrar.Text = "Entrar";
      this.btnEntrar.UseVisualStyleBackColor = false;
      this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(55, 182);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 26);
      this.label3.TabIndex = 16;
      this.label3.Text = "Senha";
      // 
      // txtUsuario
      // 
      this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsuario.Location = new System.Drawing.Point(58, 141);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(218, 29);
      this.txtUsuario.TabIndex = 11;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(55, 112);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 26);
      this.label2.TabIndex = 15;
      this.label2.Text = "Usuário";
      // 
      // txtPass
      // 
      this.txtPass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPass.Location = new System.Drawing.Point(58, 211);
      this.txtPass.Name = "txtPass";
      this.txtPass.Size = new System.Drawing.Size(218, 29);
      this.txtPass.TabIndex = 12;
      // 
      // frmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkCyan;
      this.ClientSize = new System.Drawing.Size(329, 334);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnEntrar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPass);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmLogin";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnFechar;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPass;
  }
}