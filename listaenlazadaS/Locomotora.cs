using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazadaS
{
    class Locomotora
    {
        Vagon Primero { get; set; }
        Vagon Ultimo { get; set; }

        public void AgregaPrimero(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon primVag = this.Primero;

                nuevo.Sig = primVag;
                
                this.Primero = nuevo;
                
            }

        }

        public int Largo()
        {
            return 0;
        }

        public int GetValor(int pos)
        {
            return 0;
        }

        public void AgregLEfinal(Locomotora otro)
        {

        }


        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        public string VerVagones()
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null) {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }

        public void EliminaUltimo()
        {
            Vagon nuevo = new Vagon();

            if(this.Primero == null)
            {
                return;
            }
            else if(this.Primero.Sig != null)
            {
                this.Primero = null;
            }
            else
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null && tmp.Sig.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = null;
            }
            
        }
        public bool ExisteValor(int valor)
        {
            
            Vagon tmp = this.Primero;
            while(tmp != null)
            {
                if (tmp.Dato == valor)
                {
                    return true;
                }
                tmp = tmp.Sig;
            }

            return false;
        }
        
    }
}
