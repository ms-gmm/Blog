using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.AutoMapper
{
    public static class CopyUtil
    {
        private static IMapper _mapper = AutoMapperConfig._mapper;

        public static Poco.ArticleDto ToPoco(this Entity.Article entity)
        {
            return _mapper.Map<Entity.Article, Poco.ArticleDto>(entity);
        }

        public static List<Entity.Article> ToEntity(this List<Poco.ArticleDto> pocos)
        {
            return _mapper.Map<List<Entity.Article>>(pocos);
        }


        public static Poco.UserDto ToPoco(this Entity.User entity)
        {
            return _mapper.Map<Entity.User, Poco.UserDto>(entity);
        }

        public static List<Entity.User> ToEntity(this List<Poco.UserDto> pocos)
        {
            return _mapper.Map<List<Entity.User>>(pocos);
        }

    }
}
