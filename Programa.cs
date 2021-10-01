using System;

namespace DIO.Series
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {
               
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                 switch (opcaoUsuario)
                 {
                     case "1":
                     ListarSeries();
                     break;
                     case "2":
                     InserirSerie();
                     break;
                     case "3":
                     AtualizarSerie();
                     break;
                     case "4":
                     ExcluirSerie();
                     break;
                     case "5":
                     VisualizarSerie();
                     break;
                     case "C":
                     Console.Clear();
                     break;

                     default:
                        throw new ArgumentOutOfRangeException();
                 }

                 opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("Obrigade por utilizar nossos serviços.");
            Console.ReadLine();
        
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = SeriesRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série encontrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId. serie.retornaId());
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da séire: "); 
            int entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: "); 
            string entradaDescricao = Console.ReadLine();   

            Serie novaSerie = new Serie (id: repositorio.ProximoId);
                                        genero: (Genero)entradaGenero;
                                        titulo: entradaTitulo;
                                        ano: entradaAno;
                                        descrição: entradaDescricao;

            repositorio.Insere(novaSerie);
        } 
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Séries a seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return ObterOpcaoUsuario;
        }


    }
}