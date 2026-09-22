# Escribe un programa que calcule la suma de los elementos de cada columna de una matriz.
matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

for f in range(len(matriz)):
    suma = 0
    for c in range(len(matriz[f])):
        suma += matriz[c][f]
    
    print(suma)