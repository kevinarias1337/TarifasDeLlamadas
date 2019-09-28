using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarifasllamada
{
   public class Tarifas
   {

        private double tiempo;

        public void setTiempo(double total)
        {
            this.tiempo = total;
        }

        public double getTiempo()
        {
            return this.tiempo;
        }
        //EEUU = Estados unidos, CA= Canadá, EU= Europa, RM= Resto del mundo.
        public double calcularPrecioEEUU()
        {
            return this.getTiempo() * 900;
        }

        public double calcularPrecioCA()
        {
            return this.getTiempo() *800;
        }

        public double calcularPrecioEU()
        {
            return this.getTiempo() *950;
        }

        public double calcularPrecioRM()
        {
            return this.getTiempo() * 1250;
        }
   }
}
