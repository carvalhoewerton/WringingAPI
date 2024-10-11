using System.Text.Json;
using WringingAPi.Model;

namespace WringingAPi.Configuration;

public class FilmeClient : IFilmeClient
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public FilmeClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["TmdbApi:ApiKey"];
    }
    
    public async Task<FilmeOMDB> getFilmeOMDB(string titulo)
    {
        var response = await _httpClient.GetAsync($"?t={titulo}&apikey={_apiKey}");
        var content = await response.Content.ReadAsStringAsync();
        var filme = JsonSerializer.Deserialize<FilmeOMDB>(content);

        return filme;
    }
}