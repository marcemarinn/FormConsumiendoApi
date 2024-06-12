using System.Net.Http;
using System.Threading.Tasks;
using System;
using WindowsFormsApp1.Models;
using Newtonsoft.Json;

namespace WindowsFormsApp1.Controllers
{
    public class CharacterController
    {
        private HttpClient client;
        public CharacterController()
        {
            client = new HttpClient();
        }

    }
}
