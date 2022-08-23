namespace BossOfTheGym.Models
{
    public class PersonGym
    {
        public int Id { get; set; }
        public int CoacherId { get; set; }
        public Coacher Coacher { get; set; }
        public int TypeCoacherId { get; set; }
        public TypeCoacher TypeCoacher { get; set; }
    }
}
