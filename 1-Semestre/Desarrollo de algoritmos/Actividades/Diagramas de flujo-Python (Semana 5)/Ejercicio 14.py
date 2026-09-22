'''
Usted cuenta con un seguro automotriz, el cual tiene un deducible de 5 UF.
Usted debe hacer uso del seguro por un accidente pequeño, el cual tiene un costo total de $678.987.
    - Mostrar por pantalla el monto que asume la seguradora y el monto que debe pagar usted.
    - Los montos se expresan en pesos (CLP).
'''

print("Este programa calcula el monto que asume la aseguradora y el monto que debe pagar usted por un accidente automotriz.")
uf = float(input("Ingrese el valor actual de la UF: "))

while uf <= 0:
    print("[!] El valor de la UF debe ser positivo.")
    uf = float(input("Ingrese el valor actual de la UF: "))

aseguradora = uf * 5
deducible = 678987 - aseguradora
print(f"El monto que asume la aseguradora es ${aseguradora}, usted deberá pagar ${deducible}")