﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class ReservaDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public ReservaDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }
    }
}
