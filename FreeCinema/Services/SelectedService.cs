using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using FreeCinema.Helpers;

namespace FreeCinema.Services
{
    public class SelectedService : ISelectedService
    {
        const string key = "place_items_key";
        private readonly IFilmService filmService;
        private readonly HttpContext httpContext;
        public SelectedService(IHttpContextAccessor contextAccessor, IFilmService filmService)
        {
            this.filmService = filmService;
            this.httpContext = contextAccessor.HttpContext ?? throw new Exception();
        }
        private List<int> GetCartItems()
        {
            return httpContext.Session.Get<List<int>>(key) ?? new();
        }
        private void SaveCartItems(List<int> items)
        {
            httpContext.Session.Set(key, items);
        }
        public void Add(int id)
        {
            var ids = GetCartItems();
            ids.Add(id);
            SaveCartItems(ids);
        }
        public int GetCount()
        {
            return GetCartItems().Count;
        }
        public IEnumerable<int> GetPlaceIds()
        {
            return GetCartItems();
        }
        public async Task<IEnumerable<FilmDto>> GetPlaces()
        {
            var ids = GetCartItems();
            return await filmService.Get(ids);
        }
        public bool IsExists(int id)
        {
            return GetCartItems().Contains(id);
        }
        public void Remove(int id)
        {
            var ids = GetCartItems();
            ids.Remove(id);
            SaveCartItems(ids);
        }
    }
}
