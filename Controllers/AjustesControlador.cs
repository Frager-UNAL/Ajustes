using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ajustes_Fragen.Modelos;
using Ajustes_Fragen.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Ajustes_Fragen.Controllers
{
    [Route("ajustes")]
    [ApiController]
    public class AjustesControlador : ControllerBase
    {
        private readonly AjustesServicio ajustesS;

        public AjustesControlador(AjustesServicio Aj)
        {
            ajustesS = Aj;
        }

        [HttpGet]
        public List<String> Get()
        {
            List<String> listString = new List<string>();
            var listaAjustes = ajustesS.Get();
            foreach(Ajustes ajuste in listaAjustes)
            {
                listString.Add(ajuste.ToJson());
            }
            return listString;
        }

        [HttpGet("{id}")]
        public String Get(string id)
        {
            var _ajustes = ajustesS.Get(id);

            if (_ajustes == null)
            {
                return null;
            }

            return _ajustes.ToJson();
        }

        [HttpPost]
        public String Create([FromBody] Ajustes _ajustes)
        {
            try
            {
                return ajustesS.Create(_ajustes);
            }
            catch (Exception ex)
            { 
                return ex.ToString();
            }
            
        }

        [HttpPut("{id}")]
        public String PUT(string id, [FromBody] Ajustes value)
        {
            var _ajustes = ajustesS.Get(id);

            if (_ajustes == null)
            {
                return null;
            }

            return ajustesS.Update(id, value);
        }

        [HttpDelete("{id}")]
        public String Delete(string id)
        {
            var _ajustes = ajustesS.Get(id);

            if (_ajustes == null)
            {
                return null;
            }

            return ajustesS.Remove(_ajustes);
        }
    }
}
