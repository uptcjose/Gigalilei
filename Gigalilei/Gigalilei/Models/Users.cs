



namespace Gigalilei.Models
{
   using Newtonsoft.Json;
    class Users
    {
       
       [JsonProperty(PropertyName="id_adm")]
        public int Id_adm
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "apellido")]
        public string Apellido
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "usuario")]
        public string Usuario
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "contrasena")]
        public string Contrasena
        {
            get;
            set;
        }
    }
}
