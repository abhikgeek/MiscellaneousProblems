using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixInSprialOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());
            
            int[,] arr = new int[row,col];
            for(int i = 0; i < row; i++)
            {
                string input = Console.ReadLine();
                string[] arrS = input.Split(' ');
                for(int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(arrS[j]);
                }                
            }
            // Calling the method which will print the matrix in rotating order the array
            Print2DSprial(arr,row,col);
            Console.ReadKey();
        }

        public static void Print2DSprial(int[,] arr,int row,int col)
        {
             
            int top = 0, bottom = row - 1, right = col - 1, left = 0;
            // First set the direction to first row and move clock wise
            int direction = 0;
            while(top<=bottom && left <= right)
            {
                // first row
                if (direction == 0)
                {
                    for(int i= left; i <= right; i++)
                    {
                        Console.Write(" " + arr[top,i]);                        
                    }
                    // Set top to next row
                    top++;
                    // Change direction to right most column
                    direction = 1;
                }
                // Move Last column
                else if (direction == 1)
                {
                    for(int i = top; i <= bottom; i++)
                    {
                        Console.Write(" " + arr[i,right]);                        
                    }                    
                    right--;
                    direction = 2;
                }
                else if (direction == 2)
                {
                    for(int i= right; i >= left; i--)
                    {
                        Console.Write(" " + arr[bottom,i]);
                    }
                    bottom--;
                    direction = 3;
                }
                else if (direction == 3)
                {
                    for(int i = bottom; i >= top; i--)
                    {
                        Console.Write(" " + arr[i,left]);                        
                    }
                    left++;
                    direction = 0;
                }
            }
        }
    }
}
