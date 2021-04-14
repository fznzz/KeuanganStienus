using Renci.SshNet;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    class ssh
    {
        public static MySqlConnectionStringBuilder csbCall (uint portGet)
        {
            MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                Port = portGet,
                UserID = "zanhouse_fznroot",
                Password = "fauzan19-",
                Database = "zanhouse_stienus_"
            };
            return csb;
        }
        public static (SshClient SshClient, uint Port) ConnectSsh(string sshKeyFile = null, string sshPassPhrase = null)
        {
            string sshHostName = "zanhouse.biz.id";
            string sshUserName = "zanhouse";
            string sshPassword = "Sakuragawa19";
            int sshPort = 64000;
            string databaseServer = "localhost";
            int databasePort = 3306;
            // define the authentication methods to use (in order)
            var authenticationMethods = new List<AuthenticationMethod>();
            if (!string.IsNullOrEmpty(sshKeyFile))
            {
                authenticationMethods.Add(new PrivateKeyAuthenticationMethod(sshUserName,
                    new PrivateKeyFile(sshKeyFile, string.IsNullOrEmpty(sshPassPhrase) ? null : sshPassPhrase)));
            }
            if (!string.IsNullOrEmpty(sshPassword))
            {
                authenticationMethods.Add(new PasswordAuthenticationMethod(sshUserName, sshPassword));
            }

            // connect to the SSH server
            var sshClient = new SshClient(new ConnectionInfo(sshHostName, sshPort, sshUserName, authenticationMethods.ToArray()));
            sshClient.Connect();

            // forward a local port to the database server and port, using the SSH server
            var forwardedPort = new ForwardedPortLocal("127.0.0.1", databaseServer, (uint)databasePort);
            sshClient.AddForwardedPort(forwardedPort);
            forwardedPort.Start();

            return (sshClient, forwardedPort.BoundPort);
        }
    }
}
