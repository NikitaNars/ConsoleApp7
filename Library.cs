using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        public List<T> List { get; set; }
       
        public Library()
        {
           List = new List<T>();
        }   

        public void Add(T item)
        {
            if (List.Any(x => x.Title.Equals(item.Title, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Элемент с таким названием уже существует");
                
            }
            List.Add(item);
        }
        public bool Remove(T item)
        {
            if (!List.Any(x => x.Title.Equals(item.Title, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Элемент с таким названием не существует");

            }
            if (List.Remove(item)) return true;
            return false;
        }
        public IEnumerable<T> FilterByYear(int year)
        {
            return List.Where(x => x.YearPublished > year);
        }
        public void Print()
        {
            foreach (var item in List)
            {
                Console.WriteLine(item.Title);
            }
        }

        public T FindByTitle(string title)
        {
            if (!List.Any(x => x.Title.Equals(title, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Элемент с таким названием не существует");

            }
            return List.FirstOrDefault(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<T> GetAllAvailable()
        {
           return List.Where(x => x.IsAvailable == true);
        }

       
    }
}
