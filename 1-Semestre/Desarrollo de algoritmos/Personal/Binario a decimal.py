import os

respuesta = "s"

while True:
    os.system("cls")
    binario = list(input("Ingrese un número binario: "))[::-1]
    decimal = 0

    for i in range(len(binario)):
        if int(binario[i]) == 1:
            decimal += 2**i

    print(decimal)

    while True:
        respuesta = input("¿Quiere volver a calcular? (s/n): ").lower()

        if respuesta != "s" and respuesta != "n":
            print("Ingrese un valor válido")
        else:
            break