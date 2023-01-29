using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MidTermExam
{
    class Students:CollectionBase
    {
        public void add(Student stu)
        {
            List.Add(stu);
        }

        public Student this[int index]
        {
            get { return (Student)List[index]; }
            set { List[index] = value; }
        }
    }
}
