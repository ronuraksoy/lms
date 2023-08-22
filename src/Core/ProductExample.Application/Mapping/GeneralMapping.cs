using AutoMapper;
using Lms.Application.Features.Queries.GetAllProduct;
using Lms.Application.Features.Queries.GetByIdProduct;
using Lms.Application.Features.Queries.GetWhereProduct;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, GetAllProductQueryResponse>()
                .ReverseMap();
            CreateMap<Product, GetByIdProductQueryResponse>()
                .ReverseMap();
            CreateMap<Product, GetWhereProductQueryResponse>()
                .ReverseMap();
        }
    }
}
