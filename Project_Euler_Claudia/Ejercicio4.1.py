
def invertir_numero(num):
    return int((str(num)[::-1]))

def revisar_palidromo(num):
    if(num==invertir_numero(num)):
        return True
    return False
    
def determinar_palindromo():
    pal_mayor=0
    for i in range (1000):
        for j in range (1000):
            num=i*j
            if(revisar_palidromo(num)):
                if(pal_mayor<num):
                    pal_mayor=num
    return pal_mayor
             
def main():
    print(determinar_palindromo())
main()
