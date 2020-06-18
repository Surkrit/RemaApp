namespace RemaApp2020.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Unit { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; }
        public Category Category { get; set; }
    }
}