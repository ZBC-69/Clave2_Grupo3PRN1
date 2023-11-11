using System;
using System.Text;


namespace Clave2_Grupo
{
    class Tarjeta
    {
        private string codigoTarjet;
        private string tipoTarjeta;     //Gold ($300), Silver ($150), Plus ($50)
        private double limiteCredito;   //300 ó 150 ó 50  representa la cifra de dólares
        private double saldoActual;      // el saldo puede disminuir o mantenerse
        private int puntosAcum;         //la tarjeta otorga puntos por cada compra y transaccion
        private string fechaApertura; //la tarjeta se abre y habilita cuando se compra
        private string fechaVencimiento;//se desactiva o vence y caduca 
        private bool estaVigente;   //está o no vigente la tarjeta?
        

        public Tarjeta()
        {
           
        }
        //metodos Setters y Getters para la propiedad tipoTarjeta
        public string TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }
        public string CodigoTarjeta
        {
            get { return codigoTarjet; }
            set { codigoTarjet = value; }
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

        public string FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value; }
        }

        public string FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public bool EstaVigente
        {
            get { return estaVigente; }
            set { estaVigente = value; }
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
            fechaApertura = DateTime.Now.ToString("dd/MM/yyyy");

            //se le dá un periodo de validez de la tarjeta (7 dias en este caso)
            DateTime fechaHoy = DateTime.Now;
            DateTime venceEl = fechaHoy.AddDays(4);
            fechaVencimiento = venceEl.ToString("dd/MM/yyyy");
            //una vez se venda la tarjeta es vigente y disponible para su uso
            estaVigente = true;

            
        }

        /// <summary>
        /// Crea un código único a una nueva tarjeta  para un cliente
        /// </summary>
        /// <returns></returns>
        public static string GenerarCodigoUnicoTarjet()
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int longitudCodigo = 6;

            StringBuilder codigoGenerado = new StringBuilder();
            Random random = new Random();

            while (codigoGenerado.Length < longitudCodigo)
            {
                int indiceCaracter = random.Next(0, caracteresPermitidos.Length);
                codigoGenerado.Append(caracteresPermitidos[indiceCaracter]);
            }
            
            return codigoGenerado.ToString();
        }


    }
}
