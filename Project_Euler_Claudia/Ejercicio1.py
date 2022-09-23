"""Ejercicio que suma los multiplos de 3 o de 5 hasta el 1000
   Este ejercicio puede ser modificado para cualquer multiplos 
   cualquier"""
def is_multiplo(num, multiplo):
    esMultiplo=False
    if(num%multiplo==0):
        esMultiplo=True
    return esMultiplo

def sumarMultiplos(tope):
    suma=0
    for i in range (tope):
        if(is_multiplo(i,3) or is_multiplo(i,5)):
            suma+=i
    return suma

def main():
    print(sumarMultiplos(1000))

main()
