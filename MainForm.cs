using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

using Bin2Text.Properties;

namespace Bin2Text
{
	public partial class MainForm : Form
	{
		#region Сохранение/востановление настроек, положения

		/// <summary>
		/// Конструктор
		/// </summary>
		public MainForm()
		{
			ApplyPrevVersionsSettings();

			InitializeComponent();

			_chClipboardMonitor.Checked = false;
		}

		/// <summary>
		/// Сохранение положения окна
		/// </summary>
		private void SavePos()
		{
			Settings.Default.MainFormState = WindowState;
			if (WindowState == FormWindowState.Normal)
			{
				Settings.Default.MainFormSize = Size;
				Settings.Default.MainFormLocation = Location;
			}
			else
			{
				Settings.Default.MainFormSize = RestoreBounds.Size;
				Settings.Default.MainFormLocation = RestoreBounds.Location;
			}
		}

		/// <summary>
		/// Восстановление положения окна
		/// </summary>
		private void RestorePos()
		{
			try
			{
				Size = Settings.Default.MainFormSize;
				Location = Settings.Default.MainFormLocation;
				WindowState = Settings.Default.MainFormState;
			}
			catch
			{
				// пока это положение первый раз не сохранено, при 
				// попытке чтения будет кирдык
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Text += " v." + Assembly.GetExecutingAssembly().GetName().Version.ToString();

			RestorePos();

			CalcStat();

		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SavePos();

			Settings.Default.Save();
		}

		/// <summary>
		/// Подхватить настройки предыдущих версий приложения
		/// </summary>
		private void ApplyPrevVersionsSettings()
		{
			if (Settings.Default.CallUpgrade)
			{
				Settings.Default.Upgrade();
				Settings.Default.CallUpgrade = false;
			}
		}

		#endregion

		private void _btnBin2QP_Click(object sender, EventArgs e)
		{
			string instring = _tbInput.Text.Replace("\r\n", "");
			string qpstring = "";
			for (int i = 0; i < instring.Length; i += 8)
			{
				qpstring += string.Format("={0:X2}", Convert.ToByte(instring.Substring(i, 8), 2));
			}

			_tbInput.Text = qpstring;
		}

		private void _btnBin2Win_Click(object sender, EventArgs e)
		{
			Bin2Win();
		}

		private void Bin2Win()
		{
			string instring = _tbInput.Text.Replace("\r\n", "");

			if (IsValidBinText(instring))
			{
				byte[] inbytes = new byte[instring.Length / 8];

				for (int i = 0; i < inbytes.Length; i++)
				{
					inbytes[i] = Convert.ToByte(instring.Substring(i * 8, 8), 2);
				}

				_tbInput.Text = Encoding.GetEncoding(1251).GetString(inbytes);
			}
		}

		private void _btnWin2Bin_Click(object sender, EventArgs e)
		{
			byte[] inbytes = Encoding.GetEncoding(1251).GetBytes(_tbInput.Text);

			//_tbInput.Text = string.Join("", inbytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

			string binstr = "";
			for (int i = 0; i < inbytes.Length; i++)
			{
				if (i % 10 == 0)
					binstr += Environment.NewLine;

				binstr += Convert.ToString(inbytes[i], 2).PadLeft(8, '0');
			}

			_tbInput.Text = binstr;
		}

		private void _btnWin2QP_Click(object sender, EventArgs e)
		{
			string qpstring = "";

			byte[] inbytes = Encoding.GetEncoding(1251).GetBytes(_tbInput.Text);

			for (int i = 0; i < inbytes.Length; i++)
			{
				qpstring += string.Format("={0:X2}", inbytes[i]);
			}

			_tbInput.Text = qpstring;
		}

		private void _tbInput_TextChanged(object sender, EventArgs e)
		{
			CalcStat();
		}

		private void CalcStat()
		{
			_lbl_All.Text = string.Format("Всего - {0}", _tbInput.Text.Length);

			int bins = 0;
			foreach (char c in _tbInput.Text)
			{
				if (c == '0' || c == '1')
					bins++;
			}

			_lblBins.Text = string.Format("1,0 - {0}", bins);
			_lblChars.Text = string.Format("Знаков - {0}", bins / 8.0);
		}

		private void _btnToClipboard_Click(object sender, EventArgs e)
		{
			ClipboardNotification.ClipboardUpdate -= ClipboardUpdated;

			Clipboard.SetText(_tbInput.Text);

			if (_chClipboardMonitor.Checked)
				ClipboardNotification.ClipboardUpdate += ClipboardUpdated;
		}

		private void _btnFromClipBoard_Click(object sender, EventArgs e)
		{
			Clipboard2Win();
		}

		private void Clipboard2Win()
		{
			_tbInput.Text = Clipboard.GetText();
			Bin2Win();
		}

		void ClipboardUpdated(object sender, EventArgs e)
		{
			Clipboard2Win();
		}

		private void _chClipboardMonitor_CheckedChanged(object sender, EventArgs e)
		{
			if (_chClipboardMonitor.Checked)
				ClipboardNotification.ClipboardUpdate += ClipboardUpdated;
			else
				ClipboardNotification.ClipboardUpdate -= ClipboardUpdated;
		}

		bool IsValidBinText(string str)
		{
			return Regex.IsMatch(str, "^[01]+$", RegexOptions.IgnoreCase);
		}
	}
}
