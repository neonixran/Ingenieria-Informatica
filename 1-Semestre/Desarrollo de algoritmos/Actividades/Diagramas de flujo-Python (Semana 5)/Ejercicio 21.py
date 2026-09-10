'''
Existe un alumno que utiliza periódicamente la “ley del menor esfuerzo”, por lo cual, necesita saber la cantidad de veces que se le permite faltar a la asignatura de “Lenguaje de programación”.
Él sabe que el módulo se compone de 12 clases y que la asistencia mínima es de un 70%.

Calcular a cuántas clases puede faltar este alumno sin perder la asignatura por inasistencia.
'''

print("Este programa calcula la cantidad de clases que un alumno puede faltar sin perder la asignatura")
clases_totales = int(input("Ingrese la cantidad total de clases: "))
while clases_totales < 5: # Mínimo 5 clases para evitar errores en el cálculo
    print("[!] Ingrese nuevamente")
    clases_totales = int(input("Ingrese la cantidad total de clases: "))

minimo_asistencia = clases_totales * 0.7
permitido = clases_totales - minimo_asistencia
print(f"El alumno puede faltar a {permitido:.0f} clases sin perder la asignatura")