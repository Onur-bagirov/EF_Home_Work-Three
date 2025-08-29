namespace EF_Home_Work_Three.Entities
{
    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public Themes Themes { get; set; }
        public  Categories Categories  { get; set; }
        public Authors Authors { get; set; }
        public Press Press { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }
    }
}
