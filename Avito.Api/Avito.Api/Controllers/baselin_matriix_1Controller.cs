using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avito.Api.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Avito.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class baselin_matriix_1Controller : ControllerBase
    {
        static MyDbContext dbContext = new MyDbContext();
        
        [HttpGet]
        public async Task GetByLocate([FromQuery] int? microcategory_id, [FromQuery] int? location_id )
        {
            try
            {
                if (await dbContext.baseline_matrix_1s.FirstOrDefaultAsync(x =>
                        x.microcategory_id == microcategory_id && x.location_id ==location_id) != null)
                {
                    await Response.WriteAsJsonAsync(await dbContext.baseline_matrix_1s.FirstOrDefaultAsync(x =>
                        x.microcategory_id == microcategory_id && x.location_id == location_id));
                }
                else
                {
                    Response.StatusCode = 404;
                    await Response.WriteAsJsonAsync(new { message = "Not correct data" });
                }
            }
            catch (Exception ex)
            {
                await Response.WriteAsJsonAsync(new { message = "Fuck" });
            }
        }
    }
}
