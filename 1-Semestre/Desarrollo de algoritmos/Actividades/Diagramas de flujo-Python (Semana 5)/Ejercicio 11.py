'''
Obtener el promedio de notas de un alumno.
Las evaluaciones a tomar en cuenta son:
    - certamen 1 con un 40%
    - certamen 2 con un 40%
    - un test de 20%

Las notas son ingresadas por el usuario y el promedio debe expresarse con decimales.
'''

print("Este programa calcula el promedio ponderado de notas de un alumno")
cert1, cert2, test, prom = 0, 0, 0, 0
alumnos = int(input("Ingrese cantidad de alumnos: "))

while alumnos <= 0:
    print("[!] Ingrese una cantidad válida de alumnos")
    alumnos = int(input("Ingrese cantidad de alumnos: "))

for alumno in range(alumnos):
    print(f"#{alumno + 1}")
    cert1 = float(input("Ingrese nota del certamen 1: "))
    cert2 = float(input("Ingrese nota del certamen 2: "))
    test = float(input("Ingrese nota del test: "))

    while (cert1 < 0 or cert1 > 7) or (cert2 < 0 or cert2 > 7) or (test < 0 or test > 7):
        print("[!] Ingrese notas válidas entre 0 y 7")
        cert1 = float(input("Ingrese nota del certamen 1: "))
        cert2 = float(input("Ingrese nota del certamen 2: "))
        test = float(input("Ingrese nota del test: "))

    prom = (cert1 * 0.4) + (cert2 * 0.4) + (test * 0.2)
    print(f"El promedio de notas ponderado del alumno #{alumno + 1} es: {prom:.1f}")