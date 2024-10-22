using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreDomain.Base
{
    public abstract class BaseEntitie<TID>
    {

        protected BaseEntitie() { }
        protected BaseEntitie(TID id) {
            ID = id;
        }
        public TID? ID { get; set; }

    }
}
