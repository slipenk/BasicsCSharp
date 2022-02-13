using System;
namespace Lab_2
{
    public class Footballer
    {
        public string name;
        public bool IsYellowCard = false;
        public int GoalScored = 0;
        public static int GoalsInMatch = 0;
        public static void GoalsInMatchScore()
        {
            ++GoalsInMatch;
        }
        public void ScoreGoal()
        {
            ++GoalScored;
        }

        

        public bool IsOnField = true;
        public bool GoalScoredPenalty = false;
        public bool CanceldGoal = false;
    }
}
