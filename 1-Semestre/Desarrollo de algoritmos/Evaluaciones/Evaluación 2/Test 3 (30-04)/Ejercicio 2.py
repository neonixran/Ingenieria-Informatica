# Programa que calcule e indique cuantas semanas habrá vivido cuando esté de cumpleaños. Considerar que son 52 semanas por año.
print("Este programa calcula cuantas semanas habrá vivido cuando esté de cumpleaños")
nacimiento = int(input("Ingrese su año de nacimiento: "))
semanas = (2025 - nacimiento) * 52

print(f"Habrá vivido {semanas} semanas cuando esté de cumpleaños")