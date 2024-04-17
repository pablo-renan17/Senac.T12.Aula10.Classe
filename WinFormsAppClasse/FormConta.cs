namespace WinFormsAppClasse
{
    public partial class FormConta : Form
    {
        // criado um objeto chamado conta do tipo Conta
        Conta conta = new Conta();

        public FormConta()
        {
            InitializeComponent();
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            conta = new Conta();
            // determinei os atributos do objeto conta
            // obtendo o texto do txtNumeroConta e atribuindo ao NumeroConta
            conta.NumeroConta = int.Parse(txtNumeroConta.Text);
            conta.Nome = txtTitularConta.Text;
            conta.Depositar(100);


            // carregar o listbox com os dados da conta.
            string dadosConta = "Numero: " + conta.NumeroConta +
                                " Titular: " + conta.Nome +
                                " Saldo:   " + conta.Saldo;

            listBox1.Items.Add(dadosConta);



        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Depositar(100);
            string dadosConta = "Numero: " + conta.NumeroConta +
                                " Titular: " + conta.Nome +
                                " Saldo:   " + conta.Saldo;

            listBox1.Items.Add(dadosConta);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta.Sacar(100);
            string dadosConta = "Numero: " + conta.NumeroConta +
                    " Titular: " + conta.Nome +
                    " Saldo:   " + conta.Saldo;

            listBox1.Items.Add(dadosConta);
        }
    }
}
