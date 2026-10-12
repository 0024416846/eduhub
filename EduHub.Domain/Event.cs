namespace EduHub.Domain;

/// <summary>
/// Đại diện cho một sự kiện do câu lạc bộ tổ chức.
/// </summary>
public sealed class Event
{
    /// <summary>Mã định danh sự kiện.</summary>
    public Guid Id { get; private set; }

    /// <summary>Mã câu lạc bộ tổ chức.</summary>
    public Guid ClubId { get; private set; }

    /// <summary>Tiêu đề sự kiện.</summary>
    public string Title { get; private set; }

    /// <summary>Ngày diễn ra sự kiện.</summary>
    public DateTime Date { get; private set; }

    /// <summary>Sức chứa tối đa.</summary>
    public int Capacity { get; private set; }

    /// <summary>Sự kiện có tổ chức trực tuyến hay không.</summary>
    public bool IsOnline { get; private set; }

    private Event(
        Guid id,
        Guid clubId,
        string title,
        DateTime date,
        int capacity,
        bool isOnline)
    {
        Id = id;
        ClubId = clubId;
        Title = title;
        Date = date;
        Capacity = capacity;
        IsOnline = isOnline;
    }

    /// <summary>Tạo sự kiện mới sau khi kiểm tra dữ liệu.</summary>
    public static Event Create(
        Guid clubId,
        string title,
        DateTime date,
        int capacity,
        bool isOnline)
    {
        if (clubId == Guid.Empty)
            throw new ArgumentException("ClubId không hợp lệ.");

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Tiêu đề không được để trống.");

        if (capacity <= 0)
            throw new ArgumentException("Sức chứa phải lớn hơn 0.");

        return new Event(
            Guid.NewGuid(),
            clubId,
            title.Trim(),
            date,
            capacity,
            isOnline);
    }

    /// <summary>Kiểm tra sự kiện còn chỗ hay không.</summary>
    public bool HasCapacity(int registeredCount)
    {
        if (registeredCount < 0)
            throw new ArgumentException("Số người đăng ký không được âm.");

        return registeredCount < Capacity;
    }
}