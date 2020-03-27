using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikliPrimer
{
	public class Artikal : INotifyPropertyChanged
	{
		public string Naziv { get; set; }
		private decimal cena;
		public decimal Cena 
		{
			get
			{
				return cena;
			}

			set
			{
				cena = value;
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Cena"));
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs("VrednostNaLageru"));
			}
		}
		private int kolicina;
		public int Kolicina 
		{ 
			get
			{
				return kolicina;
			}

			set
			{
				kolicina = value;
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Kolicina"));
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs("VrednostNaLageru"));
			}
		} 

		public decimal VrednostNaLageru 
		{
			get
			{
				return Cena * Kolicina; 
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
