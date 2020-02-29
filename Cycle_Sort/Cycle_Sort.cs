// C# program for cycle sort 
using System; 
  
class CycleSort { 
      
    // Function to implement Cycle sort 
    public static void cycleSort(int[] arr, int n) 
    {
        int writes = 0; 
        // traverse through array elements and find the right position  
        for (int cycle_start = 0; cycle_start <= n - 2; cycle_start++) 
        {  
            int item = arr[cycle_start]; 
            int pos = cycle_start; 
            for (int i = cycle_start + 1; i < n; i++) 
                if (arr[i] < item) 
                    pos++; 
                    
            if (pos == cycle_start) 
                continue; 
  
            while (item == arr[pos]) 
                pos += 1; 
  
            if (pos != cycle_start) { 
                int temp = item; 
                item = arr[pos]; 
                arr[pos] = temp; 
                writes++; 
            } 
  
            while (pos != cycle_start) { 
                pos = cycle_start; 
   
                for (int i = cycle_start + 1; i < n; i++) 
                    if (arr[i] < item) 
                        pos += 1; 
  
                while (item == arr[pos]) 
                    pos += 1; 
  
                if (item != arr[pos]) { 
                    int temp = item; 
                    item = arr[pos]; 
                    arr[pos] = temp; 
                    writes++; 
                } 
            } 
        } 
    } 
  
    public static void Main() 
    { 
        int[] arr = { 123, 2238, 23, 30, 320, 1424, 322, 234 }; 
        int n = arr.Length; 
          
        cycleSort(arr, n); 
  
        Console.Write("After sorting  : "); 
        for (int i = 0; i < n; i++) 
            Console.Write(arr[i] + " "); 
    } 
} 
////OUTPUT
///After sorting  : 23 30 123 234 320 322 1424 2238
