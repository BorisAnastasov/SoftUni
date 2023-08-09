using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<Box> list = new List<Box>();
            while(text != "end")
            {
                string[] arr = text.Split(" ");
                string serialnumber = arr[0];
                string name = arr[1];
                int quantity = int.Parse(arr[2]);
                double price = double.Parse(arr[3]);
                Item item = new Item(name, price);
                Box box = new Box(serialnumber,item,quantity);
                list.Add(box);
                text = Console.ReadLine();
            }
            foreach (Box box in list.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${(box.Item.Price):f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${(box.PriceForBox):f2}");
            }
        }
        public class Item 
        {
            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }
            public string Name { get; set; }
            public double Price { get; set; }
        }
        public class Box 
        {
            public Box(string serialNumber, Item item, int itemQuantity)
            {
                Item = item;
                SerialNumber = serialNumber;
                ItemQuantity = itemQuantity;
                PriceForBox = ItemQuantity * Item.Price;
                
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }   
            public double PriceForBox { get; set; }

        }
    }
}
