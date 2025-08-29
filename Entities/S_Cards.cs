namespace EF_Home_Work_Three.Entities
{
    internal class S_Cards
    {
        public int Id { get; set; }
        public Students Students { get; set; }
        public Books Books { get; set;}
        public int DateOut { get; set; }
        public int DateIn { get; set; }
        public Libs Libs { get; set; }
    }
}
