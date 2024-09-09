using System;
using lib_toan; // Tham chiếu đến thư viện lib_toan

class Program
{
    static void Main()
    {
        // Yêu cầu người dùng nhập vào hai số
        Console.Write("NNhap so thu nhat: ");
        double soThuNhat = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        double soThuHai = Convert.ToDouble(Console.ReadLine());

        // Sử dụng thư viện lib_toan để tính trung bình cộng
        TinhToan tinhToan = new TinhToan();
        double trungBinhCong = tinhToan.TinhTrungBinhCong(soThuNhat, soThuHai);

        // Hiển thị kết quả
        Console.WriteLine($"Trung binh cong cua {soThuNhat} va {soThuHai} la: {trungBinhCong}");
    }
}
