using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharpFilters
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Drawing.Bitmap m_Bitmap;
		private System.Drawing.Bitmap m_Undo;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem FileLoad;
		private System.Windows.Forms.MenuItem FileSave;
		private System.Windows.Forms.MenuItem FileExit;
		private System.Windows.Forms.MenuItem FilterGrayScale;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem Zoom25;
		private double Zoom = 1.0;
		private System.Windows.Forms.MenuItem Zoom50;
		private System.Windows.Forms.MenuItem Zoom100;
		private System.Windows.Forms.MenuItem Zoom150;
		private System.Windows.Forms.MenuItem Zoom200;
		private System.Windows.Forms.MenuItem Zoom300;
		private System.Windows.Forms.MenuItem Zoom500;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem Undo;
        private MenuItem bwToC32;
        private MenuItem bwToC24;
        private IContainer components;

		public Form1()
		{
			InitializeComponent();

			m_Bitmap= new Bitmap(2, 2);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.FileLoad = new System.Windows.Forms.MenuItem();
            this.FileSave = new System.Windows.Forms.MenuItem();
            this.FileExit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.Undo = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Zoom25 = new System.Windows.Forms.MenuItem();
            this.Zoom50 = new System.Windows.Forms.MenuItem();
            this.Zoom100 = new System.Windows.Forms.MenuItem();
            this.Zoom150 = new System.Windows.Forms.MenuItem();
            this.Zoom200 = new System.Windows.Forms.MenuItem();
            this.Zoom300 = new System.Windows.Forms.MenuItem();
            this.Zoom500 = new System.Windows.Forms.MenuItem();
            this.FilterGrayScale = new System.Windows.Forms.MenuItem();
            this.bwToC32 = new System.Windows.Forms.MenuItem();
            this.bwToC24 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem2,
            this.FilterGrayScale,
            this.bwToC32,
            this.bwToC24});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileLoad,
            this.FileSave,
            this.FileExit});
            this.menuItem1.Text = "File";
            // 
            // FileLoad
            // 
            this.FileLoad.Index = 0;
            this.FileLoad.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.FileLoad.Text = "Load";
            this.FileLoad.Click += new System.EventHandler(this.File_Load);
            // 
            // FileSave
            // 
            this.FileSave.Index = 1;
            this.FileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.FileSave.Text = "Save";
            this.FileSave.Click += new System.EventHandler(this.File_Save);
            // 
            // FileExit
            // 
            this.FileExit.Index = 2;
            this.FileExit.Text = "Exit";
            this.FileExit.Click += new System.EventHandler(this.File_Exit);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Undo});
            this.menuItem5.Text = "Edit";
            // 
            // Undo
            // 
            this.Undo.Index = 0;
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.OnUndo);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Zoom25,
            this.Zoom50,
            this.Zoom100,
            this.Zoom150,
            this.Zoom200,
            this.Zoom300,
            this.Zoom500});
            this.menuItem2.Text = "Zoom";
            // 
            // Zoom25
            // 
            this.Zoom25.Index = 0;
            this.Zoom25.Text = "25%";
            this.Zoom25.Click += new System.EventHandler(this.OnZoom25);
            // 
            // Zoom50
            // 
            this.Zoom50.Index = 1;
            this.Zoom50.Text = "50%";
            this.Zoom50.Click += new System.EventHandler(this.OnZoom50);
            // 
            // Zoom100
            // 
            this.Zoom100.Index = 2;
            this.Zoom100.Text = "100%";
            this.Zoom100.Click += new System.EventHandler(this.OnZoom100);
            // 
            // Zoom150
            // 
            this.Zoom150.Index = 3;
            this.Zoom150.Text = "150%";
            this.Zoom150.Click += new System.EventHandler(this.OnZoom150);
            // 
            // Zoom200
            // 
            this.Zoom200.Index = 4;
            this.Zoom200.Text = "200%";
            this.Zoom200.Click += new System.EventHandler(this.OnZoom200);
            // 
            // Zoom300
            // 
            this.Zoom300.Index = 5;
            this.Zoom300.Text = "300%";
            this.Zoom300.Click += new System.EventHandler(this.OnZoom300);
            // 
            // Zoom500
            // 
            this.Zoom500.Index = 6;
            this.Zoom500.Text = "500%";
            this.Zoom500.Click += new System.EventHandler(this.OnZoom500);
            // 
            // FilterGrayScale
            // 
            this.FilterGrayScale.Index = 3;
            this.FilterGrayScale.Text = "GrayScale";
            this.FilterGrayScale.Click += new System.EventHandler(this.Filter_GrayScale);
            // 
            // bwToC32
            // 
            this.bwToC32.Index = 4;
            this.bwToC32.Text = "BW to Color32+";
            this.bwToC32.Click += new System.EventHandler(this.bwToC32_Click);
            // 
            // bwToC24
            // 
            this.bwToC24.Index = 5;
            this.bwToC24.Text = "BW to Color24";
            this.bwToC24.Click += new System.EventHandler(this.bwToC24_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(627, 314);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Image Colorization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		protected override void OnPaint (PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width*Zoom), (int)(m_Bitmap.Height * Zoom)));
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void File_Load(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = "c:\\" ;
			openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|GIF files(*.gif)|*.gif|PNG files(*.png)|*.png|All valid files|*.bmp/*.jpg/*.gif/*.png";
			openFileDialog.FilterIndex = 2 ;
			openFileDialog.RestoreDirectory = true ;

			if(DialogResult.OK == openFileDialog.ShowDialog())
			{
				m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
				this.AutoScroll = true;
				this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
				this.Invalidate();
			}
		}

		private void File_Save(object sender, System.EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.InitialDirectory = "c:\\" ;
			saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg" ;
			saveFileDialog.FilterIndex = 1 ;
			saveFileDialog.RestoreDirectory = true ;

			if(DialogResult.OK == saveFileDialog.ShowDialog())
			{
				m_Bitmap.Save(saveFileDialog.FileName);
			}
		}

		private void File_Exit(object sender, System.EventArgs e)
		{
			this.Close();
		}
				
		delegate bool ImageProcessingMethod(Bitmap b);


		private void Filter_GrayScale(object sender, System.EventArgs e)
		{
				m_Undo = (Bitmap)m_Bitmap.Clone();
                if (BitmapFilterBasic.GrayScale(m_Bitmap))
					this.Invalidate();		
		}

		private void OnZoom25(object sender, System.EventArgs e)
		{
			Zoom = .25;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom50(object sender, System.EventArgs e)
		{
			Zoom = .5;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom100(object sender, System.EventArgs e)
		{
			Zoom = 1.0;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom150(object sender, System.EventArgs e)
		{
			Zoom = 1.5;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom200(object sender, System.EventArgs e)
		{
			Zoom = 2.0;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom300(object sender, System.EventArgs e)
		{
			Zoom = 3.0;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom500(object sender, System.EventArgs e)
		{
			Zoom = 5;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnUndo(object sender, System.EventArgs e)
		{
			Bitmap temp = (Bitmap)m_Bitmap.Clone();
			m_Bitmap = (Bitmap)m_Undo.Clone();
			m_Undo = (Bitmap)temp.Clone();
			this.Invalidate();
		}

        private void bwToC32_Click(object sender, EventArgs e)
        {
            m_Undo = (Bitmap)m_Bitmap.Clone();
            BitmapFilterConvolution.GrayscaleToColor(m_Bitmap);
            this.Invalidate();
        }

        private void bwToC24_Click(object sender, EventArgs e)
        {
            m_Undo = (Bitmap)m_Bitmap.Clone();
            BitmapFilterConvolution.GrayscaleToColor24(m_Bitmap);
            this.Invalidate();
        }
    }
}

