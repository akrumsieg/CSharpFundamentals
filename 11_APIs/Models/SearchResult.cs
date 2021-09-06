using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs.Models
{
    public class SearchResult<T> //class must also have T type
    {
        public int Count { get; set; }
        public List<T> Results { get; set; } = new List<T>();
    }
}
