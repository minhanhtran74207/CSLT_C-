using System.Globalization;
using System.Text;

class Session4
{
    static void Bai1()
    {
        Console.Write("Nhập số a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập số c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b != 0) Console.Write("Phương trình có nghiệm duy nhất x = " + -c / b);
            else
            {
                Console.Write(c == 0 ? "Vô số nghiệm" : "Vô nghiệm");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0) Console.Write("Phương trình có hai nghiệm phân biệt x1 = " + (-b + Math.Sqrt(delta)) / (2 * a) + ", x2 = " + (-b - Math.Sqrt(delta)) / (2 * a));
            else if (delta == 0) Console.Write("Phương trình có nghiệm kép x1 = x2 = " + -b / (2 * a));
            else Console.Write("Vô nghiệm");
        }
        Console.Write("\n");
    }
    static void Bai2_1()
    {
        Console.Write("Nhập số nguyên: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write(((num < 0 ? ~num + 1 : num) & 1) == 0 ? $"Số {num} là số chẵn" : $"Số {num} là số lẻ" + "\n");
    }
    static void Bai2_2()
    {
        Console.Write("Nhập số a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập số c: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Số lớn nhất là: {0}\n", a > b ? (a > c ? a : c) : (b > c ? b : c));
    }
    static void Bai2_3()
    {
        Console.Write("Nhập cạnh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh c: ");
        int c = int.Parse(Console.ReadLine());
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.Clear();
            Console.Write("Giá trị cạnh phải lớn hơn 0\n");
            Bai2_3();
        }
        if (!(a + b > c && a + c > b && b + c > a))
        {
            Console.Write("Đây không là tam giác\n");
            return;
        }

        if (a == b && b == c) Console.Write("Đây là tam giác đều\n");
        else if (a == b || a == c || b == c) Console.Write("Đây là tam giác cân\n");
        else Console.Write("Đây là tam giác thường\n");
    }
    static void Bai2_4()
    {
        Console.Write("Nhập số x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhập số y: ");
        double y = double.Parse(Console.ReadLine());
        if (x > 0 && y > 0) Console.Write("Góc phần tư thứ nhất");
        else if (x > 0 && y < 0) Console.Write("Góc phần tư thứ hai");
        else if (x < 0 && y > 0) Console.Write("Góc phần tư thứ ba");
        else if (x < 0 && y < 0) Console.Write("Góc phần tư thứ tư");
        else Console.Write("Tâm toạ độ");
        Console.Write("\n");
    }
    static void Run(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        //Bai1();

        //Bai2_1();

        //Bai2_2();

        //Bai2_3();

        Bai2_4();
    }
}