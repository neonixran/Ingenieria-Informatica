'''
Escribir un programa que pregunte al usuario su edad
y muestre por pantalla si es mayor de edad o no.
'''

edad = int(input("Ingrese su edad: "))

if edad <= 0:
    print("La edad no puede ser menor o igual a 0")
elif edad < 18:
    print("Usted es menor de edad")
else:
    print("Usted es mayor de edad")