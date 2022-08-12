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
	/// Summary description for NeuralNetworkGUI.
	/// </summary>
	public class NeuralNetworkStructureGUI : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ColumnHeader c_layer;
		private System.Windows.Forms.ColumnHeader c_n_neuron;
		private System.Windows.Forms.ListView list_layers;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.ContextMenu Layers_menu;
		private System.Windows.Forms.NumericUpDown num_out;
		private System.Windows.Forms.NumericUpDown num_in;

		protected ArrayList couches;

		public NeuralNetworkStructureGUI()
		{
			couches = new ArrayList();
			couches.Add(1);
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
			refreshList();
		}

		public void setNetworkStructure(NeuralNetwork.NeuralNetwork net) 
		{
			couches.Clear();
			for(int i=0; i< net.N_Layers; i++)
				couches.Add(net[i].N_Neurons);
			num_in.Value = net.N_Inputs;
			num_out.Value = net.N_Outputs;
			refreshList();
		}

		public void LockInputOutput(int inputs, int outputs) 
		{
			num_in.Value = inputs;
			num_out.Value = outputs;
			num_in.ReadOnly = true;
			num_out.ReadOnly = true;
			num_in.Maximum = inputs;
			num_in.Minimum = inputs;
			num_out.Maximum = outputs;
			num_out.Minimum = outputs;


			refreshList();
		}

		public NeuralNetwork.NeuralNetwork getNewNeuralNetwork() 
		{
			int[] p = new int[couches.Count];
			for(int i=0; i<couches.Count; i++)
				p[i] = (int)couches[i];
			return new NeuralNetwork.NeuralNetwork((int)num_in.Value, p);
		}

		protected void refreshList() 
		{
			string[] s = new String[2];
			
			list_layers.Items.Clear();
			couches[couches.Count-1] = (int)this.num_out.Value;
			for(int i=0; i<couches.Count;i++) 
			{	
				if (couches.Count == 1) s[0] = "Input/Output layer";
				else if (i == 0) s[0] = "Input layer";
				else if (i == couches.Count-1) s[0] = "Output layer";
				else s[0] = "Hidden layer "+i;
				s[1] = couches[i]+" neuron(s)";
				list_layers.Items.Add(new ListViewItem(s));

			}
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
			this.list_layers = new System.Windows.Forms.ListView();
			this.c_layer = new System.Windows.Forms.ColumnHeader();
			this.c_n_neuron = new System.Windows.Forms.ColumnHeader();
			this.Layers_menu = new System.Windows.Forms.ContextMenu();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.num_out = new System.Windows.Forms.NumericUpDown();
			this.num_in = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.num_out)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_in)).BeginInit();
			this.SuspendLayout();
			// 
			// list_layers
			// 
			this.list_layers.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.list_layers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.list_layers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.c_layer,
																						  this.c_n_neuron});
			this.list_layers.ContextMenu = this.Layers_menu;
			this.list_layers.ForeColor = System.Drawing.Color.Blue;
			this.list_layers.FullRowSelect = true;
			this.list_layers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.list_layers.Location = new System.Drawing.Point(16, 64);
			this.list_layers.MultiSelect = false;
			this.list_layers.Name = "list_layers";
			this.list_layers.Size = new System.Drawing.Size(312, 144);
			this.list_layers.TabIndex = 0;
			this.list_layers.View = System.Windows.Forms.View.Details;
			// 
			// c_layer
			// 
			this.c_layer.Text = "Layer";
			this.c_layer.Width = 150;
			// 
			// c_n_neuron
			// 
			this.c_n_neuron.Text = "Number of neurons";
			this.c_n_neuron.Width = 150;
			// 
			// Layers_menu
			// 
			this.Layers_menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuItem4,
																						this.menuItem1,
																						this.menuItem2});
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "Edit Layer";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "Insert Layer";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "Delete Layer";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Number of inputs :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Number of outputs :";
			// 
			// num_out
			// 
			this.num_out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_out.Location = new System.Drawing.Point(200, 32);
			this.num_out.Maximum = new System.Decimal(new int[] {
																	128,
																	0,
																	0,
																	0});
			this.num_out.Minimum = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.num_out.Name = "num_out";
			this.num_out.Size = new System.Drawing.Size(72, 23);
			this.num_out.TabIndex = 5;
			this.num_out.Value = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  0});
			this.num_out.ValueChanged += new System.EventHandler(this.num_out_ValueChanged);
			this.num_out.Leave += new System.EventHandler(this.num_out_ValueChanged);
			// 
			// num_in
			// 
			this.num_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_in.Location = new System.Drawing.Point(200, 8);
			this.num_in.Maximum = new System.Decimal(new int[] {
																   128,
																   0,
																   0,
																   0});
			this.num_in.Minimum = new System.Decimal(new int[] {
																   1,
																   0,
																   0,
																   0});
			this.num_in.Name = "num_in";
			this.num_in.Size = new System.Drawing.Size(72, 23);
			this.num_in.TabIndex = 6;
			this.num_in.Value = new System.Decimal(new int[] {
																 1,
																 0,
																 0,
																 0});
			this.num_in.ValueChanged += new System.EventHandler(this.num_in_ValueChanged);
			// 
			// NeuralNetworkStructureGUI
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.num_in,
																		  this.num_out,
																		  this.label2,
																		  this.label1,
																		  this.list_layers});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "NeuralNetworkStructureGUI";
			this.Size = new System.Drawing.Size(344, 224);
			((System.ComponentModel.ISupportInitialize)(this.num_out)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_in)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if (list_layers.SelectedIndices.Count != 0 && list_layers.SelectedIndices[0]!= couches.Count-1) 
			{
				NewLayerForm f = new NewLayerForm();
				f.Nb_Neurons = (int)couches[list_layers.SelectedIndices[0]];
				f.ShowDialog();
				if (f.IsValid) couches[list_layers.SelectedIndices[0]] = f.Nb_Neurons;
			}
			refreshList();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			NewLayerForm f = new NewLayerForm();
			f.ShowDialog();
			if (f.IsValid) 
			{
				if (list_layers.SelectedIndices.Count != 0) 
					couches.Insert(list_layers.SelectedIndices[0],f.Nb_Neurons);
				else 
					couches.Insert(0,f.Nb_Neurons);
			}
			refreshList();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if (couches.Count > 1 && list_layers.SelectedIndices.Count != 0 && list_layers.SelectedIndices[0]!= couches.Count-1)
				couches.RemoveAt(list_layers.SelectedIndices[0]);
			refreshList();
		}

		private void num_out_ValueChanged(object sender, System.EventArgs e)
		{
			
			refreshList();
		}

		private void num_in_ValueChanged(object sender, System.EventArgs e)
		{
		
		}
		
	}
}
