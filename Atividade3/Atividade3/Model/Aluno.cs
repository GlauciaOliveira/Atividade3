using Atividade3.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atividade3.Model
{
    public class Aluno
    {

        //private SQLiteConnection database;
        //static object locker = new object();

        //public Aluno()
        //{
        //    database = DependencyService.Get<ISQLite>().GetConexao();
        //    database.CreateTable<Aluno>();
        //}

        #region Propriedades 

        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Aprovado { get; set; }
        public string IsAprovado
        {
            get
            {
                return (Aprovado) ? "Aprovado" : "Reprovado";
            }
        }
        #endregion

        //#region Aluno Local Database         

        //public int SalvarAluno(Aluno aluno)
        //{
        //    lock (locker)
        //    {
        //        if (aluno.Id != 0)
        //        {
        //            database.Update(aluno);
        //            return aluno.Id;
        //        }
        //        else
        //            return database.Insert(aluno);
        //    }
        //}

        //public IEnumerable<Aluno> GetAlunos()
        //{
        //    lock (locker)
        //    {
        //        return (from c in database.Table<Aluno>() select c).ToList();
        //    }
        //}

        //public Aluno GetAluno(int Id)
        //{
        //    lock (locker)
        //    {                 // return database.Query< Aluno>("SELECT * FROM [Aluno] WHERE [Id] = " + Id);                 
        //        return database.Table<Aluno>().Where(c => c.Id == Id).FirstOrDefault();
        //    }
        //}

        //public int RemoverAluno(int Id)
        //{
        //    lock (locker)
        //    {
        //        return database.Delete<Aluno>(Id);
        //    }
        //}
        //#endregion
    }

}

