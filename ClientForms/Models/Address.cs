using ClientForms.RestClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ClientForms.Models
{
    public class Address
    {
        static string baseUrl = "http://localhost:10020";
        static string subUrl = "/api/Address";

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string StreetAddress { get; set; }
        public string AreaIdName { get; set; }
        public string City { get; set; }
        public string AreaCode { get; set; }


        public async Task<string> addAddress(Address address, int Id, IClient<Address> client = null)
        {
            string ret = null;

            if (client == null)
            {
                client = new Client<Address>(baseUrl, subUrl);
            }

            ret = await client.PostAsync(address,Id); 

            return ret;
        }

        public static string UpdateAddress(int Id, Address address, IClient<Address> client = null)
        {
            string ret = null;

            if (client == null)
            {
                client = new Client<Address>(baseUrl, subUrl);
            }

            
            return ret;
        }

        public static string RemoveAddress(int Id, Address address = null)
        {
            string ret = null;

            return ret;
        }

        public async Task<Address> SearchAddress(int Id, IClient<Address> client = null)
        {
            Address ret = new Address();

            if (client == null)
            {
                client = new Client<Address>(baseUrl, subUrl);
            }

            ret = await client.GetTaskAsync(Id);
            return ret;
        }

        public static List<Address> AllAddress()
        {
            List<Address> ret = new List<Address>();

            
            return ret;
        }
    }
}
