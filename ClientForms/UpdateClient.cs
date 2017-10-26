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
    public partial class UpdateClient : Form
    {
        int Id;
        string MyName;
        string Surname;
        string Gender;
        string Ethnicity;
        string Language;
        string Nationality;

        public UpdateClient(int Id, string Name, string Surname , string Gender , string Ethnicity, string Language , string Nationality )
        {
            this.Id = Id;
            this.MyName = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.Ethnicity = Ethnicity;
            this.Language = Language;
            this.Nationality = Nationality;

            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            NametxtBox.Text = MyName;
            SurnametxtBox.Text = Surname;
            GendertxtBox.Text = Gender;
            EnthnicityTextBox.Text = Ethnicity;
            LanguagetxtBox.Text = Language;
            NationalitytextBox.Text = Nationality;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Person updateClient = new Person();
            updateClient.Name = NametxtBox.Text;
            updateClient.Surname = SurnametxtBox.Text;
            updateClient.Gender = GendertxtBox.Text;
            updateClient.Ethnicity = EnthnicityTextBox.Text;
            updateClient.PrimaryLanguage = LanguagetxtBox.Text;
            updateClient.Nationality = NationalitytextBox.Text;

            string result = await updateClient.UpdatePerson(Id, updateClient);
        }
    }
}
