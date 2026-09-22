/*
1. Al jefe de Global Fast Foods le gustaría enviar cupones para la próxima oferta. Desea enviar un
cupón a cada domicilio. Cree una sentencia SELECT que devuelva el apellido del cliente y una
dirección de correo postal.
*/
SELECT last_name, address
FROM f_customers;

/*
2. Cada una de las sentencias siguientes tiene errores. Corrija los errores y ejecute la consulta en
Oracle Application Express.
    a.
    SELECT first name
    FROM f_staffs;

    b.
    SELECT first_name |" " | last_name AS "DJs on Demand Clients"
    FROM d_clients;

    c.
    SELECT DISTINCT f_order_lines
    FROM quantity;

    d.
    SELECT order number
    FROM f_orders 
*/
SELECT first_name
FROM f_staffs;

SELECT first_name || ' ' || last_name AS "DJs on Demand Clients"
FROM d_clients;

SELECT DISTINCT quantity
FROM f_order_lines;

SELECT order_number
FROM f_orders;

/*
3.  Sue, Bob y Monique han sido los empleados del mes. Mediante la tabla f_staffs, cree una
    sentencia SELECT para mostrar los resultados como aparecen en la tabla Super Star.  
*/
SELECT '*** ' || first_name || ' *** ' || first_name || ' ***' AS "Super Star"
FROM f_staffs;

/*
4. ¿Cuál de las siguientes afirmaciones es VERDADERA sobre la siguiente consulta?
    SELECT first_name, DISTINCT birthdate
    FROM f_staffs;
        
        a. Solo se devolverán dos filas.
        b. Se devolverán cuatro filas.
        c. Solo se devolverán Fred 05-Jan-1988 y Lizzie 10-Nov-1987.
        (d). No se devolverá ninguna fila
*/

/*
5. Global Fast Foods ha decidido conceder un aumento del 5% a todos los miembros de la plantilla.
    Prepare un informe que presente la salida como se muestra en la tabla.
*/
SELECT
    last_name AS "EMPLOYEE LAST NAME",
    salary AS "CURRENT SALARY",
    salary * 1.05 AS "SALARY WITH 5% RAISE"
FROM f_staffs;

/*
6. Cree una consulta que devuelva la estructura de la tabla EMPLOYEES de la base de datos
    Oracle. ¿Qué columnas se marcan como “valores nulos”? ¿Qué significa esto?

- Las columnas que se marcan como nulos son "first_name" y "phone_number", y significa que estas columnas pueden no tener valores.
*/
DESC employees;

/*
7. Los propietarios de DJs on Demand desean obtener un informe de todos los elementos de su
tabla D_CDs con las siguientes cabeceras de columna: Inventory Item, CD Title, Music Producer
y Year Purchased. Prepare este informe.
*/
SELECT
    cd_number AS "Inventory Item",
    title AS "CD Title",
    producer AS "Music Producer",
    year AS "Year Purchased"
FROM d_cds;

/*
8. Verdadero/Falso: La siguiente sentencia SELECT se ejecuta correctamente:
    SELECT last_name, job_id, salary AS Sal
    FROM employees;

- Verdadero
*/

/*
9. Verdadero/Falso: La siguiente sentencia SELECT se ejecuta correctamente:
    SELECT *
    FROM job_grades;

- Verdadero
*/

/*
10. Hay cuatro errores de código en esta sentencia. ¿Puede identificarlos?
    SELECT employee_id, last_name
    sal x 12 ANNUAL SALARY
    FROM employees;

1. Falto la coma entre last_name y la expresión "sal x 12"
2. El operador de multiplicación no es "x", sino "*"
3. Faltaron la comas en "ANNUAL SALARY"
*/
SELECT employee_id, last_name, salary * 12 "ANNUAL SALARY"
FROM employees;

/*
11. En la expresión aritmética salary*12 - 400, ¿qué operación se evalúa en primer lugar?

- La multiplicación
*/


/*
12. ¿Cuál de las siguientes opciones se puede utilizar en la sentencia SELECT para devolver todas
las columnas de datos de la tabla f_staffs de Global Fast Foods?
    a. nombres de columna
    (b). *
    c. DISTINCT id
    d. a y b
*/
SELECT * FROM f_staffs;

