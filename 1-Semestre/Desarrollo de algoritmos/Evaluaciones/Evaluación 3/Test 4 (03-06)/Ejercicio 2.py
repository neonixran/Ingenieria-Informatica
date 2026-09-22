'''
Hacer un programa en Python que lea 10 datos, los guarde en un arreglo A, lea otros 10 datos y los guarde en un arreglo B,
calcule y guarde en un arreglo C la suma de los arreglos (A + B). Luego imprima el arreglo de los resultados.
'''

longitud = 10
A = [] # Num 1
B = [] # Num 2
C = [] # Resultados

for i in range(longitud):
    dato = int(input(f"Ingrese dato 1.{i+1}: "))
    A.append(dato)

print()
for i in range(longitud):
    dato = int(input(f"Ingrese dato 2.{i+1}: "))
    B.append(dato)

for i in range(longitud):
    suma = A[i] + B[i]
    C.append(suma)

print(C)