using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemo.Models
{
    internal class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Nome="Galaxy1", ImagemUrl="galaxy1.jpg"},
                new Foto() { Nome="Galaxy2", ImagemUrl="galaxy2.jpg"},
                new Foto() { Nome="Galaxy3", ImagemUrl="galaxy3.jpg"},
                new Foto() { Nome="Galaxy4", ImagemUrl="galaxy4.jpg"},
                new Foto() { Nome="Galaxy5", ImagemUrl="galaxy5.jpg"}
            };
        }
    }
}
