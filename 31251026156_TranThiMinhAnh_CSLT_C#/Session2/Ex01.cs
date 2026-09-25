using System.Text;
using System.Globalization;

class Program
{
    // Add / Sum Two Numbers.
    static void Cau1()
    {
        int a = 4;
        int b = 7;
        Console.WriteLine($"tong 2 so la: {a + b}");
        Console.ReadKey();
    }

    // Swap Values of Two Variables.
    static void Cau2()
    {
       int x = 5;
       int y = 10;
       int tempt = x;
       x = y; 
       y = tempt;
       Console.WriteLine($"Gia tri cuar x la: {x}");
       Console.WriteLine($"Gia tri cua y la: {y}");
       Console.ReadKey();
    }

        // Multiply two Floating Point Numbers
        static void Cau3()
    {
        float a = 2.6f;
        float b = 7.3f;
        Console.WriteLine($"Tich 2 so la: {a * b}");
        Console.ReadKey();
    }

        // convert feet to meter
        static void Cau4()
    {
        double x;
        double y;
        Console.WriteLine("Moi nhap feet:");
        x = double.Parse(Console.ReadLine());
        y= x * 0.3048;
        Console.WriteLine($"{y}m");
        Console.ReadKey();
    }

        // Celsius to Fahrenheit and vice versa
        static void Cau5()
    {
        double x;
        double y;
        Console.WriteLine("Nhap do C:");
        x = double.Parse(Console.ReadLine());
        y = (x*1.8)+32;
        Console.WriteLine($"Do F la: {y}");
        Console.ReadKey();
    }

        // Print ASCII Value 
        static void Cau6()
    {
        char a;
        int b;
        Console.WriteLine("nhap ky tu:");
        a = char.Parse(Console.ReadLine());
        b = (int)a;
        Console.WriteLine($"Ma ASCII cua ky tu {a} la: {b}");
        Console.ReadKey();
    }
    
        // find the Size of data types
        static void Cau7()
    {
         Console.WriteLine($"kich thuoc cua kieu du lieu la: {sizeof(int)} bytes");
         Console.WriteLine($"kich thuoc cua kieu du kieu la: {sizeof(double)} bytes");
        Console.ReadKey();
    }

        // chu vi hinh tron
        static void Cau8()
    {
        const double PI = 3.14;
        double r;
        double C;
        double S;
        Console.WriteLine("Moi nhap ban kinh hinh tron:");
        r = double.Parse(Console.ReadLine());
        C = 2*PI*r;
        S = PI*r*r;
        Console.WriteLine($"Chu vi hinh tron la: {C}");
        Console.WriteLine($"Dien tich hinh tron la: {S}");
        Console.ReadKey();
    }

        // hinh vuong
        static void Cau9()
    {
        double a;
        double P;
        double S;
        Console.WriteLine("Do dai canh la:");
        a = double.Parse(Console.ReadLine());
        P = 4*a;
        S = a*a;
        Console.WriteLine($"Chu vi hinh vuong la: {P}");
        Console.WriteLine($"Dien tich hinh vuong la: {S}");
        Console.ReadKey();
    }

        //convert days to years, weeks and days
        static void Cau10()
    {
        int days;
        int weeks;
        int years;
        Console.WriteLine("Nhap so ngay:");
        days = int.Parse(Console.ReadLine());
        years = days/365;
        weeks = (days % 365)/7;
        days = ((days%365)%7);
        Console.WriteLine($"{years} nam + {weeks} tuan + {days} ngay ");
        Console.ReadKey();
    }

        static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // Cau1();
        // Cau2();
        // Cau3();
        // Cau4();
        // Cau5();
        // Cau6();
        // Cau7();
        // Cau8();
        // Cau9();
        Cau10();
    }

}