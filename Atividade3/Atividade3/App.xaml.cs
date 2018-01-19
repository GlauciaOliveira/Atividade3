using Atividade3.Model;
using Atividade3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Atividade3
{
    public partial class App : Application
    {
        public static AlunoViewModel AlunoVM { get; set; }
        public static UsuarioViewModel UsuarioVM { get; set; }

        public App()
        {
            InitializeComponent();
            InitializeApplication();

            //MainPage = new NavigationPage(new View.Aluno.MainPage());
            MainPage = new NavigationPage(new View.Login.LoginView() { BindingContext = App.UsuarioVM });
        }

        private void InitializeApplication()
        {
            if (AlunoVM == null) AlunoVM = new AlunoViewModel();
            if (UsuarioVM == null) UsuarioVM = new UsuarioViewModel();
        }

        //static Aluno alunoModel;

        //public static Aluno AlunoModel
        //{
        //    get
        //    {
        //        if (alunoModel == null)
        //        {
        //            alunoModel = new Aluno();
        //        }
        //        return alunoModel;
        //    }
        //}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
