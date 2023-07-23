using System;

class Program
{
    public static void Main(string[] args)
    {
        int size, height, width;
        Console.WriteLine("[Image Encoding Checker]");
        Console.Write("What is the image width? ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the image height? ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the file size (in bytes)? ");
        size = Convert.ToInt32(Console.ReadLine());

        int totalpixels, totalbytesperpixal, bytesperchannel, bitsperchannel;
        totalpixels = width * height;
        totalbytesperpixal = size / totalpixels;
        bytesperchannel = totalbytesperpixal / 3;
        bitsperchannel = bytesperchannel * 8;
        switch (bitsperchannel)
        {

            case 8:
                Console.WriteLine("\nThe RGB image is encoded with 8 bits per channel.");
                break;

            case 16:
                Console.WriteLine("\nThe RGB image is encoded with 16 bits per channel.");
                break;
        case 32:
          Console.WriteLine("\nThe RGB image is encoded with 32 bits per channel.");
          break;

      default:
        Console.WriteLine("\nThe information is invalid – please re-enter it.");
          break;

        

      }


    }
}
