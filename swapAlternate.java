public class Main
{
	public static void main(String[] args) {
	    int array[] = {2,3,4,5,6,7,8,9,11,12,13,14,15,16,17,18,19,20,21, 22};
	    
	    for (int i = 0; i<array.length; i++)
	    {
	        int temp = array[i];
	        int temp1 = array[i+1];
	        
	        array[i] = array[i+2];
	        array[i+1] = array[i+3];
	        
	        array[i+2] = temp;
	        array[i+3] = temp1;
	        
	        i=i+3;
	    }
	    
	    for (int i = 0; i<array.length; i++)
	    {
	        System.out.print(array[i] + " ");
	    }
		
	}
}
