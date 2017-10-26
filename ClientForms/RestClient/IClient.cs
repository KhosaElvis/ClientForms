using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForms.RestClient
{
    public interface IClient<T>
    {
        Task<List<T>> GetTaskAsync();
        Task<string> PostAsync(T t);
        Task<string> PostAsync(T t,int id);
        Task<string> PutAsync(int id, T t);
        Task<string> DeleteAsync(int id, T t);

    }
}
