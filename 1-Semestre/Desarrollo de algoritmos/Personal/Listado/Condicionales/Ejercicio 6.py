'''
Los alumnos de un curso se han dividido en dos grupos A y B de acuerdo al sexo y el nombre.
El grupo A esta formado por las mujeres con un nombre anterior a la M y los hombres con un
nombre posterior a la N y el grupo B por el resto. Escribir un programa que pregunte al usuario
su nombre y sexo, y muestre por pantalla el grupo que le corresponde.
'''

nombre = input("Ingrese su nombre: ").lower()
sexo = input("Ingrese su sexo (M/H): ").lower()

if sexo == "m" and nombre < "m" or sexo == "h" and nombre < "n":
    print("Es del grupo A")
else:
    print("Es del grupo B")