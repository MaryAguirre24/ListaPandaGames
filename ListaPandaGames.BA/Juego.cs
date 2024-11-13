using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaPandaGames.BA
{
    public class Juego
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Plataforma { get; set; }
        public decimal Precio { get; set; }


        public Juego()
        {

        }
        public Juego(string codigo,
                     string descripcion,
                     string plataforma,
                     string precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Plataforma = plataforma;
            Precio = Convert.ToDecimal(precio);
        }

        public override string ToString()
        {
            return $"{Codigo} - {Descripcion} - {Plataforma} -({Precio})";
        }
    }
}
