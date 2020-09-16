namespace Estacionamento
{
  partial class frmExcluir
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
      this.lblQuestao = new System.Windows.Forms.Label();
      this.btnSim = new System.Windows.Forms.Button();
      this.btnNao = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // lblQuestao
      // 
      this.lblQuestao.AutoSize = true;
      this.lblQuestao.BackColor = System.Drawing.Color.DarkSlateGray;
      this.lblQuestao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQuestao.ForeColor = System.Drawing.Color.White;
      this.lblQuestao.Location = new System.Drawing.Point(24, 23);
      this.lblQuestao.Name = "lblQuestao";
      this.lblQuestao.Size = new System.Drawing.Size(234, 19);
      this.lblQuestao.TabIndex = 33;
      this.lblQuestao.Text = "Tem certeza que quer excluir?";
      // 
      // btnSim
      // 
      this.btnSim.BackColor = System.Drawing.Color.Teal;
      this.btnSim.FlatAppearance.BorderSize = 0;
      this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSim.ForeColor = System.Drawing.Color.White;
      this.btnSim.Location = new System.Drawing.Point(41, 77);
      this.btnSim.Name = "btnSim";
      this.btnSim.Size = new System.Drawing.Size(86, 30);
      this.btnSim.TabIndex = 35;
      this.btnSim.Text = "Sim";
      this.btnSim.UseVisualStyleBackColor = false;
      this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
      // 
      // btnNao
      // 
      this.btnNao.BackColor = System.Drawing.Color.Teal;
      this.btnNao.FlatAppearance.BorderSize = 0;
      this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNao.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNao.ForeColor = System.Drawing.Color.White;
      this.btnNao.Location = new System.Drawing.Point(147, 77);
      this.btnNao.Name = "btnNao";
      this.btnNao.Size = new System.Drawing.Size(86, 30);
      this.btnNao.TabIndex = 34;
      this.btnNao.Text = "Não";
      this.btnNao.UseVisualStyleBackColor = false;
      this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(282, 152);
      this.panel1.TabIndex = 36;
      // 
      // frmExcluir
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 152);
      this.Controls.Add(this.lblQuestao);
      this.Controls.Add(this.btnSim);
      this.Controls.Add(this.btnNao);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmExcluir";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmExcluir";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblQuestao;
    private System.Windows.Forms.Button btnSim;
    private System.Windows.Forms.Button btnNao;
    private System.Windows.Forms.Panel panel1;
  }
}