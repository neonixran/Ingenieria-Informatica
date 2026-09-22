'''
Calcular el costo en pesos (CLP) de una bolsa de pan que contiene N kg.
El precio de 1 kg es ingresado por el usuario.
'''
print("Este programa calcula el costo en pesos (CLP) de una bolsa de pan que contiene N kg.")
precio = int(input("Ingrese el precio del kilo de pan: "))
kg = int(input("Ingrese la cantidad de kg: "))

while precio <= 0 or kg <= 0:
    print("[!] El precio y la cantidad de kg deben ser mayores a 0.")
    precio = int(input("Ingrese el precio del kilo de pan: "))
    kg = int(input("Ingrese la cantidad de kg: "))

costo = precio * kg
print(f"El costo de la bolsa de pan es ${costo}")