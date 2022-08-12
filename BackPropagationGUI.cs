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
	/// Summary description for BackPropagationGUI.
	/// </summary>
	public class BackPropagationGUI : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox tb_alpha;
		private System.Windows.Forms.TextBox tb_beta;
		private System.Windows.Forms.TextBox tb_iter;
		private System.Windows.Forms.TextBox tb_maxiter;
		private System.Windows.Forms.TextBox tb_err;
		private System.Windows.Forms.TextBox tb_max_err;

		protected BackPropagationLearningAlgorithm alg;

		public BackPropagationGUI()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
			
		}

		public void setBackPropagationAlgorithm(BackPropagationLearningAlgorithm a) 
		{
			alg = a;
			tb_alpha.Text = ""+a.Alpha;;
			tb_beta.Text = ""+a.Gamma;
			tb_iter.Text = ""+a.Iteration;
			tb_maxiter.Text = "" + a.MaxIteration;;
			tb_err.Text = ""+a.Error;
			tb_max_err.Text = ""+a.ErrorTreshold;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_alpha = new System.Windows.Forms.TextBox();
			this.tb_beta = new System.Windows.Forms.TextBox();
			this.tb_iter = new System.Windows.Forms.TextBox();
			this.tb_maxiter = new System.Windows.Forms.TextBox();
			this.tb_err = new System.Windows.Forms.TextBox();
			this.tb_max_err = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(114, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alpha :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gamma :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(66, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Square error :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(36, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Max square error :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(40, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Iteration number :";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(10, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Max iteration number :";
			// 
			// tb_alpha
			// 
			this.tb_alpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_alpha.Location = new System.Drawing.Point(176, 6);
			this.tb_alpha.Name = "tb_alpha";
			this.tb_alpha.Size = new System.Drawing.Size(62, 24);
			this.tb_alpha.TabIndex = 6;
			this.tb_alpha.Text = "0";
			this.tb_alpha.TextChanged += new System.EventHandler(this.tb_alpha_TextChanged);
			// 
			// tb_beta
			// 
			this.tb_beta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_beta.Location = new System.Drawing.Point(176, 32);
			this.tb_beta.Name = "tb_beta";
			this.tb_beta.Size = new System.Drawing.Size(62, 24);
			this.tb_beta.TabIndex = 7;
			this.tb_beta.Text = "0";
			this.tb_beta.TextChanged += new System.EventHandler(this.tb_beta_TextChanged);
			// 
			// tb_iter
			// 
			this.tb_iter.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tb_iter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_iter.Location = new System.Drawing.Point(176, 58);
			this.tb_iter.Name = "tb_iter";
			this.tb_iter.ReadOnly = true;
			this.tb_iter.Size = new System.Drawing.Size(62, 24);
			this.tb_iter.TabIndex = 8;
			this.tb_iter.Text = "0";
			// 
			// tb_maxiter
			// 
			this.tb_maxiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_maxiter.Location = new System.Drawing.Point(176, 84);
			this.tb_maxiter.Name = "tb_maxiter";
			this.tb_maxiter.Size = new System.Drawing.Size(62, 24);
			this.tb_maxiter.TabIndex = 9;
			this.tb_maxiter.Text = "0";
			this.tb_maxiter.TextChanged += new System.EventHandler(this.tb_maxiter_TextChanged);
			// 
			// tb_err
			// 
			this.tb_err.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tb_err.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_err.Location = new System.Drawing.Point(176, 110);
			this.tb_err.Name = "tb_err";
			this.tb_err.ReadOnly = true;
			this.tb_err.Size = new System.Drawing.Size(62, 24);
			this.tb_err.TabIndex = 10;
			this.tb_err.Text = "0";
			// 
			// tb_max_err
			// 
			this.tb_max_err.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_max_err.Location = new System.Drawing.Point(176, 136);
			this.tb_max_err.Name = "tb_max_err";
			this.tb_max_err.Size = new System.Drawing.Size(62, 24);
			this.tb_max_err.TabIndex = 11;
			this.tb_max_err.Text = "0";
			this.tb_max_err.TextChanged += new System.EventHandler(this.tb_max_err_TextChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(64, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Reset to default";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BackPropagationGUI
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.tb_max_err,
																		  this.tb_err,
																		  this.tb_maxiter,
																		  this.tb_iter,
																		  this.tb_beta,
																		  this.tb_alpha,
																		  this.label6,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "BackPropagationGUI";
			this.Size = new System.Drawing.Size(256, 208);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.BackPropagationGUI_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (alg != null) 
			{
				alg.Alpha = 0.8f;
				alg.Gamma = 0.15f;
				alg.MaxIteration = 1000;
				alg.ErrorTreshold = 0.01f;
				tb_alpha.Text = ""+alg.Alpha;
				tb_beta.Text = ""+alg.Gamma;
				tb_iter.Text = ""+alg.Iteration;
				tb_maxiter.Text = "" + alg.MaxIteration;
				tb_err.Text = ""+alg.Error;
				tb_max_err.Text = ""+alg.ErrorTreshold;
			}
		}

		private void tb_alpha_TextChanged(object sender, System.EventArgs e)
		{
			if (alg != null) 
			{
				try 
				{
					alg.Alpha = float.Parse(this.tb_alpha.Text.Replace(".",","));
				}
				catch 
				{
					tb_alpha.Text = ""+alg.Alpha;
				}
			}
		}

		private void tb_beta_TextChanged(object sender, System.EventArgs e)
		{
			if (alg != null) 
			{
				try 
				{
					alg.Gamma = float.Parse(this.tb_beta.Text.Replace(".",","));
				}
				catch 
				{
					tb_beta.Text = ""+alg.Gamma;
				}
			}
		}

		private void tb_maxiter_TextChanged(object sender, System.EventArgs e)
		{
			if (alg != null) 
			{
				try 
				{
					alg.MaxIteration = int.Parse(this.tb_maxiter.Text);
				}
				catch 
				{
					tb_maxiter.Text = ""+alg.MaxIteration;
				}
		
			}
		}

		private void tb_max_err_TextChanged(object sender, System.EventArgs e)
		{
			if (alg != null) 
			{
				try 
				{
					alg.ErrorTreshold = float.Parse(this.tb_max_err.Text.Replace(".",","));
				}
				catch 
				{
					tb_max_err.Text = ""+alg.ErrorTreshold;
				}
		
			}
		
		}

		private void BackPropagationGUI_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (alg != null) 
			{
				tb_iter.Text = ""+alg.Iteration;
				tb_err.Text = ""+alg.Error;
			}
		
		}
	}
}