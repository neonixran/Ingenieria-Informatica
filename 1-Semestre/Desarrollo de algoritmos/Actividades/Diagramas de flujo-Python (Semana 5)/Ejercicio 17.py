'''
Una institución benéfica europea ha recibido tres donaciones en soles, dólares y marcos.
La donación será repartida en tres rubros:
    - 60% para la implementación de un centro de salud
    - 30% para un comedor deniños
    - el resto para gastos administrativos.

Determinar el monto en euros que le corresponde a cada rubro.
Considere que:
    - 1 dólar = 3.52 soles
    - 1 dólar = 2.08 marcos
    - 1 dólar = 1.07 euros.

Las donaciones son ingresadas por el usuario.
'''

print("Este programa calcula el monto en euros que le corresponde a cada rubro de una donación.")

# Definición de variables y validación
soles = float(input("Ingrese la donación en soles: "))

while soles <= 0:
    print("[!] Los soles deben ser mayores a 0.")
    soles = float(input("Ingrese la donación en soles: "))

marcos = float(input("Ingrese la donación en marcos: "))

while marcos <= 0:
    print("[!] Los marcos deben ser mayores a 0.")
    marcos = float(input("Ingrese la donación en marcos: "))

dolares = float(input("Ingrese la donación en dólares: "))

while dolares <= 0:
    print("[!] Los dólares deben ser mayores a 0.")
    dolares = float(input("Ingrese la donación en dólares: "))

# Convertir las donaciones a dólares (se usa la misma variables de la moneda local)
soles = soles / 3.52
marcos = marcos / 2.08

# Convertir las donaciones a euros
euros = (soles + marcos + dolares) * 1.07

# Calcular el monto para cada rubro
centro_salud = euros * 0.60
comedor_ninos = euros * 0.30
gastos_administrativos = euros * 0.1

# Mostrar los resultados
print(f"Para el centro de salud fueron donados €{centro_salud:.2f}, para el comedor de niños €{comedor_ninos:.2f} y para gastos administrativos €{gastos_administrativos:.2f}.")