"""
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
"""
def dividir_num():
    bandera=True
    num=20
    while(bandera):
        bandera=False
        for i in range (1,21):
            if(num%i!=0):
                num+=1
                bandera=True
                break
    return num

def main():
    print(dividir_num())
main()
            