'''
Hacer un programa en python que lea datos desde teclado, valide si los datos son pares o impares, los
guarde en un arreglo PAR o IMPAR respectivamente, luego sume los datos de ambos arreglos
(PAR[i]+IMPAR[i]) y los guarde en un arreglo A. La cantidad de datos va a estar determinada por el
ingreso del usuario, cuando el ingrese un 33 o un múltiplo de 33.
'''

PAR = []
IMPAR = []
A = []

while True:
    dato = int(input(f"Ingrese un número: "))
    
    if dato % 2 == 0: # Si es par
        PAR.append(dato)
    else: # Si es impar
        IMPAR.append(dato)

    if dato % 33 == 0:
        break


min_longitud = min(len(PAR), len(IMPAR)) # Obtiene el valor minimo de ambos arreglos, en este caso el arreglo más pequeño
for i in range(min_longitud):
    suma = PAR[i] + IMPAR[i]
    A.append(suma)

print(f"Pares: {", ".join([str(PAR[i]) for i in range(len(PAR))])}")
print(f"Impares: {", ".join([str(IMPAR[i]) for i in range(len(IMPAR))])}")
print(f"Resultados: {", ".join([str(A[i]) for i in range(len(A))])}")