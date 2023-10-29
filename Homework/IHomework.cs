namespace ItAcademiaCsh.Homework;

public interface IHomework
{
    string DateIssueTask { get; }
    char TaskNumber { get; }
    void CompletingTask();
}