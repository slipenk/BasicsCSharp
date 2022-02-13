using System;
using System.Collections.Generic;
namespace Lab_2
{
    public class MatchEventsArg : EventArgs
    {
        public Footballer footballer;
        public Footballer footballerSub;
        public MatchEventsArg(Footballer footballer)
        {
            this.footballer = footballer;
        }

        public MatchEventsArg(Footballer footballer1, Footballer footballer2)
        {
            footballer = footballer1;
            footballerSub = footballer2;
        }
    }

    public class MatchEvent
    {
        public List<Footballer> Liverpool;
        public List<Footballer> West_Ham_United;

        public delegate void MatchEventHandler(object sender, MatchEventsArg e);

        public event MatchEventHandler E_GetYellowCard;
        public event MatchEventHandler E_ScoreGoal;
        public event MatchEventHandler E_Substitution;
        public event MatchEventHandler E_GoalScoredPenalty;
        public event MatchEventHandler E_CanceldGoal;

        public void GetYellowCard(Footballer footballer)
        {
            if (IsFootballerOnTheField(footballer))
            {
                footballer.IsYellowCard = true;
                if(E_GetYellowCard != null)
                     E_GetYellowCard.Invoke(this, new MatchEventsArg(footballer));
            }
        }

        private bool IsFootballerOnTheField(Footballer footballer)
        {
            return Liverpool.Find(item => item.IsOnField == true).IsOnField ||
                West_Ham_United.Find(item => item.IsOnField == true).IsOnField;
        }

        public void ScoreGoal(Footballer footballer)
        {
            if (IsFootballerOnTheField(footballer))
            {
                Footballer.GoalsInMatchScore();
                footballer.ScoreGoal();
                if (E_ScoreGoal != null)
                    E_ScoreGoal.Invoke(this, new MatchEventsArg(footballer));
            }
        }
        public void Substitution(Footballer footballer1, Footballer footballer2)
        {
            if (IsFootballerOnTheField(footballer1))
            {
                footballer1.IsOnField = false;
                footballer2.IsOnField = true;
                if (E_Substitution != null)
                    E_Substitution.Invoke(this, new MatchEventsArg(footballer1, footballer2));

            }
        }

        public void GoalScoredPenalty(Footballer footballer)
        {
            if (IsFootballerOnTheField(footballer))
            {
                Footballer.GoalsInMatchScore();
                footballer.ScoreGoal();
                footballer.GoalScoredPenalty = true;
                if (E_GoalScoredPenalty != null)
                    E_GoalScoredPenalty.Invoke(this, new MatchEventsArg(footballer));

            }
        }

        public void CanceldGoal(Footballer footballer)
        {
            if (IsFootballerOnTheField(footballer))
            {
                footballer.CanceldGoal = true;
                if (E_CanceldGoal != null)
                    E_CanceldGoal.Invoke(this, new MatchEventsArg(footballer));
            }
        }
    }

}
