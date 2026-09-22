'''
Hacer un programa que lea 10 números, los guarde en un arreglo, busque el menor y el mayor
de los elementos y los imprima

Pasos:
    1. Crear un arreglo vacio.
    2. Leer 10 números y guardarlos en el arreglo creado en el paso 1.
    3. Crear 2 variables, una para buscar el número menor y el mayor.
    4. Imprimir los valores de las variables del paso 3.
'''

longitud = 10
A = []

for i in range(longitud):
    dato = int(input(f"Ingrese el número nº{i+1}: "))
    A.append(dato)

menor = min(A)
mayor = max(A)

print(f"El menor de los elementos es {menor} y el mayor es {mayor}")