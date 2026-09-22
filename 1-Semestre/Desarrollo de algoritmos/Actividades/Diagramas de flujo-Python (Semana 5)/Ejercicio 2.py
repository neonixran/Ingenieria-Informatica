'''
a) Conversión de una longitud dada en centímetros a pies.
b) Los centímetros son ingresados por el usuario.
    Considere que: 1 pie = 30.48 centímetros.
'''

print("Este programa convierte centímetros a pies.")
cm = int(input("Ingrese la longitud en cm: "))
ft = 0

while cm <= 0:
    print("[!] La longitud debe ser mayor a 0.")
    cm = int(input("Ingrese la longitud en cm: "))

ft = cm / 30.48
print(f"La longitud en pies es de {ft:.2f} ft")