/*
1. Crear una tabla con el nombre DEPT que tenga los siguientes campos:
ID numérico de largo 7 y NOMBRE caracter de largo 25. Confirme que la tabla fue creada.
*/

CREATE TABLE DEPT (
    ID NUMBER(7),
    NOMBRE VARCHAR2(25)
);

/*
2. Pueble la tabla DEPT con datos desde la tabla DEPARTAMENTOS incluyendo sólo las columnas que necesita.
Confirme que los datos fueron almacenados.
*/

INSERT INTO DEPT(ID, NOMBRE)
    SELECT departamento_id, dept_nombre
    FROM departamentos;

-- 3. Cree la tabla EMP basado en la siguiente tabla. Confirme que la tabla fue creada.
CREATE TABLE EMP(
    ID NUMBER(7),
    APELLIDO VARCHAR2(25),
    NOMBRE VARCHAR2(25),
    DEPT_ID NUMBER(7)
);

-- 4. Modifique la tabla empleado aumentando al doble el largo del apellido. Confirme su modificación.
ALTER TABLE EMP MODIFY(
    APELLIDO VARCHAR2(50)
);

-- 5. Confirme que ambas tablas DEPT y EMP fueron almacenadas en el diccionario de datos.
SELECT table_name
FROM user_tables
ORDER BY last_analyzed DESC;

/*
6. Cree la tabla EMPLEADO2 basado en la estructura de la tabla EMPLEADOS. Incluya sólo las columnas empleado_id, nombre,
apellido y salario. Nombre las columnas en su nueva tabla como ID, FIRST_NAME;LAST_NAME y SALARY respectivamente.
Confirme la creación de su tabla.
*/

CREATE TABLE EMPLEADO2(
    ID NUMBER(7),
    FIRST_NAME VARCHAR2(25),
    LAST_NAME VARCHAR2(25),
    SALARY NUMBER(8, 2)
);

-- 7. Borre la tabla EMP.
DROP TABLE EMP;

-- 8. Renombre la tabla EMPLEADO2 y póngale EMP.
RENAME EMPLEADO2 TO EMP;

-- 9. Borre la columna FIRST_NAME de la tabla EMP. Confirme su modificación.
ALTER TABLE EMP DROP COLUMN FIRST_NAME;

/*
10. Agregue una constraint de PRIMARY KEY a nivel de tabla en la tabla EMP sobre la columna ID.
Nombre la constraint como my_emp_id_pk.
*/

ALTER TABLE EMP
ADD CONSTRAINT my_emp_id_pk PRIMARY KEY(ID);

/*
11. Agregue una constraint de PRIMARY KEY a nivel de tabla en la tabla DEPT sobre la columna ID.
Nombre la constraint como my_dept_id_pk.
*/
ALTER TABLE DEPT
ADD CONSTRAINT my_dept_id_pk PRIMARY KEY(ID);

/*
12. Agregue una columna DEPT_ID en la tabla EMP. Agregue una restricción de FOREIGN KEY en la tabla empleado que asegure que
el empleado no será asignado a un departamento inexistente. Nombre la restricción como my_emp_dept_id_fk.
*/
ALTER TABLE EMP ADD(
    DEPT_ID NUMBER(7)
);

ALTER TABLE EMP
ADD CONSTRAINT my_emp_dept_id_fk FOREIGN KEY(DEPT_ID) REFERENCES DEPT(ID);

-- 13. Confirme que las constraints han sido añadidas consultando la vista de USER_CONSTRAINT.
SELECT CONSTRAINT_NAME, CONSTRAINT_TYPE
FROM USER_CONSTRAINTS
ORDER BY LAST_CHANGE DESC;

-- 14. Despliegue los nombres de los objetos y tipos desde el diccionario de datos USER_OBJECTS para las tablas EMP y DEPT.
SELECT OBJECT_NAME, OBJECT_TYPE
FROM USER_OBJECTS
WHERE OBJECT_NAME IN ('EMP', 'DEPT');

/*
15. Modifique la tabla EMP. Agregue la columna COMISION con un tipo de dato de precisión 2 y escala 2.
Agregue una restricción a dicha columna de forma tal que se asegure que el valor de la comisión será mayor o igual que cero.
*/
ALTER TABLE EMP ADD(
    COMISION NUMBER(2, 2) CONSTRAINT ck_comision CHECK (COMISION >= 0)
);

/*
16. Ejecute la siguiente instrucción:

CREATE TABLE mi_emp(
    id NUMBER(4) CONSTRAINT mi_emp_id_nn NOT NULL,
    apellido VARCHAR2(25),
    nombre VARCHAR2(25),
    mail VARCHAR2 (8),
    salario NUMBER(9,2)
);
*/
CREATE TABLE mi_emp(
    id NUMBER(4) CONSTRAINT mi_emp_id_nn NOT NULL,
    apellido VARCHAR2(25),
    nombre VARCHAR2(25),
    mail VARCHAR2 (8),
    salario NUMBER(9,2)
);

-- 17. Agregue la primera y segunda fila de datos de la siguiente tabla.
INSERT INTO mi_emp VALUES(1, 'Patel', 'Ralph', 'rpatel', 895);
INSERT INTO mi_emp VALUES(2, 'Dancs', 'Betty', 'bdancs', 860);

-- 18. Vea el contenido de la tabla recién creada y poblada.
SELECT *
FROM mi_emp;

/*
19. Escriba un script llamado loademp.sql para grabar el resto de los empleados de la tabla usando variables de sustitución.
La dirección de mail se debe obtener a partir de la concatenación de la primera letra del nombre con el apellido considerando que
en total deben ser 8 caracteres todos en minúscula. El Nombre y el apellido deben almacenarse con letra INITCAP. 
*/

-- 20. Ejecute el script para poblar dos filas más de la tabla.
INSERT INTO mi_emp VALUES(3, INITCAP(:apellido), INITCAP(:nombre), LOWER(SUBSTR(:nombre, 1, 1) || SUBSTR(:apellido, 1, 7)), :salario);
INSERT INTO mi_emp VALUES(4, INITCAP(:apellido), INITCAP(:nombre), LOWER(SUBSTR(:nombre, 1, 1) || SUBSTR(:apellido, 1, 7)), :salario);

-- 21. Vea el contenido de la tabla.
SELECT *
FROM mi_emp;

-- 22. Grabe los cambios de forma que sean permanentes.
COMMIT;

-- 23. Cambie el apellido del empleado 3 por Drexler.
UPDATE mi_emp
SET apellido = 'Drexler'
WHERE id = 3;

-- 24. Cambie el salario a 1000 para todos los empleados cuyo salario sea menor a 900.
UPDATE mi_emp
SET salario = 1000
WHERE salario < 900;

-- 25. Verifique sus cambios en la tabla.
SELECT *
FROM mi_emp;

-- 26. Borre a la empleada Betty Dancs de la tabla.
DELETE FROM mi_emp
WHERE id = 2; -- O también: WHERE nombre = 'Betty' AND apellido = 'Dancs';

-- 27. Verifique sus cambios en la tabla.
SELECT *
FROM mi_emp;

-- 28. Confirme sus últimos cambios para que sean permanentes
COMMIT;

-- 29. Vacíe la tabla MI_EMP.
TRUNCATE TABLE mi_emp;

-- 30. Verifique sus cambios en la tabla.
SELECT *
FROM mi_emp;