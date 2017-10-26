using ClientForms.RestClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace ClientForms.Models
{
    

    public class Person 
    {
        static string baseUrl = "http://localhost:10020";
        static string subUrl = "/api/People";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public string PrimaryLanguage { get; set; }
        public string Nationality { get; set; }

        public async Task<string> addPerson(Person person , IClient<Person> client = null)
        {
            if (client == null)
            {
                client = new Client<Person>(baseUrl, subUrl);
            }
            
            return await client.PostAsync(person);
        }

        public async Task<string> UpdatePerson(int Id, Person person, IClient<Person> client = null)
        {
            if (client == null)
            {
                client = new Client<Person>(baseUrl, subUrl);
            }
            string ret = await client.PutAsync(Id, person);
            return ret;
        }

        public async Task<string> RemovePerson(int Id, Person person = null, IClient<Person> client = null)
        {
            string ret = null;

            if (client == null)
            {
                client = new Client<Person>(baseUrl, subUrl);
            }
            ret = await client.DeleteAsync(Id, person);
            return ret;
        }

        /*public async Task<Person> SearchPerson(int Id , IClient<Person> client = null)
        {

            if (client == null)
            {
                client = new Client<Person>(baseUrl, subUrl);
            }

            Person ret = new Person();

            ret = await client.GetTaskAsync()

            return ret;
        }*/

        public async Task<List<Person>> SearchPeople(IClient<Person> client = null)
        {
            if (client == null)
            {
                client = new Client<Person>(baseUrl, subUrl);
            }
            List<Person> ret = new List<Person>();
            ret = await client.GetTaskAsync();
            return ret;
        }

    }

}
