'''
Hacer un programa en python que lea n números, y que los guarde en un arreglo, sólo si los elementos
son múltiplos de 3. Imprimir el arreglo final.
'''

n = 10

A = []

for i in range(n):
    dato = int(input(f"Ingrese un número (nº{i+1}): "))
    
    if dato % 3 == 0:
        A.append(dato)

print(f"Múltiplos de 3: {", ".join([str(A[i]) for i in range(len(A))])}")
