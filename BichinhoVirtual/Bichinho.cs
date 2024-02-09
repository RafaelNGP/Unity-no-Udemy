using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BichinhoVirtual
{
    [Serializable]
    internal class Bichinho
    {
        string nome = "";
        string comidaFavorita = "";
        float alimentado;
        float limpo;
        float feliz;

        public string getName() {
            return this.nome;
        }

        public void setName(string name)
        {
            this.nome = name;
        }

        public string getComida()
        {
            return this.comidaFavorita;
        }

        public void SetComida(string comida)
        {
            this.comidaFavorita = comida;
        }

        public float getAlimentado() { 
            return this.alimentado; 
        }

        public void setAlimentadoFULL()
        {
            this.alimentado = 100;
        }

        public void setAlimentado(int valor)
        {
            this.alimentado += valor;
            if (this.alimentado >= 100) this.alimentado = 100;
        }

        public float getLimpo() {  
            return this.limpo; 
        }

        public void Limpar()
        {
            this.limpo = 100;
        }

        public float getFeliz() { 
            return this.feliz; 
        }

        public void Brincar() {
            this.feliz += 33;
            if (this.feliz >= 100) this.feliz = 100;
        }
    }
}
