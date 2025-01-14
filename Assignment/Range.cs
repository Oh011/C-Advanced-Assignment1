using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class range<T> where T:IComparable<T>
    {


        private T ?low;
        private T ?high;


        public T Low
        {

            get { return low; }

            set {


                if (value.CompareTo(high) < 0)
                    low = value;

                else
                    throw new Exception("Invalid value");
                    
                    
              ; }
        }


        public T High
        {

            get { return high; }


            set
            {

                if (value.CompareTo(low) > 0)
                    high = value;

                else
                    throw new Exception("Invalid value");
            }
        }


        public range():this(default,default)
        {

        }

        public range(T l, T h)
        {

            this.low = l;
            this.high = h;
        }


      public bool IsInRange(T val)
        {

            int v1 = val.CompareTo(low);
            int v2 = val.CompareTo(high);

            if ((v1==0 || v1>0) && (v2==0 || v2<0))
                return true;



            return false;

           

            
        }
    }
}
