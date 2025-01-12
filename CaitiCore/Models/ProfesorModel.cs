﻿using CaitiCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaitiCore.Models
{
    public class ProfesorModel
    {
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Horario_Atencion { get; set; }

        public List<Curso> Cursos { get; set; }

        public ProfesorModel(string nombre, string email, string telefono, string horario_atencion)
        {
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
            Horario_Atencion = horario_atencion;
        }
    }
}
