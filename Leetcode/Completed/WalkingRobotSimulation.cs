using System.Security.Cryptography.X509Certificates;

namespace Leetcode;

public class WalkingRobotSimulation : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[][] obstacles = [];
        int[] commands = [4, -1, 3];
        Console.WriteLine(solution.RobotSim(commands, obstacles));

        obstacles = [[2, 4]];
        commands = [4, -1, 4, -2, 4];
        Console.WriteLine(solution.RobotSim(commands, obstacles));

        
        obstacles = [];
        commands = [6, -1, -1, 6];
        Console.WriteLine(solution.RobotSim(commands, obstacles));
    }
    
    public class Solution {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            // Craft dictionary for easy access
            Dictionary<int, List<int>> obstaclesDictionary = new Dictionary<int, List<int>>();
            foreach (int[] coord in obstacles)
            {
                if (obstaclesDictionary.ContainsKey(coord[0])) // If list exist
                {
                    obstaclesDictionary[coord[0]].Add(coord[1]);
                }
                else
                {
                    List<int> list = new List<int>();
                    list.Add(coord[1]);
                    obstaclesDictionary.Add(coord[0], list);
                }
            }
            
            // Direction index
            int currentDirection = 0;
            
            // Current position
            int x = 0;
            int y = 0;
            
            // Largest
            int total = 0;
            
            // Read commands
            foreach (int command in commands)
            {
                ReadCommand(command, 
                    ref currentDirection, 
                    ref x, ref y, 
                    ref obstaclesDictionary);
                if (command > 0)
                {
                    total = Math.Max(total, x * x + y * y);
                }
            }

            return total;
        }

        void ReadCommand(int command, ref int currentDirection, ref int x, ref int y, ref Dictionary<int, List<int>> obstaclesDictionary)
        {
            if (command == -2) // Anti-Clockwise
            {
                ChangeDirection(ref currentDirection, false);
            } else if (command == -1) // Clock-wise
            {
                ChangeDirection(ref currentDirection, true);
            }
            else
            {
                for (int i = 0; i < command; i++)
                {
                    TryMove(ref currentDirection, ref x, ref y, ref obstaclesDictionary);
                }
            }
        }

        void ChangeDirection(ref int currentDirection, bool clockwise)
        {
            if (clockwise)
            {
                currentDirection += 1;
                if (currentDirection > 3)
                {
                    currentDirection -= 4;
                }
            }
            else
            {
                currentDirection -= 1;
                if (currentDirection < 0)
                {
                    currentDirection += 4;
                }
            }
        }

        void TryMove(ref int currentDirection, ref int x, ref int y, ref Dictionary<int, List<int>> obstaclesDictionary)
        {
            int[][] directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];

            int newX = x + directions[currentDirection][0];
            int newY = y + directions[currentDirection][1];

            if (obstaclesDictionary.ContainsKey(newX))
            {
                if (obstaclesDictionary[newX].Contains(newY))
                {
                    return;
                }
            }

            x = newX;
            y = newY;
        }
    }
}