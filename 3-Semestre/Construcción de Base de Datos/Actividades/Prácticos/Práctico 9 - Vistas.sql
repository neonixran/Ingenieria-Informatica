/*
1. Cree una vista llamada EMPLEADOS_VU basada en los números de empleados, apellidos y números de departamentos desde
la tabla EMPLEADOS. Cambie el encabezado para el apellido del empleado a EMPLEADO.
*/
CREATE VIEW EMPLEADOS_VU AS
    SELECT empleado_id, apellido EMPLEADO, departamento_id
    FROM empleados

-- 2. Despliegue el contenido de la vista EMPLEADOS_VU.
SELECT *
FROM EMPLEADOS_VU;

-- 3. Seleccione el nombre de la vista y el texto desde la vista del diccionario de datos USER_VIEWS.
SELECT view_name, text
FROM USER_VIEWS
WHERE view_name = 'EMPLEADOS_VU';

/*
4. Utilizando su vista EMPLEADOS_VU, ingrese una consulta que despliegue todos los apellidos de los empleados
y los números de departamentos.
*/
SELECT empleado, departamento_id
FROM EMPLEADOS_VU;

/*
5. Cree una vista llamada DEPT50 que contiene los números de empleado, apellidos y número de departamento para todos los empleados
del departamento 50. Nombre a estas columnas EMPNO, EMPLEADO, y DEPTNO.
No permita que un empleado se a reasignado a otrodepartamento a través de la vista.
*/
CREATE VIEW DEPT50(EMPNO, EMPLEADO, DEPTNO) AS
    SELECT empleado_id, apellido, departamento_id
    FROM empleados
    WHERE departamento_id = 50
    WITH READ ONLY

-- 6. Despliegue la estructura y el contenido de la vista DEPT50
DESC DEPT50; --→ Estructura.

SELECT *
FROM DEPT50; --→ Contenido.

-- 7. Intente reasignar a Matos al departamento 80.
UPDATE DEPT50 SET deptno = 80
WHERE empleado = 'Matos'; --→ Error at line 1/19: ORA-42399: cannot perform a DML operation on a read-only view.

/*
8. Cree una vista llamada SALARIO_VU basada los apellidos de los empleados, nombres de departamentos, salarios y grados para todos
los empleados. Utilice las tablas EMPLEADOS, DEPARTAMENTOS y GRADOS_CARGOS.
Nombre a las columnas empleados, salarioy grado respectivamente
*/
CREATE VIEW SALARIO_VU AS
    SELECT e.apellido AS EMPLEADO, d.dept_nombre, e.salario AS SALARIO, g.grado_nivel AS GRADO
    FROM departamentos d
        JOIN empleados e ON(d.departamento_id = e.departamento_id)
        JOIN grados_cargos g ON(e.salario BETWEEN g.salario_bajo AND g.salario_alto)