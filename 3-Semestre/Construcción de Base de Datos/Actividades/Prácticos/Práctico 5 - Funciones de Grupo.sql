/*
1. Escriba una consulta SQL que despliegue para el salario el máximo, mínimo, suma y promedio para todos los empleados del departamento 50.
   Llame a estas columnas máximo, mínimo, suma y promedio respectivamente. Redondee sus resultados a un número entero. 
*/

SELECT
    ROUND(MAX(salario), 0) AS "máximo",
    ROUND(MIN(salario), 0) AS "mínimo",
    ROUND(SUM(salario), 0) AS "suma",
    ROUND(AVG(salario), 0) AS "promedio"
FROM empleados
WHERE departamento_id = 50;

/*
2. Aproveche la consulta anterior para desplegar el mínimo, máximo, suma y salario promedio por cada tipo de cargo.
   (Muestre el cargo correspondiente a cada valor de mínimo, máximo, suma y promedio).
*/

SELECT
    cargo_id,
    ROUND(MAX(salario), 0) AS "máximo",
    ROUND(MIN(salario), 0) AS "mínimo",
    ROUND(SUM(salario), 0) AS "suma",
    ROUND(AVG(salario), 0) AS "promedio"
FROM empleados
GROUP BY cargo_id;

-- 3. Escriba una consulta SQL que despliegue el número de personas con el mismo cargo. 

SELECT
    cargo_id AS CARGO,
    COUNT(empleado_id) AS PERSONAS
FROM empleados
GROUP BY cargo_id;

-- 4. Usando la columna jefe_id de la tabla empleado, determine el número de jefes existentes.
SELECT COUNT(DISTINCT jefe_id) AS "Número de Jefes" -- DISTINCT para contar los jefes sin repetir a uno que tenga 2 o mas empleados.
FROM empleados;

-- 5. Escriba una consulta SQL que despliegue la diferencia entre el máximo y el mínimo salario. Nombre esta columna como diferencia.
SELECT MAX(salario) - MIN(salario) AS "diferencia"
FROM empleados;

/*
6. Escriba una consulta SQL que despliegue el número de Jefe y el salario más bajo de los empleados que trabajan para él.
   Excluya cualquier jefe desconocido y excluya cualquier grupo cuyo salario mínimo sea inferior a 6000.
   Ordene esta consulta por salario en forma descendente.
*/

SELECT
    jefe_id,
    MIN(salario)
FROM empleados
WHERE jefe_id IS NOT NULL -- Excluye cualquier registro nulo.
GROUP BY jefe_id
HAVING MIN(salario) > 6000 -- Excluye cualquier grupo cuyo salario mínimo sea inferior a 6000.
ORDER BY MIN(salario) DESC; -- Ordenar por salario en forma descendente.

/*
7. Escriba una consulta SQL que despliegue el nombre de cada departamento, lugar, número de empleados y el salario promedio para todos los empleados de ese departamento.
   Llame a las columnas, nombre, localización, número de personas y salario respectivamente.
   Redondee el salario promedio a dos decimales.
*/

SELECT
    d.dept_nombre AS "nombre",
    d.lugar_id AS "localización",
    COUNT(e.empleado_id) AS "número de personas",
    ROUND(AVG(e.salario), 2) AS "salario"
FROM
    empleados e
    JOIN departamentos d ON d.departamento_id = e.departamento_id
GROUP BY
    d.dept_nombre,
    d.lugar_id;

/*
8. DESAFÍO: Crear una consulta matriz que despliegue el cargo, el salario para ese cargo basado en el número de departamento y el salario total
   para ese cargo para los departamentos 20,50,80 y 90. Nombre a cada columna con un alias apropiado.
*/

SELECT
    cargo_id AS "Cargo",
    SUM(CASE WHEN departamento_id = 20 THEN salario ELSE 0 END) AS "Depto 20",
    SUM(CASE WHEN departamento_id = 50 THEN salario ELSE 0 END) AS "Depto 50",
    SUM(CASE WHEN departamento_id = 80 THEN salario ELSE 0 END) AS "Depto 80",
    SUM(CASE WHEN departamento_id = 90 THEN salario ELSE 0 END) AS "Depto 90", -- Se usa la función CASE para crear columnas para cada departamento
    SUM(salario) AS "Total" -- Se calcula el salario total sin importar el departamento.
FROM empleados
GROUP BY cargo_id;