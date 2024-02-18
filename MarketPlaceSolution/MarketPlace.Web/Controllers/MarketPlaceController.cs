using ApiHub.Service.DTO.Common;
using ApiHub.Service.Services;
using MarketPlace.Web.DTO;
using MarketPlace.Web.Service;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketPlace.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketPlaceController : ControllerBase
    {

        private readonly IDbService _dbService;
        public MarketPlaceController(IDbService dbService) {

            _dbService =dbService;
        }

        // GET: api/<MarketPlaceController>
        [HttpPost("ProductList")]
        public async Task<IActionResult> GetProductList(DtoPageRequest request)
        {
            return Ok(await _dbService.GetPaginatedResultset<DtoProducts>(request, "GetProductList"));
        }

        
    }
}
