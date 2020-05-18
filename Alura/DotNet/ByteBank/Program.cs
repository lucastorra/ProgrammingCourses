using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao(); 

            Console.ReadLine(); 
        }

        public static void CalcularBonificacao() 
        {
            BonusManager gerenciadorBonificacao = new BonusManager();

            Employee pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Employee roberta = new Ceo("159.753.398-04");
            roberta.Nome = "Roberta";

            Employee igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Employee camila = new AccountManager("326.985.628-89");
            camila.Nome = "Camila";

            Developer guilherme = new Developer("456.175.468-20"); 
            guilherme.Nome = "Guilherme"; 

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}