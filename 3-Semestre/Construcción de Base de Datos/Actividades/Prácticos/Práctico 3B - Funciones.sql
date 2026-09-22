/*
1. Construya una Consulta SQL que para cada empleado despliegue su apellido, fecha de ingreso y la fecha en que se revisó su salario que es el primer lunes después de 6 meses de servicio.
   Nombre esta columna como REVISIÓN. El formato de salida de la fecha debe ser similar a “Lunes, 01 de Septiembre de 2003”.
*/
SELECT
    apellido,
    fecha_ing,
    TO_CHAR(NEXT_DAY(ADD_MONTHS(fecha_ing, 6), 'MONDAY'), 'DAY, DD "de" MONTH "de" YYYY', 'NLS_DATE_LANGUAGE=SPANISH') revision
FROM empleados;

-- 2. Escriba una consulta SQL que despliegue el apellido, fecha de ingreso y el día de la semana en que el empleado empezó a trabajar. Nombre esta columna como DIA. 
SELECT
    apellido,
    fecha_ing,
    TO_CHAR(fecha_ing, 'day', 'NLS_DATE_LANGUAGE=SPANISH') AS DIA
FROM empleados;

/*
3. Escriba una consulta SQL que despliegue el apellido, y comisión para todos los empleados, use alias para esta última columna.
   Si un empleado no gana comisión ponga SIN COMISION.
*/
SELECT
    apellido,
    NVL(TO_CHAR(comision_porc), 'Sin Comisión') AS comision
FROM empleados;

-- 4. Use la función DECODE para escribir una consulta que despliegue para todos sus empleados su apellido, cargo_id y grado considerando la siguiente tabla.
SELECT
    apellido,
    cargo_id,
    DECODE(cargo_id,
        'AD_PRES', 'A',
        'ST_MAN', 'B',
        'IT_PROG', 'C',
        'SA_REP', 'D',
        'ST_CLERK', 'E',
        0
    ) AS GRADO
FROM empleados;

-- 5. Resuelva el problema anterior, usando la expresión CASE.
SELECT
    apellido,
    cargo_id,
    CASE cargo_id
        WHEN 'AD_PRES' THEN 'A'
        WHEN 'ST_MAN' THEN 'B'
        WHEN 'IT_PROG' THEN 'C'
        WHEN 'SA_REP' THEN 'D'
        WHEN 'ST_CLERK' THEN 'E'
        ELSE '0'
    END AS grado
FROM empleados;