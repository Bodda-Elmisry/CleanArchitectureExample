namespace WebApplication1.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        private decimal Height { get; set; }
        private decimal Length { get; set; }
        private decimal Width { get; set; }

        // dimentions = height,Length,Width
        public void SetDimentions(string dimentions)
        {
            var dim = dimentions.Split(',');
            this.Height = Convert.ToDecimal(dim[0]);
            this.Length = Convert.ToDecimal(dim[1]);
            this.Width = Convert.ToDecimal(dim[2]);
        }

        public string GetDimentions()
        {
            return string.Format("{0},{1},{2}", Height, Length, Width);
        }
    }
}
