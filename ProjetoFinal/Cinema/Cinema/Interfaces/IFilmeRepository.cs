using Cinema.Models;

namespace Cinema.Interfaces
{
    public interface IFilmeRepository
    {
        public Task Create(Filmes filme);
        public Task Update(Filmes filme);
        public Task Delete(Filmes filme);
        public Task<Filmes> GetById(int id);
        public Task<List<Filmes>> GetAll();
        public Task<List<Filmes>> GetByName(string name);
    }
}
