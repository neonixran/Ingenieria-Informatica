n = float(input("Ingrese un número positivo: "))

while n < 0: # Comprueba si el el número ingresado es menor a 0, de serlo vuelve a preguntarle al usuario.
    print("Ingrese número positivo")
    n = float(input("Ingrese un número positivo"))

print(f"El número ingresado es {n}")