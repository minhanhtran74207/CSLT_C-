using System;

using System.Collections.Generic;

using System.IO;

    internal class BaiTapFile

    {

        // 1. Tao file rong

        static void TaoFileRong(string duongDan)

        {

            using (File.Create(duongDan)) { }

            Console.WriteLine("Da tao file rong: " + duongDan);

        }

        // 2. Xoa file

        static void XoaFile(string duongDan)

        {

            if (File.Exists(duongDan))

            {

                File.Delete(duongDan);

                Console.WriteLine("Da xoa file: " + duongDan);

            }

            else

            {

                Console.WriteLine("Khong tim thay file can xoa.");

            }

        }

        // 3. Tao file va ghi noi dung

        static void TaoFileCoNoiDung(string duongDan, string noiDung)

        {

            File.WriteAllText(duongDan, noiDung);

        }

        // 4. Doc noi dung file

        static void DocFile(string duongDan)

        {

            if (File.Exists(duongDan))

                Console.WriteLine(File.ReadAllText(duongDan));

            else

                Console.WriteLine("File khong ton tai.");

        }

        // 5. Ghi mang chuoi vao file

        static void GhiMangVaoFile(string duongDan, string[] cacDong)

        {

            File.WriteAllLines(duongDan, cacDong);

        }

        // 6. Them noi dung vao cuoi file

        static void ThemNoiDung(string duongDan, string noiDung)

        {

            File.AppendAllText(duongDan, noiDung);

        }

        // 7. Sao chep file va hien thi noi dung file moi

        static void SaoChepFile(string fileNguon, string fileDich)

        {

            File.Copy(fileNguon, fileDich, true);

            Console.WriteLine("Noi dung file sau khi sao chep:");

            DocFile(fileDich);

        }

        // 8. Di chuyen hoac doi ten file

        static void DiChuyenFile(string fileNguon, string fileDich)

        {

            if (File.Exists(fileDich))

                File.Delete(fileDich);

            File.Move(fileNguon, fileDich);

            Console.WriteLine("Da di chuyen file den: " + fileDich);

        }

        // 9. Doc dong dau tien

        static string DocDongDau(string duongDan)

        {

            if (!File.Exists(duongDan))

                return "";

            using (StreamReader doc = new StreamReader(duongDan))

                return doc.ReadLine() ?? "";

        }

        // 10. Doc dong cuoi cung

        static string DocDongCuoi(string duongDan)

        {

            if (!File.Exists(duongDan))

                return "";

            string[] cacDong = File.ReadAllLines(duongDan);

            return cacDong.Length > 0 ? cacDong[cacDong.Length - 1] : "";

        }

        // 11. Doc n dong cuoi cung

        static string[] DocNDongCuoi(string duongDan, int n)

        {

            if (!File.Exists(duongDan) || n <= 0)

                return Array.Empty<string>();

            string[] cacDong = File.ReadAllLines(duongDan);

            int viTriBatDau = Math.Max(0, cacDong.Length - n);

            int soDong = cacDong.Length - viTriBatDau;

            string[] ketQua = new string[soDong];

            Array.Copy(cacDong, viTriBatDau, ketQua, 0, soDong);

            return ketQua;

        }

        // 12. Doc mot dong theo so thu tu (bat dau tu 1)

        static string DocDongTheoSo(string duongDan, int soDong)

        {

            if (!File.Exists(duongDan))

                return "";

            string[] cacDong = File.ReadAllLines(duongDan);

            if (soDong < 1 || soDong > cacDong.Length)

                return "";

            return cacDong[soDong - 1];

        }

        // 13. Dem so dong trong file

        static int DemSoDong(string duongDan)

        {

            if (!File.Exists(duongDan))

                return 0;

            return File.ReadAllLines(duongDan).Length;

        }

        // 14. In cau truc thu muc (gom ca file va thu muc con)

        static void InCauTrucThuMuc(string duongDan)

        {

            if (!Directory.Exists(duongDan))

            {

                Console.WriteLine("Thu muc khong ton tai.");

                return;

            }

            foreach (string muc in Directory.GetFileSystemEntries(duongDan))

                Console.WriteLine(muc);

        }

        // 15. Thong ke ky tu, chu cai, chu so va ky tu khac

        static void ThongKeKyTu(string duongDan)

        {

            if (!File.Exists(duongDan))

            {

                Console.WriteLine("File khong ton tai.");

                return;

            }

            string noiDung = File.ReadAllText(duongDan);

            Dictionary<char, int> thongKe = new Dictionary<char, int>();

            int soChuCai = 0;

            int soChuSo = 0;

            int kyTuKhac = 0;

            foreach (char kyTu in noiDung)

            {

                if (thongKe.ContainsKey(kyTu))

                    thongKe[kyTu]++;

                else

                    thongKe[kyTu] = 1;

                if (char.IsLetter(kyTu))

                    soChuCai++;

                else if (char.IsDigit(kyTu))

                    soChuSo++;

                else

                    kyTuKhac++;

            }

            Console.WriteLine("Thong ke tung ky tu:");

            foreach (KeyValuePair<char, int> muc in thongKe)

                Console.WriteLine("'" + muc.Key + "': " + muc.Value);

            Console.WriteLine("Tong so chu cai: " + soChuCai);

            Console.WriteLine("Tong so chu so: " + soChuSo);

            Console.WriteLine("Tong ky tu khac (khoang trang, dau cau...): " + kyTuKhac);

        }

        static void Main(string[] args)

        {

            string fileChinh = "example.txt";

            string fileSaoChep = "copy_example.txt";

            string fileDiChuyen = "moved_example.txt";

            TaoFileRong("file_rong.txt");

            XoaFile("file_can_xoa.txt");

            TaoFileCoNoiDung(fileChinh, "Dong 1: Hello World!\\nDong 2: C# 2026\\nDong 3: Bai tap Buoi 8");

            Console.WriteLine("\\n--- 4. DOC FILE ---");

            DocFile(fileChinh);

            GhiMangVaoFile(fileChinh, new string[]

            {

                "Dong 1: Hello World!",

                "Dong 2: C# 2026",

                "Dong 3: Bai tap Buoi 8"

            });

            ThemNoiDung(fileChinh, Environment.NewLine + "Dong 4: Noi dung duoc them");

            Console.WriteLine("\\n--- 7. SAO CHEP FILE ---");

            SaoChepFile(fileChinh, fileSaoChep);

            DiChuyenFile(fileSaoChep, fileDiChuyen);

            Console.WriteLine("\\nDong dau: " + DocDongDau(fileChinh));

            Console.WriteLine("Dong cuoi: " + DocDongCuoi(fileChinh));

            Console.WriteLine("Hai dong cuoi:");

            foreach (string dong in DocNDongCuoi(fileChinh, 2))

                Console.WriteLine(dong);

            Console.WriteLine("Dong thu 2: " + DocDongTheoSo(fileChinh, 2));

            Console.WriteLine("Tong so dong: " + DemSoDong(fileChinh));

            Console.WriteLine("\\n--- 14. CAU TRUC THU MUC ---");

            InCauTrucThuMuc(".");

            Console.WriteLine("\\n--- 15. THONG KE KY TU ---");

            ThongKeKyTu(fileChinh);

        }

    }
