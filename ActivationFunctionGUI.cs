using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using NeuralNetwork;

namespace NeuralNetworkGUI
{
	public class ActivationFunctionGUI : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.Container components = null;

		protected ArrayList afs;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox p_preview;
		private System.Windows.Forms.GroupBox p_params;
		private System.Windows.Forms.GroupBox p_type;
		private System.Windows.Forms.RadioButton s_Gaussian;
		private System.Windows.Forms.RadioButton s_Heaviside;
		private System.Windows.Forms.RadioButton s_Linear;
		private System.Windows.Forms.RadioButton s_Sigmoid;
		private System.Windows.Forms.Panel p_panel_lin;
		private System.Windows.Forms.TextBox param_lin_A;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel p_panel_gauss;
		private System.Windows.Forms.TextBox param_gaussian_sigma;
		private System.Windows.Forms.TextBox param_gaussian_mu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel p_panel_sigmoid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox param_sigmoid_beta;
		private FunctionPreview functionPreview1;
		protected ActivationFunction currentAF;


		public ActivationFunctionGUI()
		{
			InitializeComponent();
			currentAF = new SigmoidActivationFunction();
			

		}
		
		protected void refreshPreview() 
		{
			functionPreview1.setFunction(currentAF);
			functionPreview1.Refresh();

		}

