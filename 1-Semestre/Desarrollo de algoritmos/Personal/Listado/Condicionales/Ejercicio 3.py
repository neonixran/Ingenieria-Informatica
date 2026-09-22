'''
Escribir un programa que pida al usuario dos números y muestre por pantalla su división.
Si el divisor es cero el programa debe mostrar un error.
'''

num1 = int(input("Ingrese dividendo: "))
num2 = int(input("Ingrese divisor: "))

if num2 == 0:
    print("No se puede dividir por 0")
else:
    div = num1 / num2
    print(div)