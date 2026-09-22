# Fecha de entrega: 07-05-2025
print("Este programa calcula el IMC (Índice de Masa Corporal)")

rep = "s" # "s": Continua ejecutandose, "n": Termina el programa (puede ocurrir que con cualquier letra termina)

# Comprueba que mientras la variable rep sea igual a "s" se siga ejecutando
while rep.lower() == "s":
    # Se hacen comprobaciones de tipo (numérico) y rango de peso (0-500 kg) y estatura (0-250 cm) por separado
    masa = input("Ingrese su peso (kg): ")

    while not masa.isnumeric() or 0 <= float(masa) > 500:
        print("\t[!] Debe ingresar un valor numérico de 0 a 500 kg")
        masa = input("Ingrese nuevamente su peso (kg): ")

    estatura = input("Ingrese su estatura (cm): ")

    while not estatura.isnumeric() or 0 <= float(estatura) > 250:
        print("\t[!] Debe ingresar un valor numérico de 0 a 250 cm.")
        estatura = input("Ingrese nuevamente su estatura (cm): ")

    # Cálculo del imc, conversión de centímetros a metros
    imc = float(masa) / ((float(estatura) / 100) ** 2)

    # Tipos de peso
    if imc < 18:
        print("Bajo peso")
    elif imc < 25:
        print("Peso normal")
    elif imc < 30:
        print("Exceso de peso")
    elif imc < 35:
        print("Obesidad grado I")
    elif imc < 40:
        print("Obesidad grado II")
    elif imc < 45:
        print("Obesidad grado III (mórbida)")
    elif imc > 50:
        print("Obesidad grado IV (extrema)")
    else:
        print("No fue posible calcular")

    print(f"Su IMC es: {imc:.1f}")

    rep = input("\n¿Quiere calcular de nuevo? (s/n): ")