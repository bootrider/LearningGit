package Project_Euler_Claudia;
public class SumaMultiplo{
    public static void main(String []args){
        int suma=0;
        for(int i=0; i<1000 ; i++){
            if(i%3==0 || i%5==0)
                suma+=i;
        }
        System.out.println(suma);
    }
}