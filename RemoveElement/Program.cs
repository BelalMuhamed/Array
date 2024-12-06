namespace RemoveElement
{
    internal class Program
    {
        public static  int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            if(nums.Length == 0) return 0;
            else
            {
                for(int i = 0; i < nums.Length; i++) 
                {
                    if (nums[i] != val) 
                    {
                        nums[k] = nums[i];
                        k++;
                    }
                    
                }
               return  k;
            }
        }
        static void Main(string[] args)
        {
            int[] arra = { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine(RemoveElement(arra,2));
        }
    }
}
