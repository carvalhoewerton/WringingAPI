using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WringingAPi.Model;

public class Filme
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Title { get; set; }

    public string Year { get; set; }

    public string Director { get; set; }

    public string Plot { get; set; }

    public string Poster { get; set; }

    public string Metascore { get; set; }

    public string Genre { get; set; }
}