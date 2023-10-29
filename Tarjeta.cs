using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave2_Grupo
{
    class Tarjeta
    {
        private string tipoTarjeta;     //Gold ($300), Silver ($150), Plus ($50)
        private double limiteCredito;   //300 ó 150 ó 50  representa la cifra de dólares
        private double saldoActual;      // el saldo puede disminuir o mantenerse
        private int puntosAcum;         //la tarjeta otorga puntos por cada compra y transaccion
        private DateTime fechaApertura; //la tarjeta se abre y habilita cuando se compra
        private DateTime fechaVencimiento;//se desactiva o vence y caduca 
        private bool estaVigente;   //está o no vigente la tarjeta?
        private int cantComprasAcumuladas; //cantidad de compras que se hayan hecho con la tarjeta (conteo o recuento)

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

        /// <summary>
        /// Método que establece los valores de algunas propiedades de una tarjeta partiendo del valor de la propiedad TipoTarjeta
        /// </summary>
        public void EstablecerValoresPorTipoTarjeta()
        {
            if (tipoTarjeta == "Gold")
            {
                limiteCredito = 300;
                saldoActual = 300;
            }
            else if (tipoTarjeta == "Silver")
            {
                limiteCredito = 150;
                saldoActual = 150;
            }
            else if (tipoTarjeta == "Plus")
            {
                limiteCredito = 50;
                saldoActual = 50;
            }

            puntosAcum = 0;
            fechaApertura= DateTime.Now;
            //se le dá un periodo de validez de la tarjeta (7 dias en este caso)
            fechaVencimiento = FechaApertura.AddDays(7);
            //una vez se venda la tarjeta es vigente y disponible para su uso
            estaVigente = true;
        }


    }
}
