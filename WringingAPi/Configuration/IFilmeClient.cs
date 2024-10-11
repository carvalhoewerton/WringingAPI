using WringingAPi.Model;

namespace WringingAPi.Configuration;

public interface IFilmeClient
{
    Task<FilmeOMDB> getFilmeOMDB(string titulo);
}