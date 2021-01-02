namespace FunWithLinqExpressions
{
    public class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; }
        public int NumberInStock { get; set; }

        public override string ToString()
            => $"Name={Name}, Description={Description}, Number in Stock={NumberInStock}";
    }
}