/*
1.Utilizando SELECT básico, seleccione todos los datos de las siguientes tablas.
 - Departamentos
 - Cargos 
 - Empleados
*/
SELECT * FROM departamentos;
SELECT * FROM cargos;
SELECT * FROM empleados;

-- 2. Cree una consulta SQL que despliegue el código y nombre completo de todos los empleados.
SELECT empleado_id, apellido, nombre
FROM empleados;

-- 3. Cree una consulta SQL que muestre el código de empleado, apellido, cargo y fecha de ingreso de cada empleado. 
SELECT empleado_id, apellido, cargo_id, fecha_ing
FROM empleados;

-- 4. Cree una consulta SQL que despliegue el código y nombre de departamento de la tabla departamentos.
SELECT departamento_id, dept_nombre
FROM departamentos;

/*
5. La columna salario de la tabla empleados almacena el salario mensual de cada empleado.
   Ejecute una consulta SQL que le permita obtener para cada empleado su apellido, su nombre y su salario anual.
*/
SELECT apellido, nombre, salario * 12
FROM empleados;

/*
6. Obtenga una consulta SQL que muestre cómo quedaría el salario anual de cada empleado si se le agrega un bono extra de US$100 al año.
   La consulta debe mostrar apellido, nombre y el nuevo salario.
*/
SELECT apellido, nombre, salario * 12 + 100
FROM empleados;

/*
7. Obtenga una consulta SQL que muestre cómo quedaría el salario anual de cada empleado si se le agrega un bono mensual de US$100.
   La consulta debe mostrar los campos nombre y el nuevo salario.
*/
SELECT apellido, nombre, 12 * (salario + 100)
FROM empleados;