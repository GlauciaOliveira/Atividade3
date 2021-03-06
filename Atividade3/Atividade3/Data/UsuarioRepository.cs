﻿using Atividade3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Atividade3.Data
{
    public class UsuarioRepository
    {
        private UsuarioRepository() { }

        private static readonly UsuarioRepository instance = new UsuarioRepository();
        public static UsuarioRepository Instance
        {
            get
            {
                return instance;
            }
        }

        public static bool IsAutorizado(Usuario paramLogin)
        {
            XElement xmlUsuarios = XElement.Parse(App.UsuarioVM.Stream);
            var usuarios = new List<Usuario>();
            foreach (var item in xmlUsuarios.Elements("usuario"))
            {
                Usuario usuario = new Usuario()
                {
                    Username = item.Element("username").Value,
                    Password = item.Element("password").Value
                };
                usuarios.Add(usuario);
            }
            return usuarios.Any(user => user.Username == paramLogin.Username && user.Password == paramLogin.Password);
        }
    }
}

