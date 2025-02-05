using Lesson12Dz2.Models;

namespace Lesson12Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();

            Client client1 = new Client("Александр");
            Client client2 = new Client("Артур");
            Client client3 = new Client("Мария");
            
            client1.Subscribe(newsProvider, "новости");
            client2.Subscribe(newsProvider, "юмор");
            client3.Subscribe(newsProvider, "спорт");
            client3.Subscribe(newsProvider, "погода");
            client3.Subscribe(newsProvider, "проишествия");
            
            newsProvider.PublishNews("новости", "Новые новости новости.");
            newsProvider.PublishNews("спорт", "Сегодня полуфинал в 18:00.");
            newsProvider.PublishNews("погода", "прогноз погоды на сегодня.");
            newsProvider.PublishNews("проишествия", "Крупная авария на улице пушкина.");
            newsProvider.PublishNews("юмор", "Колобок повесиля.");

            Console.ReadLine();
        }
    }
}
