namespace IMAOCMS.Core.Entites;
public class EPCReadTemp
{
    public int Id { get; set; }
    public string Epc { get; set; }
    public int Rssi { get; set; }
    public byte Ant { get; set; }
    public DateTime EpcDate { get; set; }
}