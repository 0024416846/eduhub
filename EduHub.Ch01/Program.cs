using EduHub.Domain;

const string separator = "========================================";

// BƯỚC 1: Tạo câu lạc bộ
Console.WriteLine(separator);
Console.WriteLine("BUOC 1: TAO CAU LAC BO");

Club club = Club.Create(
    "Tech Club",
    "Cau lac bo cong nghe va tri tue nhan tao");

Console.WriteLine($"Ten CLB: {club.Name}");
Console.WriteLine($"Mo ta: {club.Description}");
Console.WriteLine($"Ma CLB: {club.Id}");

// BƯỚC 2: Thêm 3 thành viên
Console.WriteLine(separator);
Console.WriteLine("BUOC 2: THEM THANH VIEN");

Member member1 = Member.Create(
    "Nguyen Van An",
    "an@gmail.com",
    "SV001");

Member member2 = Member.Create(
    "Tran Thi Binh",
    "binh@gmail.com",
    "SV002");

Member member3 = Member.Create(
    "Le Van Cuong",
    "cuong@gmail.com",
    "SV003");

club.AddMember(member1);
club.AddMember(member2);
club.AddMember(member3);

foreach (Member member in club.Members)
{
    Console.WriteLine(
        $"Ten: {member.Name} | MSSV: {member.StudentCode}");
}

Console.WriteLine($"Tong so thanh vien: {club.MemberCount()}");

// BƯỚC 3: Tạo sự kiện
Console.WriteLine(separator);
Console.WriteLine("BUOC 3: TAO SU KIEN");

EduHub.Domain.Event ev = EduHub.Domain.Event.Create(
    club.Id,
    "Workshop AI",
    DateTime.Now.AddDays(7),
    50,
    false);

Console.WriteLine($"Ten su kien: {ev.Title}");
Console.WriteLine($"Ngay to chuc: {ev.Date:dd/MM/yyyy HH:mm}");
Console.WriteLine($"Suc chua: {ev.Capacity}");
Console.WriteLine($"Hinh thuc: {(ev.IsOnline ? "Truc tuyen" : "Truc tiep")}");

// BƯỚC 4: Hai thành viên đăng ký và xác nhận
Console.WriteLine(separator);
Console.WriteLine("BUOC 4: DANG KY VA XAC NHAN");

Registration reg1 = Registration.Create(member1.Id, ev.Id);
Registration reg2 = Registration.Create(member2.Id, ev.Id);

Console.WriteLine($"{member1.Name}: {reg1.Status}");
reg1.Confirm();
Console.WriteLine($"Sau khi xac nhan: {reg1.Status}");

Console.WriteLine($"{member2.Name}: {reg2.Status}");
reg2.Confirm();
Console.WriteLine($"Sau khi xac nhan: {reg2.Status}");

// BƯỚC 5: Một thành viên check-in
Console.WriteLine(separator);
Console.WriteLine("BUOC 5: CHECK-IN SU KIEN");

CheckIn checkIn = CheckIn.Create(
    reg1.Id,
    CheckInMethod.QRCode);

Console.WriteLine($"Thanh vien: {member1.Name}");
Console.WriteLine(checkIn.Summary());

// BƯỚC 6: Báo cáo tham dự
Console.WriteLine(separator);
Console.WriteLine("BUOC 6: BAO CAO THAM DU");

Registration[] registrations = { reg1, reg2 };
CheckIn[] checkIns = { checkIn };

Console.WriteLine($"Su kien: {ev.Title}");
Console.WriteLine($"So luong dang ky: {registrations.Length}");
Console.WriteLine($"So luot check-in: {checkIns.Length}");
Console.WriteLine("Danh sach nguoi dang ky:");

foreach (Registration registration in registrations)
{
    Member member = club.Members.Find(
        m => m.Id == registration.MemberId)!;

    Console.WriteLine(
        $"- {member.Name} | Trang thai: {registration.Status}");
}

// BƯỚC 7: Thử thao tác vi phạm nghiệp vụ
Console.WriteLine(separator);
Console.WriteLine("BUOC 7: KIEM TRA LOI NGHIEP VU");

Registration reg3 = Registration.Create(member3.Id, ev.Id);
reg3.Cancel();

try
{
    reg3.Confirm();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Da bat loi thanh cong: {ex.Message}");
}

Console.WriteLine(separator);
Console.WriteLine("KET THUC DEMO");