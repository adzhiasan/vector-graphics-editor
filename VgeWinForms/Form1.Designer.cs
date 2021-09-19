
namespace VgeWinForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.selectButton = new System.Windows.Forms.ToolStripButton();
			this.rectangleButton = new System.Windows.Forms.ToolStripButton();
			this.ellipseButton = new System.Windows.Forms.ToolStripButton();
			this.mainToolStrip.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainToolStrip
			// 
			this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Size = new System.Drawing.Size(882, 27);
			this.mainToolStrip.TabIndex = 0;
			this.mainToolStrip.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(36, 24);
			this.toolStripButton1.Text = "File";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectButton,
            this.rectangleButton,
            this.ellipseButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 27);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(882, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// selectButton
			// 
			this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
			this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(53, 24);
			this.selectButton.Text = "Select";
			// 
			// rectangleButton
			// 
			this.rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
			this.rectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rectangleButton.Name = "rectangleButton";
			this.rectangleButton.Size = new System.Drawing.Size(79, 24);
			this.rectangleButton.Text = "Rectangle";
			// 
			// ellipseButton
			// 
			this.ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
			this.ellipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ellipseButton.Name = "ellipseButton";
			this.ellipseButton.Size = new System.Drawing.Size(56, 24);
			this.ellipseButton.Text = "Ellipse";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 653);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.mainToolStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Vector Graphics Editor";
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip mainToolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton selectButton;
		private System.Windows.Forms.ToolStripButton rectangleButton;
		private System.Windows.Forms.ToolStripButton ellipseButton;
	}
}

