'''
Escribir un programa que pida al usuario una palabra y la muestre por pantalla 10 veces.
'''

char = input("Ingrese una palabra: ")

for i in range(1, 10+1):
    print(f"{i}. {char}")