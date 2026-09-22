while True:
    try:
        altura = float(input("Ingrese su altura en metros (ej. 1.70): "))

        if altura <= 0:
            print("La altura debe ser un número positivo mayor que cero.")
            continue
    except ValueError:
        print("Por favor, ingrese un valor número válido para la altura.")
        continue

    try:
        peso = float(input("Ingrese su altura en kilogramos (ej. 70): "))

        if peso <= 0:
            print("El peso debe ser un número positivo mayor que cero.")
            continue
    except ValueError:
        print("Por favor, ingrese un valor número válido para el peso.")
        continue

    imc = peso / (altura**2)
    print(f"Su IMC es {imc:.2f}")

    continuar = input("¿Desea calcular otro IMC (s/n): ").strip().lower()

    if continuar != "s":
        print("Gracias por usar el programa.")
        break