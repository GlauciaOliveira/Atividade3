﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Atividade3.Data;
using System.IO;

namespace Atividade3.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {

        }

        public SQLite.SQLiteConnection GetConexao()
        {
            var arquivodb = "fiapdb.db3";
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string bibliotecaPessoal = Path.Combine(caminho, "..", "Library");
            var local = Path.Combine(bibliotecaPessoal, arquivodb);
            var conexao = new SQLite.SQLiteConnection(local); return conexao;
        }
    }
}