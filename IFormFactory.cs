using Work_Tool.Forms;

namespace Work_Tool
{
    public interface IFormFactory
    {
        MainWindow CreateMainWindow();
        PrompTemplate CreatePrompTemplate();
        Landing_Page CreateLandingPages();
        IdeasWindow CreateIdeasWindow(Landing_Page landingPage);
        ListOfPrj CreateListOfPrj(Landing_Page landingPage);
        Work_Tool.Forms.Label_Wind CreateLabel(Landing_Page landingPage);
    }
}