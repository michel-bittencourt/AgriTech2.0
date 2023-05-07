using System.Net.NetworkInformation;

namespace AgriTechPlus.Infra.Funcoes;

public class GetGateway
{
    public string Gateway()
    {
        var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        var gatewayAddresses = networkInterfaces
            .SelectMany(ni => ni.GetIPProperties()?.GatewayAddresses)
            .Where(ga => ga?.Address != null)
            .Select(ga => ga.Address.ToString())
            .ToArray();
        var gatewayAddressesString = string.Join("-", gatewayAddresses);
        return gatewayAddressesString;
    }
}
