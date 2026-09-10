import os

matriz1 = [] # Nums 1
matriz2 = [] # Nums 2
sumas = [] # Resultados de la suma

# El usuario ingresa el tamaño de las matrices (cantidad de filas y columnas), se valida que sean números mayores a 0 y enteros.
while True:
    try:
        longitud_filas = int(input("Ingrese la cantidad de filas: "))

        if longitud_filas < 0 or longitud_filas >= 10:
            print("\t[!] No puede ingresar números menores o iguales a 0")
            continue
        break
    except ValueError:
        print("\t[!] Ingrese un número de filas válido")

while True:
    try:
        longitud_columnas = int(input("Ingrese la cantidad de columnas: "))
        if longitud_columnas < 0 or longitud_columnas >= 10:
            print("\t[!] No puede ingresar números mayor a 10, ni menores a 11")
            continue
        break
    except ValueError:
        print("\t[!] Ingrese un número de columnas válido")
        continue     

# Lectura y calculo de las matrices
os.system("cls")
print("Ingresa los números para la matriz nº1")
for fila in range(longitud_filas):
    matriz1.append([])
    for columna in range(longitud_columnas):
        while True:
            try:
                dato = int(input(f"Ingrese número {fila+1}.{columna+1}: "))
                matriz1[fila].append(dato)
                break
            except ValueError:
                print("\t[!] Ingrese sólo números enteros.")
                continue

print("\nIngresa los números para la matriz nº2")
for fila in range(longitud_filas):
    matriz2.append([])
    for columna in range(longitud_columnas):
        while True:
            try:
                dato = int(input(f"Ingrese número {fila+1}.{columna+1}: "))
                matriz2[fila].append(dato)
                break
            except ValueError:
                print("\t[!] Ingrese sólo números enteros.")
                continue

for fila in range(longitud_filas):
    sumas.append([])
    for columna in range(longitud_columnas):
        suma = matriz1[fila][columna] + matriz2[fila][columna]
        sumas[fila].append(suma)

print("Los resultados son: ")
for f in range(len(sumas)):
    print()
    for c in range(len(sumas[f])):
        print(sumas[f][c], end=" ")