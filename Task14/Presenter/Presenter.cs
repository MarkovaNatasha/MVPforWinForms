using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Task14.View;
using System.Collections.Generic;

namespace Task14.Presenter
{
    partial class Presenter
    {
        private IView view;
        private Model.Model model;

        public Presenter(IView newView)
        {
            view = newView;
            model = new Model.Model();
            view.Synchronize += OnSynchronize;
            view.SetFirst += OnSetFirst;
            view.AddToFirst += OnAddToFirst;
            view.DeleteToFirst += OnDeleteFirst;
            view.ChangeToFirst += OnChangeFirst;
            view.SetSecond += OnSetSecond;
            view.AddToSecond += OnAddToSecond;
            view.DeleteToSecond += OnDeleteSecond;
            view.ChangeToSecond += OnChangeSecond;
        }

        void OnSynchronize(object sender, EventArgs e) //метод для обробки події для синхронізації двох директорії
        {
            if (model.FirstFilesFolder == null & model.SecondFilesFolder == null)
            {
                MessageBox.Show("Both lists are empty!");
            }
            else if (model.FirstFilesFolder == null && model.SecondFilesFolder != null)
            {
                foreach (var t in model.SecondFilesFolder)
                {
                    File.Copy(model.SecondFilesFolder + "\\" + t, model.FirstFilesFolder + "\\" + t);
                }
                model.FirstFilesFolder = model.SecondFilesFolder;
            }
            else if (model.SecondFilesFolder == null && model.FirstFilesFolder != null)
            {
                foreach (var t in model.FirstFilesFolder)
                {
                    File.Copy(model.FirstPathFolder + "\\" + t, model.SecondPathFolder + "\\" + t);
                }
                model.SecondFilesFolder = model.FirstFilesFolder;
            }
            else
            {
                Synchronize(model.FirstFilesFolder, model.FirstPathFolder, model.SecondFilesFolder, model.SecondPathFolder);
                Synchronize(model.SecondFilesFolder, model.SecondPathFolder, model.FirstFilesFolder, model.FirstPathFolder);
                MessageBox.Show("Synchronization has gone correct!");
            }
        }

        private void Synchronize(List<FileInfo> listOfFilesFirst, string sourcePath, List<FileInfo> listOfFilesSecond, string destPath)
        {
            foreach (var t in listOfFilesFirst)
            {
                if (!listOfFilesSecond.Any(x => x.Name == t.Name))
                {
                    File.Copy(sourcePath + "\\" + t, destPath + "\\" + t);
                    listOfFilesSecond.Add(t);
                }
                else if (!listOfFilesSecond.Any(x => x.Length == t.Length))
                {
                    File.Delete(destPath + "\\" + t);
                    File.Copy(sourcePath + "\\" + t, destPath + "\\" + t);
                }
            }
        }

    }
}
