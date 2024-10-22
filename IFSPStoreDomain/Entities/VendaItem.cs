using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class VendaItem: BaseEntitie<int>
    {
        public VendaItem() { }

        public VendaItem(int id,float valorUnitario,float valorTotal,int quantidade,Venda venda,Produto? produto)
        {

            this.Quantidade = quantidade;
            this.ID = id;
            this.ValorUnutario = valorUnitario;
            this.ValorTotal = valorTotal;
            Venda = venda;
            Produto = produto;

        }
        public Produto? Produto { get; set; }
        public float? ValorUnutario {  get; set; }
        public float? ValorTotal { get; set; }
        public int? Quantidade {  get; set; } 
        public Venda Venda { get; set; }


    }
}
