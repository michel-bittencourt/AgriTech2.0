using System.Net;

namespace AgriTechPlus.Infra.Funcoes;

public class GetIP
{
    public string Ipv4Local()
    {
        string[] addresses = Dns.GetHostAddresses(Dns.GetHostName())
                            .Where(addr => addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            .Select(addr => addr.ToString())
                            .ToArray();
        return string.Join("-", addresses);
    }
}
