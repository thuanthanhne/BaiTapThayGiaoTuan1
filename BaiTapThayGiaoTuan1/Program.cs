using System;
//Họ và tên : Phạm Ngọc Thuận Thanh
//Bắt Đầu Làm Bài
class Program
{
    static void Main()
    {
        // Yêu cầu người dùng nhập vào hai số
        Console.Write("Nhap so thu nhat: ");
        double soThuNhat = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        double soThuHai = Convert.ToDouble(Console.ReadLine());

        // Tính trung bình cộng
        double trungBinhCong = (soThuNhat + soThuHai) / 2;

        // Hiển thị kết quả
        Console.WriteLine($"Trung binh cong cua {soThuNhat} va {soThuHai} la: {trungBinhCong}");
    }
}
