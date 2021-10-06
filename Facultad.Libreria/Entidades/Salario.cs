using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;


        // propiedades
        public double Bruto
        {
            get { return _bruto; }
        }
        public string codigoTransferencia
        {
            get { return _codigoTransferencia; }
        }

        public double Descuentos
        {
            get { return _descuentos; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
        }

        // Metodos
        public double GetSalarioNeto()
        {
            double neto = _bruto * _descuentos;
            return neto;
        }

        public void Salario1 (double Bruto)
        {
            Console.WriteLine(Bruto);
        }
        public Salario (DateTime fecha)
        {
            this._bruto = 0;
            this._descuentos=0.20;
            this._fecha = fecha;
        }
            


    }
}
