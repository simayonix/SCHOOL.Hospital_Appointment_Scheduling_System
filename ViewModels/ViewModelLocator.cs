﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Appointment_Scheduling_System_TOMAROY.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            MainViewModel = new MainViewModel();
        }
        public MainViewModel MainViewModel { get; set; }
    }
}
