namespace Estacionamento
{
  partial class frmUsuario
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
      this.btnEditar = new System.Windows.Forms.Button();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnEditar
      // 
      this.btnEditar.BackColor = System.Drawing.Color.Teal;
      this.btnEditar.FlatAppearance.BorderSize = 0;
      this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEditar.ForeColor = System.Drawing.Color.White;
      this.btnEditar.Location = new System.Drawing.Point(30, 213);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(185, 33);
      this.btnEditar.TabIndex = 37;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = false;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtID.Location = new System.Drawing.Point(30, 34);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(52, 29);
      this.txtID.TabIndex = 36;
      // 
      // txtSenha
      // 
      this.txtSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSenha.Location = new System.Drawing.Point(30, 156);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.Size = new System.Drawing.Size(183, 29);
      this.txtSenha.TabIndex = 35;
      // 
      // txtUsuario
      // 
      this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsuario.Location = new System.Drawing.Point(30, 99);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(183, 29);
      this.txtUsuario.TabIndex = 34;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(24, 131);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 22);
      this.label4.TabIndex = 33;
      this.label4.Text = "Senha";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(26, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 22);
      this.label3.TabIndex = 32;
      this.label3.Text = "Login";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(26, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 22);
      this.label2.TabIndex = 31;
      this.label2.Text = "ID";
      // 
      // btnSalvar
      // 
      this.btnSalvar.BackColor = System.Drawing.Color.Teal;
      this.btnSalvar.FlatAppearance.BorderSize = 0;
      this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalvar.ForeColor = System.Drawing.Color.White;
      this.btnSalvar.Location = new System.Drawing.Point(28, 252);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(185, 33);
      this.btnSalvar.TabIndex = 30;
      this.btnSalvar.Text = "Salvar Alterações";
      this.btnSalvar.UseVisualStyleBackColor = false;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // frmUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSlateGray;
      this.ClientSize = new System.Drawing.Size(239, 312);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnSalvar);
      this.Name = "frmUsuario";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmUsuario";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSalvar;
  }
}