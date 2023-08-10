using System.Text;

namespace T01.ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new();
            try
            {
                box = new(length, width, height);
            }
            catch (Exception t)
            {

                Console.WriteLine(t.Message);
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {box.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {box.Volume():f2}");
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}