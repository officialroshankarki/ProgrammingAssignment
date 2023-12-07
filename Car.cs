using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

public class Car
{
    private string brand;
    private int year;
    private float price;
    public Car(string brand,float price,int year) { 
     this.brand = brand;
     this.price = price;
     this.year = year;
    }
    public void Car1()
    {
        Console.WriteLine("Hekli");
        Console.WriteLine(brand);
        Console.WriteLine(price);
        Console.WriteLine(year);
    }
}
