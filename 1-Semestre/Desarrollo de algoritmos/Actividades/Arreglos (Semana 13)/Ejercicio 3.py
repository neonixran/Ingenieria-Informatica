'''
Hacer un programa que genere los 15 múltiplos de 16 que hay desde 160, guardar los múltiplos
en un arreglo

Pasos:
    1. Crear un arreglo vacio, este almacenará los múltiplos.
    2. Crear una variable de partida, empezará desde el 160.
    3. Usar un bucle for para generar 15 números.
    4. Agregar al arreglo el número inicial del paso 2.
    5. Ir sumando por 16 el número del paso 2 (el bucle for repetirá el proceso 15 veces, agregando cada número al arreglo).
    6. Imprimir el arreglo.
'''

n = 160 # Número de partida
multiplo = 16
longitud = 15

A = [] # Múltiplos

for i in range(longitud):
    A.append(n) # Ingresa el primer número al arreglo, que es el de partida
    n += multiplo

print(f"Los múltiplos de {multiplo} son: {", ".join([str(A[i]) for i in range(longitud)])}")