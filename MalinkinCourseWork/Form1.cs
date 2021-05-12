using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MalinkinLibrary;

namespace MalinkinCourseWork
{
  public partial class Form1 : Form
  {
    public Controller controller = new Controller();
    public Form1()
    {
      InitializeComponent();
      AD_LangCheckBox.Items.AddRange(Enum.GetNames(typeof(Languages)));
      AP_LangCheckBox.Items.AddRange(Enum.GetNames(typeof(Languages)));

      /*Controller c = new Controller();
      Developer d = new Developer("Borobeyka", new Languages[] { Languages.JavaScript });
      c.addDeveloper(ref d);
      c.getDeveloperInfoByID(1);*/
    }

    private void showWarningMessage(string text)
    {
      MessageBox.Show(text, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    
    private void showSuccessMessage(string text)
    {
      MessageBox.Show(text, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void AD_Submit_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(AD_Nickname.Text))
      {
        showWarningMessage("Заполните поле \"Никнейм\"");
        return;
      }
      else if (AD_LangCheckBox.CheckedItems.Count == 0)
      {
        showWarningMessage("Выберите хотя бы один элемент");
        return;
      }
      
      Developer developer = new Developer(AD_Nickname.Text, new Languages[] { });
      foreach (var item in AD_LangCheckBox.CheckedItems)
        developer.addLanguage((Languages)Enum.Parse(typeof(Languages), item.ToString()));
      controller.addDeveloper(ref developer);
      updateAllDevelopersTable();
      showSuccessMessage($"Разработчик {AD_Nickname.Text} успешно добавлен");
    }

    private void AP_Submit_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(AP_Title.Text))
      {
        showWarningMessage("Заполните поле \"Название проекта\"");
        return;
      }
      else if (String.IsNullOrEmpty(AP_Description.Text))
      {
        showWarningMessage("Заполните поле \"Описание\"");
        return;
      }
      else if (AP_LangCheckBox.CheckedItems.Count == 0)
      {
        showWarningMessage("Выберите хотя бы один элемент");
        return;
      }
      else if(DateTime.Compare(AP_Start.Value, AP_Finish.Value) > 0)
      {
        showWarningMessage("Дата завершения не может быть раньше начала");
        return;
      }

      Project project = new Project(AP_Title.Text, AP_Description.Text, new Languages[] { });
      foreach (var item in AP_LangCheckBox.CheckedItems)
        project.addLanguage((Languages)Enum.Parse(typeof(Languages), item.ToString()));
      project.setDateStart(AP_Start.Value);
      project.setDateFinish(AP_Finish.Value);
      controller.addProject(ref project);
      updateAllDProjectsTable();
      showSuccessMessage($"Проект \"{AP_Title.Text}\" успешно создан");
    }

    private void updateAllDevelopersTable()
    {
      AllD.Rows.Clear();
      for (int i = 0; i < controller.developers.Count; i++)
      {
        AllD.Rows.Add();
        Developer dev = controller.developers[i];
        AllD.Rows[i].Cells[0].Value = dev.getID();
        AllD.Rows[i].Cells[1].Value = dev.getNickname();
        AllD.Rows[i].Cells[2].Value = String.Join(", ", dev.getLanguages().ToArray());
      }
    }
    
    private void updateAllDProjectsTable()
    {
      AllP.Rows.Clear();
      for (int i = 0; i < controller.projects.Count; i++)
      {
        AllP.Rows.Add();
        Project project = controller.projects[i];
        AllP.Rows[i].Cells[0].Value = project.getID();
        AllP.Rows[i].Cells[1].Value = project.getTitle();
        AllP.Rows[i].Cells[2].Value = String.Join(", ", project.getLanguages().ToArray());
        if (project.getDevelopersNicknames().Count != 0)
          AllP.Rows[i].Cells[3].Value = String.Join(", ", project.getDevelopersNicknames().ToArray());
        else AllP.Rows[i].Cells[3].Value = "";
        AllP.Rows[i].Cells[4].Value = project.getDates().start;
        AllP.Rows[i].Cells[5].Value = project.getDates().finish;
      }
    }

    private void ADtP_Submit_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(ADtP_dID.Text))
      {
        showWarningMessage("Заполните поле \"ID разработчика\"");
        return;
      }
      else if(!controller.isDeveloperExist(Convert.ToInt32(ADtP_dID.Text)))
      {
        showWarningMessage($"Разработчика с ID {ADtP_dID.Text} не существует");
        return;
      }
      else if (String.IsNullOrEmpty(ADtP_pID.Text))
      {
        showWarningMessage("Заполните поле \"ID проекта\"");
        return;
      }
      else if (!controller.isProjectExist(Convert.ToInt32(ADtP_pID.Text)))
      {
        showWarningMessage($"Проекта с ID {ADtP_pID.Text} не существует");
        return;
      }
      Developer d = (Developer)controller.getDeveloperByID(Convert.ToInt32(ADtP_dID.Text));
      if (controller.addDeveloperAtProjectID(Convert.ToInt32(ADtP_pID.Text), d))
      {
        updateAllDProjectsTable();
        showSuccessMessage($"Разработчик ID {ADtP_dID.Text} привлечен к проекту ID {ADtP_pID.Text}");
      }
      else showWarningMessage($"У разработчика ID {ADtP_dID.Text} не хватает знаний для проекта ID {ADtP_pID.Text}");
    }

    private void gPI_Submit_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(gPI_Field.Text))
      {
        showWarningMessage("Заполните поле \"ID разработчика\"");
        return;
      }
      else if (!controller.isProjectExist(Convert.ToInt32(gPI_Field.Text)))
      {
        showWarningMessage($"Проекта с ID {gPI_Field.Text} не существует");
        return;
      }

      MessageBox.Show(controller.getProjectInfo(Convert.ToInt32(gPI_Field.Text)), $"Информация по проекту {gPI_Field.Text}", MessageBoxButtons.OK);
    }
  }
}
