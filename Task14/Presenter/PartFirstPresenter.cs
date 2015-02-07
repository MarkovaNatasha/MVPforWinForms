using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Task14.View;

namespace Task14.Presenter
{
    partial class Presenter
    {
        void OnSetFirst(object sender, EventFileNameArgs e) //метод для обробки події для ініціалізації даних першої директорії
        {
            model.FirstPathFolder = e.FileName;
            RefreshFirstList();
        }

        void OnAddToFirst(object sender, EventFileNameArgs e) //метод обробки події додавання нового файлу в першу директорію
        {
            if (Regex.IsMatch(e.FileName, @"^*.[a-zA-Z]{3,4}$"))
            {
                var file = File.Create(model.FirstPathFolder + "\\" + e.FileName);
                file.Close();
                RefreshFirstList();
                MessageBox.Show("Your file has been added...");
            }
            else
            {
                MessageBox.Show("Incorrect file name!");
            }
        }

        private void OnDeleteFirst(object sender, EventFileNameArgs e) //метод для обробки події для видалення файлу першої директорії
        {
            File.Delete(model.FirstPathFolder + "\\" + e.FileName);
            RefreshFirstList();
            MessageBox.Show("File has been deleted...");
        }

        private void OnChangeFirst(object sender, EventFileNameArgs e)  //метод для обробки події для зміни файлу першої директорії
        {
            RefreshFirstList();
        }

        private void RefreshFirstList() //обновити файли першої директорії
        {
            var files = new DirectoryInfo(model.FirstPathFolder).GetFiles();
            model.FirstFilesFolder = files.ToList();
        }
    }
}
