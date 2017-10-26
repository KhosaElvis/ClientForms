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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            person.Name = NametxtBox.Text;
            person.Surname = SurnametxtBox.Text;
            person.Gender = GendertxtBox.Text;
            person.Ethnicity = EnthnicityTextBox.Text;
            person.PrimaryLanguage = NationalitytextBox.Text;
            person.Nationality = LanguagetxtBox.Text;

            string result = await person.addPerson(person);

            MessageBox.Show(result);
        }
    }
}
