'''
Calcular e imprimir el valor de una cuota en pesos (CLP) de un crédito hipotecario expresado en UF.
    a) El valor de la UF es el valor del día.
    b) El valor del crédito debe ser ingresado por el usuario.
'''

print("Este programa calcula el valor de una cuota en pesos (CLP) de un crédito hipotecario expresado en UF.")
uf = float(input("Ingrese el valor actual de la UF: "))
cuota = float(input("Ingrese el valor de la cuota en UF: "))

while uf <= 0 or cuota <= 0:
    print("[!] Ingrese nuevamente")
    uf = float(input("Ingrese el valor actual de la UF: "))
    cuota = float(input("Ingrese el valor de la cuota en UF: "))

cuota_clp = cuota * uf
print(f"El valor de la cuota es de ${cuota_clp}")