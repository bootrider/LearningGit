primerTermino=0
for i in range (999, 99,-1):
    if(i%11==0):
        primerTermino=i
        break

print(primerTermino)       

s = 0
i=-1
num = 1234
n=num
num_invertido=0
while  n > 0 :
    s = n % 10
    n = n // 10
    i+=1
print(i)
n=num
while  n > 0 :
    s = n % 10
    n = n // 10
    num_invertido+=s*10**i
    i-=1
print(num_invertido)






