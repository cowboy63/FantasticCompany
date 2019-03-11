using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace SGE
{
    namespace Entity
    {
        public class EntityFlags : MonoBehaviour, IEnumerable<string>, IEnumerable
        {
            [SerializeField]
            protected HashSet<string> flag = new HashSet<string>();
            [SerializeField]
            protected string[] initializer;
            void Awake()
            {
                foreach (string s in initializer)
                    flag.Add(s);
            }
            public string[] Flags
            {
                get { return flag.ToArray<string>(); }
            }
            public IEnumerator<string> GetEnumerator()
            {
                foreach (string s in flag)
                    yield return s;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                foreach (string s in flag)
                    yield return s;
            }
            public bool ContainsFlag(string flag)
            {
                return this.flag.Contains(flag);
            }
            public bool AddFlag(string flag)
            {
                return this.flag.Add(flag);
            }
            public bool RemoveFlag(string flag)
            {
                return this.flag.Remove(flag);
            }
            public void ClearFlags()
            {
                flag.Clear();
            }
            public bool AddAllFlags(IEnumerable<string> flags)
            {
                bool r = false;
                foreach (string s in flags)
                    r |= flag.Add(s);
                return r;
            }
            public bool RemoveAllFlags(IEnumerable<string> flags)
            {
                bool r = false;
                foreach (string s in flags)
                    r |= flag.Remove(s);
                return r;
            }
        }
    }
}
