using DevIO.Business.Models.Enums;
using System;
using System.Collections.Generic;

namespace DevIO.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public TipodeFornecedor TipodeFornecedor { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
        public Endereco Endereco { get; set; }
        public Guid EnderecoId { get; set; }
    }
}
