namespace Cinema.Models
{
    public class ReviewsFilmes
    {
        public int ReviewId {  get; set; }
        public int FilmeId { get; set; }
        public int Nota { get; set; }
        public string? Descricao { get; set; }
    }
}
