namespace Estacionamento
{
  partial class frmVaga
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaga));
      this.txtCheckout = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtIDCarro = new System.Windows.Forms.TextBox();
      this.txtIDCliente = new System.Windows.Forms.TextBox();
      this.txtCheckin = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtModeloCarro = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnFinalizar = new System.Windows.Forms.Button();
      this.txtNomeCliente = new System.Windows.Forms.TextBox();
      this.label = new System.Windows.Forms.Label();
      this.btnIniciar = new System.Windows.Forms.Button();
      this.ucVeiculos = new Estacionamento.ucVeiculos();
      this.ucCliente = new Estacionamento.ucCliente();
      this.SuspendLayout();
      // 
      // txtCheckout
      // 
      this.txtCheckout.Enabled = false;
      this.txtCheckout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCheckout.Location = new System.Drawing.Point(293, 139);
      this.txtCheckout.Name = "txtCheckout";
      this.txtCheckout.Size = new System.Drawing.Size(183, 29);
      this.txtCheckout.TabIndex = 55;
      this.txtCheckout.DoubleClick += new System.EventHandler(this.textBox3_DoubleClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(289, 114);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(93, 22);
      this.label3.TabIndex = 54;
      this.label3.Text = "Check-out";
      // 
      // txtIDCarro
      // 
      this.txtIDCarro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtIDCarro.Location = new System.Drawing.Point(282, 55);
      this.txtIDCarro.Name = "txtIDCarro";
      this.txtIDCarro.Size = new System.Drawing.Size(42, 29);
      this.txtIDCarro.TabIndex = 53;
      this.txtIDCarro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCarro_KeyPress);
      // 
      // txtIDCliente
      // 
      this.txtIDCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtIDCliente.Location = new System.Drawing.Point(29, 55);
      this.txtIDCliente.Name = "txtIDCliente";
      this.txtIDCliente.Size = new System.Drawing.Size(42, 29);
      this.txtIDCliente.TabIndex = 52;
      this.txtIDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCliente_KeyPress);
      // 
      // txtCheckin
      // 
      this.txtCheckin.Enabled = false;
      this.txtCheckin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCheckin.Location = new System.Drawing.Point(56, 139);
      this.txtCheckin.Name = "txtCheckin";
      this.txtCheckin.Size = new System.Drawing.Size(183, 29);
      this.txtCheckin.TabIndex = 51;
      this.txtCheckin.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(52, 114);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 22);
      this.label2.TabIndex = 50;
      this.label2.Text = "Check-in";
      // 
      // txtModeloCarro
      // 
      this.txtModeloCarro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtModeloCarro.Location = new System.Drawing.Point(330, 55);
      this.txtModeloCarro.Name = "txtModeloCarro";
      this.txtModeloCarro.Size = new System.Drawing.Size(183, 29);
      this.txtModeloCarro.TabIndex = 49;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(330, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 22);
      this.label1.TabIndex = 48;
      this.label1.Text = "Carro";
      // 
      // btnFinalizar
      // 
      this.btnFinalizar.BackColor = System.Drawing.Color.Brown;
      this.btnFinalizar.FlatAppearance.BorderSize = 0;
      this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnFinalizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFinalizar.ForeColor = System.Drawing.Color.White;
      this.btnFinalizar.Location = new System.Drawing.Point(282, 215);
      this.btnFinalizar.Name = "btnFinalizar";
      this.btnFinalizar.Size = new System.Drawing.Size(185, 33);
      this.btnFinalizar.TabIndex = 47;
      this.btnFinalizar.Text = "Finalizar";
      this.btnFinalizar.UseVisualStyleBackColor = false;
      this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
      // 
      // txtNomeCliente
      // 
      this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNomeCliente.Location = new System.Drawing.Point(77, 55);
      this.txtNomeCliente.Name = "txtNomeCliente";
      this.txtNomeCliente.Size = new System.Drawing.Size(183, 29);
      this.txtNomeCliente.TabIndex = 46;
      // 
      // label
      // 
      this.label.AutoSize = true;
      this.label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
      this.label.ForeColor = System.Drawing.Color.White;
      this.label.Location = new System.Drawing.Point(25, 30);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(66, 22);
      this.label.TabIndex = 45;
      this.label.Text = "Cliente";
      // 
      // btnIniciar
      // 
      this.btnIniciar.BackColor = System.Drawing.Color.Teal;
      this.btnIniciar.FlatAppearance.BorderSize = 0;
      this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnIniciar.ForeColor = System.Drawing.Color.White;
      this.btnIniciar.Location = new System.Drawing.Point(75, 215);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(185, 33);
      this.btnIniciar.TabIndex = 44;
      this.btnIniciar.Text = "Iniciar";
      this.btnIniciar.UseVisualStyleBackColor = false;
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // ucVeiculos
      // 
      this.ucVeiculos.Location = new System.Drawing.Point(29, 55);
      this.ucVeiculos.Name = "ucVeiculos";
      this.ucVeiculos.Size = new System.Drawing.Size(515, 120);
      this.ucVeiculos.TabIndex = 57;
      this.ucVeiculos.Visible = false;
      this.ucVeiculos.VisibleChanged += new System.EventHandler(this.ucVeiculos_VisibleChanged);
      // 
      // ucCliente
      // 
      this.ucCliente.Location = new System.Drawing.Point(29, 55);
      this.ucCliente.Name = "ucCliente";
      this.ucCliente.Size = new System.Drawing.Size(378, 181);
      this.ucCliente.TabIndex = 56;
      this.ucCliente.Visible = false;
      this.ucCliente.VisibleChanged += new System.EventHandler(this.ucCliente_VisibleChanged);
      // 
      // frmVaga
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkSlateGray;
      this.ClientSize = new System.Drawing.Size(552, 306);
      this.Controls.Add(this.ucVeiculos);
      this.Controls.Add(this.ucCliente);
      this.Controls.Add(this.txtCheckout);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtIDCarro);
      this.Controls.Add(this.txtIDCliente);
      this.Controls.Add(this.txtCheckin);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtModeloCarro);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnFinalizar);
      this.Controls.Add(this.txtNomeCliente);
      this.Controls.Add(this.label);
      this.Controls.Add(this.btnIniciar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmVaga";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Estacionamento 24H - Vaga";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtCheckout;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtIDCarro;
    private System.Windows.Forms.TextBox txtIDCliente;
    private System.Windows.Forms.TextBox txtCheckin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtModeloCarro;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnFinalizar;
    private System.Windows.Forms.TextBox txtNomeCliente;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Button btnIniciar;
    private ucCliente ucCliente;
    private ucVeiculos ucVeiculos;
  }
}