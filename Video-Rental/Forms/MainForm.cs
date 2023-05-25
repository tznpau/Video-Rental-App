using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental.Forms
{
    public partial class MainForm : Form
    {
        private Clients clientsForm;
        private Films filmsForm;
        private Rentals rentalsForm;


        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true; //for keyboard shortcuts 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clientsForm = new Clients();
            filmsForm = new Films();
            rentalsForm = new Rentals();

            clientsToolStripMenuItem.Click += ClientsToolStripMenuItem_Click;
            filmsToolStripMenuItem.Click += FilmsToolStripMenuItem_Click;
            rentalsToolStripMenuItem.Click += RentalsToolStripMenuItem_Click;

        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientsForm == null || clientsForm.IsDisposed)
            {
                clientsForm = new Clients();
            }

            clientsForm.Show();
        }

        private void FilmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filmsForm == null || filmsForm.IsDisposed)
            {
                filmsForm = new Films();
            }

            filmsForm.Show();
        }

        private void RentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rentalsForm == null || rentalsForm.IsDisposed)
            {
                rentalsForm = new Rentals();
            }

            rentalsForm.Show();
        }



        //keyboard shortcuts
        //SHIFT + F  -> Films
        //SHIFT + C  -> Clients
        //SHIFT + R  -> Rentals
        private void OpenFilmsForm()
        {
            Films films = new Films();
            films.Show();
        }

        private void OpenClientsForm()
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void OpenRentalsForm()
        {
            Rentals rentals = new Rentals();
            rentals.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C)
            {
                OpenClientsForm();
            }
            else if (e.Shift && e.KeyCode == Keys.F)
            {
                OpenFilmsForm();
            }
            else if (e.Shift && e.KeyCode == Keys.R)
            {
                OpenRentalsForm();
            }
        }
    }
}
