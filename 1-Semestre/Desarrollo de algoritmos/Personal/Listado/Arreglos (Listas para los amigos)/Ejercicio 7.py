'''
Se quiere realizar un programa que lea por teclado las 5 notas obtenidas por un alumno
(comprendidas entre 1.0 y 7.0). A continuación debe mostrar todas las notas, la nota media,
la nota más alta que ha sacado y la menor.
'''

notas = []

for i in range(0, 5):
    notas.append(float(input(f"Ingrese nota {i+1}: ")))

suma = 0
for i in range(0, 5):
    suma += notas[i]

minimo = min(notas)
maximo = max(notas)
promedio = suma / len(notas)

print(f"Su nota mínima es {minimo}, su promedio es {promedio:.1f} y su nota máxima es {maximo}")