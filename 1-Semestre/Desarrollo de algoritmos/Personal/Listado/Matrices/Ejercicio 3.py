matriz = [
    [1, 2, 3],
    [4, 5, 6]
]

numero = int(input("Ingrese un número para buscar en la matriz: "))
encontrado = False
fila = 0
columna = 0

for f in range(len(matriz)):
    for c in range(len(matriz[f])):
        if numero == matriz[f][c]:
            encontrado = True
            fila = f+1
            columna = c+1
            break

if encontrado:
    print(f"Se encontró en la fila {fila}, columna {columna}")
else:
    print("No se encontró")