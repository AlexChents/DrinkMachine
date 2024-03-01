namespace DrinkMachine
{
    public class SpecificProduct : Product
    {
        public override IProductComponent componentMain { get; set; }
        public override List<IProductComponent> componentAdditives { get; set; }
    }
}