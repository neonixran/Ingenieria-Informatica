
import java.sql.*;

public class Conector {
        private final String baseDatos;
    private final String usuario;
    private final String contraseña;

    private Connection conexion;

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

    private void conectar() throws SQLException {
        this.conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/" + this.baseDatos, this.usuario, this.contraseña);
    }

    public ResultSet consultar(String sql, Object... parametro) throws SQLException {
        PreparedStatement ps = this.conexion.prepareStatement(sql);

        if (parametro.length > 0) {
            for (int i = 0; i < parametro.length; i++) {
                ps.setObject(i + 1, parametro[i]);
            }
        }

        return ps.executeQuery();

    }

    public int modificar(String sql, Object... parametro) throws SQLException {
        PreparedStatement ps = this.conexion.prepareStatement(sql);

        if (parametro.length > 0) {
            for (int i = 0; i < parametro.length; i++) {
                ps.setObject(i + 1, parametro[i]);
            }
        }
        
        return ps.executeUpdate();

    }

    public void cerrar() throws SQLException {
        if (this.conexion != null) {
            this.conexion.close();
            this.conexion = null;
        }
    }
}
