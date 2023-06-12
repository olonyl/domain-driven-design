﻿using DddInPractice.Logic;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddInPractice.UI.Common
{
    public class MainViewModel : ViewModel
    {

        public MainViewModel()
        {
            SnackMachine snackMachine;

            using(ISession session = SessionFactory.OpenSession())
            {
                snackMachine = session.Get<SnackMachine>(1L);
            }

            var viewModel = new SnackMachineViewModel(snackMachine);
            _dialogService.ShowDialog(viewModel);

        }
    }
}
