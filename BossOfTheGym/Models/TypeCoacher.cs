namespace BossOfTheGym.Models
{
    public class TypeCoacher
    {
        public int Id { get; set; }
        public string TypeCoacherName { get; set; }
        public ICollection<PersonGym> PersonsGym { get; set; }
    }
}
