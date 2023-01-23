using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace CatDog_Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatDogController : ControllerBase
    {

        [HttpPost]
        public JObject PostTodoItem(JObject JsonPayload)
        {
            return JObject.Parse(JsonPayload.ToString().Replace("dog", "cat"));
        }
    }
}