using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class PagoAdelantado
    {
        #region "Atributos"
        private int _numero;
        private int _montoPagar;
        private float _porcDesc;
        private int _dias;
        private int _numeroMeses;
        #endregion
        #region "Constructores"
        public PagoAdelantado()
        {
            _numero = 0;
            _montoPagar = 0;
            _porcDesc = 0.00F;
            _dias = 0;
            _numeroMeses = 0;
        }

        public PagoAdelantado(int numero, int montoPagar, float porcDesc, int dias, int numeroMeses)
        {
            _numero = numero;
            _montoPagar = montoPagar;
            _porcDesc = porcDesc;
            _dias = dias;
            _numeroMeses = numeroMeses;

        }
        #endregion
        #region "Propiedades"
        public int Numero
        {
            set { _numero = value; }
            get { return _numero; }
        }
        public int MontoPagar
        {
            set { _montoPagar = value; }
            get { return _montoPagar; }
        }
        public float PorcDesc
        {
            set { _porcDesc = value; }
            get { return _porcDesc; }
        }

        public int Dias
        {
            set { _dias = value; }
            get { return _dias; }
        }

        public int NumeroMeses
        {
            set { _numeroMeses = value; }
            get { return _numeroMeses; }
        }
        #endregion
        #region "Metodos"

        // Pago Adelantado = monto a pagar (1 - ((% descuento * días)) / 360)

        public float getPagoAdelantado()
        {
            float pagoAdelantado = 0;
            float desc = _porcDesc / 100;

            pagoAdelantado = _montoPagar * (1 - ((desc * _dias)) / 360);

            return pagoAdelantado;
        }
        #endregion
    }
}
