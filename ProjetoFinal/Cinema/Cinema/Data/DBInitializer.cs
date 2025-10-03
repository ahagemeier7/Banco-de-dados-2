using Cinema.Models;

namespace Cinema.Data
{
    public class DBInitializer
    {
        public static void Initialize(CinemaContext context)
        {
            context.Database.EnsureCreated();

            
            if (context.Filmes.Any())
            {
                return;
            }

            var filmes = new Filmes[]
            {
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false},
                new Filmes{Titulo="teste",Duracao=DateTime.Parse("2001-09-01"),Classificacao="18",Elenco="joao",Diretor="Paulo",Ativo=false}
            };
            foreach (Filmes f in filmes)
            {
                context.Filmes.Add(f);
            }
            context.SaveChanges();
        }
    }
}
