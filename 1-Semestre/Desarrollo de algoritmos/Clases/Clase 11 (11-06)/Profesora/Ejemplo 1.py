matriz = [
    [1, 2, 3],
    [4, 5, 6]
]

print("La matriz es: ")
ancho = len(str(max([matriz[f][c] for f in range(len(matriz)) for c in range(len(matriz[f]))])))
linea = "+" + "+".join(["-"*ancho for _ in range(3)]) + "+"
for f in matriz:
    print(linea)
    print("|" + "|".join(f"{valor: ^{ancho}}" for valor in f) + "|")
print(linea)