using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using NeuralNetwork;

namespace NeuralNetworkGUI
{
	/// <summary>
	/// Summary description for GraphicalNeuron.
	/// </summary>
	public class GraphicalNeuron : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox neuron_img;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		protected Neuron neu = null;
		private System.Windows.Forms.VScrollBar scroll;
		protected int totalHeight = 200;

		public int TotalHeight 
		{
			get { return totalHeight; }
		}

		public void setNeuron(Neuron n) 
		{
			neu = n;
		}

		public GraphicalNeuron()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GraphicalNeuron));
			this.neuron_img = new System.Windows.Forms.PictureBox();
			this.scroll = new System.Windows.Forms.VScrollBar();
			this.SuspendLayout();
			// 
			// neuron_img
			// 
			this.neuron_img.Image = ((System.Drawing.Bitmap)(resources.GetObject("neuron_img.Image")));
			this.neuron_img.Location = new System.Drawing.Point(152, 64);
			this.neuron_img.Name = "neuron_img";
			this.neuron_img.Size = new System.Drawing.Size(100, 100);
			this.neuron_img.TabIndex = 0;
			this.neuron_img.TabStop = false;
			// 
			// scroll
			// 
			this.scroll.Location = new System.Drawing.Point(400, 0);
			this.scroll.Name = "scroll";
			this.scroll.Size = new System.Drawing.Size(17, 250);
			this.scroll.TabIndex = 1;
			this.scroll.Visible = false;
			this.scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_Scroll);
			// 
			// GraphicalNeuron
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.scroll,
																		  this.neuron_img});
			this.Name = "GraphicalNeuron";
			this.Size = new System.Drawing.Size(424, 256);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicalNeuron_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		private void GraphicalNeuron_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = this.CreateGraphics();
			//g.DrawImage(Image.FromFile("images\\neuron.gif"),50,50,100,100);
			Brush b = new SolidBrush(Color.Black);
			Pen p = new Pen(b,1);
			Font ft = new Font("Verdana", 10);
			
			if (neu != null) 
			{

				int dy = -scroll.Value; 

				int tot = neu.N_Inputs + 2;
				int mil = (30*tot+60)/2;

				for(int i=2; i<tot; i++)
				{
					g.DrawString(""+neu[i-2],ft,b,80, i*30-15+dy);
					g.DrawLine(p,60,30*i+dy,180,30*i+dy);
					g.DrawString("E("+(i-2)+")",ft,b,20, i*30-10+dy);
					g.DrawLine(p,180,30*i+dy,300,mil+dy);
			
				}
				g.DrawString(""+neu.Threshold,ft,b,80, tot*30-15+10+dy);
				g.DrawLine(p,60,30*tot+10+dy,180,30*tot+10+dy);
				g.DrawString("-1",ft,b,30, tot*30+dy);
				g.DrawLine(p,180,30*tot+dy+10,300,mil+dy);
				
			
				if (30*tot+10-200> 0) { scroll.Maximum = 30*tot+10-200;scroll.Visible = true;} 
				else {scroll.Value = 0; scroll.Visible = false; }

			
			
				neuron_img.Left = 280;
				neuron_img.Top = mil-50+dy;

				totalHeight = 30*tot + 50;
			}
		}

		private void scroll_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.Refresh();
		}
	}
}
