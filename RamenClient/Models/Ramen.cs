using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RamenClient.Models
{
  public class Ramen
  {
    public int RamenId { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public string Restaurant { get; set; }
    public string Location { get; set; }
    public int Rating { get; set; }
    public string Review { get; set; }

    public static List<Ramen> GetRamens()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Ramen> ramenList = JsonConvert.DeserializeObject<List<Ramen>>(jsonResponse.ToString());

      return ramenList;
    }
  }
}