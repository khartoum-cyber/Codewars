using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyBallBearings
{
    internal class UserSolution
    {
        public static Bearing IdentifyBb(Bearing[] bearings, Func<IEnumerable<Bearing>, long> weigh)
        {
            List<Bearing> newList = new List<Bearing>();
            for (int i = 0; i < bearings.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    newList.Add(bearings[i]);
                }
            }
            return bearings[weigh(newList) - newList.Count * 10 - 1];
        }
    }
}
