using AccountantPro.Domain.Entities.Bases;

namespace AccountantPro.Domain.Entities.Clients;

public class Client:Auditable
{
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string TelegramPhoneNumber { get; set; }
    public string JSHSHIR { get; set; }
    public string Bank { get; set; }
    public string BankAddress { get; set; }
    public string INN { get; set; }
    public string OKONX { get; set; }

}
