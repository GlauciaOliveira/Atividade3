using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
