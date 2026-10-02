using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

// Bài 4.1: Khởi tạo lớp MonHoc
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

// Bài 6.1: Khởi tạo lớp He
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

// Nguồn dữ liệu dùng chung cho Bài 4, 5, 6
public static class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "JLCB",  TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new MonHoc { MaMon = "LINQ",  TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "CC++",  TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new MonHoc { MaMon = "JQUE",  TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new MonHoc { MaMon = "XML",   TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "CRYS",  TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "BWEB",  TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "XYZ",   TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
        };
    }

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD",  TenHe = "Chuyên đề" },
            new He { MaHe = "OT",  TenHe = "Chứng chỉ quốc tế" }
        };
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Bai21();
        Bai22();
        Bai31();
        Bai32();
        Bai51();
        Bai52();
        Bai62();
    }

    // Bài 2.1. Truy vấn mảng số nguyên
    static void Bai21()
    {
        Console.WriteLine("=== BÀI 2.1: TRUY VẤN MẢNG SỐ NGUYÊN ===");
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        // a. Chia hết cho 4 và 3
        var cauA = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);
        Console.Write("a. Chia hết cho 4 và 3: ");
        foreach (var x in cauA) Console.Write($"{x} ");
        Console.WriteLine();

        // b. Nhỏ hơn hoặc bằng 3
        var cauB = from x in mangSo
                   where x <= 3
                   select x;
        Console.Write("b. Nhỏ hơn hoặc bằng 3: ");
        foreach (var x in cauB) Console.Write($"{x} ");
        Console.WriteLine();

        // c. Chẵn chia đôi, lẻ giữ nguyên
        var cauC = from x in mangSo
                   select (x % 2 == 0) ? (x / 2) : x;
        Console.Write("c. Chẵn chia đôi, lẻ giữ nguyên: ");
        foreach (var x in cauC) Console.Write($"{x} ");
        Console.WriteLine("\n");
    }

    // Bài 2.2. Truy vấn mảng chuỗi
    static void Bai22()
    {
        Console.WriteLine("\n=== BÀI 2.2: TRUY VẤN MẢNG CHUỖI ===");
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
                               "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

        // a. Dài 4 ký tự, xếp tăng dần theo chữ cái đầu
        var cauA = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
        Console.Write("a. Dài 4 ký tự, xếp tăng dần theo chữ cái đầu: ");
        foreach (var s in cauA) Console.Write($"{s}  ");
        Console.WriteLine();

        // b. Biến đổi dạng: <chữ thường> - <CHỮ HOA>
        var cauB = from s in mangChuoi
                   select $"{s.ToLower()} - {s.ToUpper()}";
        Console.WriteLine("b. Biến đổi <chữ thường> - <CHỮ HOA>:");
        foreach (var s in cauB) Console.WriteLine($"   {s}");

        // c. Chứa ký tự 'u' hoặc 'ú'
        var cauC = mangChuoi.Where(s => s.Contains("u") || s.Contains("ú"));
        Console.Write("c. Chứa ký tự 'u': ");
        foreach (var s in cauC) Console.Write($"{s}  ");
        Console.WriteLine();

        // d. Bắt đầu bằng chữ in hoa
        var cauD = from s in mangChuoi
                   where char.IsUpper(s[0])
                   select s;
        Console.Write("d. Bắt đầu bằng chữ in hoa: ");
        foreach (var s in cauD) Console.Write($"{s}  ");
        Console.WriteLine("\n");
    }

    // Bài 3.1. Thống kê mảng số
    static void Bai31()
    {
        Console.WriteLine("\n=== BÀI 3.1: THỐNG KÊ MẢNG SỐ ===");
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        // a. Tổng số, số chẵn, số lẻ
        int tongSo = mangSo.Count();
        int soChan = mangSo.Count(x => x % 2 == 0);
        int soLe = mangSo.Count(x => x % 2 != 0);
        Console.WriteLine($"a. Tổng số phần tử: {tongSo} | Số chẵn: {soChan} | Số lẻ: {soLe}");

        // b. Tổng, Max, Min
        int tongGiaTri = mangSo.Sum();
        int max = mangSo.Max();
        int min = mangSo.Min();
        Console.WriteLine($"b. Tổng giá trị: {tongGiaTri} | Max: {max} | Min: {min}");

        // c. Số lượng giá trị khác nhau
        int soGiaTriKhacNhau = mangSo.Distinct().Count();
        Console.WriteLine($"c. Số giá trị khác nhau: {soGiaTriKhacNhau}");

        // d. Phân nhóm theo số dư khi chia cho 5
        var cauD = from x in mangSo
                   group x by x % 5 into nhomSoDu
                   select nhomSoDu;

        Console.WriteLine("d. Phân nhóm theo số dư khi chia cho 5:");
        foreach (var group in cauD)
        {
            Console.Write($"   - Nhóm dư {group.Key}: ");
            foreach (var item in group) Console.Write($"{item}  ");
            Console.WriteLine();
        }
    }

    // Bài 3.2. Thống kê mảng chuỗi
    static void Bai32()
    {
        Console.WriteLine("\n=== BÀI 3.2: THỐNG KÊ MẢNG CHUỖI ===");
        string[] monAn = {
            "Nước Cà phê", "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
            "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
            "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang"
        };

        // a. Chiều dài ngắn nhất và dài nhất
        int minLen = monAn.Min(m => m.Length);
        int maxLen = monAn.Max(m => m.Length);

        var nganNhat = monAn.Where(m => m.Length == minLen);
        var daiNhat = monAn.Where(m => m.Length == maxLen);

        Console.Write("a. Món tên ngắn nhất: ");
        foreach (var m in nganNhat) Console.Write($"[{m}] ");
        Console.Write("\n   Món tên dài nhất: ");
        foreach (var m in daiNhat) Console.Write($"[{m}] ");
        Console.WriteLine();

        // b. Phân nhóm theo từ đầu tiên
        var cauB = from m in monAn
                   group m by m.Split(' ')[0] into nhomTuDau
                   select nhomTuDau;

        Console.WriteLine("\nb. Phân nhóm theo từ đầu tiên:");
        foreach (var group in cauB)
        {
            Console.Write($"   - Nhóm '{group.Key}': ");
            foreach (var item in group) Console.Write($"{item}, ");
            Console.WriteLine();
        }

        // c. Đếm số món bắt đầu bằng “Bánh"
        int soMonBanh = monAn.Count(m => m.StartsWith("Bánh"));
        Console.WriteLine($"\nc. Số món bắt đầu bằng từ 'Bánh': {soMonBanh}\n");
    }

    // Bài 5.1. Truy vấn cơ bản List<MonHoc>
    static void Bai51()
    {
        Console.WriteLine("\n=== BÀI 5.1: TRUY VẤN CƠ BẢN TRÊN DANH SÁCH MÔN HỌC ===");
        var dsMon = DuLieu.DS_Mon();

        // a. Bắt đầu bằng “Lập trình"
        var cauA = dsMon.Where(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine("a. Các môn bắt đầu bằng 'Lập trình':");
        foreach (var m in cauA) Console.WriteLine($"   - {m.MaMon}: {m.TenMon}");

        // b. Hệ “CD”, sắp xếp Số tiết (giảm) -> Mã môn (tăng)
        var cauB = dsMon.Where(m => m.He == "CD")
                        .OrderByDescending(m => m.SoTiet)
                        .ThenBy(m => m.MaMon);
        Console.WriteLine("\nb. Hệ CD, sắp xếp Số tiết (giảm) -> Mã môn (tăng):");
        foreach (var m in cauB) Console.WriteLine($"   - {m.MaMon} | {m.TenMon} | {m.SoTiet} tiết");

        // c. Chứa từ “web”, lấy Tên môn và Hệ
        var cauC = from m in dsMon
                   where m.TenMon.ToLower().Contains("web")
                   select new { m.TenMon, m.He };
        Console.WriteLine("\nc. Chứa từ 'web' (chỉ lấy Tên và Hệ):");
        foreach (var m in cauC) Console.WriteLine($"   - Tên: {m.TenMon} | Hệ: {m.He}");

        // d. Hệ “KTV", sắp xếp tăng dần theo Mã môn
        var cauD = from m in dsMon
                   where m.He == "KTV"
                   orderby m.MaMon ascending
                   select m;
        Console.WriteLine("\nd. Hệ KTV, tăng dần theo Mã môn:");
        foreach (var m in cauD) Console.WriteLine($"   - {m.MaMon} | {m.TenMon}");
        Console.WriteLine();
    }

    // Bài 5.2. Thống kê trên List<MonHoc>
    static void Bai52()
    {
        Console.WriteLine("\n=== BÀI 5.2: THỐNG KÊ TRÊN LIST<MONHOC> ===");
        var dsMon = DuLieu.DS_Mon();

        // a. Tổng số môn hiện có
        Console.WriteLine($"a. Tổng số môn hiện có: {dsMon.Count}");

        // b. Số môn bắt đầu bằng “Lập trình”
        int soMonLapTrinh = dsMon.Count(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"b. Số môn bắt đầu bằng 'Lập trình': {soMonLapTrinh}");

        // c. Tổng số tiết hệ KTV
        int tongTietKTV = dsMon.Where(m => m.He == "KTV").Sum(m => m.SoTiet);
        Console.WriteLine($"c. Tổng số tiết hệ KTV: {tongTietKTV}");

        // d. Tổng số môn của mỗi hệ
        var cauD = dsMon.GroupBy(m => m.He);
        Console.WriteLine("\nd. Tổng số môn của mỗi hệ:");
        foreach (var g in cauD)
            Console.WriteLine($"   - Hệ '{(string.IsNullOrEmpty(g.Key) ? "Chưa rõ" : g.Key)}': {g.Count()} môn");

        // e. Nhóm theo Số tiết (giảm dần)
        var cauE = dsMon.GroupBy(m => m.SoTiet).OrderByDescending(g => g.Key);
        Console.WriteLine("\ne. Nhóm theo Số tiết (giảm dần):");
        foreach (var g in cauE) Console.WriteLine($"   - Số tiết {g.Key}: {g.Count()} môn");

        // f. Môn có số tiết cao nhất
        int maxTiet = dsMon.Max(m => m.SoTiet);
        var cauF = dsMon.Where(m => m.SoTiet == maxTiet);
        Console.WriteLine($"\nf. Môn có số tiết cao nhất ({maxTiet} tiết):");
        foreach (var m in cauF) Console.WriteLine($"   - {m.MaMon} | {m.TenMon}");

        // g. Thống kê theo Hệ
        var cauG = dsMon.GroupBy(m => m.He)
                        .Select(g => new {
                            He = g.Key,
                            TongMon = g.Count(),
                            TongTiet = g.Sum(m => m.SoTiet),
                            MaxTiet = g.Max(m => m.SoTiet),
                            MinTiet = g.Min(m => m.SoTiet)
                        });
        Console.WriteLine("\ng. Thống kê chi tiết theo Hệ:");
        foreach (var item in cauG)
            Console.WriteLine($"   - Hệ '{item.He}': {item.TongMon} môn | Tổng: {item.TongTiet} tiết | Max: {item.MaxTiet} | Min: {item.MinTiet}");

        // h. Liệt kê môn học theo Hệ
        Console.WriteLine("\nh. Liệt kê môn học phân nhóm theo Hệ:");
        foreach (var g in cauD)
        {
            Console.WriteLine($"   [ Hệ '{g.Key}' ]");
            foreach (var m in g) Console.WriteLine($"     + {m.MaMon}: {m.TenMon}");
        }

        // i. Phân nhóm theo Số tiết (tăng dần)
        var cauI = dsMon.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
        Console.WriteLine("\ni. Phân nhóm theo Số tiết (tăng dần):");
        foreach (var g in cauI)
        {
            Console.WriteLine($"   [ {g.Key} tiết ]");
            foreach (var m in g) Console.WriteLine($"     + {m.MaMon}: {m.TenMon}");
        }

        // j. Hệ KTV, phân nhóm theo học phần (3 ký tự đầu)
        var cauJ = dsMon.Where(m => m.He == "KTV")
                        .OrderBy(m => m.MaMon)
                        .GroupBy(m => m.MaMon.Substring(0, 3));
        Console.WriteLine("\nj. Hệ KTV, phân nhóm theo học phần:");
        foreach (var g in cauJ)
        {
            Console.WriteLine($"   [ Học phần {g.Key} ]");
            foreach (var m in g) Console.WriteLine($"     + {m.MaMon}: {m.TenMon}");
        }

        // k. Nhóm theo Hệ, chỉ lấy môn > 40 tiết
        var cauK = dsMon.Where(m => m.SoTiet > 40).GroupBy(m => m.He);
        Console.WriteLine("\nk. Nhóm theo Hệ (chỉ lấy môn > 40 tiết):");
        foreach (var g in cauK)
        {
            Console.WriteLine($"   [ Hệ '{g.Key}' ]");
            foreach (var m in g.OrderBy(x => x.MaMon))
                Console.WriteLine($"     + {m.MaMon}: {m.TenMon} ({m.SoTiet} tiết)");
        }
        Console.WriteLine();
    }

    // Bài 6.2. Join và các toán tử tập hợp
    static void Bai62()
    {
        Console.WriteLine("\n=== BÀI 6.2: JOIN VÀ CÁC TOÁN TỬ TẬP HỢP ===");
        var dsHe = DuLieu.DS_He();
        var dsMon = DuLieu.DS_Mon();

        // a. Inner Join (Hệ - Môn học)
        var cauA = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He
                   select new { h.TenHe, m.MaMon, m.TenMon };
        Console.WriteLine("a. Inner Join (Hệ - Môn học):");
        foreach (var item in cauA) Console.WriteLine($"   - {item.TenHe} | {item.MaMon} | {item.TenMon}");

        // b. Left Outer Join (Cả những hệ chưa có môn)
        var leftJoin = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into nhom
                       from sub in nhom.DefaultIfEmpty()
                       select new
                       {
                           TenHe = h.TenHe,
                           MaMon = sub?.MaMon ?? "Không có",
                           TenMon = sub?.TenMon ?? "Trống"
                       };
        Console.WriteLine("\nb. Left Outer Join (Liệt kê cả hệ chưa có môn):");
        foreach (var item in leftJoin) Console.WriteLine($"   - {item.TenHe} | {item.MaMon} | {item.TenMon}");

        // c. Full Outer Join (Hệ chưa có môn & Môn chưa khai báo hệ)
        var rightOnly = from m in dsMon
                        where !dsHe.Any(h => h.MaHe == m.He)
                        select new { TenHe = "Hệ trống", MaMon = m.MaMon, TenMon = m.TenMon };
        var cauC = leftJoin.Union(rightOnly);
        Console.WriteLine("\nc. Full Outer Join (Cả 2 bên):");
        foreach (var item in cauC) Console.WriteLine($"   - {item.TenHe} | {item.MaMon} | {item.TenMon}");

        // d. Chỉ liệt kê hệ chưa có môn và môn chưa có hệ
        var heKhongMon = leftJoin.Where(x => x.MaMon == "Không có");
        var cauD = heKhongMon.Union(rightOnly);
        Console.WriteLine("\nd. Chỉ hệ chưa môn và môn chưa hệ:");
        foreach (var item in cauD) Console.WriteLine($"   - {item.TenHe} | {item.MaMon} | {item.TenMon}");

        // e. 5 môn học đầu tiên có số tiết giảm dần
        var cauE = (from m in dsMon
                    join h in dsHe on m.He equals h.MaHe into nhom
                    from subH in nhom.DefaultIfEmpty()
                    orderby m.SoTiet descending
                    select new
                    {
                        TenHe = subH?.TenHe ?? "Trống",
                        m.MaMon,
                        m.TenMon,
                        m.SoTiet
                    }).Take(5);
        Console.WriteLine("\ne. 5 môn số tiết cao nhất:");
        foreach (var item in cauE) Console.WriteLine($"   - {item.TenHe} | {item.MaMon} | {item.TenMon} ({item.SoTiet} tiết)");

        // f. Tổng số môn học của mỗi hệ
        var cauF = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into nhom
                   select new { h.MaHe, h.TenHe, TongMon = nhom.Count() };
        Console.WriteLine("\nf. Tổng số môn của mỗi hệ:");
        foreach (var item in cauF) Console.WriteLine($"   - {item.MaHe} ({item.TenHe}): {item.TongMon} môn");

        // g. Bao nhiêu loại Số tiết khác nhau
        int loaiSoTiet = dsMon.Select(m => m.SoTiet).Distinct().Count();
        Console.WriteLine($"\ng. Số loại 'Số tiết' khác nhau: {loaiSoTiet}");

        // h. Môn học đầu tiên bắt đầu bằng "Lập trình"
        var cauH = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"\nh. Môn đầu tiên bắt đầu bằng 'Lập trình': {(cauH != null ? cauH.TenMon : "Không tìm thấy")}");

        // i. Các môn theo từng hệ, đánh số thứ tự
        Console.WriteLine("\ni. Đánh số thứ tự môn trong từng hệ:");
        var cauI = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into nhom
                   select new { h.TenHe, DanhSach = nhom };

        foreach (var nhom in cauI)
        {
            Console.WriteLine($"   [ {nhom.TenHe} ]");
            int stt = 1;
            foreach (var m in nhom.DanhSach)
            {
                Console.WriteLine($"     {stt++}. {m.MaMon} - {m.TenMon}");
            }
        }
        Console.WriteLine();
    }
}