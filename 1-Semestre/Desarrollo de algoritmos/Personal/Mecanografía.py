import random
import time
import requests

objetivo = requests.get(f"https://random-word-api.herokuapp.com/word?length={str(random.randint(10, 35))}&lang=es").json()[0]

tiempo_inicio = time.time()

frase = input(f"Escribe: {objetivo}\n-> ")

tiempo_final = time.time()

duracion = tiempo_final - tiempo_inicio # Tiempo transcurrido desde que empieza y termina de escribir
longitud = len(objetivo.split(" ")) # Cantidad de palabras

if frase == objetivo:
    print(f"Tardaste {duracion:.2f} segundos en escribir {longitud} palabras")
else:
    print(f"Has perdido!") 