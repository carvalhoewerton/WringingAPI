using Microsoft.AspNetCore.Mvc;
using WringingAPi.Service;

namespace WringingAPi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmeController : ControllerBase
{
    private readonly IFilmeService _filmeService;

    public FilmeController(IFilmeService filmeService)
    {
        _filmeService = filmeService;
    }
    
    [HttpGet("{titulo}")]
    public async Task<IActionResult> GetFilme(string titulo)
    {
        return Ok(await _filmeService.GetFilmeAsync(titulo));
    }
    
}