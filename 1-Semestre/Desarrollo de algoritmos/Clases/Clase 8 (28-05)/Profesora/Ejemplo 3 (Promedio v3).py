import random # Importamos el módulo random para generar números aleatorios

A = [] # Creamos una lista vacía para almacenar las 30 notas ingresadas por el usuario

for i in range(30): # Usamos un ciclo for para pedir 30 notas, una por una
    A.append(float(input(f"Ingrese Nota n°{i+1}: "))) # Solicitamos la nota al usuario y la agregamos directamente a la lista A

# Generamos el arreglo B con 30 números decimales aleatorios entre 1.0 y 7.0, y cada número se redondea a 2 decimales usando round().
B = [round(random.uniform(1.0, 7.0), 2) for _ in range(30)]

# Calculamos el promedio de cada par de notas de A y B y los guardamos en C, y cada número se redondea a 2 decimales usando round().
C = [round((A[i] + B[i]) / 2, 2) for i in range(30)]

# Imprimimos el contenido de los arreglos A, B y C en forma horizontal
print("\nArreglo A:")

# Se imprime cada número con 2 decimales, separados por |
print(" | ".join([f"{n:.2f}" for n in A]))
print("\nArreglo B:")
print(" | ".join([f"{n:.2f}" for n in B]))
print("\nArreglo C (promedio de A y B):")
print(" | ".join([f"{n:.2f}" for n in C]))