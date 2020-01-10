using System;
using System.Collections.Generic;
using System.Text;

namespace StatZScore
{
    public interface IFindZScore
    {
        public double ZScore(dynamic score, dynamic values);
    }
}
