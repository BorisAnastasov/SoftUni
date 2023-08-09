using System;
using System.Linq;

namespace Т10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];
            int[] indexesOfLadybugs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[] cmd = Console.ReadLine().Split(" ").ToArray();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < indexesOfLadybugs.Length; k++)
                {
                    if (i == indexesOfLadybugs[k])
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            while (cmd[0] != "end")
            {
                int ladybugIndex = int.Parse(cmd[0]);
                string direction = cmd[1];
                int flyLength = int.Parse(cmd[2]);
                if(InTheField(ladybugIndex, field) && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;
                    if(direction == "right")
                    {
                        RightAdd(ladybugIndex, flyLength, field);
                    }
                    else if(direction == "left")
                    {
                        LeftAdd(ladybugIndex, flyLength, field);
                    }
                }
                cmd = Console.ReadLine().Split(" ").ToArray();
            }
            Console.WriteLine(String.Join(" ",field));
        }
        static bool InTheField(int index, int[] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if(i == index)
                {
                    return true;
                }
            }
            return false;
        }
        static void RightAdd(int ladyBugIndex,int flyLength, int[] field)
        {
            int index = ladyBugIndex + flyLength;
            for (int i = 0; i < field.Length; i++)
            {
                if(i == index)
                {
                    if (field[i] == 0)
                    {
                        field[i] = 1;
                    }
                    else
                    {
                        index+=flyLength;                          
                    }
                }                
            }
        }
        static void LeftAdd(int ladyBugIndex, int flyLength, int[] field)
        {
            int index = ladyBugIndex - flyLength;
            for (int i = field.Length-1; i >= 0; i--)
            {
                if (i == index)
                {
                    if (field[i] == 0)
                    {
                        field[i] = 1;
                    }
                    else
                    {
                        index-=flyLength;
                        
                    }
                }
                
            }
        }
    }
}