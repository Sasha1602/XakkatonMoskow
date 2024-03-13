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
        private static MyDbContext _dbContext = new MyDbContext();

        [HttpGet]
        public async Task GetByParams([FromQuery] int? microcategory_id, [FromQuery] int? location_id)
        {
            try
            {
                if (await _dbContext.discount_matrix_1s.FirstOrDefaultAsync(x =>
                        x.location_id == location_id && x.microcategory_id == microcategory_id) != null)
                {
                    var res = await _dbContext.discount_matrix_1s.FirstOrDefaultAsync(x =>
                        x.location_id == location_id && x.microcategory_id == microcategory_id);
                    await Response.WriteAsJsonAsync(res.price);
                }
                else if (await _dbContext.baseline_matrix_1s.FirstOrDefaultAsync(x =>
                             x.location_id == location_id && x.microcategory_id == microcategory_id) != null)
                {
                    var res =  await _dbContext.baseline_matrix_1s.FirstOrDefaultAsync(x =>
                        x.location_id == location_id && x.microcategory_id == microcategory_id);
                    await Response.WriteAsJsonAsync(res.price);
                }
                else
                {
                    Response.StatusCode = 404;
                    await Response.WriteAsJsonAsync(new { message = "Not Found" });
                }
            }
            catch (Exception ex)
            {
                await Response.WriteAsJsonAsync(new { message = "Not found" });
            }
        }
    }
}
