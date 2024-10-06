﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FedorovaDA.Sprint4.Task5.V22.Lib
{
    public class DataService : ISprint4Task5V22
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
