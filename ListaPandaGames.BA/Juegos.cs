using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPandaGames.BA
{
    public class Juegos
    {
        public DataTable ListaJuegos { get; set; }

        public Juegos()
        {


            ListaJuegos = new DataTable();
            ListaJuegos.TableName = "Juegos";
            ListaJuegos.Columns.Add("Codigo");
            ListaJuegos.Columns.Add("Descripcion");
            ListaJuegos.Columns.Add("Plataforma");
            ListaJuegos.Columns.Add("Precio");

            LeerArchivo();
        }


        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Juegos.xml"))
            {
                ListaJuegos.ReadXml("Juegos.xml");
            }
        }

        private void GuardarArchivo()
        {
            ListaJuegos.WriteXml("Juegos.xml");
        }

        public void Insert(Juego ajuego)
        {

            ListaJuegos.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaJuegos.Rows.Count - 1;
            ListaJuegos.Rows[NuevoRenglon]["Codigo"] = ajuego.Codigo;
            ListaJuegos.Rows[NuevoRenglon]["Descripcion"] = ajuego.Descripcion;
            ListaJuegos.Rows[NuevoRenglon]["Plataforma"] = ajuego.Plataforma;
            ListaJuegos.Rows[NuevoRenglon]["Precio"] = ajuego.Precio;

            ListaJuegos.WriteXml("Juegos.xml");

            // public Juego[] Lista { get; set; } = new Juego[10];

            // private int proximafila = 0;
            // public void Insert(Juego juego)
            //{
            // Lista[proximafila]=juego;
            // proximafila=proximafila + 1;
            //}


        }

        public void Update(Juego juego)
        {

        }

        public void Delete(Juego juego)
        {


        }

        public Juego Select(string codigo)
        {
            Juego j = new Juego();

            return j;
        }
    }
}