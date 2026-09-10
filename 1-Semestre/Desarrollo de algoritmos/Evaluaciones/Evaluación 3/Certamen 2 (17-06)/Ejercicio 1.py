'''
En un curso, el profesor necesita entregar las estadísticas de crecimiento de sus alumnos, para eso le solicita a usted, que realice un programa en Python que:
    a) Ingrese las estaturas de cada alumno en un arreglo E de tamaño 35.
    b) Sume todas las estaturas.
    c) Calcule el promedio.
    d) Encuentre la estatura más alta y la más baja.
    e) Imprima el arreglo de la estaturas.
    f) Imprima la suma, el promedio, la mayor y la menor
'''

E = []
longitud = 35

for i in range(longitud):
    estatura = float(input(f"Ingrese la estatura en cm del alumno #{i+1}: "))
    E.append(estatura)
    
suma = sum(E)
promedio = suma / longitud
alto = max(E)
bajo = min(E)

print(f"\nLas estaturas son: {E}")
print(f"La suma de las estaturas es: {suma} cm")
print(f"El promedio es: {promedio} cm")
print(f"La estatura mayor es: {alto} cm")
print(f"La estatura menor es: {bajo} cm")