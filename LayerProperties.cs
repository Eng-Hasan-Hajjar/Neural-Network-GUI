using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NeuralNetworkGUI
{
	/// <summary>
	/// Summary description for LayerProperties.
	/// </summary>
	public class LayerProperties : System.Windows.Forms.Form
	{
		private NeuralNetworkGUI.LayerGUI layerGUI1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LayerProperties(NeuralNetwork.Layer l)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			layerGUI1.setLayer(l);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.layerGUI1 = new NeuralNetworkGUI.LayerGUI();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// layerGUI1
			// 
			this.layerGUI1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.layerGUI1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.layerGUI1.Name = "layerGUI1";
			this.layerGUI1.Size = new System.Drawing.Size(672, 504);
			this.layerGUI1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(552, 512);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LayerProperties
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(672, 542);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.layerGUI1});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximumSize = new System.Drawing.Size(680, 576);
			this.MinimumSize = new System.Drawing.Size(680, 576);
			this.Name = "LayerProperties";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "LayerProperties";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
