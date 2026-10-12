namespace EduHub.Domain;

/// <summary>
/// Đại diện cho sinh viên là thành viên của EduHub.
/// </summary>
public sealed class Member
{
    /// <summary>Mã định danh thành viên.</summary>
    public Guid Id { get; private set; }

    /// <summary>Họ tên thành viên.</summary>
    public string Name { get; private set; }

    /// <summary>Email thành viên.</summary>
    public string Email { get; private set; }

    /// <summary>Mã số sinh viên.</summary>
    public string StudentCode { get; private set; }

    /// <summary>Thời điểm tham gia hệ thống.</summary>
    public DateTime JoinedAt { get; private set; }

    private Member(
        Guid id,
        string name,
        string email,
        string studentCode,
        DateTime joinedAt)
    {
        Id = id;
        Name = name;
        Email = email;
        StudentCode = studentCode;
        JoinedAt = joinedAt;
    }

    /// <summary>Tạo thành viên mới sau khi kiểm tra dữ liệu.</summary>
    public static Member Create(
        string name,
        string email,
        string studentCode)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên không được để trống.");

        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            throw new ArgumentException("Email phải có ký tự @.");

        if (string.IsNullOrWhiteSpace(studentCode))
            throw new ArgumentException("Mã sinh viên không được để trống.");

        return new Member(
            Guid.NewGuid(),
            name.Trim(),
            email.Trim(),
            studentCode.Trim(),
            DateTime.UtcNow);
    }

    /// <summary>Kiểm tra thành viên có dữ liệu hợp lệ hay không.</summary>
    public bool IsActive()
    {
        return !string.IsNullOrWhiteSpace(Name)
            && !string.IsNullOrWhiteSpace(Email)
            && !string.IsNullOrWhiteSpace(StudentCode);
    }
}