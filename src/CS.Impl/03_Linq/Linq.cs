using System;using System.Collections.Generic;using System.IO;using System.Linq;namespace CS.Impl._03_Linq{    public class Linq    {        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(            string startCharacter, string endCharacter, IEnumerable<string> strings)        {
            return strings.Where(s => s.StartsWith(startCharacter) && s.StartsWith(endCharacter));
           
           /* IEnumerable<string> res = from s string in strings
                                      where s.startCharacter*//*                          List<string> res = new List<string>();                       foreach (var v in strings)            {                string start = v.Substring(0, 1);                string end=v.Substring(v.Length - 1, 1);                if ((start.Equals( startCharacter)) && (end.Equals(endCharacter)))                {                                    res.Add(v);                }            }            return res;*/        }        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)        {

            return numbers.Where( s => s > limit);
           /* List<int> res = new List<int>();            foreach(int v in numbers)            {                if (v > limit)                {                    res.Add(v);                }            }            return res;*/        }        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)        {            //prendere les "limit" number premier de tableau            return numbers.OrderByDescending(number => number).Take(limit);

        }        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)        {            return files
                .GroupBy(f => Path.GetExtension(f.ToLower()).Replace(".", ""))
                .Select(f => new KeyValuePair<string, int>(f.Key, f.Distinct().Count()))
                .ToDictionary(x => x.Key, x => x.Value);         }        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)        {
       return 
             from p in purchases
             join it in items on p.ItemId equals it.Id
             join c in clients on p.ClientId equals c.Id

             select new Tuple<string, string, int, double>(c.Name,it.Label,p.Quantity,it.Price);
        }    }    public class Item    {        public int Id { get; set; }        public string Label { get; set; }        public double Price { get; set; }    }    public class Purchase    {        public int ItemId { get; set; }        public int Quantity { get; set; }        public int ClientId { get; set; }    }    public class Client    {        public int Id { get; set; }        public string Name { get; set; }    }}