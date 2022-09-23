def invertir_numero(num):
    return int((str(num)[::-1]))

def revisar_palidromo(num):
    if(num==invertir_numero(num)):
        return True
    return False
    
def determinar_mult_11():
    i=999
    while(i%11!=0 and i>99):
        i-=1
    return i

def hallar_num_pal(primer_digito):
    i=999
    while(True):
        num= primer_digito*i
        print(num)
        if(revisar_palidromo(num)):
            return num
        i-=1

def main():
    primer_digito= determinar_mult_11()
    print(hallar_num_pal(primer_digito))
main()
