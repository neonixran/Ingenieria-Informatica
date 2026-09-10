'''
Hacer un programa que dado 1 arreglo con los números del 1 al 10 genere las tablas de
multiplicar y las imprima como tabla con sus resultados.

Pasos:
    1. Crear un arreglo con números del 1 al 10
    2. Recorrer el arreglo hasta el 10 creado en el paso 1 usando un bucle for.
    3. Usar un bucle for anidado al del paso 2 recorriendo del 1 al 10 (siempre se agrega 1 más).
    4. Imprimir las tablas de multiplicar
'''

A = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

for i in range(len(A)):
    print(f"\nTabla del {A[i]}:")
    for j in range(1, 11):
        print(f"{A[i]} * {j} = {A[i] * j}")