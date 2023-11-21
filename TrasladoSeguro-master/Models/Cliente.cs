using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasladoSeguro.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre {  get; set; }

        public int FechaNacimiento {  get; set; }

        public int ServicioTransporteId {  get; set; }

        public ServicioTransporte? ServicioTransporte { get; set; }


    }
}
