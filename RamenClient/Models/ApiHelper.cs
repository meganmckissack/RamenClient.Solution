using System.Threading.Tasks;
using RestSharp;

namespace RamenClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5004/api");
      RestRequest request = new RestRequest($"ramens", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5004/api");
      RestRequest request = new RestRequest($"ramens/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newRamen)
    {
      RestClient client = new RestClient("http://localhost:5004/api");
      RestRequest request = new RestRequest($"ramens", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newRamen);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newRamen)
    {
      RestClient client = new RestClient("http://localhost:5004/api");
      RestRequest request = new RestRequest($"ramens/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newRamen);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5004/api");
      RestRequest request = new RestRequest($"ramens/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}