decimal = int(input("Ingrese un número: "))
binario = []
resto = 0

while decimal > 0:
    resto = decimal % 2 # Obtiene el resto usando el módulo (Ej. 17 % 2 == 1)
    binario.append(resto)
    decimal = decimal // 2 # Divide y redondea el resultado hacia abajo

binario = "".join(map(str, binario[::-1]))
print(binario)