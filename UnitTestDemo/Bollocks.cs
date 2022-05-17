using System;

namespace UnitTestDemo
{
    public class Bollocks
    {
        public int bollNum { get; set; }
        public string bollString { get; set; }

        // assigns values to properties
        public Bollocks(int bollNum, string bollString){
            throw new NotImplementedException("Bollocks.Constructor");
        }

        // method that returns bollNum summed with the parameter value
        public int AddTo(int n){
            throw new NotImplementedException("Bollocks.AddTo");
        } 
 
        // method that DIVIDES bollNum BY 
        // the parameter value and returns the dividend

        public int DivBy(int n){
            throw new NotImplementedException("Bollocks.DivBy");
        }
        // method that returns the modulud of dividing bollNum BY 
        // the parameter value
        public int ModOfDivBy(int n){
            throw new NotImplementedException("Bollocks.ModOfDivBy");
        }
    }
}
