using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Task14.View;

namespace Task14.Presenter
{
    partial class Presenter
    {
        void OnSetSecond(object sender, EventFileNameArgs e)  //метод для обробки події для ініціалізації даних другої директорії
        {
            model.SecondPathFolder = e.FileName;
            var files = new DirectoryInfo(e.FileName).GetFiles();
            model.SecondFilesFolder = files.ToList();
        }

        void OnAddToSecond(object sender, EventFileNameArgs e) //метод для обробки події для додавання файлу до другої директорії
        {
            if (Regex.IsMatch(e.FileName, @"^*.[a-zA-Z]{3,4}$"))
            {
                var file = File.Create(model.SecondPathFolder + "\\" + e.FileName);
                file.Close();
                RefreshSecondList();
                MessageBox.Show("Your file has been added...");
            }
            else
            {
                MessageBox.Show("Incorrect file name!");
            }       
        }

        private void OnDeleteSecond(object sender, EventFileNameArgs e) //метод для обробки події для видалення файлу другої директорії
        {
            File.Delete(model.SecondPathFolder + "\\" + e.FileName);
            RefreshSecondList();
            MessageBox.Show("File has been deleted...");
        }

        private void OnChangeSecond(object sender, EventFileNameArgs e)  //метод для обробки події для зміни файлу другої директорії
        {
            RefreshFirstList();
        }

        private void RefreshSecondList() //обновити файли другої директорії
        {
            var files = new DirectoryInfo(model.SecondPathFolder).GetFiles();
            model.SecondFilesFolder = files.ToList();
        }
    }
}
