# 29 de abril 2025

# Calcular la nota de presentación y nota final de un alumno
print("Este programa calcula la nota de presentación y nota final")
t1 = float(input("Ingrese nota del test 1: "))
t2 = float(input("Ingrese nota del test 2: "))
t3 = float(input("Ingrese nota del test 3: "))
c1 = float(input("Ingrese nota del certamen 1: "))
t4 = float(input("Ingrese nota del test 4: "))
c2 = float(input("Ingrese nota del certamen 2: "))

np = (((t1 * 0.5 + t2 * 0.5)*0.25) + ((t3 * 0.3 + c1 * 0.7)*0.35) + ((t4 * 0.3 + c2 * 0.7)*0.4))

print(f"La nota de presentación es {round(np, 1)}\n")
nex = float(input("Ingrese nota de examen: "))
nf =  np*0.6 + nex*0.4
print(f"La nota final es {round(nf, 1)}")