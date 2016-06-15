using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class RockPaperScissors
    {
        //private enum HandShapes {Rock=1, Paper, Scissor};
        
        
        private string Ans,Pla;

        private int UserAns;

        private int playAgian;

        private void UserLogic()

        {
            try
            {
                Console.WriteLine("Instructions \n" +
                    "Choose a number between 1(Rock), 2(Paper) or 3(Scissors) \n" +
                    "After you make your selection the computer will display his or her answer");

                 Ans = Console.ReadLine();

            }catch (IOException e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("Choose a number between 1, 2 or 3 ");

                Ans = Console.ReadLine();

            }finally
            {
                UserAns = Int16.Parse(Ans);
            }

        }



        private void ComputerLogic()
        {
            //int handNum = (int)HandShapes.Rock;

            int compAns=new Random().Next(1, 3);

            if (compAns == 1)
            {
                if (UserAns == compAns)
                    Console.WriteLine("Tie");
                else if (UserAns == 2)
                    Console.WriteLine("Computer Choose Rock -- Player choose Paper ");
                else if (UserAns == 3)
                    Console.WriteLine("Computer Choose Rock -- Player choose Scissors");
            }

            else if (compAns == 2)
            {
                if (UserAns == compAns)
                    Console.WriteLine("Tie");
                else if (UserAns == 1)
                    Console.WriteLine("Computer Choose Paper -- Player choose Rock ");
                else if (UserAns == 3)
                    Console.WriteLine("Computer Choose Paper -- Player choose Scissor");
            }
            else if (compAns == 3)
            {
                if (UserAns == compAns)
                    Console.WriteLine("Tie");
                else if (UserAns == 1)
                    Console.WriteLine("Computer Choose Scissor -- Player choose Rock ");
                else if (UserAns == 2)
                    Console.WriteLine("Computer Choose Scissor -- Player choose Paper ");
            }
            
        }

        public void StartGame()
        {
            do
            {
                UserLogic();
                ComputerLogic();
                Console.WriteLine("Do You want to play agian ? 1(yes) or 2(no)");
                Pla = Console.ReadLine();
                playAgian = Int16.Parse(Pla);
            } while (playAgian == 1);
        }
        
    }
}
