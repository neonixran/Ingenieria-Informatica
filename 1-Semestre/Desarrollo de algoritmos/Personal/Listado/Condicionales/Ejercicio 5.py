'''
Para tributar un determinado impuesto se debe ser mayor de 16 años y tener unos ingresos iguales o
superiores a 1000 € mensuales. Escribir un programa que pregunte al usuario su edad y sus ingresos
mensuales y muestre por pantalla si el usuario tiene que tributar o no.
'''

continuar = "s"

while continuar == "s":
    while True:
        try:
            edad = int(input("Ingrese su edad: "))

            if edad <= 0:
                print("\t[!] Debe ingresar un edad válida")
                continue
            break
        except ValueError:
            print("Ingrese sólo números")
    
    while True:
        try:
            ingresos_mensuales = float(input("Ingrese sus ingresos mensuales: "))

            if ingresos_mensuales <= 0:
                print("\t[!] Debe ingresar un ingreso mensual válido")
                continue
            break
        except ValueError:
            print("Ingrese sólo números")

    if edad > 16 and ingresos_mensuales >= 1000:
        print("Debe tributar")
    else:
        print("No debe tributar")
    
    while True:
        try:
            continuar = input("Quiere volver a ejecutar? (s/n): ").lower()

            if continuar != "s" and continuar != "n":
                print("\t[!] Debe ingresar un valor válido")
                continue
            break
        except ValueError:
            print("Ingrese solo caracteres")