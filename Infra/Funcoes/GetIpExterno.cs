using System.Net;

namespace AgriTechPlus.Infra.Funcoes;

public class GetIpExterno
{
    public string IpExterno()
    {
        string enderecoIpExterno;

        using (var cliente = new WebClient())
        {
            enderecoIpExterno = cliente.DownloadString("https://api.ipify.org");
        }
        return enderecoIpExterno;
    }

    public string IpExternoReverso()
    {
        string enderecoIpExterno;
        using (var cliente = new WebClient())
        {
            enderecoIpExterno = cliente.DownloadString("https://api.ipify.org");
        }
        IPHostEntry entradaDns = Dns.GetHostEntry(enderecoIpExterno);
        return entradaDns.HostName;
    }
}