		public ActivationFunction AFunction 
		{
			get { return currentAF; }
			set 
			{
				if (value.GetType().FullName.IndexOf("Linear")>0) 
				{
					LinearActivationFunction c = (LinearActivationFunction)value;
					currentAF = new LinearActivationFunction();
					((LinearActivationFunction)currentAF).A = c.A;
					this.param_lin_A.Text = ""+c.A;
					this.s_Linear.Select();
				}
				else if (value.GetType().FullName.IndexOf("Gaussian")>0) 
				{
					GaussianActivationFunction c = (GaussianActivationFunction)value;
					currentAF = new GaussianActivationFunction();
					((GaussianActivationFunction)currentAF).Mu = c.Mu;
					((GaussianActivationFunction)currentAF).Sigma = c.Sigma;
					this.param_gaussian_mu.Text = ""+c.Mu;
					this.param_gaussian_sigma.Text = ""+c.Sigma;
					this.s_Gaussian.Select();
				}
				else if (value.GetType().FullName.IndexOf("Heaviside")>0) 
				{
					currentAF = new HeavisideActivationFunction();
					this.s_Heaviside.Select();
				}
				else if (value.GetType().FullName.IndexOf("Sigmoid")>0) 
				{
					SigmoidActivationFunction c = (SigmoidActivationFunction)value;
					currentAF = new SigmoidActivationFunction();
					((SigmoidActivationFunction)currentAF).Beta = c.Beta;
					this.param_sigmoid_beta.Text = ""+c.Beta;
					this.s_Sigmoid.Select();
				}

			}

		}

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.p_preview = new System.Windows.Forms.GroupBox();
			this.functionPreview1 = new FunctionPreview();
			this.p_params = new System.Windows.Forms.GroupBox();
			this.p_panel_lin = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.param_lin_A = new System.Windows.Forms.TextBox();
			this.p_panel_sigmoid = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.param_sigmoid_beta = new System.Windows.Forms.TextBox();
			this.p_panel_gauss = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.param_gaussian_mu = new System.Windows.Forms.TextBox();
			this.param_gaussian_sigma = new System.Windows.Forms.TextBox();
			this.p_type = new System.Windows.Forms.GroupBox();
			this.s_Gaussian = new System.Windows.Forms.RadioButton();
			this.s_Heaviside = new System.Windows.Forms.RadioButton();
			this.s_Linear = new System.Windows.Forms.RadioButton();
			this.s_Sigmoid = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.p_preview.SuspendLayout();
			this.p_params.SuspendLayout();
			this.p_panel_lin.SuspendLayout();
			this.p_panel_sigmoid.SuspendLayout();
			this.p_panel_gauss.SuspendLayout();
			this.p_type.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.p_preview,
																				 this.p_params,
																				 this.p_type});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 216);
			this.panel1.TabIndex = 0;
			// 
			// p_preview
			// 
			this.p_preview.BackColor = System.Drawing.Color.Silver;
			this.p_preview.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.functionPreview1});
			this.p_preview.Location = new System.Drawing.Point(128, 8);
			this.p_preview.Name = "p_preview";
			this.p_preview.Size = new System.Drawing.Size(200, 120);
			this.p_preview.TabIndex = 7;
			this.p_preview.TabStop = false;
			this.p_preview.Text = "Preview : ";
			// 
			// functionPreview1
			// 
			this.functionPreview1.BackColor = System.Drawing.Color.White;
			this.functionPreview1.Location = new System.Drawing.Point(8, 16);
			this.functionPreview1.Name = "functionPreview1";
			this.functionPreview1.Size = new System.Drawing.Size(184, 96);
			this.functionPreview1.TabIndex = 1;
			// 
			// p_params
			// 
			this.p_params.BackColor = System.Drawing.Color.Silver;
			this.p_params.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.p_panel_lin,
																				   this.p_panel_sigmoid,
																				   this.p_panel_gauss});
			this.p_params.Location = new System.Drawing.Point(8, 136);
			this.p_params.Name = "p_params";
			this.p_params.Size = new System.Drawing.Size(320, 72);
			this.p_params.TabIndex = 6;
			this.p_params.TabStop = false;
			this.p_params.Text = "Parameters : ";
			// 
			// p_panel_lin
			// 
			this.p_panel_lin.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.label2,
																					  this.param_lin_A});
			this.p_panel_lin.Location = new System.Drawing.Point(96, 24);
			this.p_panel_lin.Name = "p_panel_lin";
			this.p_panel_lin.Size = new System.Drawing.Size(136, 40);
			this.p_panel_lin.TabIndex = 1;
			this.p_panel_lin.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Coef : ";
			// 
			// param_lin_A
			// 
			this.param_lin_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.param_lin_A.Location = new System.Drawing.Point(64, 8);
			this.param_lin_A.MaxLength = 8;
			this.param_lin_A.Name = "param_lin_A";
			this.param_lin_A.Size = new System.Drawing.Size(56, 23);
			this.param_lin_A.TabIndex = 0;
			this.param_lin_A.Text = "1,0";
			this.param_lin_A.TextChanged += new System.EventHandler(this.param_lin_A_TextChanged);
			// 
			// p_panel_sigmoid
			// 
			this.p_panel_sigmoid.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.label5,
																						  this.param_sigmoid_beta});
			this.p_panel_sigmoid.Location = new System.Drawing.Point(96, 24);
			this.p_panel_sigmoid.Name = "p_panel_sigmoid";
			this.p_panel_sigmoid.Size = new System.Drawing.Size(136, 40);
			this.p_panel_sigmoid.TabIndex = 2;
			this.p_panel_sigmoid.Visible = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Beta : ";
			// 
			// param_sigmoid_beta
			// 
			this.param_sigmoid_beta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.param_sigmoid_beta.Location = new System.Drawing.Point(64, 8);
			this.param_sigmoid_beta.MaxLength = 8;
			this.param_sigmoid_beta.Name = "param_sigmoid_beta";
			this.param_sigmoid_beta.Size = new System.Drawing.Size(56, 23);
			this.param_sigmoid_beta.TabIndex = 0;
			this.param_sigmoid_beta.Text = "1,0";
			this.param_sigmoid_beta.TextChanged += new System.EventHandler(this.param_sigmoid_beta_TextChanged);
			// 
			// p_panel_gauss
			// 
			this.p_panel_gauss.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.label4,
																						this.label3,
																						this.param_gaussian_mu,
																						this.param_gaussian_sigma});
			this.p_panel_gauss.Location = new System.Drawing.Point(32, 24);
			this.p_panel_gauss.Name = "p_panel_gauss";
			this.p_panel_gauss.Size = new System.Drawing.Size(264, 40);
			this.p_panel_gauss.TabIndex = 1;
			this.p_panel_gauss.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(144, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mu : ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sigma : ";
			// 
			// param_gaussian_mu
			// 
			this.param_gaussian_mu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.param_gaussian_mu.Location = new System.Drawing.Point(184, 8);
			this.param_gaussian_mu.MaxLength = 8;
			this.param_gaussian_mu.Name = "param_gaussian_mu";
			this.param_gaussian_mu.Size = new System.Drawing.Size(56, 23);
			this.param_gaussian_mu.TabIndex = 1;
			this.param_gaussian_mu.Text = "0,0";
			this.param_gaussian_mu.TextChanged += new System.EventHandler(this.param_gaussian_mu_TextChanged);
			// 
			// param_gaussian_sigma
			// 
			this.param_gaussian_sigma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.param_gaussian_sigma.Location = new System.Drawing.Point(72, 8);
			this.param_gaussian_sigma.MaxLength = 8;
			this.param_gaussian_sigma.Name = "param_gaussian_sigma";
			this.param_gaussian_sigma.Size = new System.Drawing.Size(56, 23);
			this.param_gaussian_sigma.TabIndex = 0;
			this.param_gaussian_sigma.Text = "0,159";
			this.param_gaussian_sigma.TextChanged += new System.EventHandler(this.param_gaussian_sigma_TextChanged);
			// 
			// p_type
			// 
			this.p_type.BackColor = System.Drawing.Color.Silver;
			this.p_type.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.s_Gaussian,
																				 this.s_Heaviside,
																				 this.s_Linear,
																				 this.s_Sigmoid});
			this.p_type.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.p_type.Location = new System.Drawing.Point(8, 8);
			this.p_type.Name = "p_type";
			this.p_type.Size = new System.Drawing.Size(104, 120);
			this.p_type.TabIndex = 5;
			this.p_type.TabStop = false;
			this.p_type.Text = "Type : ";
			// 
			// s_Gaussian
			// 
			this.s_Gaussian.Location = new System.Drawing.Point(8, 88);
			this.s_Gaussian.Name = "s_Gaussian";
			this.s_Gaussian.Size = new System.Drawing.Size(88, 24);
			this.s_Gaussian.TabIndex = 3;
			this.s_Gaussian.Text = "Gaussian";
			this.s_Gaussian.CheckedChanged += new System.EventHandler(this.s_Gaussian_CheckedChanged);
			// 
			// s_Heaviside
			// 
			this.s_Heaviside.Location = new System.Drawing.Point(8, 64);
			this.s_Heaviside.Name = "s_Heaviside";
			this.s_Heaviside.Size = new System.Drawing.Size(88, 24);
			this.s_Heaviside.TabIndex = 2;
			this.s_Heaviside.Text = "Heaviside";
			this.s_Heaviside.CheckedChanged += new System.EventHandler(this.s_Heaviside_CheckedChanged);
			// 
			// s_Linear
			// 
			this.s_Linear.Location = new System.Drawing.Point(8, 40);
			this.s_Linear.Name = "s_Linear";
			this.s_Linear.Size = new System.Drawing.Size(80, 24);
			this.s_Linear.TabIndex = 1;
			this.s_Linear.Text = "Linear";
			this.s_Linear.CheckedChanged += new System.EventHandler(this.s_Linear_CheckedChanged);
			// 
			// s_Sigmoid
			// 
			this.s_Sigmoid.Location = new System.Drawing.Point(8, 16);
			this.s_Sigmoid.Name = "s_Sigmoid";
			this.s_Sigmoid.Size = new System.Drawing.Size(80, 24);
			this.s_Sigmoid.TabIndex = 0;
			this.s_Sigmoid.Text = "Sigmoid";
			this.s_Sigmoid.CheckedChanged += new System.EventHandler(this.s_Sigmoid_CheckedChanged);
			// 
			// ActivationFunctionGUI
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ActivationFunctionGUI";
			this.Size = new System.Drawing.Size(336, 216);
			this.panel1.ResumeLayout(false);
			this.p_preview.ResumeLayout(false);
			this.p_params.ResumeLayout(false);
			this.p_panel_lin.ResumeLayout(false);
			this.p_panel_sigmoid.ResumeLayout(false);
			this.p_panel_gauss.ResumeLayout(false);
			this.p_type.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Checkbox Callbacks

		private void s_Sigmoid_CheckedChanged(object sender, System.EventArgs e)
		{
			if (s_Sigmoid.Checked) 
			{
				SigmoidActivationFunction c = new SigmoidActivationFunction();
				currentAF = c;
				try 
				{
					c.Beta = float.Parse(this.param_sigmoid_beta.Text.Replace(".", ","));
				}
				catch 
				{
					this.param_sigmoid_beta.Text = ""+c.Beta;
				}
				this.p_panel_sigmoid.Visible = true;
				refreshPreview();
			}
			else
				this.p_panel_sigmoid.Visible = false;

		}

		private void s_Linear_CheckedChanged(object sender, System.EventArgs e)
		{
			if (s_Linear.Checked) 
			{
				LinearActivationFunction c = new LinearActivationFunction();
				currentAF = c;
				try 
				{
					c.A = float.Parse(this.param_lin_A.Text.Replace(".", ","));
				}
				catch 
				{
					this.param_lin_A.Text = ""+c.A;
				}
				this.p_panel_lin.Visible = true;
				refreshPreview();
			}
			else
				this.p_panel_lin.Visible = false;
		
		}

		private void s_Heaviside_CheckedChanged(object sender, System.EventArgs e)
		{
			if (s_Heaviside.Checked) 
			{
				HeavisideActivationFunction c = new HeavisideActivationFunction();
				currentAF = c;
				refreshPreview();
			}
		}

		private void s_Gaussian_CheckedChanged(object sender, System.EventArgs e)
		{
			if (s_Gaussian.Checked) 
			{
				GaussianActivationFunction c = new GaussianActivationFunction();
				currentAF = c;
				try 
				{
					c.Mu = float.Parse(this.param_gaussian_mu.Text.Replace(".", ","));
				}
				catch 
				{
					this.param_gaussian_mu.Text = ""+c.Mu;
				}
				try 
				{
					c.Sigma = float.Parse(this.param_gaussian_sigma.Text.Replace(".", ","));
				}
				catch 
				{
					this.param_gaussian_sigma.Text = ""+c.Sigma;
				}
				this.p_panel_gauss.Visible = true;
				refreshPreview();
			}
			else
				this.p_panel_gauss.Visible = false;
		}
		#endregion

		private void param_lin_A_TextChanged(object sender, System.EventArgs e)
		{
			LinearActivationFunction c = (LinearActivationFunction)currentAF;
			try 
			{
				c.A = float.Parse(this.param_lin_A.Text.Replace(".", ","));
			}
			catch 
			{
				this.param_lin_A.Text = ""+c.A;
			}
			refreshPreview();
		}

		private void param_gaussian_mu_TextChanged(object sender, System.EventArgs e)
		{
			GaussianActivationFunction c = (GaussianActivationFunction)currentAF;
			try 
			{
				c.Mu = float.Parse(this.param_gaussian_mu.Text.Replace(".", ","));
			}
			catch 
			{
				this.param_gaussian_mu.Text = ""+c.Mu;
			}
			refreshPreview();
		}

		private void param_gaussian_sigma_TextChanged(object sender, System.EventArgs e)
		{
			GaussianActivationFunction c = (GaussianActivationFunction)currentAF;
			try 
			{
				c.Sigma = float.Parse(this.param_gaussian_sigma.Text.Replace(".", ","));
			}
			catch 
			{
				this.param_gaussian_sigma.Text = ""+c.Sigma;
			}
			refreshPreview();
		
		}

		private void param_sigmoid_beta_TextChanged(object sender, System.EventArgs e)
		{
			SigmoidActivationFunction c = (SigmoidActivationFunction)currentAF;
			try 
			{
				c.Beta = float.Parse(this.param_sigmoid_beta.Text.Replace(".", ","));
			}
			catch 
			{
				this.param_sigmoid_beta.Text = ""+c.Beta;
			}
			refreshPreview();
		}
	}
}
