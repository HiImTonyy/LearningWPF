using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearningWPF.MISCFOLDER
{
    internal class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SkinColor { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }


        public Human(string name, string lastName, string skinColor, string gender, int age, int weight, int height)
        {
            Name = name;
            LastName = lastName;
            SkinColor = skinColor;
            Gender = gender;
            Age = age;
            Weight = weight;
            Height = height;
        }
    }
}
