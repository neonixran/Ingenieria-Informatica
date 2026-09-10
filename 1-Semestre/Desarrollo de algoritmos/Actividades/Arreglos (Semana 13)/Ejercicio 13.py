'''
Hacer un programa en python que lea n números y los guarde en un arreglo A, ordenar el arreglo de
mayor a menor e imprimir (sólo se debe usar 1 arreglo).
'''

n = 5
A = []

for i in range(n):
    dato = int(input(f"Ingrese número (nº{i+1}): "))
    A.append(dato)

A.sort(reverse=True) # Ordena la lista inversamente (mayor a menor en este caso)
print(f"\nArreglo A (mayor a menor): {", ".join([str(A[i]) for i in range(n)])}")