﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev2Model.DAL
{
    public interface ILecturasDAL
    {
        void IngresarLectura(string Lectura);
        List<Lectura> ObtenerLecturas();
    }
}