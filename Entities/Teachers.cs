namespace EF_Home_Work_Three.Entities
{
    internal class Teachers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Departments Departments { get; set; }
    }
}
