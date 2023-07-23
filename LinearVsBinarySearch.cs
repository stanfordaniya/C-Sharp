using System;

class Program
{
    public static void Main(string[] args)
    {
      int target;
     int [] array = new int [1000019];
        int num = 1000018;
      Random rnd = new Random();
      
      for(int i=0; i < array.Length; i++){
        array[i] = num;
        num--;
      }
     target = rnd.Next(1000019);
      
      int index = LinearSearch(array, target);
      int point = BinarySearch(array, target);

    
        Console.WriteLine("[Linear Vs. Binary Search]");
       Console.WriteLine("The target value is "+ target );
       Console.WriteLine("Linear Search: " + index +" loop(s)");
       Console.WriteLine("Binary Search: "+ point + " guess(es)");

      if(index > point){
         Console.Write("Linear Search is faster this time!");
      }
      else if (point > index){
         Console.Write("Binary Search is faster this time!");
      }
      else{
        Console.Write("It's a Tie!");
      }
     
      
    }
    public static int LinearSearch(int[] arr, int x)
    {
      int counter = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
              counter++;
        }
      return counter;
    }
    public static int BinarySearch(int[] arr, int x)
    {
      int counter = 0;
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
            {
              
                return counter;
            }
            else if (arr[mid] < x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
          counter++;
        }
        return counter;
    }
}
