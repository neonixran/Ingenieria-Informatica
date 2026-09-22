# Recorre e imprime al revés la matriz

matriz = [ # Matriz 2x3
    [1, 2, 3],
    [4, 5, 6]
]

for f in range(len(matriz), 0, -1):
    for c in range(len(matriz[f-1]), 0, -1):
        print(matriz[f-1][c-1], end=" ")
    print()