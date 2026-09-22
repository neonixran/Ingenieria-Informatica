'''
Escribir un programa que pida al usuario una palabra y muestre por pantalla si es un palíndromo.
'''

palabra = list(input("Ingrese una palabra: "))
palabra_inversa = palabra[::-1] # Invierte el arreglo/lista "palabra"

if palabra == palabra_inversa:
    print("Es un palíndromo")
else:
    print("No es un palíndromo")