using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace CatDog_Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatDogController : ControllerBase
    {

        //takes in a JSON payload, converts it to a string, replaces any instances of "dog" with "cat", then converts back to a JSON Object and returns it in the response body
        [HttpPost]
        public JObject PostTodoItem(JObject JsonPayload)
        {
            return JObject.Parse(JsonPayload.ToString().Replace("dog", "cat"));
        }
    }
}