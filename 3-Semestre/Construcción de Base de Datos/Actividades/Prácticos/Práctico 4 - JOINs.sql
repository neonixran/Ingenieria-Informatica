/*
1. Escriba una consulta SQL que despliegue el apellido, número de departamento y nombre de departamento de todos los empleados.
   Utilice alias apropiados en cada columna y ordene esta consulta por apellido.
*/

-- Usando Oracle "Equijoin"
SELECT
    apellido AS "Empleado",
    e.departamento_id AS "Nº Depto",
    dept_nombre AS "Nombre Departamento"
FROM
    empleados e,
    departamentos d
WHERE e.departamento_id = d.departamento_id -- Unión de tablas, departamento_id es FK de Empleados y PK de Departamentos
ORDER BY apellido; -- Ordenar por apellido

/*
2. Escriba una consulta SQL que despliegue un único cargo con su nombre para todos los empleados que trabajan en el departamento 80.
   Incluya el lugar del departamento en la salida.
*/

-- Usando SQL-JOIN con ON
SELECT
    e.cargo_id AS CARGO,
    nombre_cargo AS "NOMBRE CARGO",
    lugar_id AS "LUGAR"
FROM
    empleados e JOIN departamentos d ON(e.departamento_id = d.departamento_id) -- departamento_id es FK de Empleados y PK de Departamentos
    JOIN cargos ca ON(ca.cargo_id = e.cargo_id) -- cargo_id es FK de Empleados y PK de Cargos
WHERE e.departamento_id = 80; -- Filtro por ID del departamento

/*
3. Escriba una consulta SQL que despliegue apellido, nombre de departamento, lugar id y ciudad de todos los empleados que ganan comisión.
*/

-- Usando SQL-JOIN con ON
SELECT
    apellido,
    dept_nombre,
    d.lugar_id,
    ciudad
FROM
    empleados e JOIN departamentos d ON(e.departamento_id = d.departamento_id) -- departamento_id es FK de Empleados y PK de departamentos.
    JOIN lugares l ON(d.lugar_id = l.lugar_id) -- lugar_id es FK de Departamentos y PK de Lugares.
WHERE comision_porc IS NOT NULL;

/*
4. Escriba una consulta SQL que despliegue el apellido y nombre del departamento
   en mayúscula de todos aquellos empleados que tengan la letra a minúscula en su apellido.
*/

-- Usando Oracle Equijoin
SELECT
    apellido,
    UPPER(dept_nombre) AS DEPARTAMENTO
FROM
    empleados e,
    departamentos d
WHERE
    e.departamento_id = d.departamento_id -- Unión de tablas, departamento_id es FK de Empleados y PK de Departamentos
    AND apellido LIKE '%a%'; -- Filtro por apellido con a minúscula

/*
5. Escriba una consulta SQL que despliegue el apellido, cargo, número de departamento y
   nombre del departamento de todos los empleados que trabajan en Toronto.
*/

-- Usando Oracle-Join con Using
SELECT
    apellido,
    cargo_id,
    departamento_id,
    dept_nombre
FROM
    empleados e JOIN departamentos d USING(departamento_id) -- departamento_id es FK de Empleados y PK de Departamentos
    JOIN lugares l USING(lugar_id) -- lugar_id es FK de Departamentos y PK de Lugares
WHERE ciudad = 'Toronto'; -- Filtro por ciudad

/*
6. Escriba una consulta SQL que despliegue el apellido, número de empleado, nombre de su jefe y número de su jefe.
   Ponga los siguientes alias a las columnas: Empleado, NºEmp, Jefe, NºJefe respectivamente.
*/

-- Usando Selft Join
SELECT
    t.apellido AS "Empleado",
    t.empleado_id AS "Nº emp",
    j.apellido AS "Jefe",
    j.empleado_id AS "Nº Jefe"
FROM
    empleados t,
    empleados j
WHERE t.jefe_id = j.empleado_id;

/*
7. A partir de la consulta en 6, genere una consulta que despliegue a todos los empleados incluyendo a King que no tiene jefe. 
*/

-- Usando Oracle Outer y Selft Join
SELECT
    t.apellido AS "Empleado",
    t.empleado_id AS "Nº emp",
    j.apellido AS "Jefe",
    j.empleado_id AS "Nº Jefe"
FROM
    empleados t, 
    empleados j -- Selft Join, une la tabla consigo misma.
WHERE t.jefe_id = j.empleado_id(+); -- (+) Outer Join, muestra a los empleados que no tienen jefe.

/*
8. Escriba una consulta SQL que despliegue el apellido, cargo_id y nombre del cargo para todos los empleados (20 filas seleccionadas).
*/

-- Usando Oracle Natural-Join
SELECT
    apellido,
    cargo_id,
    nombre_cargo
FROM empleados NATURAL JOIN cargos; -- Une las tablas por columnas con el mismo nombre.

/*
9. Escriba una consulta SQL que despliegue apellido, nombre, nombre de departamento, nombre del cargo y salario de todos los empleados.
   Use alias apropiados en todas las columnas y ordene esta consulta por salario en forma descendente (20 filas seleccionadas).
*/

-- Usando Oracle Outer-Join
SELECT
    apellido AS "Apellido emp.",
    nombre AS "Nombre emp.",
    nombre_cargo AS "Cargo",
    dept_nombre AS "Nombre dept.",
    salario AS "Salario emp."
FROM
    empleados e,
    departamentos d,
    cargos c
WHERE
    e.departamento_id = d.departamento_id(+) -- departamento_id es FK de Empleados y PK de Departamentos. (+) Para mostrar todos los empleados, incluso los que no tienen departamento.
    AND e.cargo_id = c.cargo_id -- cargo_id es FK de Empleados y PK de Cargos.
ORDER BY salario DESC; -- Ordenar por salario de mayor a menor.

/*
10. Escriba una consulta SQL que despliegue el nombre, apellido y nombre del departamento en mayúscula de todos aquellos
empleados que ganan un salario mensual mayor a US$4000 y que tengan la letra a y la letra e minúscula en su apellido (3 filas seleccionadas)
*/

-- Usando SQL con Using
SELECT
    nombre,
    apellido,
    UPPER(dept_nombre) AS "Departamento"
FROM
    empleados JOIN departamentos USING(departamento_id) -- departamento_id es FK de Empleados y PK de departamentos
WHERE salario > 4000 AND apellido LIKE '%a%' AND apellido LIKE '%e%'; -- Filtro por salario y apellido