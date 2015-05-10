using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

//my code

		private List<TSPrice> GetPriceList()
		{
			return new List<TSPrice>
             {
               new TSPrice(0, ""),
               new TSPrice(0, "Half Day"),
               new TSPrice(0, "Full Day"),
               new TSPrice(0, "1 + Half"),
               new TSPrice(0, "2 Days"),
               new TSPrice(0, "Formal Quote Required")
             };
		}


	}


	public class TSPrice
	{
		private int number { get; set; }
		private string tekst { get; set; }
		public TSPrice(int _number, string _tekst)
		{
			this.number = _number;
			this.tekst = _tekst;
		}
	}
}
