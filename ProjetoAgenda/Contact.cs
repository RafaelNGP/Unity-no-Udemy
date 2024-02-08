using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    [Serializable]
    public class Contact
    {
        string nome;
        string email;

        public Contact(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public string getNome()
        {
            return this.nome;
        }
        public string getEmail()
        {
            return this.email;
        }
    }
}
