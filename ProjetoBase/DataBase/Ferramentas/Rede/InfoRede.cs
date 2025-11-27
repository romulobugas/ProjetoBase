using System.Net;

namespace ProjetoBase.Ferramentas.Rede
{
    public static class InfoRede
    {
        public static string ObterIpHost()
        {
            string host = Dns.GetHostName();
            string ip = "";

            var enderecos = Dns.GetHostAddresses(host);
            foreach (var endereco in enderecos)
            {
                if (endereco.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = endereco.ToString();
                    break;
                }
            }

            return $"{host} | {ip}";
        }
    }
}
