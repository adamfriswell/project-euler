using System;
using System.Collections.Generic;

namespace project_euler.Helpers {
    public class ListHelper {
        public string ListItems (List<long> list) {
            string output = "";
            foreach (var i in list) {
                output += i + ", ";
            }
            return output.Substring (0, output.Length - 2);;
        }
    }
}