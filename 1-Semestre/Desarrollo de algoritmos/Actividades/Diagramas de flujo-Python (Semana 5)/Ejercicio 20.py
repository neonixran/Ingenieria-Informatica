'''
Expresar la capacidad de un disco duro en megabytes, kilobytes y bytes, conociendo la capacidad del disco en gigabytes.
Considere que:
    - 1 kilobyte = 1024 bytes
    - 1 megabyte = 1024 kilobyte
    - 1 gigabyte = 1024 megabytes
'''

print("Este programa convierte la capacidad de un disco duro en gigabytes a megabytes, kilobytes y bytes.")
gigabytes = int(input("Ingrese la capacidad del disco duro en gigabytes: "))
while gigabytes <= 0:
    print("[!] La capacidad del disco duro debe ser un número entero positivo.")
    gigabytes = int(input("Ingrese la capacidad del disco duro en gigabytes: "))

megabytes = gigabytes * 1024
kilobytes = megabytes * 1024
bytes = kilobytes * 1024
print(f"Capacidad del disco duro en:\nMegabytes: {megabytes} MB\nKilobytes: {kilobytes} KB\nBytes: {bytes} B")