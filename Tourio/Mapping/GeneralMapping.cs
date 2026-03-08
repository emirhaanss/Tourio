using AutoMapper;
using Tourio.Dtos.CategoryDtos;
using Tourio.Dtos.ReviewDtos;
using Tourio.Dtos.TourDtos;
using Tourio.Entities;

namespace Tourio.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Tour, CreateTourDto>().ReverseMap();
            CreateMap<Tour, GetTourByIdDto>().ReverseMap();
            CreateMap<Tour, ResultTourDto>().ReverseMap();
            CreateMap<Tour, UpdateTourDto>().ReverseMap();

            CreateMap<Review, CreateReviewDto>().ReverseMap();
            CreateMap<Review, GetReviewByIdDto>().ReverseMap();
            CreateMap<Review, ResultReviewDto>().ReverseMap();
            CreateMap<Review, UpdateReviewDto>().ReverseMap();
            CreateMap<Review, ResultReviewByTourIdDto>().ReverseMap();

        }
    }
}