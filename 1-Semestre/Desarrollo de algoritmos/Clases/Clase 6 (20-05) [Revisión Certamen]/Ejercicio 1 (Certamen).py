r = "s"

while r == "s":
    a = int(input("Ingrese el procentaje de asistencia a clases: "))

    if a >= 0 and a <= 100:
        print(f"Su porcentaje de asistencia es {a} y es válido")
    else:
        print("Ingrese porcentaje válido")

    r = input("Otra vez (s/n): ").lower()

    # Comprueba si la variable "r" es distinta de "s" y "n", útil para que solo pueda ingresar esos dos valores y no otros.
    while r != "n" and r != "s":
        print("Ingrese un valor válido")
        r = input("Otra vez (s/n): ").lower()