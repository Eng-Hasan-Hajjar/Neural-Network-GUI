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
	/// Summary description for NeuronGUI.
	/// </summary>
	public class NeuronGUI : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TabControl Tab_neuron;
		private System.Windows.Forms.TabPage page_function;
		private System.Windows.Forms.TabPage page_test;
		private ActivationFunctionGUI activationFunctionGUI1;
		private System.Windows.Forms.Button accept_function;
		private GraphicalNeuron graphicalNeuron1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button but_rand_w;
		private System.Windows.Forms.Button but_rand_thre;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_r_min;
		private System.Windows.Forms.TextBox tb_r_max;

		protected Neuron neu = null;

		public NeuronGUI()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// TODO: Add any initialization after the InitForm call
		}

		public void setNeuron(Neuron n) 
		{
			neu = n;
			activationFunctionGUI1.AFunction = n.F;
			graphicalNeuron1.setNeuron(n);
			this.tb_r_min.Text = ""+neu.Randomization_Min;
			this.tb_r_max.Text = ""+neu.Randomization_Max;
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
			this.Tab_neuron = new System.Windows.Forms.TabControl();
			this.page_test = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tb_r_max = new System.Windows.Forms.TextBox();
			this.tb_r_min = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.but_rand_thre = new System.Windows.Forms.Button();
			this.but_rand_w = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.graphicalNeuron1 = new GraphicalNeuron();
			this.page_function = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.accept_function = new System.Windows.Forms.Button();
			this.activationFunctionGUI1 = new ActivationFunctionGUI();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Tab_neuron.SuspendLayout();
			this.page_test.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.page_function.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tab_neuron
			// 
			this.Tab_neuron.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.Tab_neuron.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.page_test,
																					 this.page_function});
			this.Tab_neuron.Name = "Tab_neuron";
			this.Tab_neuron.SelectedIndex = 0;
			this.Tab_neuron.Size = new System.Drawing.Size(472, 360);
			this.Tab_neuron.TabIndex = 0;
			// 
			// page_test
			// 
			this.page_test.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.page_test.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.panel3});
			this.page_test.Location = new System.Drawing.Point(4, 28);
			this.page_test.Name = "page_test";
			this.page_test.Size = new System.Drawing.Size(464, 328);
			this.page_test.TabIndex = 2;
			this.page_test.Text = "Neuron Weights";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.tb_r_max,
																				 this.tb_r_min,
																				 this.label2,
																				 this.label1,
																				 this.but_rand_thre,
																				 this.but_rand_w,
																				 this.panel1});
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(464, 328);
			this.panel3.TabIndex = 0;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// tb_r_max
			// 
			this.tb_r_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_r_max.Location = new System.Drawing.Point(328, 296);
			this.tb_r_max.Name = "tb_r_max";
			this.tb_r_max.Size = new System.Drawing.Size(64, 23);
			this.tb_r_max.TabIndex = 8;
			this.tb_r_max.Text = "1,0";
			this.tb_r_max.TextChanged += new System.EventHandler(this.tb_r_max_TextChanged);
			// 
			// tb_r_min
			// 
			this.tb_r_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_r_min.Location = new System.Drawing.Point(328, 272);
			this.tb_r_min.Name = "tb_r_min";
			this.tb_r_min.Size = new System.Drawing.Size(64, 23);
			this.tb_r_min.TabIndex = 7;
			this.tb_r_min.Text = "-1,0";
			this.tb_r_min.TextChanged += new System.EventHandler(this.tb_r_min_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Max Value : ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(245, 274);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Min value : ";
			// 
			// but_rand_thre
			// 
			this.but_rand_thre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_rand_thre.Location = new System.Drawing.Point(40, 272);
			this.but_rand_thre.Name = "but_rand_thre";
			this.but_rand_thre.Size = new System.Drawing.Size(176, 23);
			this.but_rand_thre.TabIndex = 4;
			this.but_rand_thre.Text = "Randomize Threshold";
			this.but_rand_thre.Click += new System.EventHandler(this.but_rand_thre_Click);
			// 
			// but_rand_w
			// 
			this.but_rand_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_rand_w.Location = new System.Drawing.Point(40, 296);
			this.but_rand_w.Name = "but_rand_w";
			this.but_rand_w.Size = new System.Drawing.Size(176, 24);
			this.but_rand_w.TabIndex = 3;
			this.but_rand_w.Text = "Randomize Weights";
			this.but_rand_w.Click += new System.EventHandler(this.but_rand_w_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.graphicalNeuron1});
			this.panel1.Location = new System.Drawing.Point(24, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 248);
			this.panel1.TabIndex = 2;
			// 
			// graphicalNeuron1
			// 
			this.graphicalNeuron1.BackColor = System.Drawing.Color.White;
			this.graphicalNeuron1.Name = "graphicalNeuron1";
			this.graphicalNeuron1.Size = new System.Drawing.Size(416, 248);
			this.graphicalNeuron1.TabIndex = 1;
			// 
			// page_function
			// 
			this.page_function.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.page_function.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.panel4});
			this.page_function.Location = new System.Drawing.Point(4, 28);
			this.page_function.Name = "page_function";
			this.page_function.Size = new System.Drawing.Size(464, 328);
			this.page_function.TabIndex = 1;
			this.page_function.Text = "Activation Function";
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.accept_function,
																				 this.activationFunctionGUI1});
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(464, 328);
			this.panel4.TabIndex = 0;
			// 
			// accept_function
			// 
			this.accept_function.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.accept_function.Location = new System.Drawing.Point(104, 272);
			this.accept_function.Name = "accept_function";
			this.accept_function.Size = new System.Drawing.Size(232, 23);
			this.accept_function.TabIndex = 1;
			this.accept_function.Text = "Apply new activation function";
			this.accept_function.Click += new System.EventHandler(this.accept_function_Click);
			// 
			// activationFunctionGUI1
			// 
			this.activationFunctionGUI1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.activationFunctionGUI1.Location = new System.Drawing.Point(56, 32);
			this.activationFunctionGUI1.Name = "activationFunctionGUI1";
			this.activationFunctionGUI1.Size = new System.Drawing.Size(336, 216);
			this.activationFunctionGUI1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.Tab_neuron});
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(472, 360);
			this.panel2.TabIndex = 1;
			// 
			// NeuronGUI
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel2});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "NeuronGUI";
			this.Size = new System.Drawing.Size(472, 360);
			this.Tab_neuron.ResumeLayout(false);
			this.page_test.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.page_function.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void but_rand_thre_Click(object sender, System.EventArgs e)
		{
			if (neu != null) neu.randomizeThreshold();
			graphicalNeuron1.Refresh();

		}

		private void but_rand_w_Click(object sender, System.EventArgs e)
		{
			if (neu != null) neu.randomizeWeight();
			graphicalNeuron1.Refresh();
		}

		private void accept_function_Click(object sender, System.EventArgs e)
		{
			if (neu != null) neu.F = activationFunctionGUI1.AFunction;
		}

		private void tb_r_min_TextChanged(object sender, System.EventArgs e)
		{
			if (neu != null) 
			{
				try 
				{
					neu.Randomization_Min = float.Parse(this.tb_r_min.Text.Replace(".",","));
				}
				catch 
				{
					this.tb_r_min.Text = ""+neu.Randomization_Min;
				}
			}
		}

		private void tb_r_max_TextChanged(object sender, System.EventArgs e)
		{
			if (neu != null) 
			{
				try 
				{
					neu.Randomization_Max = float.Parse(this.tb_r_max.Text.Replace(".",","));
				}
				catch 
				{
					this.tb_r_max.Text = ""+neu.Randomization_Max;
				}
			}
		
		}

		private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (neu != null) 
			{
				this.tb_r_min.Text = ""+neu.Randomization_Min;
				this.tb_r_max.Text = ""+neu.Randomization_Max;
			}
		}
	}
}
