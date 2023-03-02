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

        
        public void UpdateGolf(int id, GOLFOVE golf)
        {
            using (GolfDBEntities db = new GolfDBEntities())
            {
                var userToUpdate = db.GOLFOVEs.Where(u => u.Id == id).FirstOrDefault();
                if (userToUpdate != null)
                {
                    userToUpdate.Id = id;
                    userToUpdate.Model = golf.Model;
                    userToUpdate.Year = golf.Year;
                    db.SaveChanges();
                }
            }
        }

        public void DeleteGolf(int id)
        {
            using (GolfDBEntities db = new GolfDBEntities())
            {
                var userToDelete = db.GOLFOVEs.Where(u => u.Id == id).FirstOrDefault();
                if (userToDelete != null)
                {
                    db.GOLFOVEs.Remove(userToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
