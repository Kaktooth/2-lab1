using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        public static void EnterNumbers(int[,] matrixX)
        {
            for (int i = 0; i < matrixX.GetLength(0); i++)
            {
                for (int j = 0; j < matrixX.GetLength(1); j++)
                {

                    matrixX[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
          
        }
        public static void ShowMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void TransposeMatrix( int[,] matrixX, int[,] matrixY)
        {
          
           //and save to new matrix
            for (int i = 0; i < matrixY.GetLength(0); i++)
            {
             
                for (int j = 0; j < matrixY.GetLength(1); j++)
                {
                   
                    matrixY[i, j] = matrixX[j, i];
                    Console.Write(matrixX[j, i]);
               

                }
                Console.WriteLine();
             
            }
            Console.ReadLine();
          
        }
        public static void Sort1(int[,] numarray, int[,] matrixY)
        {

            for (int i = 0; i < matrixY.GetLength(0); i++)
            {
                for (int j = 0; j < matrixY.GetLength(1); j++)
                {

                    numarray[i, j] = matrixY[matrixY.GetLength(0) - i - 1, j];

                }
            }
        }
        public static void ClearingArray(int[,] numarray, int[,] sortedarray)
        {
            int savednum = 0;
            bool arraynotcleared = false;
            for (int i = 0; i < numarray.GetLength(0); i++)
            {

                if (numarray[i, 0] == 0)
                {
                    Array.Clear(numarray, i, numarray.GetLength(0));
                    arraynotcleared = true;
                    Console.WriteLine("Index " + i++ + " cleared");
                }

              

            }
            if (arraynotcleared==false)
            {
                Console.WriteLine("Array not cleared");

            }


        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter length of matrix");
            int savednum = 0;
           
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrixX = new int[n, m];
            int[,] matrixY = new int[m, n];
            int[,] numarray = new int[m, n];
            int[,] sortedarray = new int[m, n];


            EnterNumbers(matrixX);
            ShowMatrix(matrixX);
            TransposeMatrix(matrixX, matrixY);
            Sort1(numarray, matrixY);

            ShowMatrix(numarray);
            ClearingArray(numarray, sortedarray);
           
          

            ShowMatrix(numarray);
            int[] savedarray = new int[sortedarray.GetLength(1)];

       
            for (int i = 0; i < numarray.GetLength(0); i++)
            {
                for (int j = 0; j < sortedarray.GetLength(1); j++)
                {

                    savedarray[j] = numarray[i,j];
                }
                Array.Sort(savedarray);
                Array.Reverse(savedarray);


                for (int j = 0; j < sortedarray.GetLength(1); j++)
                {

                numarray[i, j]=savedarray[j];
                }


                }
            ShowMatrix(numarray);
        
          
        }
    }
}