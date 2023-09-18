using System.Collections.Generic;
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    int[] a = new int[]{1,2,2,3,4,4,5,4,3,2,1};
    List<int> b = new List<int>();
    
    
    for(int i = 0; i<a.Length; i++){
        if(!b.Contains(a[i]) )
        {
            b.Add(a[i]);
        }
        else{
            
        }
    }
    
    int[] c = b.ToArray();
    foreach(int item in b){
        Console.WriteLine( item);
    }
    
    for (int i = 0; i < c.Length; i++){
        Console.WriteLine(c[i]);
    }
    
  }
}
