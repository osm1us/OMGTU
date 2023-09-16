l = 7
n = 5
m = 10
s = 0
print('For')
for k in range(1,21):
    s = s + 2*(l + k*m + n)
    if k == 1 or k == 2 or k == 3 or k == 20:
        print(k, s)
print('Formula')
def f(k):
    return 2*(k*l + k*(m+n) + (((k-1)*k)/2)*m)
print(f(1),f(2),f(3),f(20))

