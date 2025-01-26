using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Produtcs.UpdateProduct;

/// <summary>
/// Profile for mapping between Application and API UpdateProduct responses
/// </summary>
public class UpdateProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for UpdateProduct feature
    /// </summary>
    public UpdateProductProfile()
    {
        CreateMap<UpdateProductRequest, UpdateProductCommand>();
        CreateMap<UpdateProductResult, UpdateProductResponse>();
        CreateMap<UpdateProductResult.RatingResult, UpdateProductResponse.RatingResponse>().ReverseMap();
    }
}