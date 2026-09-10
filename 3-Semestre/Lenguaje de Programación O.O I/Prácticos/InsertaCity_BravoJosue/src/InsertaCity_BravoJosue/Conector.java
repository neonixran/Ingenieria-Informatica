package InsertaCity_BravoJosue;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 *
 * @author iryde
 */
public class Conector {
    private final String baseDatos;
    private final String usuario;
    private final String contraseña;

    private Connection conexion;
    
    /**
     * @throws SQLException
     * @see #conectar()
     */
    public Conector() throws SQLException {
        this.baseDatos = "world";
        this.usuario = "root";
        this.contraseña = "";

        this.conectar();
    }

    public Conector(String baseDatos) throws SQLException {
        this.baseDatos = baseDatos;
        this.usuario = "root";
        this.contraseña = "";

        this.conectar();
    }

    public Conector(String baseDatos, String usuario, String contraseña) throws SQLException {
        this.baseDatos = baseDatos;
        this.usuario = usuario;
        this.contraseña = contraseña;

        this.conectar();
    }

    /**
     * @throws SQLException
     * @return Devuelve un objeto (@link Connection)
     * @see SQLException
     * @see DriveManager
     * 
     * Método para establecer la conexión con    la base de datos.
     */
    private void conectar() throws SQLException {
        this.conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/" + this.baseDatos, this.usuario, this.contraseña);
    }

    /**
     * @param sql Consulta sql (query) a ejecutar.
     * @param parametro Considera datos a filtrar, etc.
     * @return ResultSet
     * @throws SQLException
     * @see PreparedStatement
     * 
     * Método que funciona como SELECT.
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
     * @param sql Consulta sql (query) a ejecutar.
     * @param parametro Considera datos a filtrar, etc.
     * @return Cantidad de filas modificadas
     * @throws java.sql.SQLException
     * @see PreparedStament
     * 
     * Método que funciona como INSERT, DELETE.
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
     * @throws SQLException
     * @see SQLException
     * 
     * Método para cerrar la conexión.
     */
    public void cerrar() throws SQLException {
        if (this.conexion != null) {
            this.conexion.close();
            this.conexion = null;
        }
    }
}
