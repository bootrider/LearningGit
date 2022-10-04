"""
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?
"""
def determinar_primo_10001(tope):
    cont=2
    num=3
    while(cont<tope):
        num+=2
        if(isPrimo(num)):
            cont+=1 
    return num

def isPrimo(num):
    esPrimo= False
    cont=0
    for i in range(num-1,2,-1):
        if(num%i==0):#
            cont+=1
    if(cont==0):
        esPrimo= True
    return esPrimo

def main():
    print(determinar_primo_10001(10001))
main()