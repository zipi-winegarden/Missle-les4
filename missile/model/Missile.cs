using WebApplication1.model;

namespace Api.model
{
    public class Missile
    {
        public int Patriotmissile { get; set; }//שם טיל
    
        public Location Location { get; set; }

        public override string? ToString()
        {
            return $"id: {Patriotmissile}" + base.ToString();
        }
    }
}
