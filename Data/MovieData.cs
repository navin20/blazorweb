using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorweb.Data
{
    public class MovieData
    {
        public string moviename {get; set;}
        public string review {get;set;}
        public string description {get;set;}
        public DateOnly date {get;set;}
        public TimeOnly start_time {get;set;}
         public TimeOnly end_time {get;set;}

    }
}