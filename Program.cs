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
            // Add Services by dependencyInjection
            var builder = new ContainerBuilder();

            // DataContext_Injection
            builder.RegisterType<DataContext>()
                .WithParameter("options", new DbContextOptionsBuilder<DataContext>()
                .UseSqlite("Data Source=C:\\Users\\user\\OneDrive\\Desktop\\DB\\TestSecondo_WorkTool.db")
                .Options)
                .InstancePerLifetimeScope();

            // Registro i form nel container tentando di accededere alla DI
            builder.RegisterType<MainWindow>().InstancePerLifetimeScope();
            builder.RegisterType<IdeasWindow>().InstancePerLifetimeScope();
            builder.RegisterType<PrompTemplate>().InstancePerLifetimeScope();
            builder.RegisterType<Landing_Page>().InstancePerLifetimeScope();
            builder.RegisterType<Forms.Label_Wind>().InstancePerLifetimeScope();
            builder.RegisterType<ListOfPrj>().InstancePerLifetimeScope();

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

            var mainWindow = formFactory.CreateLandingPages();

            // RUN FROM CUSTOM CONTAINER
            Application.Run(mainWindow);
        }
    }
}