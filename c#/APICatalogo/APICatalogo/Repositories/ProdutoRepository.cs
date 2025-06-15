using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;
using X.PagedList;

namespace APICatalogo.Repositories;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(AppDbContext context): base(context)
    {       
    }

    //public IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParams)
    //{
    //    return GetAll()
    //        .OrderBy(p => p.Nome)
    //        .Skip((produtosParams.PageNumber - 1) * produtosParams.PageSize)
    //        .Take(produtosParams.PageSize).ToList();

    //}
    public async Task<IPagedList<Produto>> GetProdutosAsync(ProdutosParameters produtosParameters)
    {
        //IQueryable<T> é apropriado quando você deseja realizar consultas de forma
        //eficiente em uma fonte de dados que pode ser consultada diretamente, como
        //um banco de dados. Ele suporta a consulta diferida e permite que as
        //consultas sejam traduzidas em consultas SQL eficientes quando você está
        //trabalhando com um provedor de banco de dados, como o Entity Framework.
        //------------------------------------------------------------------------
        //IEnumerable<T> é uma interface mais geral que representa uma coleção de
        //objetos em memória. Ela não oferece suporte a consultas diferidas ou tradução
        //de consultas SQL. Isso significa que, ao usar IEnumerable, você primeiro traz
        //todos os dados para a memória e, em seguida, aplica consultas, o que pode ser
        //menos eficiente para grandes conjuntos de dados.

        var produtos = await GetAllAsync();
        var produtosOrdenados = produtos.OrderBy(p => p.Nome).AsQueryable();
        //var resultado = PagedList<Produto>.ToPagedList(produtos.AsQueryable(), 
        //           produtosParameters.PageNumber, produtosParameters.PageSize);

        var resultado = await produtosOrdenados.ToPagedListAsync(produtosParameters.PageNumber, produtosParameters.PageSize);

        return resultado;
    }

    public async Task<IPagedList<Produto>> GetProdutosFiltosPrecoAsync(ProdutosFiltroPreco produtosFiltroParams)
    {
        var produtos = await GetAllAsync();

        if (produtosFiltroParams.Preco.HasValue && !string.IsNullOrEmpty(produtosFiltroParams.PrecoCriterio))
        {
            if (produtosFiltroParams.PrecoCriterio.Equals("maior", StringComparison.OrdinalIgnoreCase))
            {
                produtos = produtos.Where(p => p.Preco > produtosFiltroParams.Preco.Value);
            }
            else if (produtosFiltroParams.PrecoCriterio.Equals("menor", StringComparison.OrdinalIgnoreCase))
            {
                produtos = produtos.Where(p => p.Preco < produtosFiltroParams.Preco.Value);
            }
            else if (produtosFiltroParams.PrecoCriterio.Equals("igual", StringComparison.OrdinalIgnoreCase))
            {
                produtos = produtos.Where(p => p.Preco == produtosFiltroParams.Preco.Value);
            }
        }

        //return PagedList<Produto>.ToPagedList(produtos.AsQueryable(), produtosFiltroParams.PageNumber, produtosFiltroParams.PageSize);
        return await produtos.ToPagedListAsync(produtosFiltroParams.PageNumber, produtosFiltroParams.PageSize);
    }

    public async Task<IEnumerable<Produto>> GetProdutosPorCategoriaAsync(int id)
    {
        var produtos = await GetAllAsync();
        return produtos.Where(c => c.CategoriaId == id);
    }
}

