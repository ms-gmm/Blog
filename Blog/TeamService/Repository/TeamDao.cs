using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamService.Models;

namespace TeamService.Repository
{
    public class TeamDao
    {
        private MyDb _db;
        public TeamDao(MyDb myDb)
        {
            _db = myDb;
        }

        public void Add(Team user)
        {
            _db.Set<Team>().Add(user);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _db.Set<Team>().Where(o => o.Id == id).FirstOrDefault();
            _db.Set<Team>().Remove(data);

            var data1 = _db.Set<Team>().Where(o => o.Id == id).ToList();

            _db.RemoveRange(data1);
            _db.SaveChanges();
        }
        public Team Find(int id)
        {
            return _db.Team.Where(o => o.Id == id).FirstOrDefault();
        }
        public List<Team> FindAll()
        {
            return _db.Team.ToList();
        }
        public void Update(Team user)
        {
            var data = Find(user.Id);
            if (data != null)
            {
                data.Name = user.Name;
                _db.Update(data);
                _db.SaveChanges();
            }
        }
    }
}
