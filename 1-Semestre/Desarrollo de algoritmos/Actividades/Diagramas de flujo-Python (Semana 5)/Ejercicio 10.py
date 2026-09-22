'''
Calcular e imprimir el valor de un dividendo en pesos (CLP) para un crédito de 2500 UF a 30 años.
El valor de la UF es el valor del día.
'''

print("Este programa calcula el valor de un dividendo en pesos (CLP) para un crédito de 2500 UF a 30 años.")
uf = float(input("Ingrese el valor actual de la UF: "))

while uf <= 0:
    print("[!] El valor de la UF debe ser mayor a 0.")
    uf = float(input("Ingrese el valor actual de la UF: "))

cuota = 2500 * uf / (30 * 12)
print(f"La cuota del dividendo es de ${cuota:.2f}")