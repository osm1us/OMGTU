with open('input_s1_01.txt', mode='rt') as file:
    inp = file.readline().split()
    X, Y, L, C1, C2, C3, C4, C5, C6 = [int(_) for _ in inp]
i = 0
itog = 0
P = (X + Y) * 2
if (L > P):
    i = L - P
    P = 0
else:
    P -= L
if (C1 > C2 + C3):
    itog += (C2 + C3) * (L-i)
    L = 0
else:
    itog += C1 * max(X, Y)
    L -= max(X, Y)

if (L < min(X, Y)):
    itog += C1 * L
    L = 0
itog += (C2 + C3) * (L - i)
itog += P * (C4 + C5)
itog += i * (C2+C6)
print(itog)