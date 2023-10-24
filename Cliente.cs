using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave2_Grupo
{
    class Cliente
    {
        private string nombre;
        private string numDui;
        private int canTarjetas;
        private string tipoTarjeta;
        private bool tienePuntosAcum;
        private int cantPuntoAcum;
        private string vigenciaTarjeta;
        private bool tieneProductRegalo;
        private string productRegaloCanjeado;
        private string tipoJuego;

        //metodos Setters y Getters para la propiedad nombre
        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombreLeido)
        {
            this.nombre = nombreLeido;
        }

        //metodos Setters y Getters para la propiedad numDui
        public string GetNumDui()
        {
            return this.numDui;
        }

        public void SetNumDui(string numDuiLeido)
        {
            this.numDui = numDuiLeido;
        }

        //metodos Setters y Getters para la propiedad canTarjetas
        public int GetCanTarjetas()
        {
            return this.canTarjetas;
        }

        public void SetCanTarjetas(int canTarjetasLeidas)
        {
            this.canTarjetas = canTarjetasLeidas;
        }

        //metodos Setters y Getters para la propiedad tipoTarjeta
        public string GetTipoTarjeta()
        {
            return this.tipoTarjeta;
        }

        public void SetTipoTarjeta(string tipoTarjetaLeida)
        {
            this.tipoTarjeta = tipoTarjetaLeida;
        }

        //metodos Setters y Getters para la propiedad tienePuntosAcum
        public bool GetTienePuntosAcum()
        {
            return this.tienePuntosAcum;
        }

        public void SetTienePuntosAcum(bool tienePuntosAcumLeido)
        {
            this.tienePuntosAcum = tienePuntosAcumLeido;
        }

        //metodos Setters y Getters para la propiedad cantPuntoAcum
        public int GetCantPuntoAcum()
        {
            return this.cantPuntoAcum;
        }

        public void SetCantPuntoAcum(int cantPuntoAcumLeidos)
        {
            this.cantPuntoAcum = cantPuntoAcumLeidos;
        }

        //metodos Setters y Getters para la propiedad vigenciaTarjeta
        public string GetVigenciaTarjeta()
        {
            return this.vigenciaTarjeta;
        }

        public void SetVigenciaTarjeta(string vigenciaTarjetaLeida)
        {
            this.vigenciaTarjeta = vigenciaTarjetaLeida;
        }

        //metodos Setters y Getters para la propiedad tieneProductRegalo
        public bool GetTieneProductRegalo()
        {
            return this.tieneProductRegalo;
        }

        public void SetTieneProductRegalo(bool tieneProductRegaloLeido)
        {
            this.tieneProductRegalo = tieneProductRegaloLeido;
        }

        //metodos Setters y Getters para la propiedad productRegaloCanjeado
        public string GetProductRegaloCanjeado()
        {
            return this.productRegaloCanjeado;
        }

        public void SetProductRegaloCanjeado(string productRegaloCanjeadoLeido)
        {
            this.productRegaloCanjeado = productRegaloCanjeadoLeido;
        }

        //metodos Setters y Getters para la propiedad tipoJuego
        public string GetTipoJuego()
        {
            return this.tipoJuego;
        }

        public void SetTipoJuego(string tipoJuegoLeido)
        {
            this.tipoJuego = tipoJuegoLeido;
        }





    }
}
