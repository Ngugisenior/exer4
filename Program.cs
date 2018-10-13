using System;

namespace Scoring {
    class Program {
        static void Main (string[] args)

        {
            //innitializing the varibles
            int Score;
            int MinScore = 0;
            int MaxScore = 100;
            Grader ();

            void Grader () {

                //Random Score generator
                Random rand = new Random ();
                Score = rand.Next (MinScore, MaxScore);

                if (Score >= 86 && Score <= 100) {
                    Console.WriteLine ("Grade = 5 \tThe Score is: "+Score);
                }
                if (Score >= 76 && Score <= 85) {
                    Console.WriteLine (value: "Grade = 4 \tThe Score is: " +Score);
                }
                if (Score >= 66 && Score <= 75) {
                    Console.WriteLine ("Grade = 3 \tThe Score is: "+Score);
                }
                if (Score >= 51 && Score <= 65) {
                    Console.WriteLine ("Grade = 2 \tThe Score is: "+Score);
                }
                if (Score >= 00 && Score <= 50) {
                    Console.WriteLine ("Grade = 1 \tThe Score is: "+Score);
                }
            }
        }
    }
}