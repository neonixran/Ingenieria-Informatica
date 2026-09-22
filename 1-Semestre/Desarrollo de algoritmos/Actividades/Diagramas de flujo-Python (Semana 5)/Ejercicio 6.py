'''
Transforme pesos (CPL) a dólares (USD), imprimiendo el resultado en pantalla.
La cantidad de pesos (CLP) es ingresada por el usuario.
'''

usd = float(input("Ingrese el valor del dólar actual: "))
clp = int(input("Ingrese la cantidad de pesos (CLP): "))
conversion = 0

while usd <= 0 or clp <= 0:
    print("[!] El valor del dólar y la cantidad de pesos deben ser mayores a 0.")
    usd = float(input("Ingrese el valor del dólar actual: "))
    clp = int(input("Ingrese la cantidad de pesos (CLP): "))

conversion = clp / usd
print(f"${clp} pesos a dólares son {conversion:.2f}") ## .2f para redondear a 2 decimales