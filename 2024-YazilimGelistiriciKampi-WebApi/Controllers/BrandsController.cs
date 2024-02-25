using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2024_YazilimGelistiriciKampi_WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    // isteği karşılayacak endpointler oluşturulur
    [HttpPost]
    public IActionResult Add(CreateBrandRequest createBrandRequest)
    {
        CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);

        return Ok(createdBrandResponse); // IActionResult -- Ok Http200 döner -- Success
        // return Ok(_brandService.Add(createBrandRequest));
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_brandService.GetAll());
    }
}
