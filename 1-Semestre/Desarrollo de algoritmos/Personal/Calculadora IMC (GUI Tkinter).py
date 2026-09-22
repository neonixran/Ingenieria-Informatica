import tkinter as tk

# Crear ventana
ventana = tk.Tk()
ventana.title("Calculadora de IMC") # Titulo
ventana.geometry("300x200") # Tamaño ventana
ventana.resizable=True # Si se puede redimensionar

# Entradas de texto para la masa y estatura
masa_text = tk.Label(ventana, text="Ingrese su peso (kg):")
masa_text.pack()
masa = tk.Entry(ventana) # Cajón de texto
masa.pack()

estatura_text = tk.Label(ventana, text="Ingrese su estatura (cm):")
estatura_text.pack()
estatura = tk.Entry(ventana)
estatura.pack()

# Botón para confirmar
boton_confirmar = tk.Button(ventana, text="Calcular", command=lambda:calc_imc())
boton_confirmar.pack()

# Información del imc
text = tk.Label(ventana)
text.pack()

# Función para realizar el cálculo y mostrar en pantalla
def calc_imc():
   if not masa.get().isnumeric() or 0 <= float(masa.get()) > 500 or not estatura.get().isnumeric() or 0 <= float(estatura.get()) > 250:
    text.config(text="Ingrese valores válidos")
    masa.config(text="")
    estatura.config(text="")
   else:
    imc = float(masa.get())/((float(estatura.get())/100)**2)
    type=""

    if imc < 18:
      type = "Bajo peso"
    elif imc < 25:
      type = "Peso normal"
    elif imc < 30:
      type = "Exceso de peso"
    elif imc < 35:
      type = "Obesidad grado I"
    elif imc < 40:
      type = "Obesidad grado II"
    elif imc < 45:
      type = "Obesidad grado III (mórbida)"
    elif imc > 50:
      type = "Obesidad grado IV (extrema)"

    text.config(text=f"Su IMC es: {imc:.1f}\nSu categoría es: {type}")

ventana.mainloop()