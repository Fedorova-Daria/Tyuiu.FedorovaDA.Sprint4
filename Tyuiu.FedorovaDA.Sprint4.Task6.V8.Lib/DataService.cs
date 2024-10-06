using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FedorovaDA.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            int count = 0;
            foreach (string dish in array)
            {
                if (dish.Length > 4)
                {
                    count++;
                }
            }

            
            string[] filteredDishes = new string[count];
            int index = 0;

            
            foreach (string dish in array)
            {
                if (dish.Length > 4)
                {
                    filteredDishes[index] = dish;
                    index++;
                }
            }

            return filteredDishes;  
        }
    }
}
