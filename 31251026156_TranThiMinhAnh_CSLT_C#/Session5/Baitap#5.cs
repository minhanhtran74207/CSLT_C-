using System;

class Exercises
{
    //Bài 1
    public static int TinhTong (int a, int b)
    {
        return a+b;
    }
    //Bài 2
    public static bool ChanLe(int n)
    {
        return n % 2 == 0;
    }
    //Bài 3
    public static int TimSoLonNhat(int a1, int b1, int c1)
    {
        return Math.Max(a1, Math.Max(b1, c1));
    }
    //Bài 4
    public static long GiaiThua(int n)
    {
        if (n < 0) throw new ArgumentException("Số truyền vào phải là số nguyên dương");
        long result = 1;
        for(int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    //bài 5
    public static string DaoNguocChuoi(string input)
    {
    if (string.IsNullOrEmpty(input)) return input;

    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray); 
    return new string(charArray);
    }
    //Bài 6
    public static bool SoNguyenTo(int n1)
    {
        if(n1<=1) return false;
        for(int i =2; i< n1/2; i++)
        {
            if(n1 % i == 0) return false;
        }
        return true;
    }
    //Bài 7
    public static void Fibonacci(int n2)
    {
        if(n2 < 0)
        {
            Console.WriteLine("Số truyền vào phải là số nguyên dương");
            return;
        } 
        if(n2 == 0)
        {
            Console.WriteLine("0"); 
            return;
        }
        if(n2 == 1)
        {
            Console.WriteLine("0"); 
            return;
        }
        long a = 0;
        long b = 1;
        long fibo = 0;
        Console.Write("0, 1, ");
        for(int i = 2; i < n2; i++)
        {
            fibo = a + b;
            a = b;
            b = fibo;
            Console.Write($"{fibo} , ");
        }
    }
    //Bài 8
    public static int DemNguyenAm(string s)
    {
        if(string.IsNullOrEmpty(s)) return 0;
        string s1 = s.ToLower();
        char [] mangKyTu = s1.ToCharArray();
        int dem = 0;
        foreach(char vowel in mangKyTu)
        {
            if(vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
            {
                dem++;
            }
        }
        return dem;
    }
    //Bài 9
    public static double TinhLuyThua(double x, int y)
    {
        if(y==0) return 1;
        double result = 1;
        for(int i = 1; i <= y; i++)
        {
            result *= x;
        }
        return result;
    }
    //Bài 10
    public static double TinhTrungBinh(int [] arr)
    {
        double sum = 0;
        foreach(double val in arr)
        {
            sum+=val;
        }
        return sum / arr.Length;
    }
    //Bài 11
    public static bool KiemTraDoiXung(string s)
    {
        if(string.IsNullOrEmpty(s)) return false;
        string s1 = s.ToLower();
        char [] chuoiNguoc = s1.ToCharArray();
        Array.Reverse(chuoiNguoc);
        string s2 = new string(chuoiNguoc);
    if (s2 == s1)
        {
            return true;
        }
        return false;
    }
    //Bài 12
    public static double CeliusToFahrenheit(double c)
    {
        return (c*1.8) + 32;
    }
    //Bài 13
    public static int TimMin(int [] arr)
    {
        int min = arr[0];
        foreach(int val in arr)
        {
           if(val < min)
            {
                min = val;
            } 
        }
        return min;;
    }
    //Bài 14
    public static int TongCacChuSo(int n3)
    {
        int soDuong = Math.Abs(n3); 
        int sum = 0;
        while (soDuong > 0)
        {
            sum += soDuong % 10; 
            soDuong /= 10;      
        }
    
    return sum;
    }

    //Bài 15
    public static void SapXepMang(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = 0; j < arr.Length - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(", ", arr));
    }
    //Bài 16
    public static string XoaTrungLap(string s)
    {
        if(string.IsNullOrEmpty(s)) return s;
        string ketQua = "";
        foreach(char c in s)
        {
            if (!ketQua.Contains(c))
            {
               ketQua+=c; 
            }
        }
        return ketQua;
    }
    //Bài 17
    public static int UCLN(int a2, int b2)
    {
        int c = Math.Max(a2,b2);
        int d = Math.Min(a2,b2);
        int r;
        do{
            r = c % d;
            c = d;
            d = r;
        }
        while(r != 0);
        return c;
    }
    //Bài 18
    public static string DecimalToBinary(int n4)
    {
        if(n4 == 0) return "0";
        string ketQua = "";
        while(n4 > 0)
        {
            int r = n4 % 2;
            ketQua = r + ketQua;
            n4 = n4 / 2;
        }
        return ketQua;
    }
    //Bài 19
    public static bool KiemTraNamNhuan(int year)
    {
        if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }
        return false;
    }
    //Bài 20
    public static int DemSoTu(string sentence)
    {
        if(string.IsNullOrEmpty(sentence)) return 0;
        string [] demTu = sentence.Split(' ');
        return demTu.Length;
    }

