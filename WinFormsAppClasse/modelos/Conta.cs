// nome do espaço organizar o projeto
namespace WinFormsAppClasse.modelos
{
    // classe ( visibilidade, tipo, nome)
    public class Conta
    {
        // propriedade (visibilida, tipo nome)
        //get e set sao nulos no comeco por padrao
        //e possivel atribuir valores ao get set por padrao. Ex:
        //: public int NumeroConta { get; set; } = 100;
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public decimal Saldo { get; set; }

        // metodo vazio
        // parametro: decimal valor
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
