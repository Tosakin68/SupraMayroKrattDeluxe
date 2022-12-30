using System.Net;
using UnityEngine.Networking;

public static class GlobalIP
{
    public static string GetGlobalIPAddress()
    {
        string ipadress = new WebClient().DownloadString("https://ifconfig.me/");
        return ipadress;
    }

}