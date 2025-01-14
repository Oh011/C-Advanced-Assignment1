using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {

        T[] Items;
        readonly int Capacity;
        int Size;


        public int size
        {

            get { return this.Size; }

        }


        public T this[int index]
        {


            get { 
            

                if(index>=0 && index<Capacity) 
                    return Items[index];


                throw new Exception("out of range");
            }


            set
            {

                if (index < 0 && index>=Capacity)
                    throw new Exception("out of range");


                Items[index] = value;


            }

        }




        public FixedSizeList():this(10)
        {


        }


        public FixedSizeList(int c)
        {

            this.Capacity = c;
            this.Size = 0;
            Items=new T[Capacity];
        }

        public void Add(T val)
        {

            if (Size < Capacity)
            {

                Items[Size++] = val;
                return;
            }


            throw new Exception("List is Full");



        }


    }
}
