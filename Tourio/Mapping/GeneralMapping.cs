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

            CreateMap<TourDayPlan, GetTourDayPlanDto>().ReverseMap();
            CreateMap<TourDayPlan, ResultTourDayPlanDto>().ReverseMap();
            CreateMap<TourDayPlan, UpdateTourDayPlanDto>().ReverseMap();
            CreateMap<TourDayPlan, CreateTourDayPlanDto>().ReverseMap();

            CreateMap<Review, CreateReviewDto>().ReverseMap();
            CreateMap<Review, GetReviewByIdDto>().ReverseMap();
            CreateMap<Review, ResultReviewDto>().ReverseMap();
            CreateMap<Review, UpdateReviewDto>().ReverseMap();
            CreateMap<Review, ResultReviewByTourIdDto>().ReverseMap();

            CreateMap<TourFeature, CreateTourFeatureDto>().ReverseMap();
            CreateMap<TourFeature, GetTourFeatureDto>().ReverseMap();
            CreateMap<TourFeature, ResultTourFeatureDto>().ReverseMap();
            CreateMap<TourFeature, UpdateTourFeatureDto>().ReverseMap();
        }
    }
}