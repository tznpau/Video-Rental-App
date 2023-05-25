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
    public partial class Films : Form
    {

        public Films()
        {
            InitializeComponent();
            dvgFilms.SelectionChanged += dvgFilms_SelectionChanged;
        }

        Operations operation = new Operations();
        string query;


        private void GetFilm()
        {
            query = "SELECT * FROM FilmsTbl";
            var ds = operation.populate(query);
            dvgFilms.DataSource = ds.Tables[0];

            //code for updating the status strip which counts available movies
            //mai bine aici decat in Films_Load
            int availableFilms = 0;
            foreach (DataGridViewRow row in dvgFilms.Rows)
            {
                bool isAvailable = Convert.ToBoolean(row.Cells["ISAvailable"].Value);
                if (isAvailable)
                    availableFilms++;
            }

            statusLabelAvailableFilms.Text = $"Available films: {availableFilms}";


        }


        private void Films_Load(object sender, EventArgs e)
        {
            GetFilm();
        }




        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int filmId = Convert.ToInt32(tbFilmId.Text);
            string title = tbFilmTitle.Text;
            decimal price = Convert.ToDecimal(cbFilmPrice.Text);
            bool isAvailable = cbIsAvailable.Text == "Yes";

            try
            {
                query = "INSERT INTO FilmsTbl (FilmId, Title, Price, IsAvailable) VALUES(" + filmId + ", '" + title + "', " + price + ", " + isAvailable + ")";
                operation.insertData(query);
                GetFilm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {   
            int filmId = Convert.ToInt32(tbFilmId.Text);

            try
            {
                query = "DELETE FROM FilmsTbl WHERE FilmId = " + filmId + ";";
                operation.deleteData(query);
                GetFilm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgFilms_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgFilms.SelectedRows.Count > 0)
            {
                tbFilmId.Text = dvgFilms.SelectedRows[0].Cells[0].Value.ToString();
                tbFilmTitle.Text = dvgFilms.SelectedRows[0].Cells[1].Value.ToString();
                cbFilmPrice.SelectedItem = dvgFilms.SelectedRows[0].Cells[2].Value.ToString();
                cbIsAvailable.SelectedItem = dvgFilms.SelectedRows[0].Cells[3].Value.ToString();
            }
        }


        private void clear()
        {
            tbFilmId.Text = "";
            tbFilmTitle.Text = "";
            cbFilmPrice.SelectedIndex = -1;
            cbIsAvailable.SelectedIndex = -1;
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int filmId = Convert.ToInt32(tbFilmId.Text);
            string title = tbFilmTitle.Text;
            decimal price = Convert.ToDecimal(cbFilmPrice.Text);
            bool isAvailable = cbIsAvailable.Text == "Yes";

            try
            {
                query = "UPDATE FilmsTbl SET Title = '" + title + "', Price = " + price + ", ISAvailable = " + isAvailable + " WHERE FilmId = " + filmId + ";";
                operation.editData(query);
                GetFilm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //context strip
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDelete_Click(sender, e);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonReset_Click(sender, e);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonUpdate_Click(sender, e);
        }




        //for connection with the Rentals form
        //when i select a film i want the id to go there
        public event Action<int> FilmSelected;
        private void dvgFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filmId = (int)dvgFilms.Rows[e.RowIndex].Cells["FilmId"].Value;
            FilmSelected?.Invoke(filmId);
            Close();
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Films Window. Feel free to add, edit or delete an item as you wish!");
        }
    }
}
