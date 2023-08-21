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

        public IdeasWindow CreateIdeasWindow(Landing_Page landingPage)
        {
            return (IdeasWindow)_formCreator(typeof(IdeasWindow));
        }

        public ListOfPrj CreateListOfPrj(Landing_Page landingPage)
        {
            return (ListOfPrj)_formCreator(typeof(ListOfPrj));
        }

        public PrompTemplate CreatePrompTemplate()
        {
            return (PrompTemplate)_formCreator(typeof(PrompTemplate));
        }

        public Landing_Page CreateLandingPages()
        {
            return (Landing_Page)_formCreator(typeof(Landing_Page));
        }

        public Forms.Label_Wind CreateLabel(Landing_Page landingPage)
        {
            return (Forms.Label_Wind)_formCreator(typeof(Forms.Label_Wind));
        }
    }
}
