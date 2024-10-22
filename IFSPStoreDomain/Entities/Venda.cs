using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Venda: BaseEntitie<int>
    {
        public Venda() { }
        public Venda(int id, DateTime data, float valorTotal, Usuario? usuario, Cliente cliente,List<VendaItem> items): base(id)
        {


            Data = data;
            ValorTotal = valorTotal;
            Usuario = usuario;
            Cliente = cliente;
            Items = items;





        }
        public DateTime? Data { get; set; }
        public float ValorTotal { get; set; }
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public virtual List<VendaItem> Items { get; set; }



    }
}
