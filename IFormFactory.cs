using Work_Tool.Forms;

namespace Work_Tool
{
    public interface IFormFactory
    {
        IdeasWindow CreateIdeasWindow();
        MainWindow CreateMainWindow();
        PrompTemplate CreatePrompTemplate();
    }
}