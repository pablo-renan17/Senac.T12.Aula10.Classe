using WinFormsAppClasse.modelos;

namespace WinFormsAppClasse
{
    public partial class FormConta : Form
    {
        // criado um objeto chamado conta do tipo Conta
        Conta conta = new Conta();
        //array e lista são diferentes. list tem tamanho infinito, array tem que definir tamanho
        //criada uma lista de conta
        //listas tem nomes em plural
        List<Conta> contas = new List<Conta>();

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
            //adicioar a nova conta na lista
            contas.Add(conta);
            //carregar a tabela de dados datagridView
            //DataSource e a origem dos dados
            //atribuir a origem dos dados como null para poder adicionar mais contas
            dataGridView1.DataSource = null;
            //Agora atribuir os dados como a lista de contas
            dataGridView1.DataSource = contas;

            //limpas campos da tela
            txtNumeroConta.Clear();
            txtTitularConta.Clear();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Depositar(100);

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta.Sacar(100);

        }

        //o "e" desse metodo mostra as coordenadas do clique(importante)
        //RowIndex = pos da linha
        //CollumIndex = pos da coluna
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //se o indice da linha for maior ou igual a 0
            //significado que foi selecionada uma linha
            //se nao tem nada no grid, o RowIndex seria -1
            if(e.RowIndex >= 0)
            {
                //cria uma variavel d tipo conta baseado na lista de contas
                var contaSelecionada = contas[e.RowIndex];

                //atribui o texto para o campo de acordo o numeroConta da conta selecionada
                txtNumeroConta.Text = contaSelecionada.NumeroConta.ToString();
                txtTitularConta.Text = contaSelecionada.Nome;
            }
        }
    }
}
