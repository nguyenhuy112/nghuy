using System;
using System.Collections.Generic;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class bai40
{
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Chương trình quản lý điểm học tập của sinh viên");
            Console.WriteLine("1. Thêm sinh viên mới");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tìm kiếm sinh viên theo MSSV");
            Console.WriteLine("4. Tính điểm trung bình của toàn bộ sinh viên");
            Console.WriteLine("5. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");

            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        HienThiDanhSach();
                        break;
                    case 3:
                        TimKiemSinhVien();
                        break;
                    case 4:
                        TinhDiemTrungBinh();
                        break;
                    case 5:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Nhập dữ liệu không hợp lệ. Vui lòng thử lại.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            Console.WriteLine();
        } while (choice != 5);
    }

    static void ThemSinhVien()
    {
        SinhVien sv = new SinhVien();
        Console.Write("Nhập MSSV: ");
        sv.MSSV = Console.ReadLine();
        Console.Write("Nhập Họ tên: ");
        sv.HoTen = Console.ReadLine();
        Console.Write("Nhập điểm Toán: ");
        sv.DiemToan = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Lý: ");
        sv.DiemLy = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Hóa: ");
        sv.DiemHoa = double.Parse(Console.ReadLine());
        danhSachSinhVien.Add(sv);
        Console.WriteLine("Thêm sinh viên thành công.");
    }

    static void HienThiDanhSach()
    {
        if (danhSachSinhVien.Count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống.");
            return;
        }

        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh}");
        }
    }

    static void TimKiemSinhVien()
    {
        Console.Write("Nhập MSSV của sinh viên cần tìm: ");
        string mssv = Console.ReadLine();
        SinhVien sv = danhSachSinhVien.Find(s => s.MSSV == mssv);
        if (sv != null)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên với MSSV này.");
        }
    }

    static void TinhDiemTrungBinh()
    {
        if (danhSachSinhVien.Count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống.");
            return;
        }

        double tongDiem = 0;
        foreach (var sv in danhSachSinhVien)
        {
            tongDiem += sv.DiemTrungBinh;
        }
        double diemTrungBinh = tongDiem / danhSachSinhVien.Count;
        Console.WriteLine($"Điểm trung bình của toàn bộ sinh viên là: {diemTrungBinh}");
    }
}