using ListaPandaGames.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPandaGames.FE
{
    public partial class frmAJuego : Form
    {
        Juegos ListaJuegos = new Juegos();

        private Juegos Juegos= new Juegos();
        
        public frmAJuego()
        {
            InitializeComponent();
            DGV.DataSource = Juegos.ListaJuegos;
        }


     
        private void btAgregar_Click(object sender, EventArgs e)
        {
             Juego juego= new Juego(txtCodigo.Text,
                                txtDescripcion.Text,
                                txtPlataforma.Text,
                                txtPrecio.Text); 

            Juegos.Insert(juego);
            Limpiar();


        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar() 
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPlataforma.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Juego juego= new Juego(txtCodigo.Text,
                               txtDescripcion.Text,
                               txtPlataforma.Text,
                               txtPrecio.Text);

            ListaJuegos.Update(juego);
            Limpiar();
        }


    }
}
