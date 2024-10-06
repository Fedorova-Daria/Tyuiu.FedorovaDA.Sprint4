using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FedorovaDA.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            List<string> dishes = new List<string>();
            foreach (string item in array)
            {
                if (item.Length > 4)
                {
                    dishes.Add(item);
                }
            }
            return dishes;
        }
    }
}
