﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.facade
{
    public interface IdataApi
    {
        public List<camion> GetCamion();
        public bool PostCamion(camion ocamion);
        public object DeleteLogico(int id_camion);
    }
}
