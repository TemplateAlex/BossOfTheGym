namespace BossOfTheGym.Models
{
    public class Coacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<PersonGym> PersonsGym { get; set; }
    }


}
