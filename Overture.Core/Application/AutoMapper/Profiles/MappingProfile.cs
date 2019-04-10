﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Overture.Core.Application.Models;
using Overture.Core.Application.AutoMapper.Resolvers;
using Overture.Core.Domain.Entities;
using Overture.Core.Domain.ValueObjects;
using Overture.Core.Services;


namespace Overture.Core.Application.AutoMapper.Profiles
{
    public class MappingProfile : Profile
    {
		public MappingProfile()
		{
			CreateMap<Business, BusinessModel>();
			CreateMap<FileAttachment, FileAttachmentModel>();
			CreateMap<IFileProperties, FileAttachmentModel>();
			CreateMap<BusinessService, BusinessServiceModel>();
			CreateMap<BusinessServiceCategory, BusinessServiceCategoryModel>()
				.ForMember(dest => dest.Description, opts => opts.MapFrom<BusinessServiceCategoryDescriptionResolver>())
				.ForMember(dest => dest.CountOfServices, opts => opts.MapFrom<CountOfServicesResolver>());

			CreateMap<Review, ReviewModel>()
				.ForMember(dest => dest.ReviewerName, opts => opts.MapFrom<UserDisplayNameResolver, string>(src => src.Reviewer))
				.ForMember(dest => dest.BusinessName, opts => opts.MapFrom<BusinessNameResolver, Guid>(src=> src.BusinessId));

		}
	}
}
