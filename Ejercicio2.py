"""En python sin funciones, 
Suma los terminos pares de la serie de fibo, tope: 4 millones"""
suma_fibo_par=2
i=1
j=2
suma=0
while(i<4000000):
    suma=i+j;
    i=j
    j=suma
    print(suma)
    if(suma%2==0):
        print("suma es par",suma)
        suma_fibo_par+=suma
print ("fibo suma= ", suma_fibo_par)