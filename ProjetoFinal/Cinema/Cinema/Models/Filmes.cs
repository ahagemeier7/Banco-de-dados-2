using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.IO;

namespace Cinema.Models
{
    public class Filmes
    {
        public int FilmeId { get; set; }
        public string? Titulo { get; set; }
        public DateTime Duracao { get; set; }
        public string? Classificacao { get; set; }
        public string? Elenco { get; set; }
        public string? Diretor { get; set; }
        public bool Ativo { get; set; }
    }
}
