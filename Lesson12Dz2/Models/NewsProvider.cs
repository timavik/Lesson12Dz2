using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Dz2.Models
{

    public delegate void NewsUpdate(string category, string message);

    public class NewsProvider
    {
        public event NewsUpdate OnNewsUpdate;

        public void PublishNews(string category, string message)
        {
            Console.WriteLine($"NewsProvider Опубликована новость в категории \"{category}\": {message}");

            OnNewsUpdate?.Invoke(category, message);
        }
    }
}
