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
	/// Summary description for LayerGUI.
	/// </summary>
	public class LayerGUI : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private NeuronGUI neuronGUI1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_in_size;
		private System.Windows.Forms.TextBox tb_out_size;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button but_rand_all_w;
		private System.Windows.Forms.Button but_rand_all_t;
		private System.Windows.Forms.Button but_choos_af;
		private System.Windows.Forms.ListBox neuron_list;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox neuron_prop;
		private System.Windows.Forms.TextBox tb_r_min;
		private System.Windows.Forms.TextBox tb_r_max;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;

		protected Layer layer = null;

		public void setLayer(Layer l) 
		{
			layer = l;
			neuron_list.Items.Clear();
			for(int i=0; i<l.N_Neurons; i++)
				neuron_list.Items.Add("Neuron " + i);
			neuron_list.SelectedIndex = 0;
			neuronGUI1.setNeuron(l[0]);
			this.tb_in_size.Text = ""+l.N_Inputs;
			this.tb_out_size.Text = ""+l.N_Neurons;
		}

		public LayerGUI()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			//setLayer(new Layer(6,4));
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
			this.neuron_list = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.neuronGUI1 = new NeuronGUI();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.neuron_prop = new System.Windows.Forms.GroupBox();
			this.tb_in_size = new System.Windows.Forms.TextBox();
			this.tb_out_size = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.but_choos_af = new System.Windows.Forms.Button();
			this.but_rand_all_t = new System.Windows.Forms.Button();
			this.but_rand_all_w = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tb_r_min = new System.Windows.Forms.TextBox();
			this.tb_r_max = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.neuron_prop.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// neuron_list
			// 
			this.neuron_list.BackColor = System.Drawing.Color.White;
			this.neuron_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.neuron_list.ItemHeight = 16;
			this.neuron_list.Items.AddRange(new object[] {
															 "no layer loaded"});
			this.neuron_list.Location = new System.Drawing.Point(16, 24);
			this.neuron_list.Name = "neuron_list";
			this.neuron_list.Size = new System.Drawing.Size(112, 226);
			this.neuron_list.TabIndex = 0;
			this.neuron_list.SelectedIndexChanged += new System.EventHandler(this.neuron_list_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.neuron_list});
			this.groupBox1.Location = new System.Drawing.Point(8, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 264);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Neurons : ";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// neuronGUI1
			// 
			this.neuronGUI1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.neuronGUI1.Location = new System.Drawing.Point(16, 24);
			this.neuronGUI1.Name = "neuronGUI1";
			this.neuronGUI1.Size = new System.Drawing.Size(480, 360);
			this.neuronGUI1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Input vector size : ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Output vector size : ";
			// 
			// neuron_prop
			// 
			this.neuron_prop.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.neuron_prop.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.neuronGUI1});
			this.neuron_prop.Location = new System.Drawing.Point(160, 104);
			this.neuron_prop.Name = "neuron_prop";
			this.neuron_prop.Size = new System.Drawing.Size(504, 392);
			this.neuron_prop.TabIndex = 5;
			this.neuron_prop.TabStop = false;
			this.neuron_prop.Text = "Neuron properties : ";
			// 
			// tb_in_size
			// 
			this.tb_in_size.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tb_in_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_in_size.Location = new System.Drawing.Point(160, 24);
			this.tb_in_size.MaxLength = 10;
			this.tb_in_size.Name = "tb_in_size";
			this.tb_in_size.ReadOnly = true;
			this.tb_in_size.Size = new System.Drawing.Size(48, 23);
			this.tb_in_size.TabIndex = 6;
			this.tb_in_size.Text = "0";
			// 
			// tb_out_size
			// 
			this.tb_out_size.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tb_out_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_out_size.Location = new System.Drawing.Point(160, 48);
			this.tb_out_size.MaxLength = 10;
			this.tb_out_size.Name = "tb_out_size";
			this.tb_out_size.ReadOnly = true;
			this.tb_out_size.Size = new System.Drawing.Size(48, 23);
			this.tb_out_size.TabIndex = 7;
			this.tb_out_size.Text = "0";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this.tb_in_size,
																					this.tb_out_size,
																					this.label1});
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(224, 88);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Layer properties";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label4,
																					this.label3,
																					this.tb_r_max,
																					this.tb_r_min,
																					this.but_rand_all_t,
																					this.but_rand_all_w});
			this.groupBox3.Location = new System.Drawing.Point(240, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 88);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Randomization of all layer neurons : ";
			// 
			// but_choos_af
			// 
			this.but_choos_af.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_choos_af.Location = new System.Drawing.Point(16, 32);
			this.but_choos_af.Name = "but_choos_af";
			this.but_choos_af.Size = new System.Drawing.Size(112, 72);
			this.but_choos_af.TabIndex = 2;
			this.but_choos_af.Text = "Choose activation function for all neurons...";
			this.but_choos_af.Click += new System.EventHandler(this.but_choos_af_Click);
			// 
			// but_rand_all_t
			// 
			this.but_rand_all_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_rand_all_t.Location = new System.Drawing.Point(24, 56);
			this.but_rand_all_t.Name = "but_rand_all_t";
			this.but_rand_all_t.Size = new System.Drawing.Size(168, 24);
			this.but_rand_all_t.TabIndex = 1;
			this.but_rand_all_t.Text = "Randomize Threshold";
			this.but_rand_all_t.Click += new System.EventHandler(this.but_rand_all_t_Click);
			// 
			// but_rand_all_w
			// 
			this.but_rand_all_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_rand_all_w.Location = new System.Drawing.Point(24, 24);
			this.but_rand_all_w.Name = "but_rand_all_w";
			this.but_rand_all_w.Size = new System.Drawing.Size(168, 24);
			this.but_rand_all_w.TabIndex = 0;
			this.but_rand_all_w.Text = "Randomize Weights";
			this.but_rand_all_w.Click += new System.EventHandler(this.but_rand_all_w_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.groupBox4,
																				 this.groupBox1,
																				 this.groupBox2,
																				 this.neuron_prop,
																				 this.groupBox3});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(672, 504);
			this.panel1.TabIndex = 10;
			// 
			// tb_r_min
			// 
			this.tb_r_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_r_min.Location = new System.Drawing.Point(344, 24);
			this.tb_r_min.Name = "tb_r_min";
			this.tb_r_min.Size = new System.Drawing.Size(64, 23);
			this.tb_r_min.TabIndex = 3;
			this.tb_r_min.Text = "-1,0";
			// 
			// tb_r_max
			// 
			this.tb_r_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_r_max.Location = new System.Drawing.Point(344, 56);
			this.tb_r_max.Name = "tb_r_max";
			this.tb_r_max.Size = new System.Drawing.Size(64, 23);
			this.tb_r_max.TabIndex = 4;
			this.tb_r_max.Text = "1,0";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.groupBox4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.but_choos_af});
			this.groupBox4.Location = new System.Drawing.Point(8, 104);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(144, 120);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Activation : ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(220, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Minimum value : ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(216, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Maximum value : ";
			// 
			// LayerGUI
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LayerGUI";
			this.Size = new System.Drawing.Size(672, 504);
			this.groupBox1.ResumeLayout(false);
			this.neuron_prop.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void but_choos_af_Click(object sender, System.EventArgs e)
		{
			ActivationFunctionChooser ac = new ActivationFunctionChooser();
			ac.ShowDialog();
			if (ac.ChooseOK && layer!=null) 
			{
				layer.setActivationFunction(ac.Choosen);
				neuronGUI1.setNeuron(layer[neuron_list.SelectedIndex]);
			}
			neuronGUI1.Refresh();


		}

		private void neuron_list_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (layer != null)
				neuronGUI1.setNeuron(layer[neuron_list.SelectedIndex]);
			neuronGUI1.Refresh();
		}

		private void but_rand_all_w_Click(object sender, System.EventArgs e)
		{
			if (layer != null) 
			{
				float min, max;
				try 
				{
					min = float.Parse(this.tb_r_min.Text.Replace(".",","));
					max = float.Parse(this.tb_r_max.Text.Replace(".",","));
				}
				catch 
				{
					min = -1f;
					max = 1f;
					tb_r_min.Text = ""+min;
					tb_r_max.Text = ""+max;
				}
				layer.setRandomizationInterval(min, max);
				layer.randomizeWeight();
			}
			neuronGUI1.Refresh();
		}

		private void but_rand_all_t_Click(object sender, System.EventArgs e)
		{
			if (layer != null) 
			{
				float min, max;
				try 
				{
					min = float.Parse(this.tb_r_min.Text.Replace(".",","));
					max = float.Parse(this.tb_r_max.Text.Replace(".",","));
				}
				catch 
				{
					min = -1f;
					max = 1f;
					tb_r_min.Text = ""+min;
					tb_r_max.Text = ""+max;
				}
				layer.setRandomizationInterval(min, max);
				layer.randomizeThreshold();
			}
			neuronGUI1.Refresh();
		}
	}
}
