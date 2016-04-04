using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight
{
    public static class Scorer
    {

        private const int ADULT_POINTS = 10;
        private const int CHILD_POINTS = 15;

        public static int AdultScore(int correct,  int incorrect)
        {
            int score = 0;

            for (int i = 0; i < correct; i++)
            {
                score = score + ADULT_POINTS;
            }

           for (int i = 0; i < incorrect; i++)
            {
                score--;
            }                      

            return score;
        }

        public static int ChildScore(int correct, int incorrect)
        {
            int score = 0;
            for (int i = 0; i < correct; i++)
            {
                score = score + CHILD_POINTS;
            }

            return score;
        }
    }
}
