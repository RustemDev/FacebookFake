using System;
using Facebookfake.usuarios;
using System.Collections.Generic;


namespace Facebookfake
{

    class Program
    {
        //Arreys 
        // Condicionais
        // Loop
        // variaveis
        static void Main(string[] args)
        {



            string nome = "";
            int senha = 0;


            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 2; i++)
            {
                Pessoa usuario1 = new Pessoa();

                Console.WriteLine("Informe o nome do usuario ");
                usuario1.Nome = Console.ReadLine();

                Console.WriteLine("Informe a idade do usuario ");
                usuario1.Idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a senha do usuario");
                usuario1.Senha = Convert.ToInt32(Console.ReadLine());

                pessoas.Add(usuario1);
            }


            Console.WriteLine("Favor inserir nome para logar  " );
            nome = (Console.ReadLine());

            Console.WriteLine("Favor inserir senha ");
            senha = Convert.ToInt32(Console.ReadLine());

            for (int usu = 0; usu < pessoas.Count; usu++)
            {
                if (pessoas[usu].Nome == nome && pessoas[usu].Senha== senha)
                {
                    Console.WriteLine("Parabéns você está logado ");
                }
                else if (pessoas[usu].Idade == 85 || pessoas[usu].Idade== 102)
                {
                    Console.WriteLine("Você está velho ");
                }
                else
                {
                    Console.WriteLine("Nome ou senha invalidos ");
                }

                Console.ReadLine();
                

                
            }




            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if (pessoas[i].Nome == nome && senha == 123)
            //    {

            //    }
            //}

            //List<Pessoa> listaPessoas = new List<Pessoa>();


            //for (int i = 0; i < 2; i++)
            //{
            //    Pessoa pp = new Pessoa();

            //    Console.WriteLine("");
            //    Console.WriteLine("informe o nome");
            //    pp.Nome = Console.ReadLine();

            //    Console.WriteLine("informe a idade");
            //    pp.Idade = Convert.ToInt32(Console.ReadLine());

            //    listaPessoas.Add(pp);

            //}

        }
    }
}




