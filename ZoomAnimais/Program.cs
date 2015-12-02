using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomAnimais
{
    class Program
    {
        static void Main(string[] args)
        {


            List<AnimalBase> animais = new List<AnimalBase>();

           

            Random rand = new Random();
            

            for (int i = 0; i <= 5; i++ )
            {
             
                animais.Add(new Leao
                {
                    Nome = string.Format("Leao {0}", rand.Next(0, 100)),
                    Idade = rand.Next(0, 100),
                    IsFromCativeiro = Convert.ToBoolean(rand.Next()),
                    Peso = rand.Next(10, 100),

                });

                animais.Add(new Tigre
                {
                    Nome = string.Format("Tigre {0}", rand.Next(0, 100)),
                    Idade = rand.Next(0, 100),
                    IsFromCativeiro = Convert.ToBoolean(rand.Next()),
                    Peso = rand.Next(10, 100),

                });

                animais.Add(new Jacare
                {
                    Nome = string.Format("Jacare {0}", rand.Next(0, 100)),
                    Idade = rand.Next(0, 100),
                    IsFromCativeiro = Convert.ToBoolean(rand.Next()),
                    Peso = rand.Next(10, 100),

                });
                animais.Add(new Lagarto
                {
                    Nome = string.Format("Lagarto {0}", rand.Next(0, 100)),
                    Idade = rand.Next(0, 100),
                    IsFromCativeiro = Convert.ToBoolean(rand.Next()),
                    Peso = rand.Next(10, 100),

                });
                animais.Add(new Tucano
                {
                    Nome = string.Format("Tucano {0}", rand.Next(0, 100)),
                    Idade = rand.Next(0, 100),
                    IsFromCativeiro = Convert.ToBoolean(rand.Next()),
                    Peso = rand.Next(10, 100),

                });
                animais.Add(new Arara
                {
                    Nome = string.Format("Arara {0}", rand.Next(0, 100)),
                    Idade = rand.Next(0, 100),
                    IsFromCativeiro = Convert.ToBoolean(rand.Next()),
                    Peso = rand.Next(10, 100),

                });

              
            }


            int soma = animais.Sum(s => s.Idade);

            Console.WriteLine("Soma das idades de todos os animais = " + soma);


            int somaLeao = animais.Where(a => a.GetType() == typeof(Leao)).Sum(s => s.Idade);

            Console.WriteLine("Soma das idades de todos os leoes = " + somaLeao);
            

            int somaLagarto = animais.Where(a => a.GetType() == typeof(Lagarto)).Sum(s => s.Idade);

            Console.WriteLine("Soma das idades de todos os lagartos = " + somaLagarto);


            int somaMamifero = animais.Where(a => a.GetType().BaseType == typeof(MamiferoBase)).Sum(s => s.Idade);

            Console.WriteLine("Soma das idades de todos os mamíferos = " + somaMamifero);


            int somaRepteis = animais.Where(a => a.GetType().BaseType == typeof(ReptilBase)).Sum(s => s.Idade);

            Console.WriteLine("Soma das idades de todos os répteis = " + somaRepteis);


            int somaAves = animais.Where(a => a.GetType().BaseType == typeof(AveBase)).Sum(s => s.Idade);

            Console.WriteLine("Soma das idades de todas os aves = " + somaAves);


            int tigresCativeiro = animais.Count(a => a.GetType() == typeof(Tigre) && a.IsFromCativeiro);

            // var resultado = animais.Where(a => a.GetType() == typeof(Leao)).
            //      Select(a => new { a.Idade }).ToList();

            /*
            resultado.ForEach(a =>
            {
                // 
            });
            */



            Console.WriteLine("Todos os trigres que são oriundos de cativeiro = " + tigresCativeiro);





            int avesMaisDeDezAnos = animais.Count(a => a.GetType().BaseType == typeof(AveBase) && a.Idade > 10);

            Console.WriteLine("Todas as aves com mais de dez anos = " + avesMaisDeDezAnos);


            int animaisMaisDeQuinzeAnos = animais.Count(a => a.GetType().BaseType.BaseType == typeof(AnimalBase) && a.Idade > 15);

            Console.WriteLine("Todos os animais com mais de quinze anos = " + animaisMaisDeQuinzeAnos);

            int TucanosAdolescentePesados = animais.Count(a => a.GetType() == typeof(Tucano) && a.Peso > 10 && a.Idade > 10);

            Console.WriteLine("Todos os Tucanos com idade maior que 10 e peso maior que 10 = " + TucanosAdolescentePesados);



















            // var resultado = animais.Where(a => a.GetType() == typeof(Leao)).
            //      Select(a => new { a.Idade }).ToList();

            /*
            resultado.ForEach(a =>
            {
                // 
            });
            */

            Console.ReadKey();



        }
    }
}
