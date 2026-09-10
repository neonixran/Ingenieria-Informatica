'''
Hacer un programa que lea 10 números, los ordene y muestre ordenados de menor a mayor.
'''

A = []
longitud = 10

for i in range(longitud):
    dato = int(input(f"Ingrese número (nº{i+1}): "))
    A.append(dato)

A.sort() # Se usa A.sort() para ordenar en este caso de menor a mayor.
print(A)