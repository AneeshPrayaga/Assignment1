using System;

namespace Assignment1
{
    class Program
    {
        // Algorithem
       
        static void Main(string[] args)
        {

            Console.WriteLine("Q1 : Enter the Moves of Robot:");

            //taking the input
            string moves = Console.ReadLine().ToLower();

            //initializing variables to create an origin
            int x = 0;
            int y = 0;


            //calling the method to get true or false
            bool pos = JudgeCircle(moves);
           
 

            //bool Output = JudgeCircle(direction);
            //priniting true false based on the output of the method

            if (pos)
            {
                Console.WriteLine("The robot Returns to the initial position (0,0)");
            }
            else {
                Console.WriteLine("The robot Does not Return to the initial position (0,0)");
            }

            //Creating the method
            bool JudgeCircle(string moves)
            {
                char[] Coordinates = moves.ToCharArray();//changing to char array to check the coditions
                foreach (char c in Coordinates)//loop to iterate in all the conditions and inputs
                {

                    if (c == 'l')//condition when  left
                    {
                        x -= 1;
                    }
                    else if (c == 'r')//condition when  right
                    {
                        x += 1;
                    }
                    else if (c == 'u')//condition when  up
                    {
                        y += 1;
                    }
                    else if (c == 'd')//condition when  Down
                    {
                        y -= 1;
                    }

                }
                if (x == 0 && y == 0)//condition for checking if it ended up in same position  
                {
                    return true;
                }
                else
                {
                    return false;//condition for not coming back to origion
                }



            }


        }
      
    }
}
