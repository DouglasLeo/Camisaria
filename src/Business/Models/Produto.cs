using DevIO.Business.Models.Enums;
using System;

namespace DevIO.Business.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public TipodeProduto Type { get; set; }
        public string Imagem { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Guid FornecedorId { get; set; }

    }
}
