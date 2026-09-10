-- 1. Escriba una sentencia SQL que muestre una proyección.
SELECT last_name
FROM employees;

/*
2. Escriba una consulta que muestra last_name y las direcciones de correo electrónico de todas las
   personas de la tabla d_client de DJs on Demand. Las cabeceras de columna deben aparecer
   como “Client” e “Email Address”
*/
SELECT
    last_name AS "Client",
    email AS "Email Address"
FROM d_client;

/*
3. Escriba una consulta que muestre el apellido y el salario de todos los empleados. Para los
empleados que ganan una comisión, muestre el monto de la comisión. Para los que no la ganan,
muestre un valor de 0. Nombre la columna de comisión como “Commission”.
*/
SELECT
    last_name,
    salary,
    NVL(commission_pct, 0) AS "Commission"
FROM employees;

/*
3. La jefa de Global Fast Foods ha decidido conceder a todos los empleados un aumento del
    5%/hora y un incentivo de 0,50 $/hora. Sin embargo, al ver los resultados, no podía entender por
    qué los nuevos aumentos no eran los que había previsto. La Sra. Doe debería tener un nuevo
    salario de 7,59 $, el del Sr. Miller debería ser de 11,00 $, y el de Monique Tuttle de 63,50 $. Ha
    utilizado la siguiente consulta. ¿Qué debería haber hecho?
*/
SELECT
    last_name,
    ROUND((salary * 1.05) + 0.50, 2)
FROM f_staffs;

/*
4. ¿Cuál de las siguientes opciones sería la forma más sencilla de ver todas las filas de la tabla d_songs?
    a. SELECT id, title, duration, artist, type_code
    b. SELECT columns
    c. SELECT *
    d. SELECT all
*/
SELECT *
FROM d_songs;

/*
5. Si el impuesto = 8,5% * costo_vehículo y el permiso_conducir = costo_vehículo * 0,01%, ¿qué valor generará el pago de vehículo más alto?
    a. Pago = (costo_vehículo * 1,25) + 5,00 - (impuesto) - (permiso_conducir)
    (b). Pago = costo_vehículo * 1,25 + 5,00 - (impuesto - permiso_conducir) 
*/

/*
6. En el siguiente ejemplo, identifique las palabras clave, las cláusulas y las sentencias:
    SELECT employee_id, last_name
    FROM employees

- Palabras clave: SELECT y FROM
- CLÁUSULAS: SELECT employee_id, last_name y FROM employees
- SENTENCIAS: SELECT employee_id, last_name FROM employees;
*/

/*
7. Etiquete cada ejemplo como SELECTION o PROJECTION
    a. Necesito que me proporcione la dirección de correo electrónico de Mary Adam. -> Selección
    b. Solo necesito la columna manager_id y ninguna otra columna. -> Proyección
*/

/*
8. ¿Cuáles de las siguientes afirmaciones son verdaderas?
    a. null * 25 = 0;
    b. null * 6.00 = 6.00
    (c). null * .05 = null
    (d). (null + 1.00) + 5.00 = 5.00
*/

/*
9. ¿Cómo se etiquetan las cabeceras de columna en el siguiente ejemplo?
    SELECT bear_id bears, color AS Color, age “age”
    FROM animals;

    - a. bears, color, age
    - b. BEARS, COLOR, AGE
    - (c). BEARS, COLOR, age
    - d. Bears, Color, Age
*/

/*
10. ¿Cuáles de las siguientes palabras deben estar en una sentencia SELECT para que se
    devuelvan todas las filas?
        a. Solo SELECT
        (b). SELECT y FROM
        c. Solo FROM
        d. Solo SELECT *
*/