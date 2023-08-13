global using W_Tool_LibreriaClassi;
global using Work_Tool.PromptDialog;
global using W_Tool_LibreriaClassi.Dto;
using Work_Tool.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using Autofac;
using Microsoft.Data.Sqlite;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Work_Tool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            #region CustomCode
            // Add Services by dependencyInjection
            var builder = new ContainerBuilder();

            // DataContext_Injection
            builder.RegisterType<DataContext>()
                .WithParameter("options", new DbContextOptionsBuilder<DataContext>()
                .UseSqlite("Data Source=C:\\Users\\user\\OneDrive\\Desktop\\DB\\Test_WorkTool.db")
                .Options)
                .InstancePerLifetimeScope();

            // Registro i form nel container tentando di accededere alla DI


            builder.RegisterType<MainWindow>().InstancePerLifetimeScope();
            builder.RegisterType<StudyWindow>().InstancePerLifetimeScope();
            builder.RegisterType<IdeasWindow>().InstancePerLifetimeScope();
            builder.RegisterType<ToDoWindow>().InstancePerLifetimeScope();
            builder.RegisterType<PrompTemplate>().InstancePerLifetimeScope();


            //Registro la funzione di creazione
            builder.Register<Func<Type, Form>>(context =>
            {
                var componentContext = context.Resolve<IComponentContext>();
                return type => (Form)componentContext.Resolve(type);
            });

            //Registro il form factory
            builder.RegisterType<FormFactory>().As<IFormFactory>();

            var container = builder.Build();

            var formFactory = container.Resolve<IFormFactory>();

            var mainWindow = formFactory.CreateMainWindow();


            #endregion
            // RUN FROM CUSTOM CONTAINER
            Application.Run(mainWindow);

            //// RUN BY DEFOULT CONTAINER
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MainWindow());
        }
    }
}