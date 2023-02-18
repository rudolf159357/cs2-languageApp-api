using cs2_languageApp_api.Data;
using cs2_languageApp_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cs2_languageApp_api.Controllers
{
    [ApiController]
    public class MyApi
    {
        private AppDBContext Context { get; set; }

        public MyApi(AppDBContext context) {
            Context = context;
        }

        [HttpGet]
        [Route("api/german")]
        public async Task<ActionResult<IEnumerable<German>>> German() {
            return await Context.german.ToListAsync();
        }

        [HttpGet]
        [Route("api/hungarian")]
        public async Task<ActionResult<IEnumerable<Hungarian>>> Hungarian()
        {
            return await Context.hungarian.ToListAsync();
        }

        [HttpGet]
        [Route("api/english")]
        public async Task<ActionResult<IEnumerable<English>>> English()
        {
            return await Context.english.ToListAsync();
        }
    }
}
