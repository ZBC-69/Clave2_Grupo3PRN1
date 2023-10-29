using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave2_Grupo
{
    class Tarjeta
    {
        private string tipoTarjeta;     //==
        private double limiteCredito;   //==
        private double saldoActual;
        private int puntosAcum;
        private DateTime fechaApertura; //==
        private DateTime fechaVencimiento;//==
        private bool estaVigente;   //==
        private int cantComprasAcumuladas;

        public Tarjeta()
        {

        }
        //metodos Setters y Getters para la propiedad tipoTarjeta
        public string TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }

        public double LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public double SaldoActual
        {
            get { return saldoActual; }
            set { saldoActual = value; }
        }

        public int PuntosAcum
        {
            get { return puntosAcum; }
            set { puntosAcum = value; }
        }

        public DateTime FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public bool EstaVigente
        {
            get { return estaVigente; }
            set { estaVigente = value; }
        }

        public int CantComprasAcumuladas
        {
            get { return cantComprasAcumuladas; }
            set { cantComprasAcumuladas = value; }
        }




    }
}
