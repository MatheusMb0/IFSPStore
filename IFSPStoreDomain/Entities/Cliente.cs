using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Cliente: BaseEntitie<int>
    {
        public Cliente() { }
        public Cliente(int id,string nome,string bairro,string documento,Cidade cidade,string endereco) {
            
            ID = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Documento = documento;




        }
        public string? Bairro { get; set; }
        public string? Cidade {  get; set; }
        public string? Documento { get; set; }
        public string? Endereco { get; set; }
        public string? Nome { get; set; }

    }
}
