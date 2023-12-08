using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeWPF.Models
{
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }

        private string ingredients;
        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; OnPropertyChanged(nameof(Ingredients)); }
        }

        private string instructions;
        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; OnPropertyChanged(nameof(Instructions)); }
        }
    }
}