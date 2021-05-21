using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WareHouse.AppResources;
using WareHouse.Entities;
using WareHouse.Enums;
using WareHouse.Exceptions;

namespace WareHouse.Managers
{
    public class ClientManager
    {
        public const string ClientPath = "Client.json";

        /// <summary>
        /// List of clients.
        /// </summary>
        private static List<Client> Clients { get; }

        static ClientManager()
        {
            Clients = new List<Client>();
        }


        /// <summary>
        /// Add new client to collection.
        /// </summary>
        /// <param name="client">New client.</param>
        public static void Add(Client client)
        {
            if (NameContains(client)) throw new CustomDataException(ApplicationStrings.ClientExistException, 400);

            Clients.Add(client);
        }

        /// <summary>
        /// Remove client from collection.
        /// </summary>
        /// <param name="client">Deleting client.</param>
        public static void Remove(Client client)
        {
            Clients.Remove(client);
        }

        /// <summary>
        /// Get client by login and password.
        /// </summary>
        /// <param name="userName">Client userName.</param>
        /// <param name="password">Client password.</param>
        /// <param name="loginType">Client login type.</param>
        /// <returns>Certain product.</returns>
        public static Client GetByPassword(string userName, string password, Login loginType)
        {
            if (!Clients.Any(client => client.CompareData(userName, password, loginType))) throw new KeyNotFoundException(ApplicationStrings.ClientGetException);

            Client tempClient;

            try
            {
                tempClient = new Client {Login = userName, Password = password, LoginType = loginType};
            }
            catch
            {
                tempClient = new Client {Email = userName, Password = password, LoginType = loginType};
            }

            return Clients.First(client => client.Equals(tempClient));
        }

        public static Client GetByName(string userName)
        {
            if (!Clients.Any(client => client.Email.Equals(userName) || client.Login.Equals(userName))) throw new KeyNotFoundException(ApplicationStrings.ClientGetException);

            return Clients.First(client => client.Email.Equals(userName) || client.Login.Equals(userName));
        }

        public static Client Get(Client client)
        {
            if (!NameContains(client)) throw new KeyNotFoundException(ApplicationStrings.ClientGetException);

            return Clients.First(other => other.Equals(client));
        }

        /// <summary>
        /// Check if client with this login and email exist.
        /// </summary>
        /// <param name="client">Client to find.</param>
        /// <returns>Result of checking.</returns>
        public static bool NameContains(Client client)
        {
            return Clients.Any(sect => sect.Equals(client));
        }

        /// <summary>
        /// Get copy of clients collection.
        /// </summary>
        /// <returns>Clients.</returns>
        public static List<Client> GetClients()
        {
            return Clients.ToList();
        }

        public static bool ClientExists(Client client, string newLogin, string newEmail)
        {
            var tempClient = new Client {Email = newEmail, Login = newLogin, LoginType = client.LoginType};
            return Clients.Any(other => !client.Equals(tempClient) && other.Equals(tempClient));
        }

        /// <summary>
        /// Save data.
        /// </summary>
        public static void Save(string folderName)
        {
            try
            {
                var serializer = new JsonSerializer {Formatting = Formatting.Indented};

                using (var fileStream = new FileStream(
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, ClientPath),
                    FileMode.Create))
                {
                    using (var stream = new StreamWriter(fileStream))
                    {
                        using (var writer = new JsonTextWriter(stream))
                        {
                            serializer.Serialize(writer, Clients);
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Load data.
        /// </summary>
        public static void Load(string folderName)
        {
            try
            {
                var deserializer = new JsonSerializer {Formatting = Formatting.Indented};
                using (var fileStream = new FileStream(
                    Path.Combine(Manager.AppPath, folderName, Manager.DataPath, ClientPath),
                    FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (var stream = new StreamReader(fileStream))
                    {
                        using (var reader = new JsonTextReader(stream))
                        {
                            var tempClients = deserializer.Deserialize<List<Client>>(reader);

                            if (tempClients == null) return;


                            foreach (var client in tempClients)
                                try
                                {
                                    Add(client);
                                }
                                catch
                                {
                                    // ignored
                                }
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }
        }


        /// <summary>
        /// Remove all data.
        /// </summary>
        public static void Clear()
        {
            Clients.Clear();
        }
    }
}