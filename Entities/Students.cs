namespace EF_Home_Work_Three.Entities
{
    internal class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Groups Groups { get; set; }
        public int Term { get; set; }
    }
}
