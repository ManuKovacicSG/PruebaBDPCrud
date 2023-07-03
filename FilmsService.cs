using System.Text.Json;


namespace BlazorCRUD.model
{
    public class FilmsService : IFilmsInterface
    {
        private readonly HttpClient _httpClient;
        const string _baseUrl = "http://albertbdp.somee.com/api/";
        const string _filmsEndpoint = "peliculas";



        public FilmsService(HttpClient httpClient) => _httpClient = httpClient;


        public async Task<List<FilmItem>> GetFilms(List<FilmItem> filmItem)
        {
            ConfigureHttpClient();

            var response = await _httpClient.GetAsync(_filmsEndpoint);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();

            FilmsDto? dto = await JsonSerializer.DeserializeAsync<FilmsDto>(stream);
            return dto.data.Select(item => new FilmItem
            {
                Name = item.name,
                Gendre = item.gendre.name,
                Character = item.characters,
                PosterUrl = item.poster
            }).ToList();

        }

        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = new Uri(_baseUrl);

        }

        Task<List<FilmItem>> IFilmsInterface.GetFilms()
        {
            throw new NotImplementedException();
        }

    }
}
