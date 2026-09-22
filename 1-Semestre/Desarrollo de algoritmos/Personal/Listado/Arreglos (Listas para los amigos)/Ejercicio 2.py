'''
Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física,
Química, Historia y Lengua) en una lista, pregunte al usuario la nota que ha sacado en cada
asignatura, y después las muestre por pantalla con el mensaje En <asignatura> has sacado <nota>
donde <asignatura> es cada una des las asignaturas de la lista y <nota> cada una de las
correspondientes notas introducidas por el usuario.
'''

asignaturas = ["Matemáticas", "Física", "Química", "Historia", "Lengua"]
notas = [] # Lista vacia, se usará append para añadir la nota de cada asignatura

# Pregunta por la nota de cada asignatura
for asignatura in range(0, len(asignaturas)):
    while True:
        try:
            nota = float(input(f"Ingrese la nota de {asignaturas[asignatura]}: "))

            if nota < 1 or nota > 7:
                print("Nota fuera de rango")
                continue

            notas.append(nota)
            break
        except ValueError:
            print("Ingrese solo valores válidos")
print()
# Imprime la nota de todas las asignaturas
for asignatura in range(0, len(asignaturas)):
    print(f"En {asignaturas[asignatura]} has sacado {notas[asignatura]}")