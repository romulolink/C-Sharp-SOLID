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



            //Todos os Tigres que são animais de cativeiro
            var resultado = animais.Where(a => a.GetType() == typeof(Tigre) && a.IsFromCativeiro).ToList();


            resultado.ForEach(a => 
            {

                Console.WriteLine(a.ToString());

            });




            Console.WriteLine("Todos os tigres que são oriundos de cativeiro = " + tigresCativeiro);


            // Todas as Aves com mais de dez anos
            var avesMaisDezAnos = animais.Where(a => a.GetType().BaseType == typeof(AveBase) && a.Idade > 10).ToList();


            resultado.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });


            int avesMaisDeDezAnosCount = animais.Count(a => a.GetType().BaseType == typeof(AveBase) && a.Idade > 10);

            Console.WriteLine("Todas as aves com mais de dez anos = " + avesMaisDeDezAnosCount);


            // Todas os animais com mais de 15 anos.
            var AnimaisMaisQuinzeAnos = animais.Where(a => a.GetType().BaseType.BaseType == typeof(AnimalBase) && a.Idade > 15).ToList();


            AnimaisMaisQuinzeAnos.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });


            int animaisMaisDeQuinzeAnosCount = animais.Count(a => a.GetType().BaseType.BaseType == typeof(AnimalBase) && a.Idade > 15);

            Console.WriteLine("Todos os animais com mais de quinze anos : " + animaisMaisDeQuinzeAnosCount);


            // Todos o tucanos que possuem mais que 10 anos e que o peso seja maior que 10kg
            var TucanosMaisQ10anosquilos = animais.Where(a => a.GetType() == typeof(Tucano) && a.Peso > 10 && a.Idade > 10).ToList();


            TucanosMaisQ10anosquilos.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });



            int TucanosAdolescentePesadosCount = animais.Count(a => a.GetType() == typeof(Tucano) && a.Peso > 10 && a.Idade > 10);

            Console.WriteLine("Todos os Tucanos com idade maior que 10 e peso maior que 10 : " + TucanosAdolescentePesadosCount);





            Console.WriteLine("Todos os Jacarés com idade maior que 30 e peso maior que 50 e sao de cativeiro  " + TucanosAdolescentePesadosCount);

           var JacaresMais30AnosPesados = animais.Where(a => a.GetType() == typeof(Jacare) && a.Peso > 50 && a.Idade > 30 && !a.IsFromCativeiro ).ToList();


            JacaresMais30AnosPesados.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });









            Console.WriteLine("Todos os animais ordenados pelo tamanho do nome de maneira ascendente");
            //ja ordena em ascendente
            var AnimasOrdemAscendente = animais.OrderBy(a => a.Nome.Length).ToList();


            AnimasOrdemAscendente.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });





            Console.WriteLine("Todos os répteis ordenados pelo peso de maneira ascendente");



            var AnimasRepteisOrdemAscendente = animais.Where(a => a.GetType().BaseType == typeof(ReptilBase) ).OrderBy(a => a.Peso).ToList();


            AnimasRepteisOrdemAscendente.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });











            Console.WriteLine("Todas as araras oriundas de cativeiro com peso maior que 10kg e mais de 5 anos ordenadas de maneira descendente pela idade.");

            var ArarasCativeiro10kg5anosDesc = animais.Where(a => a.GetType() == typeof(Arara) && a.Peso> 10 && a.Idade > 10).OrderByDescending(a => a.Idade).ToList();

            ArarasCativeiro10kg5anosDesc.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });




            Console.WriteLine("Todos os leoes e araras com mais de 10 anos que nao seja oriundos de cativeiro ordenaods pelo tamanho do nome de maneira descendente.");

            var LeoesAraras10anosCativeiro = animais.Where(a => (a.GetType() == typeof(Arara) || a.GetType() == typeof(Leao)) && a.Peso > 10 && a.Idade > 10 && !a.IsFromCativeiro).OrderByDescending(a => a.Nome).ToList();

            LeoesAraras10anosCativeiro.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });


            Console.WriteLine("Todos os mamíferos e aves oriundos de cativeiro ordenados por altura de maneira ascendente.");

            var MamiferoAvesCativeiroPorAltura = animais.Where(a => a.GetType().BaseType == typeof(MamiferoBase) || a.GetType().BaseType == typeof(AveBase) && a.IsFromCativeiro).OrderBy(a => a.Altura).ToList();

            MamiferoAvesCativeiroPorAltura.ForEach(a =>
            {

                Console.WriteLine(a.ToString());

            });


            Console.WriteLine("A quantidade de cada animal presente na lista");

           
            var animaisAgrupados = animais.GroupBy(a => a.GetType()).ToList();

            animaisAgrupados.ForEach(a =>
            {
                Console.WriteLine("{0}, {1}", a.Key.Name, a.Count());
                
            });




            Console.ReadKey();



        }
    }
}
