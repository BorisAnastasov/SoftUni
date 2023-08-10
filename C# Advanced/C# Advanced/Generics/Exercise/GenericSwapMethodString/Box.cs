﻿using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString;

public class Box<T>
{
    private List<T> items;

    public Box()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        T temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        foreach (var item in items)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }

        return sb.ToString().TrimEnd();
    }
}