namespace DrinkMachine
{
    public abstract class Creator
    {
        public abstract Product MakeDrink(IProductComponent drinkMain, List<IProductComponent> drinkAdditives);
    }
}
