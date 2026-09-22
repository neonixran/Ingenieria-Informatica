'''
En las matrices, siempre se empieza primero por las filas y luego las columnas, por lo que una matriz 3x2 serian 3 filas y 2 columnas.
'''

# Imprime los números de la matriz
matriz = [ # Matriz 3x2 (3 filas, 2 columnas)
    [1, 2], # Fila 0: Columnas 0 y 1
    [3, 4], # Fila 1: Columnas 0 y 1
    [5, 6] # Fila 2: Columnas 0 y 1
]

for fila in range(len(matriz)):
    for columna in range(len(matriz[fila])):
        print(f"Elemento en posición ({fila}, {columna}): {matriz[fila][columna]}") # Se usa Matriz[fila][columna] para acceder a los datos
print()

# Imprimir la matriz como matriz
print(f"Matriz (Forma 1): \n{"\n".join(map(str, matriz)).replace(",", "")}")

print("\nMatriz (Forma 2):")
for f in range(len(matriz)):
    print(" ".join([str(matriz[f][c]) for c in range(len(matriz[f]))]))

print("\nMatriz (Forma 3):")
for f in range(len(matriz)):
    for c in range(len(matriz[f])):
        print(matriz[f][c], end=" ")
    print()