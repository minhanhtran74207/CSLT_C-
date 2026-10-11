
using System;
using System.IO;

class BaiTap9
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\nCHỌN BÀI TẬP (1 - 15)");
            Console.WriteLine("1. Tạo file rỗng                        9. Đọc dòng đầu tiên");
            Console.WriteLine("2. Xóa file                             10. Đọc dòng cuối cùng");
            Console.WriteLine("3. Tạo file và ghi văn bản              11. Đọc n dòng cuối cùng");
            Console.WriteLine("4. Tạo và đọc file                      12. Đọc một dòng cụ thể");
            Console.WriteLine("5. Ghi mảng chuỗi vào file              13. Đếm tổng số dòng");
            Console.WriteLine("6. Nối văn bản vào file                 14. In cấu trúc thư mục");
            Console.WriteLine("7. Sao chép file và hiển thị nội dung   15. Thống kê ký tự và vị trí");
            Console.WriteLine("8. Đổi tên hoặc di chuyển file           0. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");

            string choice = Console.ReadLine();
            Console.WriteLine("\n--------------");

            switch (choice)
            {
                case "1": Ex01_CreateBlankFile(); break;
                case "2": Ex02_DeleteFile(); break;
                case "3": Ex03_CreateAndAddText(); break;
                case "4": Ex04_CreateAndReadFile(); break;
                case "5": Ex05_WriteArrayOfStrings(); break;
                case "6": Ex06_AppendText(); break;
                case "7": Ex07_CopyAndDisplay(); break;
                case "8": Ex08_MoveOrRenameFile(); break;
                case "9": Ex09_ReadFirstLine(); break;
                case "10": Ex10_ReadLastLine(); break;
                case "11": Ex11_ReadLastNLines(); break;
                case "12": Ex12_ReadSpecificLine(); break;
                case "13": Ex13_CountLines(); break;
                case "14": Ex14_PrintDirectoryStructure(@".\"); break;
                case "15": Ex15_StatisticsAndPositions(); break;
                case "0": return;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        }
    }

    // Bài 1: Tạo file rỗng
    static void Ex01_CreateBlankFile()
    {
        File.Create("blank.txt").Close();
        Console.WriteLine("Đã tạo file rỗng 'blank.txt' thành công.");
    }

    // Bài 2: Xóa file khỏi ổ đĩa
    static void Ex02_DeleteFile()
    {
        if (File.Exists("blank.txt"))
        {
            File.Delete("blank.txt");
            Console.WriteLine("Đã xóa file 'blank.txt'.");
        }
        else Console.WriteLine("File 'blank.txt' không tồn tại.");
    }

    // Bài 3: Tạo file và ghi văn bản
    static void Ex03_CreateAndAddText()
    {
        File.WriteAllText("test.txt", "Xin chào! Đây là bài tập C# File I/O.");
        Console.WriteLine("Đã ghi nội dung vào file 'test.txt'.");
    }

    // Bài 4: Tạo file văn bản và đọc nội dung
    static void Ex04_CreateAndReadFile()
    {
        string content = "Dòng 1: UEH" + Environment.NewLine + "Dòng 2: Khoa học dữ liệu";
        File.WriteAllText("read_test.txt", content);
        Console.WriteLine("Nội dung file 'read_test.txt':\n" + File.ReadAllText("read_test.txt"));
    }

    // Bài 5: Ghi mảng chuỗi vào file
    static void Ex05_WriteArrayOfStrings()
    {
        string[] names = new string[] { "Nguyễn Văn A", "Trần Thị B", "Lê Văn C" };
        File.WriteAllLines("array_test.txt", names);
        Console.WriteLine("Đã ghi mảng tên vào file 'array_test.txt'.");
    }

    // Bài 6: Nối văn bản vào file đã có
    static void Ex06_AppendText()
    {
        File.WriteAllText("append_test.txt", "Dòng ban đầu." + Environment.NewLine);
        File.AppendAllText("append_test.txt", "Dòng được nối thêm." + Environment.NewLine);
        Console.WriteLine("Nội dung sau khi nối:\n" + File.ReadAllText("append_test.txt"));
    }

    // Bài 7: Sao chép file và hiển thị nội dung
    static void Ex07_CopyAndDisplay()
    {
        File.WriteAllText("original.txt", "Nội dung của file gốc.");
        File.Copy("original.txt", "copied.txt", true);
        Console.WriteLine("Nội dung file sau khi sao chép ('copied.txt'):\n" + File.ReadAllText("copied.txt"));
    }

    // Bài 8: Di chuyển hoặc đổi tên file
    static void Ex08_MoveOrRenameFile()
    {
        File.WriteAllText("old_name.txt", "Nội dung file cần đổi tên.");
        if (File.Exists("renamed_file.txt")) File.Delete("renamed_file.txt");
        File.Move("old_name.txt", "renamed_file.txt");
        Console.WriteLine("Đã đổi tên 'old_name.txt' thành 'renamed_file.txt'.");
    }

    // Bài 9: Đọc dòng đầu tiên của file
    static void Ex09_ReadFirstLine()
    {
        string[] lines = new string[] { "Dòng 1: Đầu tiên", "Dòng 2: Thứ hai", "Dòng 3: Thứ ba" };
        File.WriteAllLines("multi.txt", lines);

        if (File.Exists("multi.txt"))
        {
            using (StreamReader sr = new StreamReader("multi.txt"))
            {
                string firstLine = sr.ReadLine();
                Console.WriteLine("Dòng đầu tiên: " + firstLine);
            }
        }
    }

    // Bài 10: Đọc dòng cuối cùng của file
    static void Ex10_ReadLastLine()
    {
        string[] lines = File.ReadAllLines("multi.txt");
        if (lines.Length > 0)
        {
            Console.WriteLine("Dòng cuối cùng: " + lines[lines.Length - 1]);
        }
    }

    // Bài 11: Đọc n dòng cuối cùng của file
    static void Ex11_ReadLastNLines()
    {
        Console.Write("Nhập n (số dòng cuối muốn đọc): ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            string[] lines = File.ReadAllLines("multi.txt");
            int startIndex = lines.Length - n;
            if (startIndex < 0) startIndex = 0;

            Console.WriteLine($"--- {lines.Length - startIndex} dòng cuối ---");
            for (int i = startIndex; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }

    // Bài 12: Đọc một dòng cụ thể từ file
    static void Ex12_ReadSpecificLine()
    {
        Console.Write("Nhập số thứ tự dòng cần đọc (ví dụ: 2): ");
        if (int.TryParse(Console.ReadLine(), out int k))
        {
            string[] lines = File.ReadAllLines("multi.txt");
            if (k > 0 && k <= lines.Length)
            {
                Console.WriteLine($"Dòng {k}: " + lines[k - 1]);
            }
            else
            {
                Console.WriteLine("Vị trí dòng không hợp lệ.");
            }
        }
    }

    // Bài 13: Đếm tổng số dòng trong file
    static void Ex13_CountLines()
    {
        string[] lines = File.ReadAllLines("multi.txt");
        Console.WriteLine("Tổng số dòng trong 'multi.txt': " + lines.Length);
    }

    // Bài 14: In cấu trúc thư mục
    static void Ex14_PrintDirectoryStructure(string path, string indent = "")
    {
        DirectoryInfo dir = new DirectoryInfo(path);
        Console.WriteLine(indent + "[Thư mục] " + dir.Name);

        // Lấy các file trong thư mục
        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            Console.WriteLine(indent + "  ├── [Tệp] " + file.Name);
        }

        // Lấy các thư mục con
        DirectoryInfo[] subDirs = dir.GetDirectories();
        foreach (DirectoryInfo subDir in subDirs)
        {
            Ex14_PrintDirectoryStructure(subDir.FullName, indent + "  ");
        }
    }

    // Bài 15: Thống kê ký tự và vị trí xuất hiện
    static void Ex15_StatisticsAndPositions()
    {
        string[] contentLines = new string[] { "AB1", "B 2" };
        File.WriteAllLines("sample_stat.txt", contentLines);
        string[] lines = File.ReadAllLines("sample_stat.txt");

        // Cách 1: Dùng mảng chữ nhật int[,] để đếm tần suất
        int[,] freq = new int[256, 2];
        for (int i = 0; i < 256; i++)
        {
            freq[i, 0] = i;
        }

        foreach (string line in lines)
        {
            foreach (char c in line)
            {
                if (c < 256)
                {
                    freq[(int)c, 1]++;
                }
            }
        }

        Console.WriteLine("TẦN SUẤT XUẤT HIỆN (MẢNG 2 CHIỀU)");
        for (int i = 0; i < 256; i++)
        {
            if (freq[i, 1] > 0)
            {
                char ch = (char)i;
                string name = char.IsWhiteSpace(ch) ? $"' '(ASCII {i})" : $"'{ch}'";
                Console.WriteLine($"Ký tự {name}: {freq[i, 1]} lần");
            }
        }

        // Cách 2: Dùng mảng ziczac int[][][] để lưu vị trí [dòng, cột]
        int[] counts = new int[256];
        foreach (string line in lines)
        {
            foreach (char c in line)
            {
                if (c < 256) counts[(int)c]++;
            }
        }

        int[][][] positions = new int[256][][];
        for (int i = 0; i < 256; i++)
        {
            positions[i] = new int[counts[i]][];
            for (int j = 0; j < counts[i]; j++)
            {
                positions[i][j] = new int[2];
            }
        }

        int[] currentIndices = new int[256];
        for (int r = 0; r < lines.Length; r++)
        {
            for (int c = 0; c < lines[r].Length; c++)
            {
                char ch = lines[r][c];
                if (ch < 256)
                {
                    int ascii = (int)ch;
                    int idx = currentIndices[ascii];
                    positions[ascii][idx][0] = r + 1;
                    positions[ascii][idx][1] = c + 1;
                    currentIndices[ascii]++;
                }
            }
        }

        Console.WriteLine("\n=== VỊ TRÍ XUẤT HIỆN [DÒNG, CỘT] (MẢNG ZICZAC) ===");
        for (int i = 0; i < 256; i++)
        {
            if (positions[i].Length > 0)
            {
                char ch = (char)i;
                string name = char.IsWhiteSpace(ch) ? $"' '(ASCII {i})" : $"'{ch}'";
                Console.Write($"Ký tự {name}: ");
                for (int j = 0; j < positions[i].Length; j++)
                {
                    Console.Write($"[Dòng {positions[i][j][0]}, Cột {positions[i][j][1]}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
