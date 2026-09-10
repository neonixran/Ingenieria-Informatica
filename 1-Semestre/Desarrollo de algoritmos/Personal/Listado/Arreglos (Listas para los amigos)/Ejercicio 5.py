'''
Realizar un programa que defina un vector llamado “vector_numeros” de 10 enteros,
a continuación lo inicialice con valores aleatorios (del 1 al 10) y posteriormente muestre
en pantalla cada elemento del vector junto con su cuadrado y su cubo.
'''

import random
vector_numeros = []

for i in range(0, 10):
    vector_numeros.append(random.randint(1, 10))

for i in range(0, 10):
    vector = vector_numeros[i]
    print(f"{vector}^2 = {vector**2}\n{vector}^3 = {vector**3}\n") # Ej. 2^2 = 4\n2^3 = 8