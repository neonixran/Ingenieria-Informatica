'''
Escribir un programa que almacene la cadena de caracteres contraseña en una variable,
pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida
por el usuario coincide con la guardada en la variable sin tener en cuenta mayúsculas y minúsculas.
'''

contraseña_guardada = "hola1234"
contraseña = input("Ingrese su contraseña: ")

if contraseña == "":
    print("Ingrese una contraseña válida")
elif contraseña == contraseña_guardada:
    print("Puede entrar")
else:
    print("Contraseña incorrecta")