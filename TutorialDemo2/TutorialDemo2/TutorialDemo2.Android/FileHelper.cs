using System;
using Android.OS;
using Xamarin.Forms;
using TutorialDemo2.Droid;
using System.IO;
using TutorialDemo2.Data;

[assembly: Dependency(typeof(FileHelper))]
namespace TutorialDemo2.Droid
{
    class FileHelper:IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}