/*
13. ¿Qué capacidad se utiliza al usar SQL para seleccionar columnas en una tabla?
    a. selección
    (b). proyección
    c. partición
    d. unión
*/

/*
14. SELECT last_name AS "Employee". La cabecera de columna aparecerá en el resultado de la
consulta como:
    a. EMPLOYEE
    b. employee
    (c). Employee
    d. "Employee:
*/

/*
15. ¿Cuál de las siguientes expresiones producirá el valor más alto?
    a. SELECT salary*6 + 100
    b. SELECT salary* (6 + 100)
    c. SELECT 6(salary+ 100)
    (d). SELECT salary+6*100
*/

/*
16. ¿Cuál de las sentencias siguientes devolverá una lista de los empleados con el siguiente
formato? Mr./Ms. Steven King is an employee of our company.

    a. SELECT "Mr./Ms."||first_name||' '||last_name 'is an employee of our company.'
    AS "Employees"
    FROM employees;
    b. SELECT 'Mr./Ms. 'first_name,last_name ||' '||'is an employee of our company.'
    FROM employees;
    (c). SELECT 'Mr./Ms. '||first_name||' '||last_name ||' '||'is an employee of our company.'
    AS "Employees"
    FROM employees ;
    d. SELECT Mr./Ms. ||first_name||' '||last_name ||' '||"is an employee of our company."
    AS "Employees"
    FROM employees
*/
SELECT 'Mr./Ms. '||first_name||' '||last_name ||' '||'is an employee of our company.' AS "Employees"
FROM employees;

/*
17. ¿Qué afirmación es verdadera acerca de las sentencias SQL?
    a. Las sentencias SQL son sensibles a mayúsculas/minúsculas.
    b. Las cláusulas SQL no se deben escribir en líneas separadas.
    (c). Las palabras clave no se pueden abreviar o dividir entre líneas.
    d. Las palabras clave SQL se introducen normalmente en minúsculas; las palabras restantes en mayúsculas.
*/

/*
18. ¿Qué consultas devolverán tres columnas cada una con cabeceras de columna en
MAYÚSCULAS?
    a. SELECT "Department_id", "Last_name", "First_name"
    FROM employees;
    (b). SELECT DEPARTMENT_ID, LAST_NAME, FIRST_NAME
    FROM employees;
    c. SELECT department_id, last_name, first_name AS UPPER CASE
    FROM employees
    d. SELECT department_id, last_name, first_name
    FROM employees;
*/

/*
¿Cuál de las siguientes sentencias puede fallar?
    (a). SELCT * FROM employees;
    b. Select * FROM employees;
    c. SELECT * FROM EMPLOYEES;
    d. SelecT* FROM employees;
*/

/*
20. Haga clic en el enlace History en la parte inferior de la ventana SQL Commands. Desplácese o
    utilice las flechas en la parte inferior de la página para buscar la sentencia que ha escrito para
    resolver el problema 3 anterior. (Sobre la cabecera de columna SuperStar). Haga clic en la
    sentencia para volver a cargarla en la ventana de comandos. Vuelva a ejecutar el comando para
    asegurarse de que es el que funciona correctamente. Una vez que se ha asegurado de que
    funciona, haga clic en el botón SAVE situado en la esquina superior derecha de la ventana SQL
    Commands e introduzca un nombre para la sentencia guardada. Utilice sus propias iniciales y
    “_superstar.sql”, de manera que si sus iniciales son CT, el nombre de archivo será
    CT_superstar.sql.

    Desconéctese de OAE y vuelva a conectarse inmediatamente. Regrese a la ventana
    SQL Commands, haga clic en el enlace Saved SQL en la parte inferior de la página y cargue su
    sentencia SQL guardada en la ventana Edit. Esto se realiza haciendo clic en el nombre del script.
    Edite la sentencia para que muestre + en lugar de *. Ejecute su sentencia corregida y guárdela
    como iniciales_superplus.sql.
*/