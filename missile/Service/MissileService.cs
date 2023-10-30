using Api.model;
using WebApplication1.model;

namespace Api.Serivce
{
    public class MissileService
    {
        public MissileService()
        {

        }
        public IEnumerable<Missile> GetData()
        {
            return DB.missileList;
        }
        
        public  bool add(Missile missile)
        {
            DB.missileList.Add(missile);
            return true;
        }
        public IEnumerable<Missile> GetbyPlace(string c)
        {
            return DB.missileList.Where(t => t.Location.city == c).ToList();
        }
        public IEnumerable<string> GetPlace()
        {
            //string s="";
            //foreach (var item in DB.missileList)
            //{
            //    s += item.Location.City.ToString() + ",";
            //}
            return DB.missileList.Select(t => t.Location.city).ToList();
        }

    }
}
