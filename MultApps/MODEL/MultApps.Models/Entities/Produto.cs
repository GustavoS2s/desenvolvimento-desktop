using MultApps.Models.Entities.Abstract;

namespace MultApps.Models.Entitites.Abstract
{
    internal class Produto : EntidadeBase
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }


    }
}
