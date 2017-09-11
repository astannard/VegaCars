using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {

        private readonly VegaDBContext context;
        public IMapper Mapper { get; set; }

        public MakesController(VegaDBContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeVM>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return Mapper.Map<List<Make>, List<MakeVM>>(makes);
        }
    }
}