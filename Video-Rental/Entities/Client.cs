using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental.Entities
{
    [Serializable]
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }

        public Client() { }

        public Client(int clientId, string clientName, string phone)
        {
            ClientId = clientId;
            ClientName = clientName;
            Phone = phone;
        }
    }
}
