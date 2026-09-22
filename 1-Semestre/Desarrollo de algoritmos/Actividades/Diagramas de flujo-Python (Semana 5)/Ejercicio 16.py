'''
Usted se debe estacionar frente a un parquímetro, el cual tiene la siguiente tarifa:
    - 0 a 20 minutos = $366
    - Minuto adicional es de $18.28
Calcular la cantidad de pesos (CLP) que debe cancelar al parquímetro por estar estacionado por N minutos.
N debe ser ingresado por el usuario.
'''

print("Este programa calcula el costo de estacionamiento en un parquímetro.")
minutos = int(input("Ingrese la cantidad de minutos que estuvo estacionado: "))

while minutos < 0:
    print("[!] Ingrese nuevamente")
    minutos = int(input("Ingrese la cantidad de minutos que estuvo estacionado: "))

if minutos < 20:
    print("Debe cancelar $366")
else:
    adicional = (minutos - 20) * 18.28
    total = adicional + 366
    print(f"Debe cancelar ${total:.2f}")