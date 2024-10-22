using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Usuario: BaseEntitie<int>
    {
        public Usuario() { }
        public Usuario(int id,string nome,string senha,string login,string email, DateTime dataCadastro,DateTime dataLogin) { 

            this.ID = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Login = login;
            this.Email = email;
            this.DataCadastro = dataCadastro;
            this.DataLogin = dataLogin;
              
        }

        public string? Nome {  get; set; }  
        public string? Senha { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataLogin { get; set; }



    }
}
