Actor 1: Sinh viên (Student)
US-01 · Sinh viên: đăng ký tham gia câu lạc bộ
① Chưa là thành viên + CLB còn hoạt động ➜ gửi yêu cầu tham gia ➜ ghi nhận thành viên trong club.Members.
② Đã là thành viên ➜ tham gia lại ➜ bị từ chối (không tạo thành viên trùng).
US-02 · Sinh viên: đăng ký sự kiện
① Sự kiện còn chỗ ➜ đăng ký hợp lệ ➜ tạo phiếu đăng ký trạng thái Pending.
② Sự kiện đã đủ sức chứa ➜ gửi yêu cầu đăng ký ➜ bị từ chối (không tạo phiếu đăng ký mới).
US-03 · Sinh viên: check-in sự kiện
① Phiếu đăng ký có trạng thái Confirmed ➜ check-in ➜ lưu thời điểm, hình thức check-in và mã phiếu đăng ký.
② Phiếu đăng ký chưa được xác nhận hoặc đã bị hủy ➜ check-in ➜ bị từ chối.
Actor 2: Ban câu lạc bộ (Club Management)
US-04 · Ban CLB: tạo sự kiện
① Có quyền quản lý CLB + dữ liệu hợp lệ ➜ tạo sự kiện ➜ lưu sự kiện và liên kết với đúng CLB.
② Tiêu đề trống hoặc sức chứa nhỏ hơn hoặc bằng 0 ➜ lưu sự kiện ➜ bị từ chối (dữ liệu không hợp lệ).
US-05 · Ban CLB: xem danh sách thành viên
① Có quyền quản lý CLB ➜ mở danh sách thành viên ➜ hiển thị thành viên thuộc CLB được chọn.
② Danh sách thành viên đã hiển thị ➜ xem thông tin tổng quan ➜ hiển thị tổng số thành viên.
US-06 · Ban CLB: xuất báo cáo tham dự
① Sự kiện có dữ liệu đăng ký ➜ tạo báo cáo ➜ hiển thị tổng số đăng ký, số lượt check-in và danh sách người đăng ký.
② Sự kiện chưa có lượt check-in ➜ tạo báo cáo ➜ báo cáo vẫn được tạo với số lượt check-in bằng 0.
Actor 3: Admin
US-07 · Admin: quản lý câu lạc bộ và phê duyệt thành viên
① Admin đã đăng nhập + thông tin CLB hợp lệ ➜ tạo hoặc cập nhật CLB ➜ lưu thông tin CLB vào hệ thống.
② Có yêu cầu tham gia đang chờ duyệt ➜ Admin phê duyệt ➜ ghi nhận quyết định và cập nhật trạng thái tương ứng.