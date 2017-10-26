using ClientForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Person person = new Person();
            List<Person> people = new List<Person>();
            people = await person.SearchPeople();
            dataGridView1.DataSource = people;
            // dataGridView1.DataSource = new Person().SearchPeople();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = (int)dataGridView1.SelectedCells[0].Value;
            AddressForm addressForm = new AddressForm(userId);
            addressForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            Person deleteClient = new Person();
            int userId = (int)dataGridView1.SelectedCells[0].Value;
            string result = await deleteClient.RemovePerson(userId);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int userId = (int)dataGridView1.SelectedCells[0].Value;
            int rowIndex = (int)dataGridView1.CurrentCell.RowIndex;

            //MessageBox.Show(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
            string Name = (string)dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string Surname = (string)dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            string Gender = (string)dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            string Ethnicity = (string)dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            string Language = (string)dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            string Nationality = (string)dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();

            UpdateClient updateClient = new UpdateClient(userId, Name, Surname, Gender, Ethnicity, Language, Nationality);
            updateClient.Show();

        }

        private void exportToFile()
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Reverside\source\repos\ClientForms\ClientForms\Models\ClientData.csv");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString()+",");
                    
                }
                writer.Write("\n");

            }
            
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            exportToFile();

        }
    }
}
