using TheSurvivors.Domain.Context;

namespace TheSurvivors
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public string ConnectionString { get; }

        public ConnectionStringProvider(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
