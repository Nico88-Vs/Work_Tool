using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Tool.Forms;

namespace Work_Tool
{
    public class FormFactory : IFormFactory
    {
        private readonly Func<Type, Form> _formCreator;

        public FormFactory(Func<Type, Form> formCreator)
        {
            _formCreator = formCreator;
        }

        public MainWindow CreateMainWindow()
        {
            return (MainWindow)_formCreator(typeof(MainWindow));
        }

        public IdeasWindow CreateIdeasWindow()
        {
            return (IdeasWindow)_formCreator(typeof(IdeasWindow));
        }

        public PrompTemplate CreatePrompTemplate()
        {
            return (PrompTemplate)_formCreator(typeof(PrompTemplate));
        }

        public Landing_Page CreateLandingPages()
        {
            return (Landing_Page)_formCreator(typeof(Landing_Page));
        }

        public Forms.Label_Wind CreateLabel()
        {
            return (Forms.Label_Wind)_formCreator(typeof(Forms.Label_Wind));
        }
    }
}
