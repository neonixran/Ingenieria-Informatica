'''
Crear un arreglo (lista) de 10 números, imprimiendo los multiplos de 7 partiendo desde el 700.
'''

longitud = 10
multiplos = []

n = 700 # Número de 
multiplo = 7

for i in range(longitud):
    multiplos.append(n)
    n += multiplo # n = n + multiplo

print(f"Los multiplos son :{", ".join([str(i) for i in multiplos])}")