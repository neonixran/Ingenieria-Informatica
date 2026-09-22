# Imprimir las columas verticalmente
matriz = []
longitud = 2

for f in range(longitud):
    matriz.append([])
    for c in range(longitud):
        dato = int(input(f"Ingrese un número {f}.{c}: "))
        matriz[f].append(dato)

for f in range(len(matriz)):
    for c in range(len(matriz[f])):
        print(matriz[c][f], end=" ")
    print()

print()
print(matriz)