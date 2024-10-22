using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
        public class Cidade : BaseEntitie<int>
        {
            public Cidade()
            {

            }
            public string? Nome { get; set; }

            public string Estado { get; set; }

            public Cidade(int id, string nome, string estado)
            {
                this.ID = id;
                this.Nome = nome;
                this.Estado = estado;
            }
        }
    }

