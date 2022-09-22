num=600851475143
i=2
while(num>i):
    if(num%i!=0):
        i+=1
    else:
        num=num/i
        i=2
print (num)