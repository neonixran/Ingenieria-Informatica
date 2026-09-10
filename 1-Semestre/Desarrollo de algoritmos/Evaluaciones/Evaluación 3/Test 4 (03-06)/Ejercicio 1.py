'''
Hacer un programa en Python que guarde en un arreglo de tamaño 10 los múltiplos de 5 que hay desde el 355, imprimir el arreglo
'''

A = []

longitud = 10
n = 355 # Número de partida

for i in range(10):
    A.append(n)
    n += 5

print(A)