using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRepaso
{
    class PrediccionDia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string _dia;

        public string Dia
        {
            get { return _dia; }
            set {
                if(value != _dia)
                {
                    _dia = value;
                    NotifyPropertyChanged("Dia");
                }
                
            }
        }
        private string _prediccion;

        public string Prediccion
        {
            get { return _prediccion; }
            set
            {
                if (value != _prediccion)
                {
                    _prediccion = value;
                    NotifyPropertyChanged("Prediccion");
                }

            }
        }

        private int _minimaFarenheit;
        public int MinimaFarenheit
        {
            get { return _minimaFarenheit; }
            set
            {
                if (value != _minimaFarenheit)
                {
                    _minimaFarenheit = value;
                    NotifyPropertyChanged("MinimaFarenheit");
                }

            }
        }

        private int _maximaFarenheit;
        public int MaximaFarenheit
        {
            get { return _maximaFarenheit; }
            set
            {
                if (value != _maximaFarenheit)
                {
                    _maximaFarenheit = value;
                    NotifyPropertyChanged("MaximaFarenheit");
                }

            }
        }

        public PrediccionDia(string dia,string prediccion, int minima, int maxima)
        {
            this.Dia = dia;
            this.Prediccion = prediccion;
            this.MinimaFarenheit = minima;
            this.MaximaFarenheit = maxima;
        }

        public static ObservableCollection<PrediccionDia> ObtenerDatos()
        {
            ObservableCollection<PrediccionDia> dias = new ObservableCollection<PrediccionDia>();
            dias.Add(new PrediccionDia("Lunes", "sol", 44, 60));
            dias.Add(new PrediccionDia("Martes", "nubes", 55, 70));
            dias.Add(new PrediccionDia("Miércoles", "sol", 35, 55));
            dias.Add(new PrediccionDia("Jueves", "nubes", 48, 65));
            dias.Add(new PrediccionDia("Viernes", "lluvia", 37, 50));
            dias.Add(new PrediccionDia("Sábado", "nubes", 30, 50));
            dias.Add(new PrediccionDia("Domingo", "nieve", 28, 40));
            return dias;
        }

    }
}
