{
    class ins
    {
        public static void Main()
        {   
            int i;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<n;i++)
            {
                if(arr[i]%2==0)
                {
                    Console.WriteLine(arr[i]+" is a even number.");
                }
                else
                {
                    Console.WriteLine(arr[i]+" is a odd number.");
                }
            }
        }
    }
}
