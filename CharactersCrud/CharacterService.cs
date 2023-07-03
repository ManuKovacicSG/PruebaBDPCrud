using System.Text.Json;

namespace BlazorCRUD.model
{
    public class CharacterService : ICharacterInterface
    {
        private readonly HttpClient _httpClient;
        const string _baseUrl = "http://albertbdp.somee.com/api/";
        const string _charactersEndpoint = "actores";



        public CharacterService(HttpClient httpClient) => _httpClient = httpClient;


        public async Task<List<CharacterItem>> GetFilms(List<CharacterItem> characterItem)
        {
            ConfigureHttpClient();

            var response = await _httpClient.GetAsync(_charactersEndpoint);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();

            CharacterDto? dto = await JsonSerializer.DeserializeAsync<CharacterDto>(stream);
            return dto.data.Select(item => new CharacterItem
            {
                Id = item.id,
                Name = item.name,
                Description = item.description,
                BirthDate = item.birthDate,
                Foto = item.foto
            }).ToList();

        }

        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = new Uri(_baseUrl);

        }

        Task<List<CharacterItem>> ICharacterInterface.GetCharacters()
        {
            throw new NotImplementedException();
        }

    }
}
