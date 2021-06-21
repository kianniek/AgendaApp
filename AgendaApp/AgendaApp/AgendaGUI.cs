using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaApp
{
	public partial class AgendaGUI : Form
	{
		string[] Month =
		{
			"January",
			"February",
			"March",
			"April",
			"May",
			"June",
			"July",
			"August",
			"September",
			"October",
			"November",
			"December"
		};
		private int[] WeekNumbers(int year, int month)
        {
			int[] weekNumbers = {};
			return weekNumbers;
        }

		public AgendaGUI()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
