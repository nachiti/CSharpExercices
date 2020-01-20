﻿using System;
            return strings.Where(s => s.StartsWith(startCharacter) && s.StartsWith(endCharacter));
           
           /* IEnumerable<string> res = from s string in strings
                                      where s.startCharacter*/

            return numbers.Where( s => s > limit);


        }
                .GroupBy(f => Path.GetExtension(f.ToLower()).Replace(".", ""))
                .Select(f => new KeyValuePair<string, int>(f.Key, f.Distinct().Count()))
                .ToDictionary(x => x.Key, x => x.Value); 
       return 
             from p in purchases
             join it in items on p.ItemId equals it.Id
             join c in clients on p.ClientId equals c.Id

             select new Tuple<string, string, int, double>(c.Name,it.Label,p.Quantity,it.Price);
        }