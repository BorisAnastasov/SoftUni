namespace _02._Delivery_Boy
{
       internal class Program
       {
              public static int rowBoy = 0;
              public static int colBoy = 0;
              static void Main(string[] args)
              {
                     int[] paramaters = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                     int rows, cols;
                     rows = paramaters[0];
                     cols = paramaters[1];
                     int[,] matrix = new int[rows, cols];

                     for (int i = 0; i < matrix.GetLength(0); i++)
                     {
                            char[] line = Console.ReadLine().ToCharArray();
                            for (int z = 0; z < matrix.GetLength(1); z++)
                            {
                                   if (line[z] == 'B')
                                   {
                                          rowBoy = i;
                                          colBoy = z;
                                   }
                                   matrix[i, z] = line[z];
                            }
                     }
                     string cmd;
                     while ((cmd = Console.ReadLine()) != null)
                     {
                            matrix[rowBoy, colBoy] = '.';

                            if (cmd == "up")
                            {
                                   colBoy++;

                            }
                            else if (cmd == "down")
                            {
                                   colBoy--;

                            }
                            else if (cmd == "right")
                            {
                                   rowBoy++;
                            }
                            else //left
                            {
                                   rowBoy--;
                            }
                     }
              }

              public bool IsLate(int row, int col, ref int[,] matrix)
              {
                     return matrix.GetLength(0) >= row + 1 &&
                     matrix.GetLength(1) >= col + 1 &&
                     0 <= row &&
                     0 <= col;
              }

              public int[] DeliveryMover(int row, int col, ref int[,] matrix)
              {

                     if ()
              }
       }
}