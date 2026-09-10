

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Clase encargada de manejar la conexión y consultas SQL.
 * 
 * @author Josué Bravo
 */
public class Conector {

    private final String baseDatos;
    private final String usuario;
    private final String contraseña;

    private Connection conexion;

    /**
     * Crea una conexión usando la base de datos "world" con el usuario por
     * defecto "root" y sin contraseña.
     *
     * @throws SQLException si ocurre un error al establecer la conexión
     * @see #conectar()
     */
    public Conector() throws SQLException {
        this.baseDatos = "world";
        this.usuario = "root";
        this.contraseña = "";

        this.conectar();
    }

    /**
     * Crea una conexión a la base de datos indicada, usando el usuario por
     * defecto "root" y sin contraseña.
     *
     * @param baseDatos nombre de la base de datos a la que conectarse.
     * @throws SQLException si ocurre un error al establecer la conexión.
     * @see #conectar()
     */
    public Conector(String baseDatos) throws SQLException {
        this.baseDatos = baseDatos;
        this.usuario = "root";
        this.contraseña = "";

        this.conectar();
    }

    /**
     * Crea una conexión a la base de datos indicada, con credenciales
     * personalizadas.
     *
     * @param baseDatos nombre de la base de datos a la que conectarse.
     * @param usuario usuario de la base de datos.
     * @param contraseña contraseña del usuario.
     * @throws SQLException si ocurre un error al establecer la conexión.
     * @see #conectar()
     */
    public Conector(String baseDatos, String usuario, String contraseña) throws SQLException {
        this.baseDatos = baseDatos;
        this.usuario = usuario;
        this.contraseña = contraseña;

        this.conectar();
    }

    /**
     * Método para establecer la conexión con la base de datos.
     *
     * @throws SQLException Si ocurre un error al establecer la conexión.
     * @see DriverManager
     * @see #cerrar()
     */
    private void conectar() throws SQLException {
        this.conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/" + this.baseDatos, this.usuario, this.contraseña);
    }

    /**
     * Método que funciona como SELECT.
     *
     * @param sql Consulta SQL a ejecutar.
     * @param parametro Valores a vincular en la consulta (en orden).
     * @return El ResultSet con los resultados de la consulta.
     * @throws SQLException Si ocurre un error al ejecutar la consulta.
     * @see PreparedStatement
     */
    public ResultSet consultar(String sql, Object... parametro) throws SQLException {
        PreparedStatement ps = this.conexion.prepareStatement(sql);

        if (parametro.length > 0) {
            for (int i = 0; i < parametro.length; i++) {
                ps.setObject(i + 1, parametro[i]);
            }
        }

        return ps.executeQuery();
    }

    /**
     * Método que funciona como INSERT, DELETE.
     *
     * @param sql Consulta SQL a ejecutar.
     * @param parametro Valores a vincular en la consulta (en orden).
     * @return Un número entero con la cantidad de filas afectadas.
     * @throws SQLException Si ocurre un error al ejecutar la consulta.
     * @see PreparedStatement
     */
    public int modificar(String sql, Object... parametro) throws SQLException {
        PreparedStatement ps = this.conexion.prepareStatement(sql);

        if (parametro.length > 0) {
            for (int i = 0; i < parametro.length; i++) {
                ps.setObject(i + 1, parametro[i]);
            }
        }

        return ps.executeUpdate();

    }

    /**
     * Método para cerrar la conexión.
     *
     * @throws SQLException Si ocurre un error al cerrar la conexión.
     */
    public void cerrar() throws SQLException {
        if (this.conexion != null) {
            this.conexion.close();
            this.conexion = null;
        }
    }
}