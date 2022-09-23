"""En python estructurado 
   Ejercicio que suma los multiplos de 3 o de 5 hasta el 1000"""

suma=0
for i in range (1000):
    if(i%3==0 or i%5==0):
        suma+=i
print (suma)