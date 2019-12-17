using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KataApi.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
  {


    [HttpGet]
    public ActionResult GetResult(string s)
    {
      return Ok(string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i))));
    }
  }
}