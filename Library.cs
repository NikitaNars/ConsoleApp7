using System;
using System.Collections.Generic;
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
            List.Add(item);
        }
        public bool Remove(T item)
        {
            if (List.Remove(item)) return true;
            return false;
        }
        public IEnumerable<T> FilterByYear(int year)
        {
            return List.Where(x => x.YearPublished > year);
        }

        public T FindByTitle(string title)
        {
            return List.FirstOrDefault(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<T> GetAllAvailable()
        {
           return List.Where(x => x.IsAvailable == true);
        }

       
    }
}
