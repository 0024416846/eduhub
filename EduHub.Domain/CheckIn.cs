namespace EduHub.Domain;

/// <summary>
/// Ghi nhận điểm danh tại sự kiện.
/// </summary>

/// <summary>
/// Các hình thức check-in sự kiện.
/// </summary>
public enum CheckInMethod
{
    QRCode,
    Manual
}
public sealed class CheckIn
{
    /// <summary>Mã định danh check-in.</summary>
    public Guid Id { get; private set; }

    /// <summary>Mã phiếu đăng ký.</summary>
    public Guid RegistrationId { get; private set; }

    /// <summary>Thời điểm check-in.</summary>
    public DateTime CheckedInAt { get; private set; }

    /// <summary>Hình thức check-in.</summary>
    public CheckInMethod Method { get; private set; }

    private CheckIn(
        Guid id,
        Guid registrationId,
        DateTime checkedInAt,
        CheckInMethod method)
    {
        Id = id;
        RegistrationId = registrationId;
        CheckedInAt = checkedInAt;
        Method = method;
    }

    /// <summary>Tạo lượt check-in mới.</summary>
    public static CheckIn Create(
        Guid registrationId,
        CheckInMethod method)
    {
        if (registrationId == Guid.Empty)
            throw new ArgumentException(
                "RegistrationId không hợp lệ.");

        if (!Enum.IsDefined(method))
            throw new ArgumentException(
                "Hình thức check-in không hợp lệ.");

        return new CheckIn(
            Guid.NewGuid(),
            registrationId,
            DateTime.UtcNow,
            method);
    }

    /// <summary>Trả về chuỗi mô tả lượt check-in.</summary>
    public string Summary()
    {
        return $"Check-in: {Id} | " +
               $"Phiếu đăng ký: {RegistrationId} | " +
               $"Thời gian: {CheckedInAt:yyyy-MM-dd HH:mm:ss} UTC | " +
               $"Hình thức: {Method}";
    }
}