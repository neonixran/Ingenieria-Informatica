'''
Calcular la cantidad de tazas de té que pueden ser servidas con N litros de agua y donde cada taza tiene una capacidad de 200 cc.
Debe tener en cuenta que 1 litro = 1000 cc.
N debe ser ingresado por el usuario.
'''

print("Este programa calcula cuantas tazas de té se pueden servir con N litros de agua")
litros = int(input("Ingrese la cantidad de litros de agua: "))

while litros <= 0:
    print("[!] La cantidad de litros debe ser mayor a 0.")
    litros = int(input("Ingrese la cantidad de litros de agua: "))

litros *= 1000 # Convertir litros a cc, 1 litro = 1000 cc
tazas = litros / 200
print(f"Se pueden servir {tazas} tazas de té")