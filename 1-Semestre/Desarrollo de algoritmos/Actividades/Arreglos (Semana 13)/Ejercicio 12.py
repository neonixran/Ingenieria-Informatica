'''
Hacer un programa en python que lea n números y los guarde en un arreglo A, ordenar los números
de menor a mayor y guardarlos ordenados en un arreglo B, imprimir ambos arreglos.
'''

n = 5
A = []

for i in range(n):
    dato = int(input(f"Ingrese un número (nº{i+1}): "))
    A.append(dato)

B = sorted(A) # Ordena la lista, en este caso de menor a mayor. (Se usa sorted y no A.sort() porque sino devuelve None al asignarlo a otra variable)
print(f"Arreglo A (original): {A}")
print(f"Arreglo B (ordenado): {B}")