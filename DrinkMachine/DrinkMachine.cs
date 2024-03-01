namespace DrinkMachine
{
    public class DrinkMachine
    {
        private List<DrinkMain> _drinkMainList;
        private List<DrinkAdditive> _drinkAdditivesList;
        private Creator _creator;

        public DrinkMachine()
        {
            _drinkMainList = new List<DrinkMain>()
            {
                new DrinkMain { Id = 1, Name = "кофе", Price = 15 },
                new DrinkMain { Id = 2, Name = "чай", Price = 10 }
            };

            _drinkAdditivesList = new List<DrinkAdditive>()
            {
                new DrinkAdditive { Id = 1, Name = "молоко", Price = 2 },
                new DrinkAdditive { Id = 2, Name = "сахар", Price = 1 },
                new DrinkAdditive { Id = 3, Name = "корица", Price = 3 },
                new DrinkAdditive { Id = 4, Name = "лимон", Price = 1 }
            };

            _creator = new CreatorSpecificProduct();
        }

        private Product GetDrink(int idDrinkMain, List<int> idDrinkAdditives)
        {
            var drinkMain = _drinkMainList.FirstOrDefault(dm => dm.Id == idDrinkMain);

            if (drinkMain == null)
                throw new Exception("Данный напиток не существует");

            List<IProductComponent> drinkAdditives = new List<IProductComponent>();
            foreach (var item in idDrinkAdditives)
            {
                var tempDrinkAdditives = _drinkAdditivesList.FirstOrDefault(da => da.Id == item);
                if (tempDrinkAdditives == null)
                    throw new Exception("Данные добавки не существуют");
                drinkAdditives.Add(tempDrinkAdditives);
            }
            
            return _creator.MakeDrink(drinkMain, drinkAdditives);
        }

        public decimal GetCost(ref int idDrinkMain, ref List<int> idDrinkAdditives)
        {
            decimal cost = 0;
            var product = GetDrink(idDrinkMain, idDrinkAdditives);
            if (product == null)
                throw new Exception("Данный продукт не возможно сделать.");
            cost += product.componentMain.Price;
            foreach (var item in product.componentAdditives)
                cost += item.Price;
            return cost;
        }
    }
}
