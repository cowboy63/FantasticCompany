using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using SGE.Util.Proc;

namespace JGE.Character.Proc
{
    public static class NameProvider
    {
        /// <summary>
        /// Returns a name selected from an existing pool of names. Returns null if there is no valid pool provided.
        /// Paramterizes with:
        ///     POOL as a List of strings for unweighted name selection
        ///     (Optional) SEED an int for the seed of the RNG
        /// </summary>
        public static readonly ParamaterizedProvider<string> PoolSelector = (x) =>
        {
            Random r = new Random();
            if (x.ContainsKey("SEED") && x["SEED"] is int)
                r = new Random((int)x["SEED"]);
            if (x.ContainsKey("POOL"))
            {
                object obj = x["POOL"];
                if (obj is List<string>)
                {
                    List<string> l = (List<string>)obj;
                    return l[r.Next(l.Count)];
                }
                else return null;
            }
            else return null;
        };
    }
}
