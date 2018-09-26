using SalesDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDemo.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
