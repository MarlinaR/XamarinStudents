using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace Extra_task_1
{
    public  class ClassListColor
    {
        public Color color { get; set; }
        public string name { get; set; }
           
        public static List<Color> GetColors()
        {
            List<Color> allColors = new List<Color>();

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    allColors.Add((Color)property.GetValue(null));
                }
            }

            return allColors;
        }
    }
}
