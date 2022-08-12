using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NeuralNetworkGUI
{
	/// <summary>
	/// Summary description for NewLayerForm.
	/// </summary>
	public class NewLayerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown num_neur;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		protected bool valid = false;

		public int Nb_Neurons 
		{
			set { num_neur.Value = value; }
			get { return (int)num_neur.Value; }
		}

		public bool IsValid 
		{
			get { return valid; }
		}


		public NewLayerForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.label1 = new System.Windows.Forms.Label();
			this.num_neur = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num_neur)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Number of neurons :";
			// 
			// num_neur
			// 
			this.num_neur.BackColor = System.Drawing.Color.White;
			this.num_neur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_neur.Location = new System.Drawing.Point(176, 24);
			this.num_neur.Maximum = new System.Decimal(new int[] {
																	 1024,
																	 0,
																	 0,
																	 0});
			this.num_neur.Minimum = new System.Decimal(new int[] {
																	 1,
																	 0,
																	 0,
																	 0});
			this.num_neur.Name = "num_neur";
			this.num_neur.Size = new System.Drawing.Size(48, 23);
			this.num_neur.TabIndex = 2;
			this.num_neur.Value = new System.Decimal(new int[] {
																   1,
																   0,
																   0,
																   0});
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(72, 80);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Cancel";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(176, 80);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// NewLayerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(292, 152);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.num_neur,
																		  this.label1});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 160);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 160);
			this.Name = "NewLayerForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Layer Properties...";
			((System.ComponentModel.ISupportInitialize)(this.num_neur)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			valid = false;
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			valid = true;
			this.Close();
		}
	}
}
