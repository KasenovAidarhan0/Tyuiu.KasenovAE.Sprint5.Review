using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KasenovAE.Sprint5.TaskReview.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string savePath = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V1.txt";
            string res = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    res += ' ';
                    continue;
                }
                res += text[i];
            }
            File.AppendAllText(savePath, res);
            return savePath;
        }
    }
}
