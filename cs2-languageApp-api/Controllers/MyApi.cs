using cs2_languageApp_api.Data;
using cs2_languageApp_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cs2_languageApp_api.Controllers
{
    [ApiController]
    public class MyApi: ControllerBase
    {
        private AppDBContext Context { get; set; }

        public MyApi(AppDBContext context) {
            Context = context;
        }
        //GET
        [HttpGet]
        [Route("api/german")]
        public async Task<IActionResult> German() {
            var list =  await Context.german.ToListAsync();
            return Ok(list);
        }

        // CREATE
        [HttpPost]
        [Route("api/create_german_data")]
        public async Task<IActionResult> CreateGerman(German data) {
            Context.german.Add(data);
            Context.SaveChanges();
            return Ok(data);
        }

        // UPDATE
        [HttpPut]
        [Route("api/update_german_data")]
        public async Task<IActionResult> UpdateGerman(int id, German data) {
                data.Id = id;
                Context.german.Update(data);
                Context.SaveChanges();
                return Ok(data);
        }

        // DELETE
        [HttpDelete]
        [Route("api/delete_german_data")]
        public async Task<IActionResult> DeleteGerman(int id) {

            var dataToDelete = await Context.german.FindAsync(id);
            if (dataToDelete == null) { 
                return NotFound();
            }

            Context.german.Remove(dataToDelete);
            Context.SaveChanges();
            return Ok(dataToDelete);
         }

        //GET
        [HttpGet]
        [Route("api/hungarian")]
        public async Task<IActionResult> Hungarian()
        {
            var list = await Context.hungarian.ToListAsync();
            return Ok(list);
        }

        // CREATE
        [HttpPost]
        [Route("api/create_hungarian_data")]
        public async Task<IActionResult> CreateHungarian(Hungarian data) {
            Context.hungarian.Add(data);
            Context.SaveChanges();
            return Ok(data);
        }

        // UPDATE
        [HttpPut]
        [Route("api/update_hungarian_data")]
        public async Task<IActionResult> UpdateHungarian(int id, Hungarian data) {
            data.Id=id;
            Context.hungarian.Update(data);
            Context.SaveChanges();
            return Ok(data);
        }


        //DELETE
        [HttpDelete]
        [Route("api/delete_hungarian_data")]
        public async Task<IActionResult> DeleteHungarian(int id) {

            var dataToDelete = await Context.hungarian.FindAsync(id);
            if (dataToDelete == null) {
                return NotFound();
            }

            Context.hungarian.Remove(dataToDelete);
            Context.SaveChanges();
            return Ok(dataToDelete);
        }

        //GET
        [HttpGet]
        [Route("api/english")]
        public async Task<IActionResult> English()
        {
            var list =  await Context.english.ToListAsync();
            return Ok(list);
        }

        // CREATE
        [HttpPost]
        [Route("api/create_english_data")]
        public async Task<IActionResult> CreateEnglish(English data) {
            Context.english.Add(data);
            Context.SaveChanges();
            return Ok(data);
        }

        // UPDATE
        [HttpPut]
        [Route("api/update_english_data")]
        public async Task<IActionResult> UpdateEnglish(int id, English data) { 
            data.Id= id;
            Context.english.Update(data);
            Context.SaveChanges();
            return Ok(data);
        }

        // DELETE
        [HttpDelete]
        [Route("api/delete_english_data")]
        public async Task<IActionResult> DeleteEnglish(int id) {

            var dataToDelete = await Context.english.FindAsync(id);
            if (dataToDelete == null)
            {
                return NotFound();
            }

            Context.english.Remove(dataToDelete);
            Context.SaveChanges();
            return Ok(dataToDelete);
        }

    }
}
