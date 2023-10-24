using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave2_Grupo
{
    class Tarjeta
    {
        private string tipoTarjeta;
        private double limiteCredito;
        private double saldoActual;
        private int puntosAcum;
        private DateTime fechaApertura;
        private DateTime fechaVencimiento;
        private bool estaVigente;
        private int cantComprasAcumuladas;

        //metodos Setters y Getters para la propiedad tipoTarjeta
        public string GetTipoTarjeta()
        {
            return this.tipoTarjeta;
        }

        public void SetTipoTarjeta(string tipoTarjetaLeida)
        {
            this.tipoTarjeta = tipoTarjetaLeida;
        }

        //metodos Setters y Getters para la propiedad limiteCredito
        public double GetLimiteCredito()
        {
            return this.limiteCredito;
        }

        public void SetLimiteCredito(double limiteCreditoLeido)
        {
            this.limiteCredito = limiteCreditoLeido;
        }

        //metodos Setters y Getters para la propiedad saldoActual
        public double GetSaldoActual()
        {
            return this.saldoActual;
        }

        public void SetSaldoActual(double saldoActualLeido)
        {
            this.saldoActual = saldoActualLeido;
        }

        //metodos Setters y Getters para la propiedad puntosAcum
        public int GetPuntosAcum()
        {
            return this.puntosAcum;
        }

        public void SetPuntosAcum(int puntosAcumLeidos)
        {
            this.puntosAcum = puntosAcumLeidos;
        }

        //metodos Setters y Getters para la propiedad fechaApertura
        public DateTime GetFechaApertura()
        {
            return this.fechaApertura;
        }

        public void SetFechaApertura(DateTime fechaAperturaLeida)
        {
            this.fechaApertura = fechaAperturaLeida;
        }

        //metodos Setters y Getters para la propiedad fechaVencimiento
        public DateTime GetFechaVencimiento()
        {
            return this.fechaVencimiento;
        }

        public void SetFechaVencimiento(DateTime fechaVencimientoLeida)
        {
            this.fechaVencimiento = fechaVencimientoLeida;
        }

        //metodos Setters y Getters para la propiedad estaVigente
        public bool GetEstaVigente()
        {
            return this.estaVigente;
        }

        public void SetEstaVigente(bool estaVigenteLeido)
        {
            this.estaVigente = estaVigenteLeido;
        }

        //metodos Setters y Getters para la propiedad cantComprasAcumuladas
        public int GetCantComprasAcumuladas()
        {
            return this.cantComprasAcumuladas;
        }

        public void SetCantComprasAcumuladas(int cantComprasAcumuladasLeidas)
        {
            this.cantComprasAcumuladas = cantComprasAcumuladasLeidas;
        }



    }
}
