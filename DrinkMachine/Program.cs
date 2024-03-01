namespace DrinkMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вначале идентификатор напитка, а потом идентификаторы добавок через запятую.");
            Console.WriteLine();
            Console.WriteLine("Идентификатор напитка.\n1 - кофе - 15$. 2 - чай - 10$.");
            Console.WriteLine("Идентификатор добавки.\n1 - молоко - 2$. 2 - сахар - 1$. 3 - корица - 3$. 4 - лимон - 1$.\n");


            int idDrinkMain = 0;
            List<int> idDrinkAdditives = new List<int>();
            Start:
            while (true)
            {
                try
                {
                    Console.Write("Введите напиток: ");
                    idDrinkMain = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Значение имеет не целочисленное значение");
                }
            }
            
            while (true)
            {
                try
                {
                    idDrinkAdditives.Clear();
                    Console.Write("Введите добавки: ");
                    string[] strAdditives = Console.ReadLine().Split(',');
                    foreach (string str in strAdditives)
                    {
                        int temp = Convert.ToInt32(str);
                        idDrinkAdditives.Add(temp);
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Значения имеют не целочисленные значения");
                }
            }
            
            DrinkMachine drinkMachine = new DrinkMachine();
            try
            {
                Console.WriteLine("Стоимость - " + drinkMachine.GetCost(ref idDrinkMain, ref idDrinkAdditives) + "$.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            Console.ReadLine();
        }
    }
}
