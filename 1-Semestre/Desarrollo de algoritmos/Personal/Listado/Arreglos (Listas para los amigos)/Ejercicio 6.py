'''
Crear un vector de 5 elementos de cadenas de caracteres, inicializa el vector con datos leídos por
el teclado. Copia los elementos del vector en otro vector pero en orden inverso, y muéstralo por
la pantalla.
'''

vector1 = []
vector2 = []

# Pregunta al usuario por 10 datos
for i in range(0, 5):
    vector1.append(input(f"Ingrese dato {i+1}: "))

# Crea una copia del arreglo "vector1" en "vector2" y luego invierte esa copia
vector2 = vector1.copy()
vector2.reverse()

# Imprime la copia inversa
for i in range(0, 5):
    print(vector2[i])