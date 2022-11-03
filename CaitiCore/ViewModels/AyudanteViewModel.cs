﻿using CaitiCore.Commands;
using CaitiCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CaitiCore.ViewModels
{
    public class AyudanteViewModel : ViewModelBase
    {
        public ICommand Cerrar { get; }

        public AyudanteViewModel(ModalNavigationService cerrar)
        {
            Cerrar = new CloseModalCommand(cerrar);
        }
    }
}
