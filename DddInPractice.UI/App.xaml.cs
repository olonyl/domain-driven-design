﻿using DddInPractice.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DddInPractice.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {
        public App()
        {
            Initer.Init(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DddInPractice;Integrated Security=True;");
        }
    }
}
