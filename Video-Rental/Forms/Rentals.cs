using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Video_Rental.Entities;

namespace Video_Rental.Forms
{
    public partial class Rentals : Form
    {
        public Rentals()
        {
            InitializeComponent();
        }


        private int selectedFilmId;
        private int selectedClientId;

        private void buttonChooseFilm_Click(object sender, EventArgs e)
        {
            Films films = new Films();
            films.FilmSelected += Films_FilmSelected;
            films.ShowDialog();
        }

        private void Films_FilmSelected(int filmId)
        {
            selectedFilmId = filmId;
            tbSelectedFilmId.Text = selectedFilmId.ToString();
        }

        private void buttonChooseClient_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.ClientSelected += Clients_ClientSelected; 
            clients.ShowDialog();
        }

        private void Clients_ClientSelected(int clientId)
        {
            selectedClientId = clientId;
            tbSelectedClientId.Text = selectedClientId.ToString();
        }


        //----------------------------------------------------------------------
        Operations operation = new Operations();
        string query;


        private void GetRental()
        {
            query = "SELECT * FROM RentalsTbl";
            var ds = operation.populate(query);
            dvgRentals.DataSource = ds.Tables[0];
        }

        private void Rentals_Load(object sender, EventArgs e)
        {
            GetRental();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int rentalId = Convert.ToInt32(tbRentalId.Text);
            int filmId = Convert.ToInt32(tbSelectedFilmId.Text);
            int clientId = Convert.ToInt32(tbSelectedClientId.Text);
            DateTime rentalDate = dpRentalDate.Value;
            DateTime dueDate = dpDueDate.Value;
            string rentalStatus = cbStatus.Text;

            try
            {
                query = "INSERT INTO RentalsTbl (RentalId, ClientId, FilmId, RentalDate, DueDate, RentalStatus) VALUES(" + rentalId + ", " + clientId + ", " + filmId + ", #" + rentalDate.ToString("yyyy-MM-dd") + "#, #" + dueDate.ToString("yyyy-MM-dd") + "#, '" + rentalStatus + "' )";
                operation.insertData(query);
                GetRental();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rentalId = Convert.ToInt32(tbRentalId.Text);

            try
            {
                query = "DELETE FROM RentalsTbl WHERE RentalId = " + rentalId + ";";
                operation.deleteData(query);
                GetRental();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int rentalId = Convert.ToInt32(tbRentalId.Text);
            int filmId = Convert.ToInt32(tbSelectedFilmId.Text);
            int clientId = Convert.ToInt32(tbSelectedClientId.Text);
            DateTime rentalDate = dpRentalDate.Value;
            DateTime dueDate = dpDueDate.Value;
            string rentalStatus = cbStatus.Text;

            try
            {
                query = "UPDATE RentalsTbl SET RentalId = " + rentalId + ", ClientId = " + clientId + ", FilmId = " + filmId + ", RentalDate = #" + rentalDate.ToString("yyyy-MM-dd") + "#, DueDate = #" + dueDate.ToString("yyyy-MM-dd") + "#, RentalStatus = '" + rentalStatus + "' WHERE RentalId = " + rentalId + ";";
                operation.editData(query);
                GetRental();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            tbRentalId.Text = "";
            tbSelectedClientId.Text = "";
            tbSelectedFilmId.Text = "";
            dpRentalDate.Value = DateTime.Now;
            dpDueDate.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dvgRentals_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgRentals.SelectedRows.Count > 0)
            {
                tbRentalId.Text = dvgRentals.SelectedRows[0].Cells[0].Value.ToString();
                tbSelectedClientId.Text = dvgRentals.SelectedRows[0].Cells[1].Value.ToString();
                tbSelectedFilmId.Text = dvgRentals.SelectedRows[0].Cells[2].Value.ToString();

                DateTime rentalDate;
                if (DateTime.TryParse(dvgRentals.SelectedRows[0].Cells[3].Value.ToString(), out rentalDate))
                {
                    dpRentalDate.Value = rentalDate;
                }

                DateTime dueDate;
                if (DateTime.TryParse(dvgRentals.SelectedRows[0].Cells[4].Value.ToString(), out dueDate))
                {
                    dpDueDate.Value = dueDate;
                }

                cbStatus.SelectedItem = dvgRentals.SelectedRows[0].Cells[5].Value.ToString();

            }
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Rentals Window. Feel free to add, edit or delete an item as you wish!");
        }
    }
}
