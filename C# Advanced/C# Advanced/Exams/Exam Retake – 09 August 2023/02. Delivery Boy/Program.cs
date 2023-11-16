namespace _02._Delivery_Boy
{
       internal class Program
       {
              public static int startRow = 0;
              public static int startCol = 0;
              public static int rowBoy = 0;
              public static int colBoy = 0;
              public static int[] changing = new int[2];
              public static bool IsPizzaCollected = false;

              static void Main(string[] args)
              {
                     int[] paramaters = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                     int rows, cols;
                     rows = paramaters[0];
                     cols = paramaters[1];
                     char[,] matrix = new char[rows, cols];

                     for (int i = 0; i < matrix.GetLength(0); i++)
                     {
                            char[] line = Console.ReadLine().ToCharArray();
                            for (int z = 0; z < matrix.GetLength(1); z++)
                            {
                                   if (line[z] == 'B')
                                   {
                                          rowBoy = i;
                                          colBoy = z;
                                          startRow = i;
                                          startCol = z;
                                   }
                                   matrix[i, z] = line[z];
                            }
                     }
                     string cmd;
                     while (true)
                     {
                            cmd = Console.ReadLine();
                            if (cmd == "up")
                            {
                                   rowBoy--;
                                   changing[0]--;
                                   if (IsNotLate(matrix))
                                   {
                                          DeliveryMover(ref matrix);
                                   }
                                   else
                                   {
                                          matrix[startRow, startCol] = ' ';
                                          Console.WriteLine("The delivery is late. Order is canceled.");
                                          PrintingMatrix(matrix);
                                          return;
                                   }
                                   changing[0] = 0;
                            }
                            else if (cmd == "down")
                            {
                                   rowBoy++;
                                   changing[0]++;
                                   if (IsNotLate(matrix))
                                   {
                                          DeliveryMover(ref matrix);
                                   }
                                   else
                                   {
                                          matrix[startRow, startCol] = ' ';
                                          Console.WriteLine("The delivery is late. Order is canceled.");
                                          PrintingMatrix(matrix);
                                          return;
                                   }
                                   changing[0] = 0;

                            }
                            else if (cmd == "right")
                            {
                                   colBoy++;
                                   changing[1]++;
                                   if (IsNotLate(matrix))
                                   {
                                          DeliveryMover(ref matrix);
                                   }
                                   else
                                   {
                                          matrix[startRow, startCol] = ' ';
                                          Console.WriteLine("The delivery is late. Order is canceled.");
                                          PrintingMatrix(matrix);
                                          return;
                                   }
                                   changing[1] = 0;
                            }
                            else //left
                            {
                                   colBoy--;
                                   changing[1]--;
                                   if (IsNotLate(matrix))
                                   {
                                          DeliveryMover(ref matrix);
                                   }
                                   else
                                   {
                                          matrix[startRow, startCol] = ' ';
                                          Console.WriteLine("The delivery is late. Order is canceled.");
                                          PrintingMatrix(matrix);
                                          return;
                                   }
                                   changing[1] = 0;
                            }
                     }
              }

              public static bool IsNotLate(char[,] matrix)
              {
                     return matrix.GetLength(0) >= rowBoy + 1 &&
                     matrix.GetLength(1) >= colBoy + 1 &&
                     0 <= rowBoy &&
                     0 <= colBoy;
              }

              public static void DeliveryMover(ref char[,] matrix)
              {
                     if (matrix[rowBoy, colBoy] == '-' || matrix[rowBoy, colBoy] == '.')
                     {
                            matrix[rowBoy, colBoy] = '.';
                     }
                     else if (matrix[rowBoy, colBoy] == '*')
                     {
                            rowBoy -= changing[0];
                            colBoy -= changing[1];
                     }
                     else if (matrix[rowBoy, colBoy] == 'P')
                     {
                            matrix[rowBoy, colBoy] = 'R';
                            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                            IsPizzaCollected = true;
                     }
                     else if (matrix[rowBoy, colBoy] == 'A')
                     {
                            if (IsPizzaCollected)
                            {
                                   matrix[rowBoy, colBoy] = 'P';
                                   Console.WriteLine("Pizza is delivered on time! Next order...");
                                   PrintingMatrix(matrix);
                                   return;
                            }
                     }
              }

              public static void PrintingMatrix(char[,] matrix)
              {
                     for (int i = 0; i < matrix.GetLength(0); i++)
                     {
                            for (int z = 0; z < matrix.GetLength(1); z++)
                            {
                                   Console.Write($"{matrix[i, z]}");
                            }
                            Console.WriteLine();
                     }
              }
       }
}