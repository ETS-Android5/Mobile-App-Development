using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstGo
{
    class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        string numberAsString = "0";
        public string NumberAsString
        {
            get => numberAsString;
            set
            {
                if (!value.Equals(numberAsString))
                {
                    numberAsString = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NumberAsString"));
                    }
                }
            }
        }



        public void NextNumber()
        {
            int count = 0;
            count += 1;
            numberAsString = count.ToString();


        }


        public Model()
        { 
        
        }


    }

}
