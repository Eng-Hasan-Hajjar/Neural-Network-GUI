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
	/// Summary description for FunctionPreview.
	/// </summary>
	public class FunctionPreview : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		protected ActivationFunction af = null;

		public FunctionPreview()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
		}

		public void setFunction(ActivationFunction f) 
		{
			af = f;
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
			// 
			// FunctionPreview
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Name = "FunctionPreview";
			this.Size = new System.Drawing.Size(176, 128);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FunctionPreview_Paint);

		}
		#endregion

		public float X_MIN = -4f;
		public float X_MAX = 4f;
		public float Y_MIN = -0.25f;
		public float Y_MAX = 1.25f;

		protected int cX(float x) 
		{
			return (int)(((float)(Width-1))/(X_MAX-X_MIN)*(x-X_MIN));
		}
		protected int cY(float y) 
		{
			return (Height-1) - (int)(((float)(Height-1))/(Y_MAX-Y_MIN)*(y-Y_MIN));
		}


		private void FunctionPreview_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = this.CreateGraphics();
			Pen p = new Pen(new SolidBrush(Color.Black),1);
			// Le repere :
			g.DrawLine(p,cX(0),cY(Y_MIN),cX(0),cY(Y_MAX));
			g.DrawLine(p,cX(X_MIN),cY(0),cX(X_MAX),cY(0));
			p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			p.Color = Color.Blue;
			g.DrawLine(p,cX(X_MIN),cY(1),cX(X_MAX),cY(1));

			p = new Pen(new SolidBrush(Color.Red),1);
			
			float x1, x2, y1, y2;
			
			if (af != null) 
			{
				x2 = X_MIN;
				y2 = af.Output(X_MIN);
				for (x1 = X_MIN; x1 <= X_MAX; x1+=0.1f)
				{
					try 
					{
						y1 = af.Output(x1);
						g.DrawLine(p,cX(x1),cY(y1),cX(x2),cY(y2));
						x2 = x1; y2 = y1;
					}
					catch {}
				}


			}
			


		}
	}
}
