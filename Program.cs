using Educma_Hackaton.Design;
using System;

class Program
{
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new Educma());
        //Application.Run(new LoadingPage());
        //Application.Run(new Connexion());
    }
}