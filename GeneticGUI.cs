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
	/// Summary description for GeneticGUI.
	/// </summary>
	public class GeneticGUI : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TextBox tb_err;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_gen;
		private System.Windows.Forms.NumericUpDown num_pop_size;
		private System.Windows.Forms.Button button1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.NumericUpDown num_mut_amp;
		private System.Windows.Forms.NumericUpDown num_mut_ratio;
		private System.Windows.Forms.NumericUpDown num_sel_ratio;
		private System.Windows.Forms.NumericUpDown num_max_gen;
		private System.Windows.Forms.NumericUpDown num_max_err;

		protected GeneticLearningAlgorithm alg;

		public GeneticGUI()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		public void setGeneticLearningAlgorithm(GeneticLearningAlgorithm a) 
		{
			alg = a;
			num_pop_size.Value = alg.PopulationSize;
			num_mut_amp.Value = (decimal)alg.MaxMutationAmplitude;
			num_mut_ratio.Value = alg.MutationRatio;
			num_sel_ratio.Value = alg.SelectionRatio;
			num_max_gen.Value = alg.MaxIteration;
			num_max_err.Value = (decimal)alg.ErrorTreshold;
			tb_err.Text = ""+alg.Error;
			tb_gen.Text = "" + alg.Iteration;
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
			this.tb_err = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_gen = new System.Windows.Forms.TextBox();
			this.num_pop_size = new System.Windows.Forms.NumericUpDown();
			this.num_mut_amp = new System.Windows.Forms.NumericUpDown();
			this.num_mut_ratio = new System.Windows.Forms.NumericUpDown();
			this.num_sel_ratio = new System.Windows.Forms.NumericUpDown();
			this.num_max_gen = new System.Windows.Forms.NumericUpDown();
			this.num_max_err = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num_pop_size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_mut_amp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_mut_ratio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_sel_ratio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_max_gen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_max_err)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_err
			// 
			this.tb_err.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tb_err.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_err.Location = new System.Drawing.Point(184, 152);
			this.tb_err.Name = "tb_err";
			this.tb_err.ReadOnly = true;
			this.tb_err.Size = new System.Drawing.Size(88, 23);
			this.tb_err.TabIndex = 23;
			this.tb_err.Text = "0";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 128);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "Max generation number :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(88, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Generation :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(48, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Max square error :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(80, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Square error :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Selection Ratio :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Population Size :";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(64, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 23);
			this.label7.TabIndex = 26;
			this.label7.Text = "Mutation Ratio :";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(32, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 23);
			this.label8.TabIndex = 27;
			this.label8.Text = "Mutation Amplitude :";
			// 
			// tb_gen
			// 
			this.tb_gen.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tb_gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_gen.Location = new System.Drawing.Point(185, 104);
			this.tb_gen.Name = "tb_gen";
			this.tb_gen.ReadOnly = true;
			this.tb_gen.Size = new System.Drawing.Size(87, 23);
			this.tb_gen.TabIndex = 28;
			this.tb_gen.Text = "0";
			// 
			// num_pop_size
			// 
			this.num_pop_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_pop_size.Location = new System.Drawing.Point(184, 8);
			this.num_pop_size.Maximum = new System.Decimal(new int[] {
																		 250,
																		 0,
																		 0,
																		 0});
			this.num_pop_size.Minimum = new System.Decimal(new int[] {
																		 5,
																		 0,
																		 0,
																		 0});
			this.num_pop_size.Name = "num_pop_size";
			this.num_pop_size.Size = new System.Drawing.Size(88, 23);
			this.num_pop_size.TabIndex = 29;
			this.num_pop_size.Value = new System.Decimal(new int[] {
																	   50,
																	   0,
																	   0,
																	   0});
			this.num_pop_size.ValueChanged += new System.EventHandler(this.num_pop_size_ValueChanged);
			this.num_pop_size.Leave += new System.EventHandler(this.num_pop_size_ValueChanged);
			// 
			// num_mut_amp
			// 
			this.num_mut_amp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_mut_amp.DecimalPlaces = 2;
			this.num_mut_amp.Increment = new System.Decimal(new int[] {
																		  1,
																		  0,
																		  0,
																		  65536});
			this.num_mut_amp.Location = new System.Drawing.Point(184, 80);
			this.num_mut_amp.Maximum = new System.Decimal(new int[] {
																		10,
																		0,
																		0,
																		0});
			this.num_mut_amp.Name = "num_mut_amp";
			this.num_mut_amp.Size = new System.Drawing.Size(88, 23);
			this.num_mut_amp.TabIndex = 30;
			this.num_mut_amp.Value = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  0});
			this.num_mut_amp.ValueChanged += new System.EventHandler(this.num_mut_amp_ValueChanged);
			this.num_mut_amp.Leave += new System.EventHandler(this.num_mut_amp_ValueChanged);
			// 
			// num_mut_ratio
			// 
			this.num_mut_ratio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_mut_ratio.Location = new System.Drawing.Point(184, 56);
			this.num_mut_ratio.Name = "num_mut_ratio";
			this.num_mut_ratio.Size = new System.Drawing.Size(88, 23);
			this.num_mut_ratio.TabIndex = 31;
			this.num_mut_ratio.Value = new System.Decimal(new int[] {
																		4,
																		0,
																		0,
																		0});
			this.num_mut_ratio.ValueChanged += new System.EventHandler(this.num_mut_ratio_ValueChanged);
			this.num_mut_ratio.Leave += new System.EventHandler(this.num_mut_ratio_ValueChanged);
			// 
			// num_sel_ratio
			// 
			this.num_sel_ratio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_sel_ratio.Location = new System.Drawing.Point(184, 32);
			this.num_sel_ratio.Minimum = new System.Decimal(new int[] {
																		  2,
																		  0,
																		  0,
																		  0});
			this.num_sel_ratio.Name = "num_sel_ratio";
			this.num_sel_ratio.Size = new System.Drawing.Size(88, 23);
			this.num_sel_ratio.TabIndex = 32;
			this.num_sel_ratio.Value = new System.Decimal(new int[] {
																		10,
																		0,
																		0,
																		0});
			this.num_sel_ratio.ValueChanged += new System.EventHandler(this.num_sel_ratio_ValueChanged);
			this.num_sel_ratio.Leave += new System.EventHandler(this.num_sel_ratio_ValueChanged);
			// 
			// num_max_gen
			// 
			this.num_max_gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_max_gen.Increment = new System.Decimal(new int[] {
																		  50,
																		  0,
																		  0,
																		  0});
			this.num_max_gen.Location = new System.Drawing.Point(184, 128);
			this.num_max_gen.Maximum = new System.Decimal(new int[] {
																		100000,
																		0,
																		0,
																		0});
			this.num_max_gen.Minimum = new System.Decimal(new int[] {
																		10,
																		0,
																		0,
																		0});
			this.num_max_gen.Name = "num_max_gen";
			this.num_max_gen.Size = new System.Drawing.Size(88, 23);
			this.num_max_gen.TabIndex = 33;
			this.num_max_gen.Value = new System.Decimal(new int[] {
																	  500,
																	  0,
																	  0,
																	  0});
			this.num_max_gen.ValueChanged += new System.EventHandler(this.num_max_gen_ValueChanged);
			this.num_max_gen.Leave += new System.EventHandler(this.num_max_gen_ValueChanged);
			// 
			// num_max_err
			// 
			this.num_max_err.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.num_max_err.DecimalPlaces = 6;
			this.num_max_err.Increment = new System.Decimal(new int[] {
																		  1,
																		  0,
																		  0,
																		  196608});
			this.num_max_err.Location = new System.Drawing.Point(184, 176);
			this.num_max_err.Maximum = new System.Decimal(new int[] {
																		10,
																		0,
																		0,
																		0});
			this.num_max_err.Minimum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		393216});
			this.num_max_err.Name = "num_max_err";
			this.num_max_err.Size = new System.Drawing.Size(88, 23);
			this.num_max_err.TabIndex = 34;
			this.num_max_err.Value = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  131072});
			this.num_max_err.ValueChanged += new System.EventHandler(this.num_max_err_ValueChanged);
			this.num_max_err.Leave += new System.EventHandler(this.num_max_err_ValueChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(48, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(208, 23);
			this.button1.TabIndex = 35;
			this.button1.Text = "Randomize all population";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GeneticGUI
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.num_max_err,
																		  this.num_max_gen,
																		  this.num_sel_ratio,
																		  this.num_mut_ratio,
																		  this.num_mut_amp,
																		  this.num_pop_size,
																		  this.tb_gen,
																		  this.label8,
																		  this.label7,
																		  this.tb_err,
																		  this.label6,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "GeneticGUI";
			this.Size = new System.Drawing.Size(280, 240);
			((System.ComponentModel.ISupportInitialize)(this.num_pop_size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_mut_amp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_mut_ratio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_sel_ratio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_max_gen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_max_err)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void num_pop_size_ValueChanged(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.PopulationSize = (int)num_pop_size.Value;
		}

		private void num_sel_ratio_ValueChanged(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.SelectionRatio = (int)num_sel_ratio.Value;
		}

		private void num_mut_ratio_ValueChanged(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.MutationRatio = (int)num_mut_ratio.Value;
		}

		private void num_mut_amp_ValueChanged(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.MaxMutationAmplitude = (float)num_mut_amp.Value;
		}

		private void num_max_gen_ValueChanged(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.MaxIteration = (int)num_max_gen.Value;
		}

		private void num_max_err_ValueChanged(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.ErrorTreshold = (float)num_max_err.Value;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (alg != null)
				alg.RandomizePopulation();
		}
	}
}
