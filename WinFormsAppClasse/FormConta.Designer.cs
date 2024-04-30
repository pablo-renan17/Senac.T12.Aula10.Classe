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
            btnDepositar = new Button();
            btnSacar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNovaConta
            // 
            btnNovaConta.Font = new Font("Segoe UI", 12F);
            btnNovaConta.Location = new Point(14, 141);
            btnNovaConta.Margin = new Padding(3, 2, 3, 2);
            btnNovaConta.Name = "btnNovaConta";
            btnNovaConta.Size = new Size(135, 31);
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
            groupBox1.Location = new Point(14, 13);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(422, 124);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conta";
            // 
            // txtTitularConta
            // 
            txtTitularConta.Location = new Point(198, 47);
            txtTitularConta.Margin = new Padding(3, 2, 3, 2);
            txtTitularConta.Name = "txtTitularConta";
            txtTitularConta.Size = new Size(219, 29);
            txtTitularConta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 25);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 2;
            label2.Text = "Titular da conta";
            // 
            // txtNumeroConta
            // 
            txtNumeroConta.Location = new Point(13, 47);
            txtNumeroConta.Margin = new Padding(3, 2, 3, 2);
            txtNumeroConta.Name = "txtNumeroConta";
            txtNumeroConta.Size = new Size(152, 29);
            txtNumeroConta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Número da conta";
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Segoe UI", 12F);
            btnDepositar.Location = new Point(157, 141);
            btnDepositar.Margin = new Padding(3, 2, 3, 2);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(135, 31);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Font = new Font("Segoe UI", 12F);
            btnSacar.Location = new Point(297, 141);
            btnSacar.Margin = new Padding(3, 2, 3, 2);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(135, 31);
            btnSacar.TabIndex = 4;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(418, 150);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // FormConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 352);
            Controls.Add(dataGridView1);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(groupBox1);
            Controls.Add(btnNovaConta);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormConta";
            Text = "Cadastro de Conta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaConta;
        private GroupBox groupBox1;
        private TextBox txtTitularConta;
        private Label label2;
        private TextBox txtNumeroConta;
        private Label label1;
        private Button btnDepositar;
        private Button btnSacar;
        private DataGridView dataGridView1;
    }
}
