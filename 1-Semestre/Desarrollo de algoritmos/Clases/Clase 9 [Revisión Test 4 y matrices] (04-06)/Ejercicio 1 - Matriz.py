A = [
    [1, 2, 3],
    [4, 5, 6]
] # Matriz de 2 filas y 3 columnas

for f in range(len(A)):
    for c in range(len(A[f])):
        print(f"fila: {f} columna: {c}: valor: {A[f][c]}")