/*
1. Escriba una consulta que por cada empleado despliegue su código, apellido, salario y salario incrementado en un 15% expresado como un número entero.
   Nombre esta última columna como NUEVO SALARIO.
*/
SELECT empleado_id, apellido, salario, salario * 1.15 "NUEVO SALARIO"
FROM empleados;

-- 2. Modifique su consulta del problema anterior y agregue una columna que muestre la resta entre el nuevo salario y el antiguo y llámela DIFERENCIA.
SELECT empleado_id, apellido, salario, salario * 1.15 "NUEVO SALARIO", (salario * 1.15) - salario "DIFERENCIA"
FROM empleados;

/*
3. Escriba una consulta que despliegue el nombre de cada empleado con la primera letra en mayúscula y todas las otras en minúscula y el largo de su nombre para todos los empleados cuyo nombre comience con la letra J, M o A.
   Póngale a cada columna un nombre apropiado y ordene esta consulta por el nombre de empleado.
*/
SELECT INITCAP(nombre) "NOMBRE EMPLEADO", LENGTH(nombre) "LARGO NOMBRE"
FROM empleados
WHERE SUBSTR(nombre, 1, 1) IN('A', 'J', 'M')
ORDER BY "NOMBRE EMPLEADO";

/*
4. Escriba una consulta que por cada empleado despliegue el apellido y calcule el número de meses entre hoy y la fecha en que el ingresó.
   Llame a esta última columna como MESES TRABAJADOS. Ordene esta consulta por el número de meses trabajados.
   Redondee el número de meses en un número entero.
*/
SELECT apellido, ROUND(MONTHS_BETWEEN(TO_DATE('25/03/04', 'DD/MM/YY'), fecha_ing)) "MESES TRABAJADOS"
FROM empleados
ORDER BY "MESES TRABAJADOS" DESC;

/*
5. Escriba una consulta ( usando la función CONCAT) que produzca la siguiente salida para cada empleado: <apellido> gana <salario> mensualmente, pero desearía ganar < 3 veces su salario>.
   Llame a esta columna como Salario Soñado.
*/
SELECT CONCAT(apellido, CONCAT(' gana ', CONCAT(salario, CONCAT(' mensualmente, pero desearía ganar ', salario * 3)))) "Salario Soñado"
FROM empleados;

/*
6. Escriba una consulta que despliegue el apellido y salario de todos los empleados.
   El formato del salario es de largo 15 y debe justificarlo a la izquierda con el signo ‘$’.
   Nombre a esta última columna como SALARIO.
*/
SELECT apellido, LPAD(salario, 15, '$') AS SALARIO
FROM empleados;

-- 7. Escriba una consulta SQL que despliegue para cada empleado, su apellido, nombre, fecha de ingreso y los años y meses de servicio. Ponga nombres apropiados a cada columna.
SELECT
    apellido,
    nombre,
    fecha_ing,
    MONTHS_BETWEEN(TO_DATE('25/08/03', 'DD/MM/YY'), fecha_ing) / 12 "Años Trabajados",
    MONTHS_BETWEEN(TO_DATE('25/08/03', 'DD/MM/YY'), fecha_ing) "Meses Trabajados"
FROM empleados;