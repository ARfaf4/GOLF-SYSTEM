using GOLF_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOLF_SYSTEM.Controllers
{
    internal class GolfController
    {
        public void AddGolf(GOLFOVE golf)
        {
            using (GolfDBEntities db = new GolfDBEntities())
            {
                golf.Id = db.GOLFOVEs.ToList().LastOrDefault().Id + 1;
                db.GOLFOVEs.Add(golf);
                db.SaveChanges();
            }
        }
        public List<GOLFOVE> GetAllGolfes()
        {
            using (GolfDBEntities db = new GolfDBEntities())
            {
                return db.GOLFOVEs.ToList();
            }
        }

        /*
        public void UpdateGolf(int id, GOLFOVE golf)
        {
            using (GolfDBEntities db = new GolfDBEntities())
            {
                var userToUpdate = db.GOLFOVEs.Where(u => u.Id == id).FirstOrDefault();
                userToUpdate = golf;
                db.GOLFOVEs.AddOrUpdate(golf);
                db.SaveChanges();
            }
        }
        */
    }
}
