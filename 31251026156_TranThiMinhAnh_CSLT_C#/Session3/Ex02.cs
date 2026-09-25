using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

class Session3
{
    static void Bai1()
    {
        Console.WriteLine("Tinh tien dien sinh hoat gia dinh theo bac thang");
        Console.WriteLine("--- INPUT ---");
        Console.Write("Nhap chi so dien cu (kWh): ");
        int chiSoCu = int.Parse(Console.ReadLine());
        Console.Write("Nhap chi so dien moi (kWh): ");
        int chiSoMoi = int.Parse(Console.ReadLine());
        if (chiSoCu > chiSoMoi || chiSoCu < 0 || chiSoMoi < 0)
        {
            Console.Clear();
            Console.WriteLine("Chi so khong hop le, vui long nhap lai!");
            Bai1();
            return;
        }
        
        Console.WriteLine("--- OUTPUT ---");
        int soDien = chiSoMoi - chiSoCu;
        decimal tienDien = 0;
        if (soDien >= 0 && soDien < 51) tienDien = 1806m;
        else if (soDien < 101) tienDien = 1866m;
        else if (soDien < 201) tienDien = 2167m;
        else if (soDien < 301) tienDien = 2729m;
        else tienDien = 3050m;
        Console.WriteLine($"So dien tieu thu: {soDien} kWh");
        decimal tienDienChuaThue = tienDien * soDien;
        Console.WriteLine($"Tien dien chua thue: {tienDienChuaThue :N0} VND");
        decimal VAT = tienDienChuaThue * 0.08m;
        Console.WriteLine($"Thue VAT (8%): {VAT :N0} VND");
        decimal tongTienDien = tienDienChuaThue + VAT;
        Console.WriteLine($"Tong thanh toan: {tongTienDien :N0} VND");
    }

    static void Bai2()
    {
        Console.WriteLine("Tinh chi so suc khoe BMI");
        Console.WriteLine("--- INPUT ---");
        Console.Write("Chieu cao (m): ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Can nang (kg): ");
        double weight = double.Parse(Console.ReadLine());
        
        Console.WriteLine("--- OUTPUT ---");
        double BMI = weight / (height * height);
        Console.WriteLine($"Chi so suc khoe cua ban: {Math.Round(BMI, 2)}");
        string ketQuaChiSo = "";
        if (BMI >= 0 && BMI < 18.5) ketQuaChiSo = "Gay";
        else if (BMI < 23.0) ketQuaChiSo = "Binh thuong";
        else if (BMI < 25.0) ketQuaChiSo = "Thua can";
        else ketQuaChiSo = "Beo phi";
        Console.WriteLine($"Phan loai suc khoe: {ketQuaChiSo}");
        Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {Math.Round(18.5 * height * height, 2)} kg den {Math.Round(22.9 * height * height, 2)} kg");
    }

    static void Bai3()
    {
        Console.WriteLine("Ung dung quy doi tien te ngoai te da ty gia ngan hang");
        Console.WriteLine("--- INPUT ---");
        Console.Write("Nhap so tien VND: ");
        decimal VND = decimal.Parse(Console.ReadLine());
        Console.Write("Chon ngoai te: (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
        int type = int.Parse(Console.ReadLine());
        
        Console.WriteLine("--- OUTPUT ---");
        string typename = "";
        decimal exchangeRate = 0;
        switch(type)
        {
            case 1:
                typename = "USD";
                exchangeRate = 26105m;
                break;
            case 2:
                typename = "EUR";
                exchangeRate = 30601m;
                break;
            case 3:
                typename = "JPY";
                exchangeRate = 163.92m;
                break;
            default:
                typename = "GBP";
                exchangeRate = 35705m;
                break;
        }
        Console.WriteLine($"Phi dich vu (0.5%): {VND * 0.005m :N0} VND");
        Console.WriteLine($"So tien VND tinh doi: {VND * 0.995m :N0}");
        Console.WriteLine($"So tien {typename} nhan duoc: {Math.Round(VND * 0.995m / exchangeRate, 2)} {typename}");
    }

    static void Bai4()
    {
        Console.WriteLine("Tinh tuoi chinh xac va dem nguoc ngay sinh nhat");
        Console.WriteLine("--- INPUT ---");
        Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("--- OUTPUT ---");
        DateTime present = DateTime.Now.Date;
        int age = present.Year - birthDate.Year;
        if (present < birthDate.AddYears(age)) --age;
        Console.WriteLine($"Tuoi hien tai: {age} tuoi");
        Console.WriteLine($"Ban da song tong cong: {(present - birthDate).Days} ngay");
        DateTime nextBirthday = new DateTime(
            present.Year,
            birthDate.Month,
            birthDate.Day
        );
        if (nextBirthday < present) nextBirthday = nextBirthday.AddYears(1);
        Console.WriteLine($"Sinh nhat tiep theo con: {(nextBirthday - present).Days} ngay nua");
    }

    static void Bai5()
    {
        Console.WriteLine("Quan ly diem hoc phan va quy doi thang diem GPA 4.0");
        Console.WriteLine("--- INPUT ---");
        Console.Write("So TC Lap trinh C#: ");
        int tc1 = int.Parse(Console.ReadLine());
        Console.Write("So TC Toan roi rac: ");
        int tc2 = int.Parse(Console.ReadLine());
        Console.Write("So TC Tieng Anh: ");
        int tc3 = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("--- INPUT ---");
        Console.Write($"Lap trinh C# ({tc1} TC): ");
        double diem1 = double.Parse(Console.ReadLine());
        Console.Write($"Toan roi rac ({tc2} TC): ");
        double diem2 = double.Parse(Console.ReadLine());
        Console.Write($"Tieng Anh ({tc3} TC): ");
        double diem3 = double.Parse(Console.ReadLine());

        Console.WriteLine("--- OUTPUT ---");
        double tb = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3) / (tc1 + tc2 + tc3);
        double dtbLamTron = Math.Round(tb, 2);
        Console.WriteLine($"Diem trung binh thang 10: {dtbLamTron}");
        string[] chuSo = {"khong", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin", "muoi", "phay"};
        int donVi = (int)dtbLamTron, tp1 = (int)(dtbLamTron * 10) % 10, tp2 = (int)(dtbLamTron * 100) % 10;
        Console.WriteLine($"Diem chu quy doi: {chuSo[donVi]} {chuSo[11]} {chuSo[tp1]} {chuSo[tp2]}");
        double gpa = 0;
        string hocLuc = "";
        if (tb >= 0 && tb < 4.0)
        {
            gpa = 0.0;
            hocLuc = "Kem (Truot)";
        }
        else if (tb < 5.5)
        {
            gpa = 1.0;
            hocLuc = "Yeu";
        }
        else if (tb < 6.9)
        {
            gpa = 2.0;
            hocLuc = "Trung binh";
        }
        else if (tb < 8.4)
        {
            gpa = 3.0;
            hocLuc = "Kha";
        }
        else if (tb < 10.1)
        {
            gpa = 4.0;
            hocLuc = "Xuat sac/Gioi";
        }
        Console.WriteLine($"Diem GPA thang 4: {Math.Round(gpa, 1)}");
        Console.WriteLine($"Xep loai hoc luc: {hocLuc}");
    }

    static void Bai6()
{
    Console.WriteLine("Bai 6: Xu ly du lieu ho ten nhap vao tu ban phim");
    Console.Write("Xin moi nhap ho ten cua ban:");
    string hotentho = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(hotentho))
    {
        Console.WriteLine("Ho ten khong duoc de trong! Vui long nhap lai:");
        hotentho = Console.ReadLine();
    }

    string[] words = hotentho.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = words[i].ToLower();
        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
    }

