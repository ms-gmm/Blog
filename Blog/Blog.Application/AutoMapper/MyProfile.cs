using AutoMapper;
using Blog.Application.Entity;
using Blog.Application.Poco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.AutoMapper
{
    public class MyProfile : Profile
    {

        public MyProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Article, ArticleDto>();

            // 源  目标(目标 ，源)
            CreateMap<ArticleDto, Article>().ForMember(entity => entity.UserName, entity => entity.MapFrom(s => s.User.Name));

            //.ForMember(d => d.Name, opt =>
            // {
            //     opt.MapFrom(s => s.Name);
            // })
        }

    }

}
