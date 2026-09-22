# Crea una matriz nxm (dimensiones dadas por el usuario) llena de ceros.
n = int(input("Ingrese la cantidad de filas: "))
m = int(input("Ingrese la cantidad de columnas: "))

matriz = []

for f in range(n):
    matriz.append([])
    for c in range(m):
        matriz[f].append(0)
        print(matriz[f][c], end=" ")
    print()