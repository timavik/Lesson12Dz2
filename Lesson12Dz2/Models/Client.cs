using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Dz2.Models
{
    public class Client
    {
        private string _name;

        public Client(string name)
        {
            _name = name;
        }

        public void ReceiveNews(string category, string message)
        {
            Console.WriteLine($"{_name} Получена новость из категории \"{category}\": {message}");
        }

        public void Subscribe(NewsProvider provider, string category)
        {
            provider.OnNewsUpdate += (cat, msg) =>
            {
                if (cat == category)
                {
                    ReceiveNews(cat, msg);
                }
            };
        }
    }

}
