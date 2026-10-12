EduHub - Hệ thống quản lý câu lạc bộ và sự kiện sinh viên
1. Giới thiệu dự án
EduHub là dự án được xây dựng nhằm hỗ trợ quản lý hoạt động của các câu lạc bộ sinh viên trong trường học. Hệ thống tập trung vào việc quản lý thành viên, tổ chức sự kiện, đăng ký tham gia và ghi nhận điểm danh.
Dự án được thực hiện trong khuôn khổ bài tập CH01 – Phân tích yêu cầu và Domain Modeling EduHub của môn IN4211.
2. Mục tiêu
- Phân tích yêu cầu hệ thống thông qua User Stories.
- Xây dựng sơ đồ lớp (Class Diagram) mô tả các đối tượng và mối quan hệ trong hệ thống.
- Xây dựng các lớp nghiệp vụ bằng ngôn ngữ C#.
- Minh họa quy trình quản lý câu lạc bộ, sự kiện, đăng ký và điểm danh.
- Sử dụng Git và GitHub để quản lý mã nguồn.
3. Chức năng chính
- Quản lý câu lạc bộ:Tạo câu lạc bộ và lưu thông tin mô tả.
- Quản lý thành viên:Tạo và quản lý thông tin thành viên câu lạc bộ.
- Quản lý sự kiện:Tạo sự kiện và thiết lập sức chứa tối đa.
- Đăng ký sự kiện:Cho phép thành viên đăng ký và xác nhận hoặc hủy đăng ký.
- Điểm danh:Ghi nhận thông tin điểm danh của thành viên đã đăng ký.
- Báo cáo:Thống kê số lượng đăng ký và số lượt điểm danh trong chương trình demo.
4. Công nghệ sử dụng
- Ngôn ngữ lập trình: C#.
- Nền tảng: .NET.
- Môi trường phát triển: Visual Studio.
- Quản lý mã nguồn: Git và GitHub.
- Tài liệu phân tích, thiết kế: Markdown và Mermaid.
5. Cấu trúc dự án
EduHub.Ch01/
├── Domain/
│   ├── Member.cs
│   ├── Club.cs
│   ├── Event.cs
│   ├── Registration.cs
│   └── CheckIn.cs
├── docs/
│   ├── user-stories.md
│   └── class-diagram.md
├── Program.cs
├── EduHub.Ch01.csproj
└── README.md
Mô tả các thành phần
- Domain/: Chứa các lớp nghiệp vụ của hệ thống.
- docs/user-stories.md: Mô tả yêu cầu của người dùng.
- docs/class-diagram.md: Mô tả sơ đồ lớp của hệ thống.
- Program.cs: Chương trình demo các chức năng chính.
- EduHub.Ch01.csproj: Tệp cấu hình dự án C#.
- README.md: Tài liệu giới thiệu và hướng dẫn sử dụng dự án.
6. Mô hình nghiệp vụ
Hệ thống gồm 5 lớp nghiệp vụ chính:
- Member:Đại diện cho thành viên.
- Club:Đại diện cho câu lạc bộ.
- Event:Đại diện cho sự kiện do câu lạc bộ tổ chức.
- Registration:Lưu thông tin đăng ký tham gia sự kiện.
- CheckIn:Lưu thông tin điểm danh của lượt đăng ký.
Các lớp liên kết với nhau để mô phỏng quy trình từ quản lý câu lạc bộ đến tổ chức sự kiện, đăng ký và điểm danh.
7. Hướng dẫn chạy chương trình
Yêu cầu
- Đã cài đặt Visual Studio có hỗ trợ phát triển ứng dụng .NET.
- Đã cài đặt phiên bản .NET SDK tương thích với `EduHub.Ch01.csproj`.
Các bước thực hiện
1. Mở solution EduHub.Ch01 bằng Visual Studio.
2. Trong Solution Explorer, chọn project chứa tệp Program.cs làm Startup Project.
3. Chọn Build → Build Solution để biên dịch dự án.
4. Chọn Debug → Start Without Debugging hoặc nhấn Ctrl + F5 để chạy chương trình.
5. Quan sát kết quả hiển thị trên cửa sổ Console.
8. Kết quả mong đợi
Chương trình demo thực hiện các bước:
1. Tạo câu lạc bộ Tech Club.
2. Thêm 3 thành viên.
3. Tạo sự kiện Workshop AI với sức chứa tối đa 50 người.
4. Cho 2 thành viên đăng ký và xác nhận đăng ký.
5. Ghi nhận điểm danh cho một thành viên.
6. Hiển thị báo cáo gồm số lượt đăng ký, số lượt điểm danh và danh sách thành viên tham gia.
Kết quả thực tế phụ thuộc vào nội dung mã nguồn hiện tại của dự án.
9. Quản lý mã nguồn
Dự án sử dụng Git và GitHub để quản lý phiên bản mã nguồn. Các thay đổi được lưu bằng commit và có thể được gửi thông qua Pull Request để xem xét trước khi hợp nhất vào nhánh chính.
10. Tác giả
- Họ và tên: Nguyễn Ngọc Phương Quỳnh
- MSSV: 0024416846
- Môn học: IN421107
- Bài tập: BÀI TẬP CH01 — PHÂN TÍCH YÊU CẦU VÀ DOMAIN MODELING EDUHUB
