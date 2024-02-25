using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandReuqest)
    {
        // Business Rules 

        // mapping --> AutoMapper
        Brand brand = new();
        brand.Name = createBrandReuqest.Name;
        brand.CreatedDate = DateTime.Now;

        _brandDal.Add(brand);

        // mapping
        CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
        createdBrandResponse.Name = brand.Name;
        createdBrandResponse.Id = 4; // Db'den Gelecek
        createdBrandResponse.CreatedDate = brand.CreatedDate;

        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands =  _brandDal.GetAll();

        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.CreatedDate = brand.CreatedDate;

            getAllBrandResponses.Add(getAllBrandResponse);
        }
        return getAllBrandResponses;
    }
}
