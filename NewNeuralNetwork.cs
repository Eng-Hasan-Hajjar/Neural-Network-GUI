using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NeuralNetworkGUI
{
	/// <summary>
	/// Summary description for NewNeuralNetwork.
	/// </summary>
	public class NewNeuralNetwork : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private NeuralNetworkGUI.NeuralNetworkStructureGUI neuralNetworkStructureGUI1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		protected bool valid = false;

		public bool IsValid 
		{
			get { return valid; }
		}

		public NeuralNetwork.NeuralNetwork NewNetwork 
		{
			get { return neuralNetworkStructureGUI1.getNewNeuralNetwork(); }
		}

		public void setNetworkStructure(NeuralNetwork.NeuralNetwork net) 
		{
			neuralNetworkStructureGUI1.setNetworkStructure(net);
		}

		public void LockInputOutput(int inputs, int outputs) 
		{
			neuralNetworkStructureGUI1.LockInputOutput(inputs, outputs);
		}

		public NewNeuralNetwork()
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.neuralNetworkStructureGUI1 = new NeuralNetworkGUI.NeuralNetworkStructureGUI();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(224, 240);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(128, 240);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "Cancel";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// neuralNetworkStructureGUI1
			// 
			this.neuralNetworkStructureGUI1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.neuralNetworkStructureGUI1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.neuralNetworkStructureGUI1.Location = new System.Drawing.Point(8, 8);
			this.neuralNetworkStructureGUI1.Name = "neuralNetworkStructureGUI1";
			this.neuralNetworkStructureGUI1.Size = new System.Drawing.Size(344, 224);
			this.neuralNetworkStructureGUI1.TabIndex = 3;
			// 
			// NewNeuralNetwork
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(368, 270);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.neuralNetworkStructureGUI1});
			this.MaximumSize = new System.Drawing.Size(376, 304);
			this.MinimumSize = new System.Drawing.Size(376, 304);
			this.Name = "NewNeuralNetwork";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NewNeuralNetwork";
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			valid = true;
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			valid = false;
			this.Close();
		}
	}
}
