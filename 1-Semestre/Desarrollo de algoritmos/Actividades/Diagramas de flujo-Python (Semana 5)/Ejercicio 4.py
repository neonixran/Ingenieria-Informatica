'''
Calculo del área y perímetro de un rectángulo.

Considere las siguientes formulas:
    a) área = base x altura
    b) perímetro = 2 x (base + altura)

Tanto base como altura son ingresados por el usuario.
'''

print("Este programa calcula el área y perímetro de un rectángulo.")
base = int(input("Ingrese la base: "))
altura = int(input("Ingrese la altura: "))
area = 0
perimetro = 0

while base <= 0 or altura <= 0 or base == altura: # Comprueba que la base y altura sean mayores a 0 y diferentes entre sí
    print("[!] La base y la altura deben ser mayores a 0 y diferentes entre sí.")
    base = int(input("Ingrese la base: "))
    altura = int(input("Ingrese la altura: "))

area = base * altura
perimetro = 2 * (base + altura)
print(f"El área es de {area} cm² y el perímetro es de {perimetro} cm.")