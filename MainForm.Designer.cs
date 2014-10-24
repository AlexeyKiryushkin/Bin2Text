namespace Bin2Text
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._tbInput = new System.Windows.Forms.TextBox();
			this._btnBin2QP = new System.Windows.Forms.Button();
			this._btnBin2Win = new System.Windows.Forms.Button();
			this._btnWin2Bin = new System.Windows.Forms.Button();
			this._btnWin2QP = new System.Windows.Forms.Button();
			this._lbl_All = new System.Windows.Forms.Label();
			this._lblBins = new System.Windows.Forms.Label();
			this._lblChars = new System.Windows.Forms.Label();
			this._btnFromClipBoard = new System.Windows.Forms.Button();
			this._btnToClipboard = new System.Windows.Forms.Button();
			this._chClipboardMonitor = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// _tbInput
			// 
			this._tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._tbInput.Font = new System.Drawing.Font("Anonymous", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbInput.Location = new System.Drawing.Point(12, 90);
			this._tbInput.Multiline = true;
			this._tbInput.Name = "_tbInput";
			this._tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._tbInput.Size = new System.Drawing.Size(402, 243);
			this._tbInput.TabIndex = 0;
			this._tbInput.TextChanged += new System.EventHandler(this._tbInput_TextChanged);
			// 
			// _btnBin2QP
			// 
			this._btnBin2QP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnBin2QP.Location = new System.Drawing.Point(216, 46);
			this._btnBin2QP.Name = "_btnBin2QP";
			this._btnBin2QP.Size = new System.Drawing.Size(96, 31);
			this._btnBin2QP.TabIndex = 1;
			this._btnBin2QP.Text = "Bin --> QP";
			this._btnBin2QP.UseVisualStyleBackColor = true;
			this._btnBin2QP.Click += new System.EventHandler(this._btnBin2QP_Click);
			// 
			// _btnBin2Win
			// 
			this._btnBin2Win.Location = new System.Drawing.Point(12, 46);
			this._btnBin2Win.Name = "_btnBin2Win";
			this._btnBin2Win.Size = new System.Drawing.Size(96, 31);
			this._btnBin2Win.TabIndex = 1;
			this._btnBin2Win.Text = "Bin --> Win";
			this._btnBin2Win.UseVisualStyleBackColor = true;
			this._btnBin2Win.Click += new System.EventHandler(this._btnBin2Win_Click);
			// 
			// _btnWin2Bin
			// 
			this._btnWin2Bin.Location = new System.Drawing.Point(114, 46);
			this._btnWin2Bin.Name = "_btnWin2Bin";
			this._btnWin2Bin.Size = new System.Drawing.Size(96, 31);
			this._btnWin2Bin.TabIndex = 1;
			this._btnWin2Bin.Text = "Win --> Bin";
			this._btnWin2Bin.UseVisualStyleBackColor = true;
			this._btnWin2Bin.Click += new System.EventHandler(this._btnWin2Bin_Click);
			// 
			// _btnWin2QP
			// 
			this._btnWin2QP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._btnWin2QP.Location = new System.Drawing.Point(318, 46);
			this._btnWin2QP.Name = "_btnWin2QP";
			this._btnWin2QP.Size = new System.Drawing.Size(96, 31);
			this._btnWin2QP.TabIndex = 1;
			this._btnWin2QP.Text = "Win --> QP";
			this._btnWin2QP.UseVisualStyleBackColor = true;
			this._btnWin2QP.Click += new System.EventHandler(this._btnWin2QP_Click);
			// 
			// _lbl_All
			// 
			this._lbl_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lbl_All.Location = new System.Drawing.Point(13, 340);
			this._lbl_All.Name = "_lbl_All";
			this._lbl_All.Size = new System.Drawing.Size(111, 21);
			this._lbl_All.TabIndex = 2;
			this._lbl_All.Text = "Всего - ";
			// 
			// _lblBins
			// 
			this._lblBins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblBins.Location = new System.Drawing.Point(130, 340);
			this._lblBins.Name = "_lblBins";
			this._lblBins.Size = new System.Drawing.Size(95, 21);
			this._lblBins.TabIndex = 2;
			this._lblBins.Text = "1,0 - ";
			// 
			// _lblChars
			// 
			this._lblChars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblChars.Location = new System.Drawing.Point(231, 340);
			this._lblChars.Name = "_lblChars";
			this._lblChars.Size = new System.Drawing.Size(135, 21);
			this._lblChars.TabIndex = 2;
			this._lblChars.Text = "Знаков - ";
			// 
			// _btnFromClipBoard
			// 
			this._btnFromClipBoard.Location = new System.Drawing.Point(12, 9);
			this._btnFromClipBoard.Name = "_btnFromClipBoard";
			this._btnFromClipBoard.Size = new System.Drawing.Size(134, 31);
			this._btnFromClipBoard.TabIndex = 1;
			this._btnFromClipBoard.Text = "Из буфера обмена";
			this._btnFromClipBoard.UseVisualStyleBackColor = true;
			this._btnFromClipBoard.Click += new System.EventHandler(this._btnFromClipBoard_Click);
			// 
			// _btnToClipboard
			// 
			this._btnToClipboard.Location = new System.Drawing.Point(152, 9);
			this._btnToClipboard.Name = "_btnToClipboard";
			this._btnToClipboard.Size = new System.Drawing.Size(134, 31);
			this._btnToClipboard.TabIndex = 1;
			this._btnToClipboard.Text = "В буфер обмена";
			this._btnToClipboard.UseVisualStyleBackColor = true;
			this._btnToClipboard.Click += new System.EventHandler(this._btnToClipboard_Click);
			// 
			// _chClipboardMonitor
			// 
			this._chClipboardMonitor.AutoSize = true;
			this._chClipboardMonitor.Location = new System.Drawing.Point(293, 13);
			this._chClipboardMonitor.Name = "_chClipboardMonitor";
			this._chClipboardMonitor.Size = new System.Drawing.Size(94, 17);
			this._chClipboardMonitor.TabIndex = 3;
			this._chClipboardMonitor.Text = "Отслеживать";
			this._chClipboardMonitor.UseVisualStyleBackColor = true;
			this._chClipboardMonitor.CheckedChanged += new System.EventHandler(this._chClipboardMonitor_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 370);
			this.Controls.Add(this._chClipboardMonitor);
			this.Controls.Add(this._lblChars);
			this.Controls.Add(this._lblBins);
			this.Controls.Add(this._lbl_All);
			this.Controls.Add(this._btnWin2Bin);
			this.Controls.Add(this._btnToClipboard);
			this.Controls.Add(this._btnFromClipBoard);
			this.Controls.Add(this._btnBin2Win);
			this.Controls.Add(this._btnWin2QP);
			this.Controls.Add(this._btnBin2QP);
			this.Controls.Add(this._tbInput);
			this.MinimumSize = new System.Drawing.Size(442, 362);
			this.Name = "MainForm";
			this.Text = "BinToText";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _tbInput;
		private System.Windows.Forms.Button _btnBin2QP;
		private System.Windows.Forms.Button _btnBin2Win;
		private System.Windows.Forms.Button _btnWin2Bin;
		private System.Windows.Forms.Button _btnWin2QP;
		private System.Windows.Forms.Label _lbl_All;
		private System.Windows.Forms.Label _lblBins;
		private System.Windows.Forms.Label _lblChars;
		private System.Windows.Forms.Button _btnFromClipBoard;
		private System.Windows.Forms.Button _btnToClipboard;
		private System.Windows.Forms.CheckBox _chClipboardMonitor;
	}
}

