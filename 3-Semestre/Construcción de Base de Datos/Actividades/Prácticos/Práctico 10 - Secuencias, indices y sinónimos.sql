/*
1. Cree una secuencia para ser utilizada con la columna de primary key de la tabla DEPT. La secuencia debería comenzar en 200 y tener un valor máximo de 1000.
Debe incrementarse en 10 números cada vez. Llame a la secuencia DEPT_ID_SEQ.
*/

CREATE SEQUENCE DEPT_ID_SEQ
    INCREMENT BY 10
    START WITH 200
    MAXVALUE 1000;

-- 2. Escriba una consulta para desplegar la siguiente información acerca de sus secuencias: nombre de la secuencia, valor máximo, tamaño del incremento, y último número.
SELECT sequence_name, min_value, max_value, increment_by, last_number
FROM user_sequences
WHERE sequence_name = 'DEPT_ID_SEQ';

/*
3. Inserte dos filas en la tabla DEPT. Asegúrese de usar la secuencia que creó para la columna id. Agregue dos departamentos llamados Education y Administration.
Confirme sus inserciones.
*/

INSERT INTO DEPT(id, nombre) VALUES (DEPT_ID_SEQ.NEXTVAL, 'Education');
INSERT INTO DEPT(id, nombre) VALUES (DEPT_ID_SEQ.NEXTVAL, 'Administration');

SELECT *
FROM DEPT
WHERE Nombre IN('Education', 'Administration');

-- 4. Cree un índice no único para la columna de clave foránea DEPT_ID en la tabla EMP.
CREATE INDEX emp_dept_id_idx ON EMP(DEPT_ID);

-- 5. Despliegue los índices y la unicidad que existe en el diccionario de datos para la tabla EMP.
SELECT ic.index_name, ic.table_name, ix.uniqueness
FROM user_indexes ix, user_ind_columns ic
WHERE ic.index_name = ix.index_name AND ic.table_name = 'EMP';