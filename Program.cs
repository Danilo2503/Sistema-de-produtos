using System;

namespace Sistema_de_produtos
{
    class Program
    {
        private static float promo;

        static void Main(string[] args)
        {   
            string[] nome = new string [10];
            float[] preco = new float [10];
            

            Console.WriteLine("---------------------------------");
            Console.WriteLine("----Gerenciamento de Produtos----");
            Console.WriteLine("---------------------------------");

            bool Promocao;

            do
            {
                Console.WriteLine("Informe o valor do produto:");
                string produto = Console.ReadLine();
                Promocao = VerPreco(promo);
            } while (!Promocao);


            int escolha;

                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("Selecione uma das seguintes opções:");
                    Console.WriteLine("[1] Cadastrar produtos");
                    Console.WriteLine("[2] Listar produtos");
                    Console.WriteLine("[3] Sair");
                    escolha = int.Parse(Console.ReadLine());

                        switch(escolha)
                        {
                            case 1: 

                                int contador = 0;

                                do
                                {
                                    if (contador < 10)
                                    {
                                        Console.WriteLine($"Informe o nome do {contador + 1} produto");
                                        nome [contador] = Console.ReadLine();
                                        Console.WriteLine($"Digite o preço do {contador + 1} produto");
                                        preco [contador] = float.Parse(Console.ReadLine());
                                        contador++;
                                    }else{
                                        Console.WriteLine("Produto inválido");
                                    }
                                } while (escolha == 1);
                            break;

                            case 2:

                                for (var i = 0; i < 10; i++)
                                {
                                    Console.WriteLine($"Produto {nome[i]}");
                                }
                            break;

                            case 0:
                                //Sair
                                
                            break;    
                        }

                } while (escolha != 0);
                
                bool VerPreco(float promo){

                    if (promo == 10)
                    {
                        Console.WriteLine("Parabéns,o produto está em promoção!");
                        return true;
                    }
                    else{
                        Console.WriteLine("Esse produto não está em promoção no momento");
                        return false;
                    }
                }

        }

        private static bool VerPreco(object promo)
        {
            throw new NotImplementedException();
        }
    }
}
