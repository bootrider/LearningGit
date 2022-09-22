public class SumaNumeros{
    public static void Main(){
        int suma=0;
        for(int i=0; i<10 ; i++){
            if(i%3==0 || i%5==0)
                suma+=i;
        }
        System.Console.WriteLine(suma);
    }
}