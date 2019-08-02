using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

using slonexch.Helpers;

namespace slonexch.ViewModel
{
    public class ButtonViewModel : BaseViewModel
    {
        public ICommand Command_XamarinForms { get; }

        public ICommand Command_WPFMVVM { get; }

        string infoCommand;
        public string InfoCommand
        {
            get { return infoCommand; }
            set { infoCommand = value; NotifyPropertyChanged(); }
        }


        public ButtonViewModel()
        {
            Command_XamarinForms = new Command(action_one);
            Command_WPFMVVM = new ButtonCommand(action_two);        
        }
        


        public void action_one()
        {
            InfoCommand = "Support XamarinForms";                                       
        }

        public void action_two(object sender)                                                                  
        {
            InfoCommand = "Support WPFMVVM";
        }

 
    }
}
