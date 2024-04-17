namespace WinFormsAppClasse
{
    partial class FormConta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNovaConta = new Button();
            groupBox1 = new GroupBox();
            txtTitularConta = new TextBox();
            label2 = new Label();
            txtNumeroConta = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            btnDepositar = new Button();
            btnSacar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaConta
            // 
            btnNovaConta.Font = new Font("Segoe UI", 12F);
            btnNovaConta.Location = new Point(16, 188);
            btnNovaConta.Name = "btnNovaConta";
            btnNovaConta.Size = new Size(154, 41);
            btnNovaConta.TabIndex = 0;
            btnNovaConta.Text = "Nova conta";
            btnNovaConta.UseVisualStyleBackColor = true;
            btnNovaConta.Click += btnNovaConta_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTitularConta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumeroConta);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(16, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 165);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conta";
            // 
            // txtTitularConta
            // 
            txtTitularConta.Location = new Point(226, 63);
            txtTitularConta.Name = "txtTitularConta";
            txtTitularConta.Size = new Size(250, 34);
            txtTitularConta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 33);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 2;
            label2.Text = "Titular da conta";
            // 
            // txtNumeroConta
            // 
            txtNumeroConta.Location = new Point(15, 63);
            txtNumeroConta.Name = "txtNumeroConta";
            txtNumeroConta.Size = new Size(173, 34);
            txtNumeroConta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 33);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Número da conta";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(18, 246);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(474, 164);
            listBox1.TabIndex = 2;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Segoe UI", 12F);
            btnDepositar.Location = new Point(179, 188);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(154, 41);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Font = new Font("Segoe UI", 12F);
            btnSacar.Location = new Point(339, 188);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(154, 41);
            btnSacar.TabIndex = 4;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // FormConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 426);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnNovaConta);
            Name = "FormConta";
            Text = "Cadastro de Conta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaConta;
        private GroupBox groupBox1;
        private TextBox txtTitularConta;
        private Label label2;
        private TextBox txtNumeroConta;
        private Label label1;
        private ListBox listBox1;
        private Button btnDepositar;
        private Button btnSacar;
    }
}
