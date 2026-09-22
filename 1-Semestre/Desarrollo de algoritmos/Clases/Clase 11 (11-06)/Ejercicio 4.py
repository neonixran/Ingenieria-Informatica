# Mutiplicar un arreglo por una matriz, recorrerla al revés e imprimirla
import random

arreglo = []
matriz = []

longitud =  4

for f in range(longitud):
    matriz.append([])
    for c in range(longitud):
        matriz[f].append(random.randint(1, 50))

for i in range(longitud):
    arreglo.append(random.randint(1, 10))

print(f"Matriz base: {matriz}")

for f in range(len(matriz), 0, -1):
    for c in range(len(matriz[f-1]), 0, -1):
        matriz[f-1][c-1] *= arreglo[c-1]

print(f"Arreglo: {arreglo}\n")
print(f"Matriz duplicada: {matriz}")