'''
Para poder comprobar que sabe manejar matrices se le solicita a usted que:
    a) Cree una matriz de 4x4
    b) Ingrese datos enteros entre 30 y 80 en la matriz
    c) Imprima todos los datos de la matriz
    d) Imprima sólo los datos de la diagonal secundaria
'''

M = []
longitud = 4 # Matriz de mismas filas, mismas columnas (ej. 4x4)

for f in range(longitud):
    M.append([])
    for c in range(longitud):
        while True:
            num = int(input(f"Ingrese números entre 30 y 80 [{f+1}][{c+1}]: "))
            
            if num < 30 or num > 80:
                print("\tIngrese solo números entre 30 y 80!")
                continue
            else:
                M[f].append(num)
            break

print("\nLos datos de la matriz son:")
for f in range(longitud):
    for c in range(longitud):
        print(M[f][c], end=" ")
    print()

print("\nLa diagonal secundaria es: ")
c = longitud - 1
for f in range(longitud):
    print(M[f][c])
    c = c - 1