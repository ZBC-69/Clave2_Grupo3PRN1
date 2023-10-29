using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave2_Grupo
{
    public class Cliente
    {
        private string nombre;  //
        private string numDui;  //
        private int canTarjetas;    //
        private string tipoTarjeta;
        private bool tienePuntosAcum;
        private int cantPuntoAcum;
        private string vigenciaTarjeta;
        private bool tieneProductRegalo;
        private string productRegaloCanjeado;
        private string tipoJuego;

        //metodos Setters y Getters para la propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NumDui
        {
            get { return numDui; }
            set { numDui = value; }
        }

        public int CanTarjetas
        {
            get { return canTarjetas; }
            set { canTarjetas = value; }
        }

        public string TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }

        public bool TienePuntosAcum
        {
            get { return tienePuntosAcum; }
            set { tienePuntosAcum = value; }
        }

        public int CantPuntoAcum
        {
            get { return cantPuntoAcum; }
            set { cantPuntoAcum = value; }
        }

        public string VigenciaTarjeta
        {
            get { return vigenciaTarjeta; }
            set { vigenciaTarjeta = value; }
        }

        public bool TieneProductRegalo
        {
            get { return tieneProductRegalo; }
            set { tieneProductRegalo = value; }
        }

        public string ProductRegaloCanjeado
        {
            get { return productRegaloCanjeado; }
            set { productRegaloCanjeado = value; }
        }

        public string TipoJuego
        {
            get { return tipoJuego; }
            set { tipoJuego = value; }
        }

        public bool VerificarNombreVacio()
        {
            if (string.IsNullOrEmpty(nombre))
            {
                //esta vacio
                return false;
            }
            else
            {   
                //tiene datos
                return true;
            }
        }



    }
}
