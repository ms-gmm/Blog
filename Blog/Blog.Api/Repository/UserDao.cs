using Blog.Application.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Repository
{
    public class UserDao
    {
        private MyDb _db;
        public UserDao(MyDb myDb)
        {
            _db = myDb;
        }

        public void Add(UserDto user)
        {
            _db.Set<UserDto>().Add(user);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _db.Set<UserDto>().Where(o => o.Id == id).FirstOrDefault();
            _db.Set<UserDto>().Remove(data);

            var data1 = _db.Set<UserDto>().Where(o => o.Id == id).ToList();

            _db.RemoveRange(data1);
            _db.SaveChanges();
        }
        public UserDto Find(int id)
        {
            return _db.User.Where(o => o.Id == id).FirstOrDefault();
        }
        public List<UserDto> FindAll()
        {
            //var b = _db.User.SingleOrDefault(o => o.Age == 1);//报错 因为有2个这个年龄
            // var b1 = _db.User.SingleOrDefault(o => o.Age == 3);
            //var c = _db.User.FirstOrDefault(o => o.Age == 1);
            //var c1 = _db.User.FirstOrDefault(o => o.Age == 3);
            // var d = _db.User.First(o => o.Age == 1);
            //var d1 = _db.User.First(o => o.Age == 2);//报错 因为没有2
            //var a = _db.User.Single(o => o.Age == 1); 报错 有2个
            // var a1 = _db.User.Single(o => o.Age == 2);//没有也报错

          //  _db.User.GroupBy(o => o.Id).Select(p => new {AgeCount=p.Count(),Name=p.Key,MaxAge=p.Max(a=>a.Age) });
            return _db.User.ToList();
        }
        public void Update(UserDto user)
        {
            var data=Find(user.Id);
            if (data != null)
            {
                data.Name = user.Name;
                data.NickName = user.NickName;
                data.Phone = user.Phone;
                _db.Update(data);
                _db.SaveChanges();
            }
        }
    }
}
