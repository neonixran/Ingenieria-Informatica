'''
Conversión de una longitud dada en pies a centímetros.
Los pies son ingresados por el usuario. Considere que: 1 pie = 30.48 centímetros.
'''

print("Este programa convierte pies a centimetros")
ft = int(input("Ingrese la longitud en pies: "))
cm = 0

while ft <= 0:
    print("[!] La longitud no puede ser menor o igual a 0.")
    ft = int(input("Ingrese la longitud en pies: "))

cm = ft * 30.48
print(f"La longitud en centimetros es de {cm} cm")