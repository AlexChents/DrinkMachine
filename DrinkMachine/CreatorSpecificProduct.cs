using System.Text;

namespace DrinkMachine
{
    public class CreatorSpecificProduct : Creator
    {
        private Product _product;

        public CreatorSpecificProduct()
        {
            _product = new SpecificProduct();
        }

        public override Product MakeDrink(IProductComponent drinkMain, List<IProductComponent> drinkAdditives)
        {
            _product.componentMain = drinkMain;
            _product.componentAdditives = drinkAdditives;
            return _product;
        }
    }
}
