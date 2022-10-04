"""
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
"""
def calcular_sumatoria_dig(inicio, final):
    #mediante la formula de gaus
    suma=(inicio+final)*(final/2)
    return suma

def hallar_raices(inicio,final):
    #mediante formula
    suma_cuadrados= (final*(final+1)*(2*final+1))/6  
    return suma_cuadrados

def  calcular_diferencia(i,f):
    s=calcular_sumatoria_dig(i, f)
    r=hallar_raices(i,f)
    dif= (s**2)-r
    return dif

def main():
    print(calcular_diferencia(1,100))

main()
