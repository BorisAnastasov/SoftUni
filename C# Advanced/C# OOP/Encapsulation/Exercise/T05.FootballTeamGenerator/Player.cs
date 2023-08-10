using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int skillLevel;
        public Player(string name, Dictionary<string, int> stats)
        {
            Name = name;
            SkillLevel = CalculatingStats(stats);
        }

        public string Name 
        {
            get => name;
            private set 
            {
                if (string.IsNullOrEmpty(value)||value==" ")
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value;
            }
        }
        public int SkillLevel 
        {
            get => skillLevel;
            set
            {
                skillLevel= value;
            } 
        }
        private static int CalculatingStats(Dictionary<string, int> stats)
        {
            foreach (var item in stats)
            {
                if (item.Value < 0 || item.Value > 100)
                {
                    throw new Exception($"{item.Key} should be between 0 and 100.");
                }
            }
            double sum = (stats.Values.Sum())/5.0;
            return (int)Math.Round(sum);
        }
    }
}
