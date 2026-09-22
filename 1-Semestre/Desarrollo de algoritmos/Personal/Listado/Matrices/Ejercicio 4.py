# Calcular el promedio de filas de una matriz
matriz = [
    [1, 2, 3],
    [4, 5, 6]
]
promedio = []

for f in range(len(matriz)):
    suma = 0
    for c in range(len(matriz[f])):
        suma += matriz[f][c]
    prom = suma / len(matriz[f])
    promedio.append(prom)

print(promedio)