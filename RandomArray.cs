using System;

class Program {
   public static void random_arr(int arr[,]) {
       Console.WriteLine("Random Array: ");
       for (int i = 0; i < arr.length; i++) {
           arr[i] = (int) Math.floor(Math.random() * (500 + 500) - 500 );
           Console.WriteLine(arr[i] + ", ");
       }
   }
   public static boolean isSorted(int arr[,]) {
       for (int i = 0; i < arr.length - 1; i++) {
           if (arr[i] > arr[i + 1])
               return false;
       }
       return true;
   }
   public static void sortArr(int arr[,])
   {
       int n = arr.length;


       
       for (int i = 0; i < n; i++)
       {
          
           int min_idx = i;
           for (int j = i+1; j < n; j++)
               if (arr[j] < arr[min_idx])
                   min_idx = j;


           
           int temp = arr[min_idx];
           arr[min_idx] = arr[i];
           arr[i] = temp;
           Console.WriteLine(arr[i] + ", ");
       } 
   }

   public static void main(String[] args) {
     
     int userChoice = 0;
     Console.WriteLine("[Is It Sorted?]");
     int arr[] = new int[10];
     random_arr(arr);
     Console.WriteLine();
     do
     {
       Console.WriteLine("\nWhat do you want to do?\n" +
               "1) Generate a new random array\n" +
               "2) Is the array sorted?\n" +
               "3) Sort the array\n" +
               "4) Quit\n" +
               "\nChoice: ");
               userChoice = Convert.ToInt32(Console.ReadLine());
               switch (userChoice) {
                   case 1:
                       Console.WriteLine();
                       random_arr(arr) ;
                   Console.WriteLine();
                   break;
                   case 2:
                       if (!isSorted(arr)) {
                           Console.WriteLine("\nThe array is not sorted.");
                       }
                       else {
                           Console.WriteLine("\nThe array is sorted.");
                       }
                       break;
                   case 3:
                       Console.WriteLine("Sorted Array: "); sortArr(arr);
                       break;
               }
     }
     while(userChoice != 4);
   }


}
