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
    public partial class AddressForm : Form
    {
        private int userId;
        public AddressForm(int UserId)
        {
            InitializeComponent();
            this.userId = UserId;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Address homeaddress = new Address();
            homeaddress.PersonId = userId;
            homeaddress.StreetAddress = HomeAddtxtBox1.Text;
            homeaddress.AreaIdName = HomeAddtxtBox2.Text;
            homeaddress.City = HomeAddtxtBox3.Text;
            homeaddress.AreaCode = HomeAddtxtBox4.Text;

            Address workaddress = new Address();
            workaddress.PersonId = userId;
            workaddress.StreetAddress = WorkAddtxtBox1.Text;
            workaddress.AreaIdName = WorkAddtxtBox2.Text;
            workaddress.City = WorkAddtxtBox3.Text;
            workaddress.AreaCode = WorkAddtxtBox4.Text;

            Address postaladdress = new Address();
            postaladdress.PersonId = userId;
            postaladdress.StreetAddress = PostalAddtxtBox1.Text;
            postaladdress.AreaIdName = PostalAddtxtBox2.Text;
            postaladdress.City = PostalAddtxtBox3.Text;
            postaladdress.AreaCode = PostalAddtxtBox4.Text;


            string homeaddressResponse = await homeaddress.addAddress(homeaddress, userId);
            string workaddressResponse = await workaddress.addAddress(workaddress, userId);
            string postaladdressResponse = await postaladdress.addAddress(postaladdress, userId);

            //MessageBox

            DialogResult dresult = MessageBox.Show(homeaddressResponse + "\n" + workaddressResponse + "\n" + postaladdressResponse);

            //if (dresult == DialogResult.Yes)
            //{
            //    Application.Close();
            //}
        }
    }
}
