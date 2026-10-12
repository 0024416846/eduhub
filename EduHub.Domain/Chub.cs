namespace EduHub.Domain;

/// <summary>
/// Đại diện cho một câu lạc bộ sinh viên.
/// </summary>
public sealed class Club
{
    /// <summary>Mã định danh câu lạc bộ.</summary>
    public Guid Id { get; private set; }

    /// <summary>Tên câu lạc bộ.</summary>
    public string Name { get; private set; }

    /// <summary>Mô tả câu lạc bộ.</summary>
    public string Description { get; private set; }

    /// <summary>Thời điểm tạo câu lạc bộ.</summary>
    public DateTime CreatedAt { get; private set; }

    /// <summary>Danh sách thành viên.</summary>
    public List<Member> Members { get; private set; }

    private Club(
        Guid id,
        string name,
        string description,
        DateTime createdAt)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedAt = createdAt;
        Members = new List<Member>();
    }

    /// <summary>Tạo câu lạc bộ mới.</summary>
    public static Club Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên câu lạc bộ không được để trống.");

        if (description == null)
            throw new ArgumentNullException(nameof(description));

        return new Club(
            Guid.NewGuid(),
            name.Trim(),
            description.Trim(),
            DateTime.UtcNow);
    }

    /// <summary>Thêm thành viên nếu chưa tồn tại.</summary>
    public void AddMember(Member member)
    {
        ArgumentNullException.ThrowIfNull(member);

        if (Members.Any(m => m.Id == member.Id))
            return;

        Members.Add(member);
    }

    /// <summary>Đếm số thành viên của câu lạc bộ.</summary>
    public int MemberCount()
    {
        return Members.Count;
    }
}