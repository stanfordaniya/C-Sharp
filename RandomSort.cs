using System;

class Program {
  public static void Main (string[] args) {
    
    int [] array = new int [17];
    Random rnd = new Random();
    int total = 0;
    
    for(int i = 0; i < array.Length; i++){
      array[i] = rnd.Next(1,360);
    }
    
    Console.WriteLine ("[Random Sort]");
    
    
    while(check_if_sorted(array) == false){
       Console.WriteLine("\nPrinting array...");
          array = shuffleArray(array);
          total = total + 1;
          PrintArray(array);
      Console.WriteLine("Not sorted yet!");
     
      Console.Write(" ");
      Console.Write("\nShuffling array...\n");
      
    }
   
    
    Console.Write("\nHooray, it’s sorted! And it only took "+ total +" attempts!");
  
  }
  public static bool check_if_sorted(int[] x) {
    for(int i = 0; i < x.Length - 1; i++){
      if(x[i] > x[i + 1]){
        return false;
      }
      
    }
    return true;
  }
   public static int[] shuffleArray(int[] x) {
   Random random = new Random();
    int newSwap = x.Length;
     while (newSwap > 1){
       newSwap--;
       int nextSwap = random.Next(newSwap + 1);
       int newValue = x[nextSwap];
       x[nextSwap] = x[newSwap];
       x[newSwap] = newValue;
     }
     return x;
  }
   public static void PrintArray(int[] x) {
   for(int i = 0; i < x.Length; i++){
     Console.Write(x[i] + "," + " ");
   }
     Console.WriteLine(" ");
  }
}
