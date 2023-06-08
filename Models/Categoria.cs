using System.Collections.ObjectModel;

namespace ApiCatalogo.Models;

public class Categoria
{

    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; } //Uma categoria, pode ter vários produtos
}