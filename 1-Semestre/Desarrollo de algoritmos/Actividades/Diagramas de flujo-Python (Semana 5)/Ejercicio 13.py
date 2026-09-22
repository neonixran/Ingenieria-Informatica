'''
Calcular el IMC (Índice de Masa Corporal).
    - Usando la fórmula: IMC = Masa / (estatura²)
Masa y estatura son ingresados por el usuario
'''

print("Este programa calcula el IMC (Índice de Masa Corporal)")
masa = float(input("Ingrese su peso (kg): "))
estatura = float(input("Ingrese su estatura (cm): "))


while masa <= 0 or estatura <= 0:
    print("[!] Debe ingresar valores positivos.")
    masa = float(input("Ingrese su peso (kg): "))
    estatura = float(input("Ingrese su estatura (cm): "))

imc = masa / ((estatura / 100) ** 2)

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
else:
    print("Obesidad grado III")

print(f"Su IMC es: {imc:.1f}")