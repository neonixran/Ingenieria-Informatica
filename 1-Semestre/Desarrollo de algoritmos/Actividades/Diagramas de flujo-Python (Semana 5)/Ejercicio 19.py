'''
El sueldo neto de un vendedor se calcula como la suma de un sueldo básico más el 12% del monto total vendido.
Determinar el sueldo neto de un vendedor sabiendo que hizo tres ventas en el mes.

Las ventas son ingresadas por el usuario.
'''

print("Este programa calcula el sueldo neto de un vendedor.")
sueldo_base = int(input("Ingrese el sueldo base del vendedor: "))
while sueldo_base <= 0:
    print("[!] El sueldo base debe ser mayor a 0")
    sueldo_base = int(input("Ingrese el sueldo base del vendedor: "))

venta1 = int(input("Ingrese el monto de la venta 1: "))
venta2 = int(input("Ingrese el monto de la venta 2: "))
venta3 = int(input("Ingrese el monto de la venta 3: "))
while venta1 <= 0 or venta2 <= 0 or venta3 <= 0:
    print("[!] El monto de las ventas debe ser mayor a 0")
    venta1 = int(input("Ingrese el monto de la venta 1: "))
    venta2 = int(input("Ingrese el monto de la venta 2: "))
    venta3 = int(input("Ingrese el monto de la venta 3: "))

ventas = (venta1 + venta2 + venta3) * 0.12
sueldo_neto = sueldo_base + ventas
print(f"El sueldo neto del vendedor es: ${sueldo_neto}")