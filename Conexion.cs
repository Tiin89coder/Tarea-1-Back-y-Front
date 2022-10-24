using System;

namespace DTOs{
    public class empleados{
        public int idEmpleado {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public int idPuesto {get;set;}
        public string DPI {get;set;}
        public DateOnly FechaNacimiento {get;set;}
        public DateTime FechaIngreso {get;set;}        

    }

    public class puesto{
        public int idPuesto {get;set;}
        public string Puesto {get;set;}
    }
}