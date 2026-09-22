for i in range(1, 4):
    print(f"Estudiante #{i}")
    while True:
        try:
            n1 = float(input("Ingrese nota 1: "))

            if n1 < 1 or n1 > 7: # 1 < n1 > 7
                print("Ingrese una nota dentro del rango (1.0 a 7.0)")
                continue
        except ValueError:
            print("Ingrese un valor válido")
            continue

        try:
            n2 = float(input("Ingrese nota 2: "))

            if n2 < 1 or n2 > 7: # 1 < n2 > 7
                print("Ingrese una nota dentro del rango (1.0 a 7.0)")
                continue
        except ValueError:
            print("Ingrese un valor válido")
            continue
            
        prom = (n1 + n2) / 2
        print(f"Su promedio es {prom}")
        break