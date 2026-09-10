'''
Hacer un programa que lea la estatura de un alumno y le diga:
    a) "Alto" si su estatura es mayor o igual a 1,85
    b) "Regular" si su estatura es mayor o igual a 1,65, pero menor que 1,85
    c) "Bajo" si su estatura es menor que 1,65

El programa debe repetirse para 10 estudiantes.
'''

for i in range(1, 11): # Se repite para 10 estudiantes
    print(f"Estudiante #{i}")
    while True:
        try:
            estatura = float(input("Ingrese su estatura (m): "))

            if estatura < 0 or estatura > 2.5:
                print("[!] Ingrese un estatura válida")
                continue
            else:
                if estatura < 1.65:
                    print("Su estatura es baja")
                elif estatura < 1.85:
                    print("Su estatura es regular")
                else:
                    print("Su estatura es alta")
        except ValueError:
            print("[!] Ingrese números validos")
            continue
        
        break