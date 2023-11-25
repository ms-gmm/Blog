using Blog.Api.Controller;
using Blog.Api.Repository;
using Blog.Application.AutoMapper;
using Blog.Application.Entity;
using Blog.Application.Poco;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    public class ArticleController : BaseController
    {
        private  ArticleDao articleDao;

        public ArticleController(ArticleDao articleDao)
        {
            this.articleDao = articleDao;
        }

        [HttpGet]
        public Result<List<Article>> GetAll()
        {
            var list = articleDao.FindAll();
            return new Result<List<Article>>(list);
        }

        [HttpPost]
        public Result Add(ArticleDto article)
        {
            articleDao.Add(article);
            return new Result();
        }

        [HttpPost]
        public Result Delete(Article article)
        {
            articleDao.Delete(article.ToPoco());
            return new Result();
        } 

        [HttpPost]
        public Result Update(ArticleDto article)
        {
            articleDao.Update(article);
            return new Result();
        }
    }
}
