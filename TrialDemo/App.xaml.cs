using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TrialDemo.Database;

namespace TrialDemo
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Trial_Demo_420_KamilEntities DB = new Trial_Demo_420_KamilEntities();
    }
}
