'''
Determinar el porcentaje de varones y de mujeres que hay en un salón de clases.
Todo número requerido para realizar el cálculo es ingresado por el usuario.
'''

print("Este programa calcula el porcentaje de hombres y mujeres en un salón de clases.")
muj = int(input("Ingrese la cantidad de mujeres: "))
hom = int(input("Ingrese la cantidad de hombres: "))

while muj <= 0 or hom <= 0: # Comprueba que los valores sean mayores a 0
    print("[!] La cantidad de hombres y mujeres debe ser mayor a 0.")
    muj = int(input("Ingrese la cantidad de mujeres: "))
    hom = int(input("Ingrese la cantidad de hombres: "))

total = hom + muj # Total de alumnos
p_muj = (muj / total) * 100 # Porcentaje de mujeres
p_hom = (hom / total) * 100 # Porcentaje de hombres

print(f"\nDe un total de {total} alumnos hay {p_muj:.2f}% de mujeres y {p_hom:.2f}% de hombres en el salón.") ## .2f para redondear a 2 decimales