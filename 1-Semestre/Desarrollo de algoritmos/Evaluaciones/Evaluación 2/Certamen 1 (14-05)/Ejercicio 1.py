'''
Hacer un programa en Python que lea el porcentaje de asistencia de un alumno y
diga si es válido o no (no debe ser menor a 0, ni mayor a 100),
el programa debe repetirse hasta que el usuario indique lo contrario.
'''

r = "s"

while r == "s":
    try:
        porcentaje_asistencia = int(input("Ingrese su porcentaje de asistencia: "))

        if porcentaje_asistencia < 0 or porcentaje_asistencia > 100:
            print("[!] El porcentaje de asistencia es inválido!")
            continue
        else:
            print("Bien")
    except ValueError:
        print("[!] Ingrese un número válido")
        continue

    r = input("Quiere ejecutar de nuevo? (s/n): ").lower()