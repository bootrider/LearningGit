int main(){
    int suma=0;
    for(int i=0; i<10 ; i++){
        if(i%3==0 || i%5==0)
            suma+=i;
    }
    printf("%d",suma);
    return 0;
}