Num1 = []
Num2 = []
Resultado = []

for i in range(0, 3):
    Num1.append(int(input(f"Ingrese número 1 [{i+1}]: ")))
print()
for i in range(0, 3):
    Num2.append(int(input(f"Ingrese número 2 [{i+1}]: ")))

print("\nEl resultado es: ")
for i in range(0, 3):
    Resultado.append(Num1[i]+Num2[i])
    print(f"[{i+1}]: {Resultado[i]}")