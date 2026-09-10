'''
Calcular el sueldo líquido de un trabajador.
Los elementos a considerar son:
    - sueldo base
    - fondo de pensión (20%)
    - fondo de salud (7%)
Estos tres valores son ingresados por el usuario.
'''

print("Este programa calcula el sueldo líquido de un trabajador.")
base = int(input("Ingrese el sueldo base: "))
afp = int(input("Ingrese el fondo de pensión (poner 0 para tomar el 20%): "))
salud = int(input("Ingrese el fondo de salud (poner 0 para tomar el 7%): "))

while base <= 0 or afp < 0 or salud < 0:
    print("[!] Debe ingresar valores positivos.")
    base = int(input("Ingrese el sueldo base: "))
    afp = int(input("Ingrese el fondo de pensión (poner 0 para tomar el 20%): "))
    salud = int(input("Ingrese el fondo de salud (poner  en blanco para tomar el 7%): "))

if afp == 0:
    afp = base * 0.20

if salud == 0:
    salud = base * 0.07

liquido = base - (afp + salud)
print(f"El sueldo líquido es de ${liquido}")