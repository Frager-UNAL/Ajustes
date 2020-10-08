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
        public List<Ajustes> Get()
        {
            var listaAjustes = ajustesS.Get();
            return listaAjustes;
        }

        [HttpGet("{id}")]
        public Ajustes Get(string id)
        {
            var _ajustes = ajustesS.Get(id);

            if (_ajustes == null)
            {
                return null;
            }

            return _ajustes;
        }

        [HttpPost]
        public Ajustes Create([FromBody] Ajustes _ajustes)
        {
            try
            {
                return ajustesS.Create(_ajustes);
            }
            catch (Exception ex)
            { 
                return null;
            }
            
        }

        [HttpPut("{id}")]
        public Ajustes PUT(string id, [FromBody] Ajustes value)
        {
            var _ajustes = ajustesS.Get(id);

            if (_ajustes == null)
            {
                return null;
            }

            return ajustesS.Update(id, value);
        }

        [HttpDelete("{id}")]
        public int Delete(string id)
        {
            var _ajustes = ajustesS.Get(id);

            if (_ajustes == null)
            {
                return 0;
            }

            return ajustesS.Remove(_ajustes);
        }
    }
}
