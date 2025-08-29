namespace EF_Home_Work_Three.Entities
{
    internal class T_Cards
    {
        public int Id { get; set; }
        public Teachers Teachers { get; set; }
        public Books Books { get; set; }
        public int DateOut { get; set; }
        public int DateIn { get; set; }
        public Libs Libs { get; set; }
    }
}
