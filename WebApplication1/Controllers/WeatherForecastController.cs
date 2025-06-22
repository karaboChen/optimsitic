using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ModelContext _modelContext;
        public WeatherForecastController(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var apples = await _modelContext.APPLE.SingleAsync(x=>x.GID == "A1F9038890DF43C59E1E95D06AB400AD");
            var apples = await _modelContext.APPLE.Where(x => x.NAME == "ī�G").ToListAsync();

            foreach (var apple in apples)
            {
                apple.NAME = "123";
            }

            var messge  = string.Empty;
            try
            {
                 await _modelContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                messge = "��ƳQ���ʤF";
            }


            return Ok(messge);
        }


        [HttpGet]
        public async Task<IActionResult> Insert()
        {

            var apple = new APPLE
            {
                NAME = "�����"
            };

            await _modelContext.APPLE.AddAsync(apple);
            await _modelContext.SaveChangesAsync(); 
            return Ok("�[�J���\");
        }

    }
}
