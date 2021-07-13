using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingTask
{
    /// <summary>
    /// A class used for storing information about triplets present in the input file
    /// </summary>
    class Triplet
    {
        //Left connection of the triplet
        public string Left { get; set; }
        //Part of the message carried by a triplet
        public string Message { get; set; }
        //Right connection of the triplet
        public string Right { get; set; }

        public Triplet(string left, string message, string right)
        {
            this.Left = left;
            this.Message = message;
            this.Right = right;   
        }
    }
}
