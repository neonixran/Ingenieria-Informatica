-- 1. Ejecute una consulta SQL que muestre el apellido, nombre y departamento de todos aquellos empleados que ingresaron el 7 de junio de 1994.
SELECT apellido, nombre, departamento_id
FROM empleados
WHERE fecha_ing = '94-JUN-07';

-- 2. Ejecute una consulta que muestre el apellido, nombre y salario de todos aquellos empleados que tengan un sueldo mensual superior a US$ 16000.
SELECT apellido, nombre, salario
FROM empleados
WHERE salario > 16000;

-- 3. Ejecute una consulta que muestre el mail, fono, y cargo de todos aquellos empleados cuyo apellido sea Taylor.
SELECT email, fono, cargo_id
FROM empleados
WHERE apellido = 'Taylor';

-- 4. Ejecute una consulta que muestre el nombre, apellido y salario de todos aquellos empleados cuyo salario mensual esté entre 2500 y 3500.
SELECT nombre, apellido, salario
FROM empleados
WHERE salario BETWEEN 2500 AND 3500;

-- 5. Ejecute una consulta que muestre el nombre, apellido y salario de todos los empleados cuyo sueldo mensual sea 17000 o 6000 0 3500.
SELECT nombre, apellido, salario
FROM empleados
WHERE salario IN(17000, 6000, 3500);

-- 6. Ejecute una consulta SQL que despliegue el nombre y cargo_id de los empleados que no tienen jefe.
SELECT nombre, cargo_id
FROM empleados
WHERE jefe_id IS NULL;

-- 7. Ejecute una consulta SQL que despliegue apellido y cargo_id de aquellos empleados cuyo cargo no sea IT_PROG, ST_CLERK, SA_REP.
SELECT apellido, cargo_id
FROM empleados
WHERE cargo_id NOT IN('IT_PROG', 'ST_CLERK', 'SA_REP');

-- 8. Ejecute una consulta SQL que despliegue el código de empleado, apellido y salario anual, nombrando esta última columna como RENTA ANUAL ordenado por dicha renta anual.
SELECT empleado_id, apellido, salario * 12 "RENTA ANUAL"
FROM empleados
ORDER BY "RENTA ANUAL";

-- 9. Ejecute una consulta SQL que despliegue el apellido, código de departamento y salario ordenado por departamento ( ascendente) y por salario ( descendente).
SELECT apellido, departamento_id, salario
FROM empleados
ORDER BY departamento_id, salario DESC;

-- 10. Crear una consulta que despliegue el apellido y salario de los empleados que ganan mensualmente más de US$12000. 
SELECT apellido, salario
FROM empleados
WHERE salario > 12000;

-- 11. Crear una consulta que despliegue el apellido, nombre y número de departamento del empleado número 176.
SELECT apellido, nombre, departamento_id
FROM empleados
WHERE empleado_id = 176;

-- 12. Modifique la consulta del ejercicio 10. para desplegar el apellido y salario de todos los empleados cuyo salario no está en el rango de US$5000 y US$12000.
SELECT apellido, salario
FROM empleados
WHERE salario NOT BETWEEN 5000 AND 12000;

/*
13. Crear una consulta que despliegue el apellido, código de cargo y fecha de ingreso de los empleados que ingresaron entre el 20 de febrero de 1998 y el primero de mayo de 1998.
    Ordene esta consulta en orden ascendente por fecha de ingreso.
*/
SELECT apellido, cargo_id, fecha_ing
FROM empleados
WHERE fecha_ing BETWEEN '98-FEB-20' AND '98-MAY-01'
ORDER BY fecha_ing;

-- 14. Crear una consulta que despliegue el apellido y número de departamento de los empleados del departamento 20 y 50 ordenados alfabéticamente por apellido.
SELECT apellido, departamento_id
FROM empleados
WHERE departamento_id IN(20, 50)
ORDER BY apellido;

/*
15. Modifique el ejercicio 12. para listar el apellido y salario de los empleados que ganan entre US$5000 y US$ 12000 y que estén en el departamento 20 o 50.
    Nombre las columnas como EMPLEADO y SALARIO MENSUAL respectivamente.
*/
SELECT apellido "EMPLEADO", salario "SALARIO MENSUAL"
FROM empleados
WHERE salario BETWEEN 5000 AND 12000
AND departamento_id IN(20, 50);

-- 16. Ejecute una consulta que despliegue el apellido y fecha de ingreso de todos los empleados que ingresaron el año 1994.
SELECT apellido, fecha_ing
FROM empleados
WHERE fecha_ing LIKE '94%';

/* 
17. Ejecute una consulta que muestre el apellido, salario y porcentaje de comisión de todos los empleados que ganan comisión.
Ordene esta consulta en orden descendente por salario y comisión.
*/
SELECT apellido, salario, comision_porc
FROM empleados
WHERE comision_porc IS NOT NULL
ORDER BY salario desc, comision_porc desc;

-- 18. Ejecute una consulta que muestre el apellido de todos los empleados cuyo apellido tenga la letra a en tercer lugar.
SELECT apellido
FROM empleados
WHERE apellido LIKE '__a%';

-- 19. Ejecute una consulta que muestre el apellido de todos los empleados que tengan una a y una e en sus apellidos.
SELECT apellido
FROM empleados
WHERE apellido LIKE '%a%' AND apellido LIKE '%e%';

-- 20. Ejecute una consulta que despliegue el apellido, código del cargo y salario cuyo cargo_id es SA_REP o ST_CLERK y cuyos salarios no sean igual a 2500, 3500 o 7000.
SELECT apellido, cargo_id, salario
FROM empleados
WHERE cargo_id IN('SA_REP', 'ST_CLERK') AND salario NOT IN(2500, 3500, 7000);

-- 21. Modifique el ejercicio 15. para desplegar el nombre, apellido, salario y porcentaje de comisión de todos aquellos empleados cuya comisión es del 20%.
SELECT nombre, apellido, salario, comision_porc
FROM empleados
WHERE comision_porc = '.20';