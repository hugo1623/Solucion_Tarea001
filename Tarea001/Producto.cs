using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea001
{
    class Producto
    {
        public string Marca {  get; set; }
        public string Descripcion { get; set; }
        public double PesoEnKilogramos { get; set; }
        public double PesoEnLibra 
        {
            get { return PesoEnKilogramos * 2.2046; }
        }
        
    }
}
