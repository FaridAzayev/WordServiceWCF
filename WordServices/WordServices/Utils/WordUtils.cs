using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordServices.Utils
{
    public class WordUtils{
        public static string Reverser(string initial){
            return String.Join("", initial.ToCharArray().Reverse());
        }
    }
}