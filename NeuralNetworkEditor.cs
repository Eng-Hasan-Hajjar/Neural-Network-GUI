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
	/// Summary description for NeuralNetworkEditor.
	/// </summary>
	public class NeuralNetworkEditor : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ListView list_layers;
		private System.Windows.Forms.ColumnHeader c_layer;
		private System.Windows.Forms.ColumnHeader c_n_neuron;
		private NeuralNetworkGUI.BackPropagationGUI backPropagationGUI1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NumericUpDown num_max;
		private System.Windows.Forms.NumericUpDown num_min;


		protected NeuralNetwork.NeuralNetwork nn;

		protected bool IOlocked = false;
		protected int l_ins, l_outs;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_bp;
		private System.Windows.Forms.TabPage tab_genetic;
		private System.Windows.Forms.Button but_load;
		private System.Windows.Forms.Button but_save;
		private System.Windows.Forms.Button but_new;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.OpenFileDialog openDialog;
		private NeuralNetworkGUI.GeneticGUI geneticGUI1;

		public NeuralNetwork.NeuralNetwork Neural_Network
		{
			get {return nn;}
			set { nn = value; refreshAll(); }
		}

		public void lockNetworkIO(int inputs, int outputs) 
		{
			l_ins = inputs;
			l_outs = outputs;
			IOlocked = true;
		}

		public void refreshAll() 
		{
			if (nn != null) 
			{
				string[] s = new String[2];
				list_layers.Items.Clear();
				for(int i=0; i<nn.N_Layers;i++) 
				{	
					if (nn.N_Layers == 1) s[0] = "Input/Output layer";
					else if (i == 0) s[0] = "Input layer";
					else if (i == nn.N_Layers-1) s[0] = "Output layer";
					else s[0] = "Hidden layer "+i;
					s[1] = nn[i].N_Neurons+" neuron(s)";
					list_layers.Items.Add(new ListViewItem(s));
				}
				if (nn.LearningAlg.GetType().FullName.IndexOf("Genetic")> 0)
				{
					tabControl1.SelectedTab = tab_genetic;
					geneticGUI1.setGeneticLearningAlgorithm((GeneticLearningAlgorithm)nn.LearningAlg);
				}
				else if (nn.LearningAlg.GetType().FullName.IndexOf("BackPropagation")> 0) 
				{
					tabControl1.SelectedTab = tab_bp;
					backPropagationGUI1.setBackPropagationAlgorithm((BackPropagationLearningAlgorithm)nn.LearningAlg);
				}
			}
		}


		public NeuralNetworkEditor()
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
			this.list_layers = new System.Windows.Forms.ListView();
			this.c_layer = new System.Windows.Forms.ColumnHeader();
			this.c_n_neuron = new System.Windows.Forms.ColumnHeader();
			this.backPropagationGUI1 = new NeuralNetworkGUI.BackPropagationGUI();
			this.but_new = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.num_max = new System.Windows.Forms.NumericUpDown();
			this.num_min = new System.Windows.Forms.NumericUpDown();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_bp = new System.Windows.Forms.TabPage();
			this.tab_genetic = new System.Windows.Forms.TabPage();
			this.geneticGUI1 = new NeuralNetworkGUI.GeneticGUI();
			this.but_load = new System.Windows.Forms.Button();
			this.but_save = new System.Windows.Forms.Button();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.openDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tab_bp.SuspendLayout();
			this.tab_genetic.SuspendLayout();
			this.SuspendLayout();
			// 
			// list_layers
			// 
			this.list_layers.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.list_layers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.list_layers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.c_layer,
																						  this.c_n_neuron});
			this.list_layers.ForeColor = System.Drawing.Color.Blue;
			this.list_layers.FullRowSelect = true;
			this.list_layers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.list_layers.Location = new System.Drawing.Point(8, 8);
			this.list_layers.MultiSelect = false;
			this.list_layers.Name = "list_layers";
			this.list_layers.Size = new System.Drawing.Size(320, 128);
			this.list_layers.TabIndex = 1;
			this.list_layers.View = System.Windows.Forms.View.Details;
			this.list_layers.ItemActivate += new System.EventHandler(this.list_layers_ItemActivate);
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
			// backPropagationGUI1
			// 
			this.backPropagationGUI1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.backPropagationGUI1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.backPropagationGUI1.Location = new System.Drawing.Point(32, 16);
			this.backPropagationGUI1.Name = "backPropagationGUI1";
			this.backPropagationGUI1.Size = new System.Drawing.Size(256, 208);
			this.backPropagationGUI1.TabIndex = 2;
			// 
			// but_new
			// 
			this.but_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_new.Location = new System.Drawing.Point(32, 520);
			this.but_new.Name = "but_new";
			this.but_new.Size = new System.Drawing.Size(80, 23);
			this.but_new.TabIndex = 4;
			this.but_new.Text = "New...";
			this.but_new.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button3,
																					this.button2,
																					this.label2,
																					this.label1,
																					this.num_max,
																					this.num_min});
			this.groupBox2.Location = new System.Drawing.Point(8, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(320, 100);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Neurons parameters : ";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(16, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 64);
			this.button3.TabIndex = 5;
			this.button3.Text = "Choose Activation function...";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(160, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 24);
			this.button2.TabIndex = 4;
			this.button2.Text = "Randomize";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(156, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Maximum :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Minimum :";
			// 
			// num_max
			// 
			this.num_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_max.DecimalPlaces = 2;
			this.num_max.Increment = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  65536});
			this.num_max.Location = new System.Drawing.Point(240, 72);
			this.num_max.Maximum = new System.Decimal(new int[] {
																	10,
																	0,
																	0,
																	0});
			this.num_max.Minimum = new System.Decimal(new int[] {
																	10,
																	0,
																	0,
																	-2147483648});
			this.num_max.Name = "num_max";
			this.num_max.Size = new System.Drawing.Size(56, 23);
			this.num_max.TabIndex = 1;
			this.num_max.Value = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  0});
			// 
			// num_min
			// 
			this.num_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_min.DecimalPlaces = 2;
			this.num_min.Increment = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  65536});
			this.num_min.Location = new System.Drawing.Point(240, 48);
			this.num_min.Maximum = new System.Decimal(new int[] {
																	10,
																	0,
																	0,
																	0});
			this.num_min.Minimum = new System.Decimal(new int[] {
																	10,
																	0,
																	0,
																	-2147483648});
			this.num_min.Name = "num_min";
			this.num_min.Size = new System.Drawing.Size(56, 23);
			this.num_min.TabIndex = 0;
			this.num_min.Value = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  -2147483648});
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tab_bp,
																					  this.tab_genetic});
			this.tabControl1.Location = new System.Drawing.Point(8, 248);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(320, 264);
			this.tabControl1.TabIndex = 6;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tab_bp
			// 
			this.tab_bp.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tab_bp.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.backPropagationGUI1});
			this.tab_bp.Location = new System.Drawing.Point(4, 25);
			this.tab_bp.Name = "tab_bp";
			this.tab_bp.Size = new System.Drawing.Size(312, 235);
			this.tab_bp.TabIndex = 0;
			this.tab_bp.Text = "Back Propagation";
			// 
			// tab_genetic
			// 
			this.tab_genetic.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tab_genetic.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.geneticGUI1});
			this.tab_genetic.Location = new System.Drawing.Point(4, 22);
			this.tab_genetic.Name = "tab_genetic";
			this.tab_genetic.Size = new System.Drawing.Size(312, 238);
			this.tab_genetic.TabIndex = 1;
			this.tab_genetic.Text = "Genetic";
			// 
			// geneticGUI1
			// 
			this.geneticGUI1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.geneticGUI1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.geneticGUI1.Location = new System.Drawing.Point(16, 0);
			this.geneticGUI1.Name = "geneticGUI1";
			this.geneticGUI1.Size = new System.Drawing.Size(280, 240);
			this.geneticGUI1.TabIndex = 7;
			// 
			// but_load
			// 
			this.but_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_load.Location = new System.Drawing.Point(128, 520);
			this.but_load.Name = "but_load";
			this.but_load.Size = new System.Drawing.Size(80, 23);
			this.but_load.TabIndex = 7;
			this.but_load.Text = "Load...";
			this.but_load.Click += new System.EventHandler(this.but_load_Click);
			// 
			// but_save
			// 
			this.but_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but_save.Location = new System.Drawing.Point(224, 520);
			this.but_save.Name = "but_save";
			this.but_save.Size = new System.Drawing.Size(80, 23);
			this.but_save.TabIndex = 8;
			this.but_save.Text = "Save...";
			this.but_save.Click += new System.EventHandler(this.but_save_Click);
			// 
			// saveDialog
			// 
			this.saveDialog.DefaultExt = "nn";
			this.saveDialog.Filter = "Neural network file|*.nn";
			this.saveDialog.RestoreDirectory = true;
			this.saveDialog.Title = "Save neural network";
			this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDialog_FileOk);
			// 
			// openDialog
			// 
			this.openDialog.DefaultExt = "nn";
			this.openDialog.Filter = "Neural Network File|*.nn";
			this.openDialog.RestoreDirectory = true;
			this.openDialog.Title = "Open neural network...";
			this.openDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDialog_FileOk);
			// 
			// NeuralNetworkEditor
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.but_save,
																		  this.but_load,
																		  this.tabControl1,
																		  this.groupBox2,
																		  this.but_new,
																		  this.list_layers});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "NeuralNetworkEditor";
			this.Size = new System.Drawing.Size(992, 784);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tab_bp.ResumeLayout(false);
			this.tab_genetic.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			NewNeuralNetwork ns = new NewNeuralNetwork();
			if (nn != null)
				ns.setNetworkStructure(nn);
			if (this.IOlocked)
				ns.LockInputOutput(l_ins, l_outs);
			ns.ShowDialog();
			if (ns.IsValid)
			{
				nn = ns.NewNetwork;
				if (tabControl1.SelectedTab == tab_genetic)
					nn.LearningAlg = new GeneticLearningAlgorithm(nn);
				else if (tabControl1.SelectedTab == tab_bp) 
					nn.LearningAlg = new BackPropagationLearningAlgorithm(nn);
			}
			refreshAll();
		}

		private void list_layers_ItemActivate(object sender, System.EventArgs e)
		{
			if (nn != null && list_layers.SelectedIndices.Count != 0)
				new LayerProperties(nn[list_layers.SelectedIndices[0]]).ShowDialog();;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if (nn != null)
			{
				ActivationFunctionChooser f = new ActivationFunctionChooser();
				f.ShowDialog();
				if (f.ChooseOK)
					nn.setActivationFunction(f.Choosen);
			}
			refreshAll();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (nn != null) 
			{
				nn.setRandomizationInterval((float)this.num_min.Value, (float)this.num_max.Value);
				nn.randomizeAll();
			}

		
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (tabControl1.SelectedTab == tab_genetic)
			{
				nn.LearningAlg = new GeneticLearningAlgorithm(nn);
				geneticGUI1.setGeneticLearningAlgorithm((GeneticLearningAlgorithm)nn.LearningAlg);
			}
			
			else if (tabControl1.SelectedTab == tab_bp) 
			{
				nn.LearningAlg = new BackPropagationLearningAlgorithm(nn);
				backPropagationGUI1.setBackPropagationAlgorithm((BackPropagationLearningAlgorithm)nn.LearningAlg);
			}
		}

		private void but_save_Click(object sender, System.EventArgs e)
		{
			this.saveDialog.ShowDialog();
		}

		private void saveDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			nn.save(saveDialog.FileName);
		}

		private void but_load_Click(object sender, System.EventArgs e)
		{
			openDialog.ShowDialog();
		}

		private void openDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			NeuralNetwork.NeuralNetwork n = NeuralNetwork.NeuralNetwork.load(openDialog.FileName);
			if (IOlocked && (l_ins != n.N_Inputs || l_outs != n.N_Outputs))
			{
				new CompatibilityError().ShowDialog();
				//openDialog.ShowDialog();
			}
			else
				nn = NeuralNetwork.NeuralNetwork.load(openDialog.FileName);
			this.refreshAll();
		}
	}
}
