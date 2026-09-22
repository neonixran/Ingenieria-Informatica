cont_13 = 0
suma_13 = 0
cont_17 = 0
suma_17 = 0

for i in range(1, 101):
    if i % 13 == 0:
        cont_13 += 1
        suma_13 += i
    elif i % 17 == 0:
        cont_17 += 1
        suma_17 += i

promedio_13 = suma_13  / cont_13
promedio_17 = suma_17  / cont_17

print(f"La suma de los múltiplos de 13 es {suma_13} y su promedio es {promedio_13}")
print(f"La suma de los múltiplos de 17 es {suma_17} y su promedio es {promedio_17}")