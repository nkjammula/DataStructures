using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Arrays
    {
        public void printOneDimensionalIntegerArray()
        {

            //int[] intArr = new int[5] { 1,2,3,4,5};


            int[] intArr = { 1,2,3,4,5};

            for(int i=0; i<intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }
        }

        public void printOneDimensionalStringArray()
        {
            string[] strArry = {"Mon","Tue","Wed","Thurs","Fri" };
            Console.WriteLine("Printing Days:");
            for(int i = 0; i < strArry.Length; i++)
            {
                Console.WriteLine(strArry[i] + " ");
            }
        }

        public void MultiDimensionalArray()
        {
            // creating two dimensional array
            int[,] int2DArr = new int[4, 2] { {1,2 },{3,4 },{ 5,6},{7,8 } };

            //Three dimensional array
            int[,,] int3DArr = new int[4, 2, 3] 
            { { { 1, 2, 3 }, { 4, 5, 6 } },
            { { 1, 2, 3 }, { 4, 5,6 } },
            { { 1, 2, 3 }, { 4, 5, 6 } },
            { { 1, 2, 3 }, { 4, 5, 6 } }
            };
            Console.WriteLine("printing Three dimensional Arrays");
            for(int i=0; i < 4; i++)
            {
                for(int j=0; j<2; j++)
                {
                    for(int k=0; k < 3; k++)
                    {
                        Console.WriteLine(int3DArr[i, j, k]);
                    }
                }
            }

        }

        public void JaggedArray()
        {
            int[][] jaggedArr =
            {
                new int[]{1,2,3,4,5},
                new int[]{6,7,8,9}
            };
            Console.WriteLine("/***********Printing Jagged Array*****/");
            for(int i=0;i<jaggedArr.Length; i++)
            {
                for(int j=0; j<jaggedArr[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr[i][j]);
                }
            }
           


        }
       

    }
}