    string hotenChuanHoa = string.Join(" ", words);
    string ho = words[0];
    string ten = words[words.Length - 1];
    string tendem = "";

    if (words.Length > 2)
    {
        tendem = string.Join(" ", words, 1, words.Length - 2);
    }

    string boDau(string text)
    {
        string normalized = text.Normalize(NormalizationForm.FormD);
        Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        string strWithoutDiacritics = regex.Replace(normalized, string.Empty);
        return strWithoutDiacritics.Replace("đ", "d").Replace("Đ", "D");
    }

    string[] wordNosign = new string[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
        wordNosign[i] = boDau(words[i].ToLower());
    }

    string username = "";
    if (wordNosign.Length == 1)
    {
        username = wordNosign[0];
    }
    else
    {
        string tenKhongDau = wordNosign[words.Length - 1];
        string hoVaTenDemKhongDau = "";
        for (int i = 0; i < words.Length - 1; i++)
        {
            hoVaTenDemKhongDau += wordNosign[i];
        }
        username = tenKhongDau + "." + hoVaTenDemKhongDau;
    }

    string email = username + "@company.edu.vn";
    Console.WriteLine($"Ho ten chuan hoa: {hotenChuanHoa}");
    Console.WriteLine($"Ho: {ho} | Ten dem: {tendem} | Ten: {ten}");
    Console.WriteLine($"Username: {username}");
    Console.WriteLine($"Email: {email}");
    Console.WriteLine("Nhan Enter de tiep tuc");
    Console.ReadLine();
}

 static void Bai7()
        {
            Console.WriteLine(" lap ke hoach chi phi nhien lieu va chia se chuyen di");
            Console.Write("Nhap quang duong chuyen di (km): ");
            double quangduong = double.Parse(Console.ReadLine());
            Console.Write("Nhap muc tieu hao nhien lieu (lit/100km): ");
            double muctieuthu = double.Parse(Console.ReadLine());
            Console.Write("Nhap gia xang (VND/lit): ");
            decimal giaxang = decimal .Parse(Console.ReadLine());
            Console.Write("Nhap so nguoi di: ");
            int songuoi = int.Parse(Console.ReadLine());
            double tongsolitxang = (quangduong / 100f) * muctieuthu;
            decimal tongchiphitienxang = (decimal)tongsolitxang * giaxang;
            decimal tienmoinguoi = tongchiphitienxang / songuoi;
            Console.WriteLine($"Tong nhien lieu phai tra: {tongsolitxang:F2}");
            Console.WriteLine($"TTong chi phi xang dau: {tongchiphitienxang:#,##0} VND ");
            Console.WriteLine($"TTong chi phi moi nguoi: {Math.Ceiling(tienmoinguoi):#,##0} VND");
        }
    

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        //Bai1();
        // Bai2();
        // Bai3();
        // Bai4();
        // Bai5();
        // Bai6();
        Bai7();
    }
}