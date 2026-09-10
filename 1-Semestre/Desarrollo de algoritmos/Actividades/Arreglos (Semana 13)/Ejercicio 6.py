'''
Hacer un programa en python que lea números desde teclado (el usuario debe determinar cuántos)
que los guarde en un arreglo, luego pregunte al usuario un número, multiplique los números iniciales
por el último número ingresado y muestre los valores finales.
'''

A = []

while True:
    dato = int(input(f"Ingrese un número (0 para salir): "))
    
    if dato != 0:
        A.append(dato)
    else:
        break

num = int(input("\nIngrese un número: "))
print()
for i in range(len(A)):
    print(f"{num} * {A[i]} = {num * A[i]}")