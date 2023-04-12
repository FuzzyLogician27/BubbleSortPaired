namespace BubbleSortApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArr1 = new int[3] { 1, 2, 5 };
            //BubbleSort(ref testArr);

            //NICECCCCCECECEC 

            

            int[] testArr2 = new int[3] { 2, 4, 6 };

            int[] outputArr = new int[6];
            outputArr = PreludeMergeSort(testArr1, testArr2);
            foreach (int n in outputArr)
            {
                Console.WriteLine(n);
            }

        }

        public static void BubbleSort(ref int[] arr)
        {
            int temp = 0;
            bool clean = true;
            do
            {
                clean = true;
                //Lowest to highest BUBBLING
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[i];
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        clean = false;
                    }
                }

            } while (clean == false);
        }


        public static int[] PreludeMergeSort(int[] arr1, int[] arr2)
        {
            if(arr1 == null || arr2 == null)
            {
                throw new ArgumentException("This method needs two arrays");
            }
            if((arr1.Length + arr2.Length) == 0)
            {
                return new int[] { };
            }

            int[] mergedArray = new int[(arr1.Length + arr2.Length)];

            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < mergedArray.Length; i++)
            {
                if (index1 <= arr1.Length - 1 && arr1[index1] <= arr2[index2])
                {
                    mergedArray[i] = arr1[index1];
                    index1++;

                }
                else if (index2 <= arr2.Length - 1)
                {
                    mergedArray[i] = arr2[index2];
                    index2++;
                }
            }


            return mergedArray;
        }


    }
}