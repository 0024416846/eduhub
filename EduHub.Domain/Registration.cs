namespace EduHub.Domain;

/// <summary>
/// Các trạng thái của phiếu đăng ký.
/// </summary>
public enum RegistrationStatus
{
    Pending,
    Confirmed,
    Cancelled
}

/// <summary>
/// Đại diện cho phiếu đăng ký tham dự sự kiện.
/// </summary>
public sealed class Registration
{
    /// <summary>Mã phiếu đăng ký.</summary>
    public Guid Id { get; private set; }

    /// <summary>Mã thành viên đăng ký.</summary>
    public Guid MemberId { get; private set; }

    /// <summary>Mã sự kiện được đăng ký.</summary>
    public Guid EventId { get; private set; }

    /// <summary>Thời điểm đăng ký.</summary>
    public DateTime RegisteredAt { get; private set; }

    /// <summary>Trạng thái phiếu đăng ký.</summary>
    public RegistrationStatus Status { get; private set; }

    private Registration(
        Guid id,
        Guid memberId,
        Guid eventId,
        DateTime registeredAt)
    {
        Id = id;
        MemberId = memberId;
        EventId = eventId;
        RegisteredAt = registeredAt;
        Status = RegistrationStatus.Pending;
    }

    /// <summary>Tạo phiếu đăng ký mới.</summary>
    public static Registration Create(Guid memberId, Guid eventId)
    {
        if (memberId == Guid.Empty)
            throw new ArgumentException("MemberId không hợp lệ.");

        if (eventId == Guid.Empty)
            throw new ArgumentException("EventId không hợp lệ.");

        return new Registration(
            Guid.NewGuid(),
            memberId,
            eventId,
            DateTime.UtcNow);
    }

    /// <summary>Xác nhận phiếu đăng ký đang chờ xử lý.</summary>
    public void Confirm()
    {
        if (Status != RegistrationStatus.Pending)
            throw new InvalidOperationException(
                "Chỉ phiếu Pending mới được xác nhận.");

        Status = RegistrationStatus.Confirmed;
    }

    /// <summary>Hủy phiếu đăng ký.</summary>
    public void Cancel()
    {
        if (Status == RegistrationStatus.Cancelled)
            return;

        Status = RegistrationStatus.Cancelled;
    }
}