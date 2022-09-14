namespace Domain.Entities;
public class SystemSettings : BaseDomainEntity
{
    public int SettingId { get; set; }
    public string KeyName { get; set; } = null!;
    public string? Category { get; set; }
    public string? KeyType { get; set; }
    public string? KeyValue { get; set; }
    public byte? KeyLength { get; set; }
}
