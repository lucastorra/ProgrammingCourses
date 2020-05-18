using System;
using ByteBank.Employees;
using ByteBank.Systems;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateBonus(); 
            UsingSystem();

            Console.ReadLine(); 
        }

        public static void UsingSystem()
        {
            InternalSystem internalSystem = new InternalSystem();

            Ceo roberta = new Ceo("13123213");
            roberta.Name = "Roberta";
            roberta.Password = "123";

            AccountManager camila = new AccountManager("13123213");
            camila.Name = "Roberta";
            camila.Password = "123";


            internalSystem.SignIn(roberta, "123");
            internalSystem.SignIn(roberta, "345");

            internalSystem.SignIn(camila, "123");
            internalSystem.SignIn(camila, "345");


        }

        public static void CalculateBonus() 
        {
            BonusManager bonusManager = new BonusManager();

            Employee pedro = new Designer("833.222.048-39");
            pedro.Name = "Pedro";

            Employee roberta = new Ceo("159.753.398-04");
            roberta.Name = "Roberta";

            Employee igor = new Auxiliar("981.198.778-53");
            igor.Name = "Igor";

            Employee camila = new AccountManager("326.985.628-89");
            camila.Name = "Camila";

            Developer guilherme = new Developer("456.175.468-20"); 
            guilherme.Name = "Guilherme";

            bonusManager.Record(guilherme);
            bonusManager.Record(pedro);
            bonusManager.Record(roberta);
            bonusManager.Record(igor);
            bonusManager.Record(camila);

            Console.WriteLine("Total de bonificações do mês " + bonusManager.GetTotalBonus());
        }
    }
}