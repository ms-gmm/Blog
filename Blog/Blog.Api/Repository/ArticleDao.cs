using AutoMapper;
using Blog.Application.AutoMapper;
using Blog.Application.Poco;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Repository
{
    public class ArticleDao
    {
        public readonly MyDb _db;
        //private readonly AutoMapperConfig _config;

        //public ArticleDao(MyDb myDb,AutoMapperConfig config)
        //{
        //    _db = myDb;
        //    _config = config.GetMapper();
        //}

        private readonly IMapper _mapper;

        public ArticleDao(MyDb myDb, IMapper mapper)
        {
            _db = myDb;
            _mapper = mapper;
        }
        public void Add(ArticleDto article)
        {
            _db.AddAsync(article);
            _db.SaveChanges();
        }

        public void Delete(ArticleDto article)
        {
            var data = _db.Article.Single(o => o.Id == article.Id);
            _db.Remove(data);
            _db.SaveChanges();
        }

        public void Update(ArticleDto article)
        {
            var data = Find(article.Id);
            if (data != null)
            {
                data.Title = article.Title;
                data.Content = article.Content;
                data.UserId = article.UserId;
                _db.Update(data);
                _db.SaveChanges();
            }
        }
        public ArticleDto Find(int id)
        {
            return _db.Article.Single(o => o.Id == id);
        }

        public List<Application.Entity.Article> FindAll()
        {
            var list = _db.Article.Include(o => o.User).ToList();

            var rst = _mapper.Map<List<Application.Entity.Article>>(list);


            return rst;
        }
    }

}
