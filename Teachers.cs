using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MidTermExam
{
    class Teachers:CollectionBase
    {
        public void add(Teacher tea)
        {
            List.Add(tea);
        }

        public Teacher this[int index]
        {
            get { return (Teacher)List[index]; }
            set { List[index] = value; }
        }
    }
}
