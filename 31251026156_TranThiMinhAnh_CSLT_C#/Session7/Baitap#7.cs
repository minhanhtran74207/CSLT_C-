
using System;
    class BaiTapChuoi
    {
        static void NhapVaInChuoi()
        {
            Console.WriteLine("Bai 1: Nhap chuoi va in chuoi.");
            Console.WriteLine("Vui long nhap chuoi ban can in ra: ");
            string chuoiNhap = Console.ReadLine();
            Console.WriteLine($"Chuoi vua nhap la: {chuoiNhap}");
        }
        static void DemDoDaiChuoi()
        {
            Console.WriteLine("Bai 2: to find the length of a string without using a library function.");
            Console.WriteLine("Vui long nhap vao chuoi ban can tinh do dai: ");
            string chuoiNhap = Console.ReadLine();
            int length = 0;
            foreach (char c in chuoiNhap)
            {
                length++;
            }
            Console.WriteLine($"Do dai cua chuoi la: {length}");
        }
        static void TachTungKyTu()
        {
            Console.WriteLine("Bai 3: Separate individual character from a string .");
            Console.WriteLine("Vui long nhap vao chuoi ban can tach ky tu: ");
            string chuoiNhap = Console.ReadLine();
            Console.WriteLine("Cac ky tu trong chuoi la: ");
            foreach (char c in chuoiNhap)
            {
                Console.WriteLine(c);
            }
        }
        static void InChuoiNguoc()
        {
            Console.WriteLine("Bai 4: Print individual characters of the string in reverse order.");
            Console.WriteLine("Vui long nhap vao chuoi ban can in ra theo thu tu nguoc lai: ");
            string chuoiNhap = Console.ReadLine();
            Console.WriteLine("Cac ky tu trong chuoi theo thu tu nguoc lai la: ");
            for (int i = chuoiNhap.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(chuoiNhap[i]);
            }
        }
        static void DemSoTu()
        {
            Console.WriteLine("Bai 5: Count the total number of tus in a string.");
            Console.WriteLine("Vui long nhap vao chuoi ban can dem so tu: ");
            string chuoiNhap = Console.ReadLine();
            int soTu = 0;
            string[] tus = chuoiNhap.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string tu in tus)
            {
                if (!string.IsNullOrWhiteSpace(tu))
                {
                    soTu++;
                }
            }
            Console.WriteLine($"So tu trong chuoi la: {soTu}");
        }
        static void SoSanhHaiChuoi()
        {
            Console.WriteLine("Bai 6: Compare two strings without using a string library functions.");
            Console.WriteLine("Vui long nhap vao chuoi thu nhat: ");
            string chuoiThuNhat = Console.ReadLine() ?? "";
            Console.WriteLine("Vui long nhap vao chuoi thu hai: ");
            string chuoiThuHai = Console.ReadLine() ?? "";
            int doDai1 = 0;
            int doDai2 = 0;
            foreach (char c in chuoiThuNhat)
            {
                doDai1++;
            }
            foreach (char c in chuoiThuHai)
            {
                doDai2++;
            }
            if (doDai1 != doDai2)
            {
                Console.WriteLine("Hai chuoi khong bang nhau.");
                return;
            }
            for (int i = 0; i < doDai1; i++)
            {
                if (chuoiThuNhat[i] != chuoiThuHai[i])
                {
                    Console.WriteLine("Hai chuoi khong bang nhau.");
                    if (chuoiThuNhat[i] < chuoiThuHai[i])
                    {
                        Console.WriteLine($"Chuoi thu nhat nho hon chuoi thu hai.");
                    }
                    else
                    {
                        Console.WriteLine($"Chuoi thu nhat lon hon chuoi thu hai.");
                    }
                    return;
                }
            }
            Console.WriteLine("Hai chuoi bang nhau.");
        }
        static void DemChuCaiChuSoKyTuDacBiet()
        {
            Console.WriteLine("Bai 7: Count the number of alphabets, digits, and special characters in a string.");
            Console.WriteLine("Vui long nhap vao chuoi ban can dem: ");
            string chuoiNhap = Console.ReadLine() ?? "";
            int soChuCai = 0;
            int soChuSo = 0;
            int soKyTuDacBiet = 0;
            foreach (char c in chuoiNhap)
            {
                if (char.IsLetter(c))
                {
                    soChuCai++;
                }
                else if (char.IsDigit(c))
                {
                    soChuSo++;
                }
                else
                {
                    soKyTuDacBiet++;
                }
            }
            Console.WriteLine($"So chu cai: {soChuCai}");
            Console.WriteLine($"So chu so: {soChuSo}");
            Console.WriteLine($"So ky tu dac biet: {soKyTuDacBiet}");
        }
        static void DemNguyenAmPhuAm()
        {
            Console.WriteLine("Bai 8: Count the number of vowels or consonants in a string.");
            Console.WriteLine("Vui long nhap vao chuoi ban can dem: ");
            string chuoiNhap = Console.ReadLine() ?? "";
            int soNguyenAm = 0;
            int soPhuAm = 0;
            foreach (char c in chuoiNhap)
            {
                if (char.IsLetter(c))
                {
                    char kyTuThuong = char.ToLower(c);
                    if (kyTuThuong == 'a' || kyTuThuong == 'e' || kyTuThuong == 'i' || kyTuThuong == 'o' || kyTuThuong == 'u')
                    {
                        soNguyenAm++;
                    }
                    else
                    {
                        soPhuAm++;
                    }
                }
            }
            Console.WriteLine($"So nguyen am: {soNguyenAm}");
            Console.WriteLine($"So phu am: {soPhuAm}");
        }
        static void KiemTraChuoiCon()
        {
            Console.WriteLine("Bai 9: Check whether a given substring is present in the given string.");
            Console.WriteLine("Type your main string:");
            string chuoiChinh = Console.ReadLine() ?? "";
            Console.WriteLine("Type your substring:");
            string chuoiCon = Console.ReadLine() ?? "";
            bool coChuoiCon = false;
            if (chuoiCon.Length > 0 && chuoiCon.Length <= chuoiChinh.Length)
            {
                for (int i = 0; i <= chuoiChinh.Length - chuoiCon.Length; i++)
                {
                    bool trungKhop = true;
                    for (int j = 0; j < chuoiCon.Length; j++)
                    {
                        if (chuoiChinh[i + j] != chuoiCon[j])
                        {
                            trungKhop = false;
                            break;
                        }
                    }

                    if (trungKhop)
                    {
                        coChuoiCon = true;
                        break;
                    }
                }
            }

            if (coChuoiCon)
            {
                Console.WriteLine("The substring exists in the string.");
            }
            else
            {
                Console.WriteLine("The substring is not found.");
            }
        }
        static void TimViTriChuoiCon()
        {
            Console.WriteLine("Bai 10: Search for the viTri of a substring within a string.");
            Console.WriteLine("Type your main string:");
            string chuoiChinh = Console.ReadLine() ?? "";
            Console.WriteLine("Type your substring:");
            string chuoiCon = Console.ReadLine() ?? "";
            int viTri = -1;
            if (chuoiCon.Length > 0 && chuoiCon.Length <= chuoiChinh.Length)
            {
                for (int i = 0; i <= chuoiChinh.Length - chuoiCon.Length; i++)
                {
                    bool trungKhop = true;
                    for (int j = 0; j < chuoiCon.Length; j++)
                    {
                        if (chuoiChinh[i + j] != chuoiCon[j])
                        {
                            trungKhop = false;
                            break;
                        }
                    }
                    if (trungKhop)
                    {
                        viTri = i;
                        break;
                    }
                }
            }
            if (viTri != -1)
            {
                Console.WriteLine($"The substring is found at viTri: {viTri}");
            }
            else
            {
                Console.WriteLine("The substring is not found.");
            }
        }
        static void KiemTraKyTuVaChuHoa()
        {
            Console.WriteLine("Bai 11: Check whether a character is an alphabet and not and if so, check for the case.");
            Console.WriteLine("Type your character:");
            char kyTuNhap = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(kyTuNhap))
            {
                if (char.IsUpper(kyTuNhap))
                {
                    Console.WriteLine($"The character '{kyTuNhap}' is an uppercase alphabet.");
                }
                else
                {
                    Console.WriteLine($"The character '{kyTuNhap}' is a lowercase alphabet.");
                }
            }
            else
            {
                Console.WriteLine($"The character '{kyTuNhap}' is not an alphabet.");
            }
        }
        static void DemSoLanXuatHienChuoiCon()
        {
            Console.WriteLine("Bai 12: Find the number of times a substring appears in a given string.");
            Console.WriteLine("Type your main string:");
            string chuoiChinh = Console.ReadLine() ?? "";
            Console.WriteLine("Type your substring:");
            string chuoiCon = Console.ReadLine() ?? "";
            int soLan = 0;
            if (chuoiCon.Length > 0 && chuoiCon.Length <= chuoiChinh.Length)
            {
                for (int i = 0; i <= chuoiChinh.Length - chuoiCon.Length; i++)
                {
                    bool trungKhop = true;
                    for (int j = 0; j < chuoiCon.Length; j++)
                    {
                        if (chuoiChinh[i + j] != chuoiCon[j])
                        {
                            trungKhop = false;
                            break;
                        }
                    }
                    if (trungKhop)
                    {
                        soLan++;
                    }
                }
            }
            Console.WriteLine($"The substring appears {soLan} times in the main string.");
        }
        static void ChenChuoiTruocViTriTimThay()
        {
            Console.WriteLine("Bai 13: Insert a substring before the first occurrence of a string.");
            Console.WriteLine("Type your main string:");
            string chuoiChinh = Console.ReadLine() ?? "";
            Console.WriteLine("Type the substring to insert:");
            string chuoiCanChen = Console.ReadLine() ?? "";
            Console.WriteLine("Type the target substring to find:");
            string chuoiMucTieu = Console.ReadLine() ?? "";
            int viTri = -1;
            if (chuoiMucTieu.Length > 0 && chuoiMucTieu.Length <= chuoiChinh.Length)
            {
                for (int i = 0; i <= chuoiChinh.Length - chuoiMucTieu.Length; i++)
                {
                    bool trungKhop = true;
                    for (int j = 0; j < chuoiMucTieu.Length; j++)
                    {
                        if (chuoiChinh[i + j] != chuoiMucTieu[j])
                        {
                            trungKhop = false;
                            break;
                        }
                    }
                    if (trungKhop)
                    {
                        viTri = i;
                        break;
                    }
                }
            }
            if (viTri != -1)
            {
                string chuoiKetQua = chuoiChinh.Substring(0, viTri) + chuoiCanChen + chuoiChinh.Substring(viTri);
                Console.WriteLine($"The new string after insertion is: {chuoiKetQua}");
            }
            else
            {
                Console.WriteLine("The target substring is not found in the main string.");
            }
        }
        
        public static void Main(string[] args)
        {
            //NhapVaInChuoi();
            //DemDoDaiChuoi();
           // TachTungKyTu();
           // InChuoiNguoc();
           // DemSoTu();
           // SoSanhHaiChuoi();
           // DemChuCaiChuSoKyTuDacBiet();
           // DemNguyenAmPhuAm();
            //KiemTraChuoiCon();
            //TimViTriChuoiCon();
            //KiemTraKyTuVaChuHoa();
            //DemSoLanXuatHienChuoiCon();
            ChenChuoiTruocViTriTimThay();
        }
        
    }

