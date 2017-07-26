using Newtonsoft.Json;
using System;
using System.Collections.Generic;

//json object
// var person = {
// id : 1,
// name : "rinesh",
// interest :[101,"games"],
// experiance : 1,
// visited : {
//   state : "kl",
//   place : "kannur"
// }
//}


namespace JsonObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                id = 1,
                experiance = 2,
                interest = new List<object> { 101, "games" },
                name = "Rinesh",
                visited = new Visisted
                {
                    place = "kannur",
                    state = "kl"
                }

            };
            var value = JsonConvert.SerializeObject(person);
            Console.WriteLine(value);
            var deser = JsonConvert.DeserializeObject<Person>(value);
            Console.WriteLine(deser.name);
        }
    }

    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> interest { get; set; }
        public int experiance { get; set; }
        public Visisted visited { get; set; }
    }
    public class Visisted
    {
        public string state { get; set; }
        public string place { get; set; }
    }


}
