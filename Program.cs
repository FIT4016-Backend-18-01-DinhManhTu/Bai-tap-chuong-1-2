    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Chương trình Xếp loại Sinh viên ===\n");

            // TODO 1: Khai báo biến thông tin sinh viên
            string hoVaTen = "Nguyễn Văn A";   // Thay bằng tên của bạn
            double diem = 7.5;                 // Thay bằng điểm của bạn

            // TODO 2: In ra thông tin sinh viên
            Console.WriteLine($"Họ tên: {hoVaTen}");
            Console.WriteLine($"Điểm: {diem}\n");

            // TODO 3: Cấu trúc if/else để xếp loại
            string xepLoai;

            if (diem >= 8.5)
                xepLoai = "Giỏi";
            else if (diem >= 7.0)
                xepLoai = "Khá";
            else if (diem >= 5.5)
                xepLoai = "Trung bình";
            else
                xepLoai = "Yếu";

            Console.WriteLine($"Xếp loại: {xepLoai}\n");


            // TODO 4: Bảng điểm 3 sinh viên
            string[] tenSV = { "Nguyễn Văn A", "Trần Thị B", "Lê Văn C" };
            double[] diemSV = { 8.5, 7.2, 5.8 };

            Console.WriteLine("=== Bảng Điểm ===");
            for (int i = 0; i < tenSV.Length; i++)
            {
                string xl;

                if (diemSV[i] >= 8.5)
                    xl = "Giỏi";
                else if (diemSV[i] >= 7.0)
                    xl = "Khá";
                else if (diemSV[i] >= 5.5)
                    xl = "Trung bình";
                else
                    xl = "Yếu";

                Console.WriteLine($"{i + 1}. {tenSV[i]} - Điểm: {diemSV[i]} - Xếp loại: {xl}");
            }


            // TODO 6: Tính tổng điểm bằng while
            double tongDiem = 0;
            int j = 0;

            while (j < diemSV.Length)
            {
                tongDiem += diemSV[j];
                j++;
            }

            Console.WriteLine($"\nTổng điểm: {tongDiem}");
            Console.WriteLine($"Điểm trung bình: {tongDiem / diemSV.Length:F2}");
        }
    }
