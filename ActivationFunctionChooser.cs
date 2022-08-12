using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NeuralNetwork;

namespace NeuralNetworkGUI
{
	/// <summary>
	/// Summary description for ActivationFunctionChooser.
	/// </summary>
	public class ActivationFunctionChooser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Button button_cancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private NeuralNetworkGUI.ActivationFunctionGUI activationFunctionGUI1;

		protected bool chooseOK = false;
		public bool ChooseOK 
		{
			get { return chooseOK; }
		}

		public ActivationFunction Choosen 
		{
			get { return activationFunctionGUI1.AFunction; }
		}

		public ActivationFunctionChooser()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			activationFunctionGUI1.AFunction = new SigmoidActivationFunction();
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
			this.button_ok = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.activationFunctionGUI1 = new NeuralNetworkGUI.ActivationFunctionGUI();
			this.SuspendLayout();
			// 
			// button_ok
			// 
			this.button_ok.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_ok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button_ok.Location = new System.Drawing.Point(232, 248);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(96, 24);
			this.button_ok.TabIndex = 1;
			this.button_ok.Text = "OK";
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// button_cancel
			// 
			this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_cancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button_cancel.Location = new System.Drawing.Point(120, 248);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(96, 24);
			this.button_cancel.TabIndex = 2;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// activationFunctionGUI1
			// 
			this.activationFunctionGUI1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.activationFunctionGUI1.Location = new System.Drawing.Point(16, 16);
			this.activationFunctionGUI1.Name = "activationFunctionGUI1";
			this.activationFunctionGUI1.Size = new System.Drawing.Size(336, 216);
			this.activationFunctionGUI1.TabIndex = 3;
			// 
			// ActivationFunctionChooser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(368, 312);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.activationFunctionGUI1,
																		  this.button_cancel,
																		  this.button_ok});
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(376, 320);
			this.MinimumSize = new System.Drawing.Size(376, 320);
			this.Name = "ActivationFunctionChooser";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Choose an activation function ...";
			this.ResumeLayout(false);

		}
		#endregion

		private void button_cancel_Click(object sender, System.EventArgs e)
		{
			chooseOK = false;
			this.Close();
		}

		private void button_ok_Click(object sender, System.EventArgs e)
		{
			if (activationFunctionGUI1.AFunction != null) 
			{
				chooseOK = true;
				this.Close();
			}
		}
	}
}
