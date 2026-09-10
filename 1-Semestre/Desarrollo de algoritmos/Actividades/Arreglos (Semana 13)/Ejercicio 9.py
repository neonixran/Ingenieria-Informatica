'''
Hacer un programa en python que lea 10 números, los guarde en un arreglo A, verifique si son pares
o impares, los pares los guarde en un arreglo llamado PAR, y los impares en uno llamado IMPAR.
Finalmente debe imprimir los arreglos A, PAR e IMPAR.
'''

A = []
PAR = []
IMPAR = []

longitud = 10

for i in range(longitud):
    dato = int(input(f"Ingrese un número (nº{i+1}): "))
    A.append(dato)

    if dato % 2 == 0: # Si es par
        PAR.append(dato)
    else: # Si es impar
        IMPAR.append(dato)

print(f"\nNúmeros: {", ".join(str(A[i]) for i in range(longitud))}")
print(f"Números Pares: {", ".join(str(PAR[i]) for i in range(len(PAR)))}")
print(f"Números Impares: {", ".join(str(IMPAR[i]) for i in range(len(IMPAR)))}")