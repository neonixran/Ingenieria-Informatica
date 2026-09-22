'''
1.1 -> Escriba un programa que permita crear una lista de palabras. Para ello, el programa tiene que pedir un número y luego
solicitar ese número de palabras para crear la lista. Por último, el programa tiene que escribir la lista.

1.2 -> Escriba un programa que permita crear una lista de palabras y que, a continuación, pida una palabra y diga cuántas veces
aparece esa palabra en la lista.

# https://www.mclibre.org/consultar/python/ejercicios/ej-listas-1.html
'''

palabras = []
longitud = int(input("Ingrese la cantidad de palabras que tendrá la lista: "))

for i in range(longitud):
    palabras.append(input(f"Ingrese la palabra {i+1}: "))

print(f"La lista creada es: {palabras}")
if len(palabras) != 0:
    buscar = input("Ingrese la palabra a buscar: ")
    cantidad = 0
    for i in range(longitud):
        if buscar == palabras[i]:
            cantidad += 1

    print(f"La palabra {buscar} aparece {cantidad} veces.")