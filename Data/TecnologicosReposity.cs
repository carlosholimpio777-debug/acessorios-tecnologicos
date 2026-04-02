using AcessoriosTecnologicos.Models;

namespace AcessoriosTecnologicos.Data;

public class TecnologicosReposity
{
    private static List<Produtos> produtos = new List<Produtos>();

    static TecnologicosReposity()
    {
        produtos.Add(new Produtos{  nome="Carlos"  , idade =200 });
    }
}