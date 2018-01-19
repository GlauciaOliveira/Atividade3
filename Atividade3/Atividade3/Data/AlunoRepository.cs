using Atividade3.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atividade3.Data
{
    public class AlunoRepository
    {
        private AlunoRepository() { }

        private static SQLiteConnection database;
        private static readonly AlunoRepository instance = new AlunoRepository();
        public static AlunoRepository Instance
        {
            get
            {
                if (database == null)
                {
                    database = DependencyService.Get<ISQLite>().GetConexao();
                    database.CreateTable<Aluno>();
                }
                return instance;
            }
        }

        static object locker = new object();

        public static int SalvarAluno(Aluno aluno)
        {
            lock (locker)
            {
                if (aluno.Id != 0)
                {
                    database.Update(aluno);
                    return aluno.Id;
                }
                else return database.Insert(aluno);
            }
        }

        public static List<Aluno> GetAlunos()
        {
            lock (locker)
            {
                return (from c in database.Table<Aluno>()
                        select c).ToList();
            }
        }

        public static Aluno GetAluno(int Id)
        {
            lock (locker)
            {
                // return database.Query<Aluno>("SELECT * FROM [Aluno] WHERE [Id] = " + Id);
                return database.Table<Aluno>().Where(c => c.Id == Id).FirstOrDefault();
            }
        }

        public static int RemoverAluno(int Id)
        {
            lock (locker)
            {
                return database.Delete<Aluno>(Id);
            }
        }
    }
}
