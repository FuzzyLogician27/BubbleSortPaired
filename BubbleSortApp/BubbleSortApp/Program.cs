namespace BubbleSortApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[3] { 3, 2, 1 };
            BubbleSort(ref testArr);

            //NICECCCCCECECEC 

            foreach(int n in testArr)
            {
                Console.WriteLine(n);
            }
            
        }

        public static void BubbleSort(ref int[] arr)
        {
            int temp = 0;
            bool clean = false;

            while (clean == false)
            {

                //Lowest to highest BUBBLING
                clean = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[i];
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = arr[i + 1];
                        arr[i+1] = temp;
                        clean = false;
                    }
                        
                        
                }

            }

            

        }
    }
}