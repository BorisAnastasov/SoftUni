using System;
using System.ComponentModel;

namespace T05.FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new();
            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    string[] cmd = input.Split(";").ToArray();
                    if (cmd[0] == "Team")
                    {
                        string name = cmd[1];
                        Team team = new(name);
                        teams.Add(team);
                    }
                    else if (cmd[0] == "Add")
                    {
                        string name = cmd[1];
                        string playerName = cmd[2];
                        var stats = new Dictionary<string, int>();
                        int endurance = int.Parse(cmd[3]);
                        int sprint = int.Parse(cmd[4]);
                        int dribble = int.Parse(cmd[5]);
                        int passing = int.Parse(cmd[6]);
                        int shooting = int.Parse(cmd[7]);
                        stats.Add("Endurance", endurance);
                        stats.Add("Sprint", sprint);
                        stats.Add("Dribble", dribble);
                        stats.Add("Passing", passing);
                        stats.Add("Shooting", shooting);
                        Player player = new(playerName, stats);
                        foreach (var item in teams)
                        {
                            if (item.Name == name)
                            {
                                item.Add(player);
                                break;
                            }
                        }
                    }
                    else if (cmd[0] == "Remove")
                    {
                        string name = cmd[1];
                        string playerName = cmd[2];
                        if(teams.FirstOrDefault(teams=> teams.Name == name) == null)
                        {
                            throw new Exception($"Team {name} does not exist.");
                        }
                        Team team = teams.FirstOrDefault(t => t.Name == name);
                        team.Remove(playerName, team);
                    }
                    else if (cmd[0] == "Rating")
                    {
                        string name = cmd[1];
                        if (teams.FirstOrDefault(team => team.Name == name) == null)
                        {
                            throw new Exception($"Team {name} does not exist.");
                        }
                        Team team = teams.FirstOrDefault(t => t.Name == name);
                        team.Setting();
                        Console.WriteLine($"{team.Name} - {team.Rating}");
                    }
                }   
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                input = Console.ReadLine();
            }


        }
    }
}