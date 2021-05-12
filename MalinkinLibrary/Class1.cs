using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalinkinLibrary
{
  public enum Languages
  {
    JavaScript = 1,
    C_Sharp,
    C,
    Python,
    Java
  }

  public class Developer : ICloneable
  {
    private static int TOTAL_DEVELOPERS = 0;

    private int id;
    private string nickname;
    private List<Languages> languages = new List<Languages>();

    public Developer(string nickname, Languages[] languages)
    {
      this.nickname = nickname;
      foreach (var language in languages)
        this.languages.Add(language);
      id = ++TOTAL_DEVELOPERS;
    }

    public int getID()
    {
      return id;
    }

    public void getInfo()
    {
      Console.WriteLine($"СТАТИСТИКА РАЗРАБОТЧИКА {id}\n———————————————————————————————————");
      Console.WriteLine($"Никнейм: {nickname}");
      Console.Write($"Владение языками:\n\t");
      foreach (var language in languages)
        Console.Write($"{language} ");
      Console.WriteLine();
    }

    public string getNickname()
    {
      return nickname;
    }

    public bool addLanguage(Languages language)
    {
      if (!languages.Contains(language))
      {
        languages.Add(language);
        return true;
      }
      return false;
    }

    public List<Languages> getLanguages()
    {
      return languages;
    }

    /*public void printLanguages()
    {
      foreach (var lang in languages)
        Console.WriteLine(lang);
    }*/

    public object Clone()
    {
      return MemberwiseClone();
    }
  }

  public class Project
  {
    private static int TOTAL_COUNT = 0;

    private int id;
    private string title;
    private string description;
    private DateTime start;
    private DateTime finish;
    private List<Languages> languages = new List<Languages>();
    private List<Developer> developers = new List<Developer>();

    public Project(string title, string description, Languages[] languages)
    {
      this.title = title;
      this.description = description;
      foreach (var language in languages)
        this.languages.Add(language);
      id = ++TOTAL_COUNT;
    }

    public string getTitle()
    {
      return title;
    }

    public int getID()
    {
      return id;
    }

    public bool addLanguage(Languages language)
    {
      if (!languages.Contains(language))
      {
        languages.Add(language);
        return true;
      }
      return false;
    }

    public List<string> getDevelopersNicknames()
    {
      List<string> developers = new List<string>();
      foreach (Developer developer in this.developers)
        developers.Add(developer.getNickname());
      return developers;
    }

    public List<Languages> getLanguages()
    {
      return languages;
    }

    public (DateTime start, DateTime finish) getDates()
    {
      return (start: start, finish: finish);
    }

    public void setDateStart(DateTime date)
    {
      start = date;
      Console.WriteLine($"Обновлено время начала проекта - {date}");
    }

    public void setDateFinish(DateTime date)
    {
      if (DateTime.Compare(date, start) < 0)
      {
        Console.WriteLine($"Дата завершения разработки проекта не может быть раньше начала");
        return;
      }
      finish = date;
      Console.WriteLine($"Обновлено время завершения проекта - {date}");
    }

    public bool addDeveloper(ref Developer developer)
    {
      int coincidence = 0;
      foreach (var language in languages)
        foreach (var devLanguage in developer.getLanguages())
          if (language == devLanguage) coincidence++;

      if (coincidence != languages.Count)
      {
        Console.WriteLine("Знаний языков программирования у разработчика не хватает для этого проекта");
        return false;
      }
      developers.Add(developer);
      return true;
    }

    public bool removeDeveloperByID(int developerID)
    {
      foreach (var developer in developers)
        if (developer.getID() == developerID)
          return developers.Remove(developer);
      return false;
    }

    public string getInfo()
    {
      string res = "";
      res += $"СТАТИСТИКА ПРОЕКТА {id}\n";
      res += $"Название проекта: {title}\n";
      res += $"Описание:\n{description}\n";
      res += $"Время разработки:\n";
      res += $"Начало: {start}\n";
      res += $"Завершение: {finish}\n";
      res += $"Используемые языки прогр-я ({languages.Count}):\n";
      foreach (var language in languages)
        res += $"{language} ";
      res += "\n";
      res += $"Разработчики ({developers.Count}):\n";
      foreach (var developer in developers)
        res += $"{developer.getNickname()} ";
      res += "\n";
      return res;
    }
  }

  public class Controller
  {
    public List<Developer> developers = new List<Developer>();
    public List<Project> projects = new List<Project>();

    public object getDeveloperByID(int developerID)
    {
      foreach (Developer developer in developers)
        if (developer.getID() == developerID)
          return developer.Clone();
      return false;
    }

    public bool isDeveloperExist(int developerID)
    {
      foreach (Developer developer in developers)
        if (developer.getID() == developerID)
          return true;
      return false;
    }

    public bool isProjectExist(int projectID)
    {
      foreach (Project project in projects)
        if (project.getID() == projectID)
          return true;
      return false;
    }

    public string getProjectInfo(int projectID)
    {
      foreach (var project in projects)
        if (project.getID() == projectID)
          return project.getInfo();
      return "";
    }

    public void getDeveloperInfoByID(int developerID)
    {
      foreach (var developer in developers)
        if (developer.getID() == developerID)
          developer.getInfo();
    }

    public void addProject(ref Project project)
    {
      projects.Add(project);
    }

    public bool removeProjectByID(int projectID)
    {
      foreach (var project in projects)
        if (project.getID() == projectID)
          return projects.Remove(project);
      return false;
    }

    public void addDeveloper(ref Developer developer)
    {
      developers.Add(developer);
    }

    public bool addDeveloperAtProjectID(int projectID, Developer developer)
    {
      foreach (var project in projects)
        if (project.getID() == projectID)
          return project.addDeveloper(ref developer);
      return false;
    }

    public bool removeDeveloperFromProjectID(int projectID, int developerID)
    {
      foreach (var project in projects)
        if (project.getID() == projectID)
          return project.removeDeveloperByID(developerID);
      return false;
    }

  }
}
