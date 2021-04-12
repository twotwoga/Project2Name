using Microsoft.VisualBasic;
using System.Windows.Forms;
using System;

class InputDialogDemo
{
    static void Main()
    {
        string name, res, txt;

        int year = 2021, age, born;
        
        name = Interaction.InputBox(
            "Ваше ФИО",
            "Давайте познакомимся"
            );

        res = Interaction.InputBox("В каком году вы родились?", "Год рождения");

        born = Int32.Parse(res);

        age = year - born;

        txt = name + " Тогда вам " + age + " лет ";


        //string txt1 = "очень приятно, " + name + "!";

        MessageBox.Show(txt, "Знакомство состоялось");
    }
}