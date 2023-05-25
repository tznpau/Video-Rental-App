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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        Operations operation = new Operations();
        string query;

        private void GetClient()
        {
            query = "SELECT * FROM ClientsTbl";
            var ds = operation.populate(query);
            dvgClients.DataSource = ds.Tables[0];
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            GetClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(tbClientId.Text);
            string name = tbClientName.Text;
            string phone = tbPhone.Text;

            try
            {
                query = "INSERT INTO ClientsTbl (ClientId, ClientName, Phone) VALUES(" + clientId + ", '" + name + "', '" + phone + "')";
                operation.insertData(query);
                GetClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(tbClientId.Text);

            try
            {
                query = "DELETE FROM ClientsTbl WHERE ClientId = " + clientId + ";";
                operation.deleteData(query);
                GetClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dvgClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgClients.SelectedRows.Count > 0)
            {
                tbClientId.Text = dvgClients.SelectedRows[0].Cells[0].Value.ToString();
                tbClientName.Text = dvgClients.SelectedRows[0].Cells[1].Value.ToString();
                tbPhone.Text = dvgClients.SelectedRows[0].Cells[2].Value.ToString();
            }
        }


        private void clear()
        {
            tbClientId.Text = "";
            tbClientName.Text = "";
            tbPhone.Text = "";
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(tbClientId.Text);
            string name = tbClientName.Text;
            string phone = tbPhone.Text;

            try
            {
                query = "UPDATE ClientsTbl SET ClientName = '" + name + "', Phone = '" + phone + "' WHERE ClientId = " + clientId + ";";
                operation.editData(query);
                GetClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonUpdate_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDelete_Click(sender, e);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonReset_Click(sender, e);
        }




        //for connection with the Rentals form
        //i want to select a client for the id
        public event Action<int> ClientSelected;
        private void dvgClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int clientId = (int)dvgClients.Rows[e.RowIndex].Cells["ClientId"].Value;
            ClientSelected?.Invoke(clientId);
            Close();
        }


        private void backToMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Clients Window. Feel free to add, edit or delete an item as you wish!");
        }
    }
}
