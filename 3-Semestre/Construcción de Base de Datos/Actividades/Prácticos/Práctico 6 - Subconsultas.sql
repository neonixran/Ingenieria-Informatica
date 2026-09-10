/*
1. Construya una Consulta SQL que despliegue  apellido y fecha de ingreso de aquellos empleados
   que trabajan en el mismo departamento que Zlotkey. Excluya a Zlotkey.
*/

SELECT apellido, fecha_ing
FROM empleados
WHERE departamento_id = (
    SELECT departamento_id
    FROM empleados
    WHERE LOWER(apellido) = 'zlotkey'
) AND LOWER(apellido) <> 'zlotkey';

/*
2. Escriba una consulta SQL que despliegue el número de empleado (id), apellido y salario de todos
   los empleados que ganan más que el salario promedio. Ordene esta consulta en orden ascendente
   de salario.
*/

SELECT empleado_id, apellido, salario
FROM empleados
WHERE salario > (
    SELECT AVG(salario)
    FROM empleados
)
ORDER BY salario ASC;

/*
3. Escriba una consulta SQL que despliegue el número de empleado (id) y apellido de todos los empleados que trabajan
   en un departamento con cualquier empleado cuyo apellido contenga una letra u.
*/

SELECT empleado_id, apellido
FROM empleados
WHERE departamento_id IN (
    SELECT departamento_id
    FROM empleados
    WHERE apellido LIKE '%u%'
);

/*
4. Escriba una consulta SQL que despliegue el apellido, número de departamento y cargo id
   de todos los empleados cuyo lugar id es 1700.
*/

SELECT apellido, departamento_id, cargo_id
FROM empleados
WHERE departamento_id IN (
    SELECT departamento_id
    FROM departamentos
    WHERE lugar_id = 1700
);

/*
5. Despliegue el apellido y sueldo de cada empleado cuyo jefe sea King. (5 filas)
*/

SELECT apellido, salario
FROM empleados
WHERE jefe_id IN (
    SELECT empleado_id
    FROM empleados
    WHERE apellido = 'King'
);

/*
6. Despliegue el número de departamento, apellido, cargo id para cada empleado en el departamento Executive. (3 filas)
*/

SELECT departamento_id, apellido, cargo_id
FROM empleados
WHERE departamento_id = (
    SELECT departamento_id
    FROM departamentos
    WHERE dept_nombre = 'Executive'
);

/*
7. Modifique la consulta 3 para desplegar los números de empleado, apellidos sueldos de todos
   los empleados que ganan más que el salario promedio y que trabajan en un departamento
   con cualquier empleado con una u en su nombre. (1 fila)
*/

SELECT empleado_id, apellido, salario
FROM empleados
WHERE salario > (
    SELECT AVG(salario)
    FROM empleados
) AND departamento_id = ANY (
    SELECT departamento_id
    FROM empleados
    WHERE nombre LIKE '%u%'
);