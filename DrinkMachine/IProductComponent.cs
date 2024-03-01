namespace DrinkMachine
{
    public interface IProductComponent
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
    }
}
