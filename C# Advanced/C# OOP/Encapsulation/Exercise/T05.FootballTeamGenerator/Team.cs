using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using T05.FootballTeamGenerator;

namespace T05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> playerList = new();
        private int rating;

        public Team(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value;
            }
        }
        public int Rating
        {
            get => rating;
            private set { rating = value; }
        }
        public List<Player> PlayerList
        {
            get => playerList;
        }
        public void Add(Player player)
        {

            PlayerList.Add(player);
        }
        public void Remove(string playerName, Team team)
        {
            try
            {
                Player player = team.PlayerList.First(player => player.Name == playerName);
                PlayerList.Remove(player);
            }
            catch (Exception)
            {
                throw new Exception($"Player {playerName} is not in {team.Name} team.");
            }
        }
        public void Setting()
        {
            double resultDouble = 0;
            if(PlayerList.Count == 0) 
            { 
                Rating= 0;
            }
            else
            {
                foreach (var item in PlayerList)
                {
                    resultDouble += item.SkillLevel;
                }
                resultDouble /= PlayerList.Count;
                Rating = (int)Math.Round(resultDouble);
            }
            
        }
    }
}
