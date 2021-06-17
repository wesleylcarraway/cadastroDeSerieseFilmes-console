using System;

namespace DIO.Series
{
    public class ProcessarFilme : Processar
    {
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();

        public override void Excluir()
		{                     
            Console.Write("Digite o id do filme: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorioFilme.Exclui(indiceSerie);	
		}

        public override void Visualizar()
		{          
            Console.Write("Digite o id do filme: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorioFilme.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);            			
		}

        public override void Atualizar()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioFilme.Atualiza(indiceFilme, atualizaFilme);
        }

        public override void Listar()
        {
            Console.WriteLine("Filmes: ");

            var lista = repositorioFilme.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach(var filme in lista)
            {
                var excluido = filme.RetornarExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", filme.RetornaId(), filme.RetornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        public override void Inserir()
        {
            Console.WriteLine("Inserir novo filme");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título do filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de início do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorioFilme.Insere(novoFilme);            
        }
    }
}