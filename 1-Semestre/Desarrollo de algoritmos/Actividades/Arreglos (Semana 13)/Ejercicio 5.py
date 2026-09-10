'''
Hacer un programa en python que lea 10 números, los guarde en un arreglo A, luego lea otros 10
números, los guarde en un arreglo B, sume los números y guarde el resultado en un arreglo C. Imprima
los 3 arreglos.

Pasos:
    1. Crear 3 arreglos
    2. En los primeros 2 arreglos usar un bucle for que lea 10 números de forma independiente y guardarlos en el arreglo correspondiente.
    3. En el último arreglo, usar un bucle for.
        3-1. Crear una variable que almacene la suma de los números de ambos arreglos.
        3-2. guardar el resultado de cada suma al último arreglo.
    4. Imprimir los arreglos (num1, num2 y resultados)
'''

longitud = 10
A = []
B = []
C = []

for i in range(longitud):
    dato = int(input(f"Ingrese número 1.{i+1}: "))
    A.append(dato)
print()
for i in range(longitud):
    dato = int(input(f"Ingrese número 2.{i+1}: "))
    B.append(dato)

for i in range(longitud):
    suma = A[i] + B[i]
    C.append(suma)

print(f"\nA: {", ".join([str(A[i]) for i in range(longitud)])}")
print(f"B: {", ".join([str(B[i]) for i in range(longitud)])}")
print(f"Resultados: {", ".join([str(C[i]) for i in range(longitud)])}")