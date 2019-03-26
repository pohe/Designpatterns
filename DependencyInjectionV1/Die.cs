using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionV1
{
    public class Die
    {
        private int _faceValue;
        private int _noOfSides;
        private static Random _random = new Random();

        public Die(int noOfSides)
        {
            _noOfSides = noOfSides;
            Roll();
        }

        public int FaceValue
        {
            get { return _faceValue; }
        }

        public void Roll()
        {
            _faceValue = _random.Next(0, _noOfSides) + 1;
        }
    }

}
