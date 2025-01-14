using System.Collections;

namespace Assignment
{
    internal class Program
    {



        #region Q1 Functions

        static void Swap<T>(ref T x, ref T y)
        {

            T Temp = y;
            y = x;
            x= Temp;
        }

        static void BubbleSort<T>(T[]arr) where T:IComparable<T>
        {


            bool swapped=false;



            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < arr.Length - i-1; j++)
                {

                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        swapped=true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }


                if(!swapped)
                    break;

               
            }



        }


        #endregion




        #region Q3 Function
        static void Reverse(ArrayList arr)
        {

            int s = 1;


            for (int i = 0; i < arr.Count / 2; i++)
            {


                object temp = arr[arr.Count - s];
                arr[arr.Count - s] = arr[i];
                arr[i] = temp;
                ++s;


            }

        }


        #endregion



        #region Q6 Function


        public static int GetFirstNotRepeated(string s)
        {

            Dictionary<char, int> counts = new Dictionary<char, int>();


            for (int i = 0; i < s.Length; i++)
            {

                if (counts.ContainsKey(s[i]))
                    counts[s[i]]++;

                else
                    counts[s[i]] = 1; ;
            }


            for (int i = 0;i < s.Length; i++)
            {

                if (counts[s[i]]==1)
                    return i;
            }


            return -1;

        }
        #endregion






        static void Main(string[] args)
        {

            #region Q1

            //int[] arr = { 4, 1, -1, 6, 7, 3, 4, 5 };

            //BubbleSort<int>(arr);


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+" ");  
            //}

            #endregion


            #region Q2

            //range<int> x = new range<int>(10, 30);


            //Console.WriteLine(x.IsInRange(10));
            //Console.WriteLine(x.IsInRange(15));

            #endregion



            #region Q3


            //ArrayList arr=new ArrayList() { 1,2,3,4,5,6};


            //Reverse(arr);


            //for (int i = 0;i < arr.Count; i++)
            //{

            //    Console.Write(arr[i]+" ");
            //}


            #endregion



            #region Q4


            //List<int> IntList=new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12};

            //List<int> EvenList = new List<int>();



            //foreach(int i in IntList)
            //{

            //    if(i%2==0)
            //        EvenList.Add(i);

            //}


            //foreach(int x in EvenList)
            //    Console.Write(x+" ");

            #endregion


            #region Q5


            //FixedSizeList<int> ls = new FixedSizeList<int>(5);

            //ls.Add(5);
            //ls.Add(6);
            //ls.Add(7);
            //ls.Add(8);
            //ls.Add(9);

            //try
            //{

            //ls.Add(10);
            //}

            //catch(Exception e) 
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine(e.Message);
            //    Console.ForegroundColor =ConsoleColor.White;
            //}

            //for(int i = 0; i<ls.size; i++)
            //{

            //    Console.WriteLine(ls[i]);
            //}

            #endregion



            #region Q6


            //string S = "aaabbbnwerdd";
            //Console.WriteLine(GetFirstNotRepeated(S));


            #endregion
        }
    }
}
