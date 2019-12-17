using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KataApi.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {


    [HttpGet]
    public ActionResult GetResult(string s)
    {
      return Ok(string.Join("", s.Select(c => new String(c, int.(c.ToString())))));
    }
  }
}