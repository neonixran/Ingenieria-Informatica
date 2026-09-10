'''
Hacer un programa en python que lea n números, los guarde en un arreglo busque los elementos
pares y los cambie por unos (1), luego imprima el arreglo modificado
'''

n = 10
A = []

for i in range(n):
    dato = int(input(f"Ingrese un número (nº{i+1}): "))
    A.append(dato)

for i in range(n):
    if A[i] % 2 == 0:
        A[i] = "(1)"

print(", ".join([str(A[i]) for i in range(n)]))