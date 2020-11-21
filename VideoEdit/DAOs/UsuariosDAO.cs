using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace VideoEdit.DAOs {
    static class UsuariosDAO {
        static RestClient client = new RestClient("https://localhost:44371/");

        public static Boolean login(String usuario, String contraseña) {
            var req = new RestRequest($"API/Login?nombre={usuario}&contraseña={contraseña}");            
            req.RequestFormat = DataFormat.Json;
            var respuesta = client.Get(req).Content;
            Console.WriteLine(respuesta);
            return respuesta.Equals("\"true\"");
        }
    }
}
