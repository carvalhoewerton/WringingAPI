using WringingAPi.Model;

namespace WringingAPi.Service;

public interface IFilmeService
{
    Task<FilmeOMDB> GetFilmeAsync(string titulo);
}