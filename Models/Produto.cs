using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemo.Models
{
    internal class Produto : INotifyPropertyChanged
    {
        private string nome;
        private decimal preco;
        private int stock;

        public string Nome { 
            get => nome; 
            set 
            {
                nome = value;
                OnPropertyCanged();
            } 
        }

        public decimal Preco { 
            get => preco; 
            set 
            {
                preco = value;
                OnPropertyCanged();
            } 
        }

        public int Stock { 
            get => stock; 
            set {
                stock = value;
                OnPropertyCanged();
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyCanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
