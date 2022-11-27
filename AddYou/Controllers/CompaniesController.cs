using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet("GetPopularCompanies")]
        public async Task<IActionResult> GetPopularCoffeeHouses() =>
            Ok(await _companyService.GetPopularCompanies());

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _companyService.GetAllAsync());

        [HttpPut]
        public async Task<IActionResult> Get([FromBody] GetCompaniesByAdmin command) =>
            Ok(await _companyService.GetAllAsync(command.AdminId));

        [HttpGet("GetProductByUserAsync")]
        public async Task<IActionResult> GetProductByUserAsync([FromQuery] string idUser) =>
            Ok(await _companyService.GetProductByUserAsync(idUser));

        [HttpGet("GetByCompaniesIdUser")]
        public async Task<IActionResult> GetByCompaniesIdUser([FromQuery] string userId) =>
            Ok(await _companyService.GetByCompaniesIdUser(userId));

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) =>
            Ok(await _companyService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Company value) =>
            Ok(await _companyService.AddAsync(value));

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Company value) =>
            Ok(await _companyService.UpdateAsync(value));

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
