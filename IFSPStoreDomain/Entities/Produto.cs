using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Produto : BaseEntitie<int>
    {
        public Produto() { }


        public Produto(int id, string nome, float preco, int quantidade, DateTime dataCompra, string unidadeVenda)
        {
            this.ID = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.DataCompra = dataCompra;
            this.UnidadeVenda = unidadeVenda;





        }
        public string? Nome {  get; set; } 
        public string? UnidadeVenda { get; set; }
        public float? Preco { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? DataCompra { get; set; }



    }
}
