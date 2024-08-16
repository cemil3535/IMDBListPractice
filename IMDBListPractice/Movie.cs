using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBListPractice
{
    // Movie class created
    public class Movie
    {
        // property created
        public string MovieName {  get; set; }
        public double imdbScore { get; set; }

        public override string ToString()
        {
            return MovieName;
        }



    }
}
