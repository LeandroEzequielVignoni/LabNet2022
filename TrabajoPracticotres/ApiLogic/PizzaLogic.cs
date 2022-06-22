using EntityFramework.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ApiLogic
{
    public class PizzaLogic


    {
        string link = "http://order-pizza-api.herokuapp.com/api/orders";
        public async Task<List<Pizza>> GetPizza()

        {


            var client = new HttpClient();
            var json = await client.GetStringAsync(link);

            dynamic pizza = JsonConvert.DeserializeObject<List<Pizza>>(json);

            return pizza;



        }
    }
}
