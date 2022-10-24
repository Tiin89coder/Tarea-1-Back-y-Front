using DTOs;
using System;



namespace Data{
    public class EmpleadosRepository{
        private readonly string conexionString;
        public EmpleadosRepository(){
            conexionString = "Server=127.0.0.1;Port=3306;Database=db_empleados;Uid=root;password=UMG123;";
        
        }
        public empleados GetEmpleados(int idEmpleado){
            using(MySqlCommand conexion = new MysqlConnection(conexionString)){
                //codigo del select
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "SELECT * FROM empleados where idEmpleado = ?empleadosIdEmpleado";
                comando.Parameters.Add("?empleadosIdEmpleado", MySqlDbType.Int32).value = idEmpleado;
                comando.Connection = conexion;


                using(var reader = comando.ExecuteReader()){
                    while (reader.Read()){
                        empleados.idEmpleado = Convert.ToInt32(reader["idEmpleado"]);
                        empleados.Nombre = reader["Nombre"].ToString();
                        empleados.Apellido = reader["Apellido"].ToString();
                        empleados.Direccion = reader["Direccion"].ToString();
                        empleados.Telefono = Convert.ToInt32(reader["Telefono"]);
                        empleados.idPuesto = Convert.ToInt32(reader["idPuesto"]);
                        empleados.DPI = reader["DPI"].ToString();
                        empleados.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        empleados.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                    }
                    return empleados;
                }

            }
        }
        public int InsertarEmpleados(int empleadosIdEmpleado, string Nombre, string Apellido, string Direccion, int Telefono, int idPuesto, string DPI, DateOnly FechaNacimiento, DateTime FechaIngreso){
            using(MySqlCommand conexion = new MysqlConnection(conexionString)){
                //codigo del select
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "INSERT INTO empleados (empleadosIdEmpleado,Nombre,Apellido,Direccion,Telefono,idPuesto,DPI,FechaNacimiento,FechaIngresoRegistro) VALUES(?idEmpleado,?Nombre,?Apellido,?Direccion,?Telefono,?idPuesto,?DPI,?FechaNacimiento,?FechaIngresoRegistro);";
                comando.Connection = conexion;
                comando.Parameters.Add("?empleadosIdEmpleado", MySqlDbType.Int32).value=empleadosIdEmpleado;
                comando.Parameters.Add("?Nombre", MySqlDbType.string).value=Nombre;
                comando.Parameters.Add("?Apellido", MySqlDbType.string).value=Apellido;
                comando.Parameters.Add("?Direccion", MySqlDbType.string).value=Direccion;
                comando.Parameters.Add("?Telefono", MySqlDbType.Int32).value=Telefono;
                comando.Parameters.Add("?idPuesto", MySqlDbType.Int32).value=idPuesto;
                comando.Parameters.Add("?DPI", MySqlDbType.string).value=DPI;
                comando.Parameters.Add("?FechaNacimiento", MySqlDbType.DateTime).value=DateTime.Now;
                comando.Parameters.Add("?FechaIngreso", MySqlDbType.DateTime).value=DateTime.Now;

                comando.ExecuteNonQuery();
                return (int)comando.LastInsertedId;
            }
        }
        public void ActualizarEmpleados(int empleadosIdEmpleado, string Nombre, string Apellido, string Direccion, int Telefono, int idPuesto, string DPI, DateOnly FechaNacimiento, DateTime FechaIngreso){
            using(MySqlCommand conexion = new MysqlConnection(conexionString)){
                //codigo del select
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "UPDATE empleados set 'Nombre' = ?Nombre,'Apellido' = ?Apellido,'Direccion' = ?Direccion,'Telefono' = ?Telefono,'idPuesto' = ?idPuesto, 'DPI' = ?DPI, 'FechaNacimiento' = ?FechaNacimiento, 'FechaIngresoRegistro' = ?FechaIngreso where idEmpleado = ?idEmpleado;";
                comando.Connection = conexion;
                comando.Parameters.Add("?IdEmpleado", MySqlDbType.Int32).value=empleadosIdEmpleado;
                comando.Parameters.Add("?Nombre", MySqlDbType.string).value=Nombre;
                comando.Parameters.Add("?Apellido", MySqlDbType.string).value=Apellido;
                comando.Parameters.Add("?Direccion", MySqlDbType.string).value=Direccion;
                comando.Parameters.Add("?Telefono", MySqlDbType.Int32).value=Telefono;
                comando.Parameters.Add("?idPuesto", MySqlDbType.Int32).value=idPuesto;
                comando.Parameters.Add("?DPI", MySqlDbType.string).value=DPI;
                comando.Parameters.Add("?FechaNacimiento", MySqlDbType.DateTime).value=DateTime.Now;
                comando.Parameters.Add("?FechaIngreso", MySqlDbType.DateTime).value=DateTime.Now;

                comando.ExecuteNonQuery();
            }
        }

          public void BorrarEmpleados(int empleadosIdEmpleado, string Nombre, string Apellido, string Direccion, int Telefono, int idPuesto, string DPI, DateOnly FechaNacimiento, DateTime FechaIngreso){
            using(MySqlCommand conexion = new MysqlConnection(conexionString)){
                //codigo del select
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "DELETE from empleados where idEmpleado = ?idEmpleado;";
                comando.Connection = conexion;
                comando.Parameters.Add("?IdEmpleado", MySqlDbType.Int32).value=empleadosIdEmpleado;
                comando.Parameters.Add("?Nombre", MySqlDbType.string).value=Nombre;
                comando.Parameters.Add("?Apellido", MySqlDbType.string).value=Apellido;
                comando.Parameters.Add("?Direccion", MySqlDbType.string).value=Direccion;
                comando.Parameters.Add("?Telefono", MySqlDbType.Int32).value=Telefono;
                comando.Parameters.Add("?idPuesto", MySqlDbType.Int32).value=idPuesto;
                comando.Parameters.Add("?DPI", MySqlDbType.string).value=DPI;
                comando.Parameters.Add("?FechaNacimiento", MySqlDbType.DateTime).value=DateTime.Now;
                comando.Parameters.Add("?FechaIngreso", MySqlDbType.DateTime).value=DateTime.Now;

                comando.ExecuteNonQuery();
            }
        }
    }
}
