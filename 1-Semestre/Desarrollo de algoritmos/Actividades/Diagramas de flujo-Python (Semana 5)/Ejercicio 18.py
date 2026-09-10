'''
En una competencia atlética de velocidad el tiempo se mide en minutos, segundos y centésimas de segundo y, el espacio recorrido se mide en metros.
Determinar la velocidad promedio de un atleta en km/hr.
Considere que:
    - 1 hora = 60 minutos
    - 1 minuto = 60 segundos
    - 1 segundo = 100 centésimas de segundo
    - 1 kilómetro = 1000 metros
    
Todos los datos requeridos son ingresados por el usuario.
'''

print("Este programa calcula la velocidad promedio de un atleta en km/h")
metros = float(input("Ingrese la distancia recorrida en metros: "))
while metros <= 0:
    print("[!] Los metros deben ser mayores a 0")
    metros = float(input("Ingrese la distancia recorrida en metros: "))

minutos = int(input("Ingrese los minutos: "))
while minutos < 0:
    print("[!] Los minutos deben ser mayores o iguales a 0")
    minutos = int(input("Ingrese los minutos: "))

segundos = int(input("Ingrese los segundos: "))
while segundos < 0:
    print("[!] Los segundos deben ser mayores o iguales a 0")
    segundos = int(input("Ingrese los segundos: "))

centecimas = int(input("Ingrese las centésimas de segundo: "))
while centecimas < 0:
    print("[!] Los centésimas deben ser mayores o iguales a 0")
    centecimas = int(input("Ingrese las centésimas de segundo: "))

km = metros / 1000  # Convertir metros a kilómetros

# Convertir el tiempo a horas
minutos = minutos + (segundos + (centecimas / 100)) / 60
horas = minutos / 60

velocidad = km / horas  # Velocidad en km/h

print(f"La velocidad promedio del atleta es de {velocidad:.2f} km/h")