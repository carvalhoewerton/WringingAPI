using WringingAPi.Configuration;
using WringingAPi.Model;

namespace WringingAPi.Service;

public class FilmeService :IFilmeService
{
    
    private readonly IFilmeClient _filmeClient;

    public FilmeService(IFilmeClient filmeClient)
    {
        _filmeClient = filmeClient;
    }

    public async Task<FilmeOMDB> GetFilmeAsync(string titulo)
    {
        return await _filmeClient.getFilmeOMDB(titulo);
    }
}