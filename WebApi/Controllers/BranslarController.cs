using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class BranslarController : ApiController
    {
        [HttpGet]
        public List<Veritabani.Tbl_Branslar> BransBilgileri()
        {
            var liste = new Siniflarim.Branslar().Listele();
            if (liste.Count > 0)
                return liste;
            else
                return null;
        }
    }
}
