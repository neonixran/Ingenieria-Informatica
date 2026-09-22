import random

A = []
B = []
n = 3 # Longitud del arreglo

# Preguntar al usuario por los números en el arreglo A y asignar datos aleatoriamente en el arreglo B
for i in range(0, n):
    A.append(int(input(f"Ingrese número {i+1}: ")))
    B.append(random.randint(1, 100))

#Calcular promedio, sacar minimo y máximo del arreglo (u = Datos ingresados por el usuario, r = Datos aleatorios usando "random")
u_suma = 0
r_suma = 0

for i in range(0, n):
    u_suma += A[i]
    r_suma += B[i]

u_minimo = min(A)
u_maximo = max(A)
u_promedio = u_suma / n

r_minimo = min(B)
r_maximo = max(B)
r_promedio = r_suma / n

# Imprimir los resultados
print(f"\n[Usuario] El menor número es {u_minimo}, el promedio es {u_promedio:.1f} y el mayor número es {u_maximo}")
print(f"[Random] De la lista {B}. El menor número es {r_minimo}, el promedio es {r_promedio:.1f} y el mayor número es {r_maximo}")