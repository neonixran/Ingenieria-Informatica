for i in range(1, 11):
    estatura = float(input(f"Ingrese la estutura del alumno {i}: "))

    if estatura <= 0:
        print("Estatura inválida")
    elif estatura < 1.65:
        print("Estatura baja")
    elif estatura <= 1.8:
        print("Estatura media")
    elif estatura < 2.5:
        print("Estatura alta")
    else:
        print("Estatura inválida")