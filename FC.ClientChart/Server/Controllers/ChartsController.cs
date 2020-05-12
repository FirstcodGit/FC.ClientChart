using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FC.Highcharts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FC.ClientChart.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await GetScatterModel());
        }

        // Fake data
        private async Task<ScatterModel> GetScatterModel()
        {
            var male = new List<double[]>();
            var female = new List<double[]>();

            for (int i = 0; i < 100; i++)
            {
                male.Add(new double[] { new Random().Next(160,200), new Random().Next(65,110) });
                female.Add(new double[] { new Random().Next(155, 195), new Random().Next(55, 90) });
            }

            var model = new ScatterModel()
            {
                MaleData = male,
                FeMaleData = female
            };

            return await Task.FromResult(model);
        }
    }
}