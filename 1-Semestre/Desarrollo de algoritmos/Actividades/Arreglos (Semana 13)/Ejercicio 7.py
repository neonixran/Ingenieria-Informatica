'''
Hacer un programa que lea 10 números, los guarde en un arreglo A, y luego los traspase al revés
a un arreglo B. Imprimir ambos arreglos.
'''

A = []
longitud = 10

for i in range(longitud):
    dato =  int(input(f"Ingrese un número (nº{i+1}): "))
    A.append(dato)

B = A[::-1] # Invierte el arreglo A, también puede usarse: B = list(reversed(A))
print(f"A: {A}")
print(f"B: {B}")
