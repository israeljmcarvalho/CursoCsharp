///*
//HOTKEYS
//Shift + Alt + C = New Class
//Ctrl + K + D = Auto Identity
//Ctrl + W + S = Solution Explorer

//S5 - Construtores, palavra this, sobrecarga, encapsulamento

//*/

//using System;
//using System.Globalization;

//namespace nsCursoCsharp
//{
//    class S5_Main
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Entre os dados do produto:");
//            Console.Write("Nome: ");
//            string nome = Console.ReadLine();

//            Console.Write("Preço: ");
//            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.Write("Quantidade no estoque: ");
//            int quantidade = int.Parse(Console.ReadLine());


//            //Utilizando o CONSTRUTOR PADRÃO
//            //S5_Produto P1 = new S5_Produto();

//            //Utilizando o CONSTRUTOR_II
//            //S5_Produto P1 = new S5_Produto(preco);

//            //Utilizando o CONSTRUTOR_III 
//            S5_Produto P1 = new S5_Produto(nome, preco, quantidade);


//            // Sintaxe que seria utilizada para atribuir um valor para o atributo _nome utilizando o método Set
//            //P1.SetNome("Bike");

//            //Atribuindo valor "Bike" para o atributo _nome através da Property Nome
//            P1.Nome = "Bike";

//            Console.WriteLine("Dados do produto: " + P1);

//            Console.WriteLine(Environment.NewLine);

//            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
//            int qte = int.Parse(Console.ReadLine());
//            P1.AdicionarProdutos(qte);
//            Console.WriteLine("Dados atualizados: " + P1);
//            Console.WriteLine(Environment.NewLine);

//            Console.Write("Digite o número de produtos a ser removido do estoque: ");
//            qte = int.Parse(Console.ReadLine());
//            P1.RemoverProdutos(qte);
//            P1.ImprimirResultado();
//            Console.WriteLine(P1);
            
            
//            Console.WriteLine();
//        }
//    }
//}