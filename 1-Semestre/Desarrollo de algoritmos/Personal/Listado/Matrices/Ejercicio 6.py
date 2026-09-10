# Escribe un programa que cuente cuántos números pares hay en una matriz e imprima la cantidad y cuales son.
matriz = [
    [1, 2, 3],
    [4, 5, 6]
]

pares = 0
n_pares = []
for f in range(len(matriz)):
    for c in range(len(matriz[f])):
        if matriz[f][c] % 2 == 0:
            pares += 1
            n_pares.append(matriz[f][c])

print(f"Hay {pares} números en la matriz, que son: {n_pares}")