using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ClientForms.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string CellNumber { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }


        public static string addContact(Contact contact , int Id)
        {
            string connectinString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string ret = null;

            string query = string.Format("insert into tblContact values('{0}','{1}','{2},'{3},'",Id , 
                contact.CellNumber, contact.HomeNumber , contact.WorkNumber);
            using (SqlConnection conn = new SqlConnection(connectinString))
            {
                using (SqlCommand com = new SqlCommand(query, conn))
                {
                    conn.Open();
                    int results = com.ExecuteNonQuery();
                    conn.Close();

                    if (results > 0)
                        ret = string.Format("Successfull added Contacts");
                    else
                        ret = string.Format("Sorry, fail to add contacts");
                }
            }

            return ret;
        }

        public static string UpdateContact(int Id, Contact contact)
        {
            string ret = null;

            string connectinString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string query = string.Format("UPDATE tblContact  SET [CellNumber] = '{0}',  [HomeNumber] = '{1}', [WorkNumber] = '{2}'" 
                + " WHERE [PersonId] = '{3}' "
                , contact.CellNumber , contact.HomeNumber , contact.WorkNumber, Id);
            using (SqlConnection conn = new SqlConnection(connectinString))
            {
                using (SqlCommand com = new SqlCommand(query, conn))
                {
                    conn.Open();
                    int results = (int)com.ExecuteNonQuery();
                    conn.Close();

                    if (results > 0)
                        ret = string.Format("Successfull updated Client's Contact details");
                    else
                        ret = string.Format("Sorry, fail to update Client's Contact details");
                }
            }

            return ret;
        }

        public static string RemoveContact(int Id, Contact Contact = null)
        {
            string ret = null;

            string connectinString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            string query = string.Format("DELETE FROM tblContact WHERE [PersonId] = '{0}'", Id);

            using (SqlConnection conn = new SqlConnection(connectinString))
            {
                using (SqlCommand com = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        int rows = com.ExecuteNonQuery();
                        conn.Close();
                        if (rows > 0)
                            ret = string.Format("Client's contacts details is deleted ");
                        else
                            ret = string.Format("Fail to deleted Client's contact deatails ");
                    }
                    catch (Exception e)
                    {
                        ret = string.Format("Hi, Sorry, {0} ", e.Message);
                    }
                }
            }

            return ret;
        }

        public static Contact SearchContact(int Id)
        {
            Contact ret = new Contact();

            string connectinString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string query = string.Format("SELECT * FROM tblContact WHERE [PersonId] = '{0}'", Id);
            using (SqlConnection conn = new SqlConnection(connectinString))
            {
                using (SqlCommand com = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        ret.PersonId = (int)reader["Id"];
                        ret.CellNumber = (string)reader["Name"];
                        ret.HomeNumber = (string)reader["Surname"];
                        ret.WorkNumber = (string)reader["IdNumber"];

                        conn.Close();
                    }
                }
            }

            return ret;
        }

        public static List<Contact> AllContacts( )
        {
            List<Contact> ret = new List<Contact>();

            string connectinString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string query = string.Format("SELECT * FROM tblContact");
            using (SqlConnection conn = new SqlConnection(connectinString))
            {
                using (SqlCommand com = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        ret.Add(new Contact
                        {
                            PersonId = (int)reader["Id"],
                            CellNumber = (string)reader["Name"],
                            HomeNumber = (string)reader["Surname"],
                            WorkNumber = (string)reader["IdNumber"]
                        });
                    }
                    conn.Close();
                }
            }
            return ret;
        }
    }
}
