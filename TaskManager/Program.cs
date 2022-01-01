using System;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TaskManager.Core;

namespace TaskManager
{
    public static class Program
    {
        private static IHost _host;

        public static void Main(string[] args)
        {
            ForbiddenProcessesManager.GetInstance(); // Creation
            // Init grpc
            _host = Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options =>
                    {
                        options.Listen(IPAddress.Any, 5001,
                            listenOptions => { listenOptions.UseHttps(BuildSelfSignedServerCertificate()); });
                    });
                    webBuilder.UseStartup<Startup>();
                })
                .Build();

            var serverAdvertizer = new ServerAdvertizer();
            serverAdvertizer.Start();
            _host.Run(); // block
            ForbiddenProcessesManager.GetInstance().Stop();
            serverAdvertizer.Stop();
        }

        private static X509Certificate2 BuildSelfSignedServerCertificate()
        {
            const string certificateName = "localhost";
            SubjectAlternativeNameBuilder sanBuilder = new SubjectAlternativeNameBuilder();
            sanBuilder.AddIpAddress(IPAddress.Loopback);
            sanBuilder.AddIpAddress(IPAddress.IPv6Loopback);
            sanBuilder.AddDnsName("localhost");
            sanBuilder.AddDnsName(Environment.MachineName);

            X500DistinguishedName distinguishedName = new X500DistinguishedName($"CN={certificateName}");

            using (RSA rsa = RSA.Create(2048))
            {
                var request = new CertificateRequest(distinguishedName, rsa, HashAlgorithmName.SHA256,
                    RSASignaturePadding.Pkcs1);

                request.CertificateExtensions.Add(
                    new X509KeyUsageExtension(
                        X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment |
                        X509KeyUsageFlags.DigitalSignature, false));
                request.CertificateExtensions.Add(
                    new X509EnhancedKeyUsageExtension(
                        new OidCollection {new Oid("1.3.6.1.5.5.7.3.1")}, false));

                request.CertificateExtensions.Add(sanBuilder.Build());

                var certificate = request.CreateSelfSigned(new DateTimeOffset(DateTime.UtcNow.AddDays(-1)),
                    new DateTimeOffset(DateTime.UtcNow.AddDays(3650)));
                certificate.FriendlyName = certificateName;

                return new X509Certificate2(certificate.Export(X509ContentType.Pfx, "WeNeedASaf3rPassword"),
                    "WeNeedASaf3rPassword", X509KeyStorageFlags.UserKeySet);
            }
        }
    }
}