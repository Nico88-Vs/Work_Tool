using Work_Tool.Forms;

namespace Work_Tool
{
    public interface IFormFactory
    {
        MainWindow CreateMainWindow();
        PrompTemplate CreatePrompTemplate();
        Landing_Page CreateLandingPages();
        IdeasWindow CreateIdeasWindow();
        Work_Tool.Forms.Label_Wind CreateLabel();
    }
}