    public static void Main(String[] args)
    {
        // Console.WriteLine("\n---Bài 1---");
        // Console.Write("Nhập vào số nguyên a: ");
        // int a = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập vào số nguyên b: ");
        // int b = int.Parse(Console.ReadLine() ?? "0");
        // int tong = TinhTong(a,b);
        // Console.WriteLine($"Tổng của {a} và {b} là: {tong}");
        // Console.WriteLine("\n---Bài 2---");
        // Console.Write("Nhập vào số nguyên n: ");
        // int n = int.Parse(Console.ReadLine() ?? "0");
        // if (ChanLe(n))
        // {
        //     Console.WriteLine($"{n} là số chẵn");
        // }
        // else
        // {
        //     Console.WriteLine($"{n} là số lẻ");
        // }

        // Console.WriteLine("\n---Bài 3---");
        // Console.Write("Nhập số nguyên a: ");
        // int a1 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập số nguyên b: ");
        // int b1 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập số nguyên c: ");
        // int c1 = int.Parse(Console.ReadLine() ?? "0");
        // int max = TimSoLonNhat(a1, b1, c1);
        // Console.WriteLine($"Số lớn nhất trong 3 số {a1}, {b1}, {c1} là: {max}");

        // Console.WriteLine("\n---Bài 4---");
        // Console.Write("Nhập một số nguyên dương n: ");
        // int n = int.Parse(Console.ReadLine() ?? "0");
        // long tinhGiaiThua = GiaiThua(n);
        // Console.WriteLine($"Giai thừa của {n} là: {tinhGiaiThua}");

        // Console.WriteLine("\n---Bài 5---");
        // Console.Write("Nhập một chuỗi: ");
        // string input = Console.ReadLine() ?? "0";
        // Console.WriteLine($"Chuỗi sau khi đảo ngược là:{DaoNguocChuoi(input)} ");

        // Console.WriteLine("\n---Bài 6---");
        // Console.Write("Nhập một số nguyên dương n: ");  
        // int n1 = int.Parse(Console.ReadLine() ?? "0");
        // if (SoNguyenTo(n1))
        // {
        //     Console.WriteLine($"{n1} là số nguyên tố");
        // }
        // else
        // {
        //     Console.WriteLine($"{n1} không phải là số nguyên tố");
        // }

        // Console.WriteLine("\n---Bài 7---");
        // Console.Write("Nhập một số nguyên dương n: ");
        // int n2 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write($"{n2} số fibonacci đầu tiên là: ");
        // Fibonacci(n2);

        // Console.WriteLine("\n---Bài 8---");
        // Console.Write("Nhập một chuỗi vào để kiểm tra: ");
        // string s = Console.ReadLine() ?? "0";
        // int demNguyenAm = DemNguyenAm(s);
        // Console.WriteLine($"Số nguyên âm trong chuỗi \"{s}\" là: {demNguyenAm}");

        // Console.WriteLine("\n---Bài 9---");
        // Console.Write("Nhập vào cơ số x: ");
        // double x = double.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập vào số mũ y: ");
        // int y = int.Parse(Console.ReadLine() ?? "0");
        // double luyThua = TinhLuyThua(x,y);
        // Console.WriteLine($"{x} ^ {y} = {luyThua}");

        // Console.WriteLine("---Bài 10---");
        // Console.Write("Nhập số lượng phần tử của mảng: ");
        // int soLuong = int.Parse(Console.ReadLine() ?? "0");
        // int [] mang = new int[soLuong];
        // for(int i = 0; i < soLuong; i++)
        // {
        //     Console.Write($"arr[{i}]: ");
        //     mang[i] = int.Parse(Console.ReadLine());
        // }
        // double trungBinh = TinhTrungBinh(mang);
        // Console.WriteLine($"Trung bình của mảng là: {trungBinh}");

        // Console.WriteLine("---Bài 11---");
        // Console.Write("Nhập vào một chuỗi để kiểm tra: ");
        // string s = Console.ReadLine() ?? "0";
        // if (KiemTraDoiXung(s))
        // {
        //     Console.WriteLine($"Chuỗi \"{s}\" đọc xuôi ngược giống nhau");
        // }
        // else
        // {
        //     Console.WriteLine($"Chuỗi \"{s}\" đọc xuôi ngược không giống nhau");
        // }

        // Console.WriteLine("---Bài 12---");
        // Console.Write("Nhập vào số độ C: ");
        // double c = double.Parse(Console.ReadLine() ?? "0");
        // double f = CeliusToFahrenheit(c);
        // Console.WriteLine($"{c} độ C = {f} độ F");

        // Console.WriteLine("---Bài 13---");
        // Console.Write("Nhập số phần tử của mảng: ");
        // int phanTu = int.Parse(Console.ReadLine() ?? "0");

        // int [] mang1 = new int[phanTu];
        // for(int i = 0; i < phanTu; i++)
        // {
        //     Console.Write($"arr[{i}] = ");
        //     mang1[i] = int.Parse(Console.ReadLine() ?? "0");
        // }
        // int min = TimMin(mang1);
        // Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");

        // Console.WriteLine("---Bài 14---");
        // Console.Write("Nhập và một số n: ");
        // int n3 = int.Parse(Console.ReadLine() ?? "0");

        // int tong = TongCacChuSo(n3);
        // Console.WriteLine($"Tổng từng chữ số tạo nên n là: {tong} ");

        // Console.WriteLine("---Bài 15---");
        // Console.Write("Nhập số phần tử của mảng: ");
        // int soLuongMangSapXep = int.Parse(Console.ReadLine() ?? "0");

        // int [] mangSapXep = new int[soLuongMangSapXep];
        // for(int i = 0; i < soLuongMangSapXep; i++)
        // {
        //     Console.Write($"arr[{i}] = ");
        //     mangSapXep[i] = int.Parse(Console.ReadLine() ?? "0");
        // }
        // Console.Write("Mảng sau khi sắp xếp là: ");
        // SapXepMang(mangSapXep);

        // Console.WriteLine("---Bài 16---");
        // Console.Write("Nhập vào một chuỗi: ");
        // string s = Console.ReadLine();

        // string xoaTrungLap = XoaTrungLap(s);
        // Console.WriteLine($"Chuỗi \"{s}\" sau khi xoá ký tự trùng lặp: {xoaTrungLap}");

        // Console.WriteLine("---Bài 17---");
        // Console.Write("Nhập vào số a: ");
        // int a2 = int.Parse(Console.ReadLine() ?? "0");
        // Console.Write("Nhập vào số b: ");
        // int b2 = int.Parse(Console.ReadLine() ?? "0");
        // int uocChungLonNhat = UCLN(a2,b2);
        // Console.WriteLine($"Ước chung lớn nhất của {a2} và {b2} là: {uocChungLonNhat}");

        // Console.WriteLine("---Bài 18---");
        // Console.Write("Nhập vào số thập phân hệ 10: ");
        // int n4 = int.Parse(Console.ReadLine() ?? "0");

        // string nhiPhan = DecimalToBinary(n4);
        // Console.WriteLine($"Số {n4} đổi sang hệ nhị phân là: {nhiPhan}");

        // Console.WriteLine("---Bài 19---");
        // Console.Write("Nhập vào số năm muốn kiểm tra: ");
        // int year = int.Parse(Console.ReadLine() ?? "0");

        // if (KiemTraNamNhuan(year))
        // {
        //     Console.WriteLine($"Năm {year} là năm nhuận");
        // }
        // else
        // {
        //     Console.WriteLine($"Năm {year} không phải là năm nhuận");
        // }

        Console.WriteLine("---Bài 20---");
        Console.Write("Nhập vào một chuỗi: ");
        string sentence = Console.ReadLine() ?? "0";

        int soTuCuaCau = DemSoTu(sentence);
        Console.WriteLine($"Câu trên có tổng cộng: {soTuCuaCau} từ");
    }
}
