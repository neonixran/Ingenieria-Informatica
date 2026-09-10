'''
Hacer un programa que lea 10 elementos, los guarde en un arreglo, luego duplique los
elementos del arreglo (que queden guardados) e imprima los elementos duplicados

Pasos:
    1. Crear un arreglo vacio.
    2. Leer 10 números y guardarlos en el arreglo creado en el paso 1.
    3. Duplicar los números del arreglo.
    4. Imprimir el arreglo con los números duplicados.
'''

longitud = 2
A = []

for i in range(longitud): # El usuario ingresa la cantidad de números definidos por la variable longitud
    dato = int(input(f"Ingrese el elemento #{i+1}: ")) # Variable de paso para ingresar los números
    A.append(dato)

for i in range(longitud):
    A[i] *= 2

print(f"Duplicada: {", ".join([str(A[i]) for i in range(longitud)])}") # Imprime el mismo arreglo pero ahora con los números duplicados