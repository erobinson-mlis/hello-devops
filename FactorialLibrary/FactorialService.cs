namespace FactorialLibrary;

public class FactorialService
{
    public static int Factorial(int n) {

        if(n<0) {
            throw new InvalidOperationException("Negative numbers do not have a factorial.");
        }

        if(n==0 || n==1) { //   0! = 1,  1! = 1
            return 1;
        }
        
        return n * Factorial(n-1); // e.g., 5! = 5 * 4!
    }

}
