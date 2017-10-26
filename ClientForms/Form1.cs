using ClientForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
