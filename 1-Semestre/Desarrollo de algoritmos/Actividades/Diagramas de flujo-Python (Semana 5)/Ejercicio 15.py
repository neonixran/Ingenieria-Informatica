'''
Usted se dedica a sembrar pasto para jardines de lujo, para lo cual, cobra sus honorarios por m².
Este costo incluye materiales (semillas y abonos). Calcular el costo total de su trabajo en un jardín de N m².
    - Considere que el kilo de semillas tiene un costo de $5.000 y esto cubre 1 m2 del jardín.
    - El abono tiene un costo de $2.000 y esto cubre, también, 1 m² del jardín.
    - Los honorarios del jardinero (mano de obra) son de $30.000 por cada m2.
Los N m² son ingresados por el usuario.
'''

print("Este programa calcula el costo total de sembrar pasto para jardines de lujo.")
m2 = int(input("Ingrese la cantidad de m² trabajados: "))

while m2 <= 0:
    print("[!] La cantidad de m² debe ser positiva.")
    m2 = int(input("Ingrese la cantidad de m² trabajados: "))

total = m2 * (5000 + 2000 + 30000)
print(f"El costo total del trabajo es ${total}")