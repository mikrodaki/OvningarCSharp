namespace _15._5___Poängtavla
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
			btnHomeGoal = new Button();
			lblHomeScore = new Label();
			lblDash = new Label();
			lblAwayScore = new Label();
			btnAwayGoal = new Button();
			btnReset = new Button();
			SuspendLayout();
			// 
			// btnHomeGoal
			// 
			resources.ApplyResources(btnHomeGoal, "btnHomeGoal");
			btnHomeGoal.Name = "btnHomeGoal";
			btnHomeGoal.UseVisualStyleBackColor = true;
			btnHomeGoal.Click += button1_Click;
			// 
			// lblHomeScore
			// 
			resources.ApplyResources(lblHomeScore, "lblHomeScore");
			lblHomeScore.ForeColor = Color.LimeGreen;
			lblHomeScore.Name = "lblHomeScore";
			lblHomeScore.UseMnemonic = false;
			lblHomeScore.Click += lblHomePoints_Click;
			// 
			// lblDash
			// 
			resources.ApplyResources(lblDash, "lblDash");
			lblDash.Name = "lblDash";
			lblDash.UseMnemonic = false;
			// 
			// lblAwayScore
			// 
			resources.ApplyResources(lblAwayScore, "lblAwayScore");
			lblAwayScore.ForeColor = Color.Red;
			lblAwayScore.Name = "lblAwayScore";
			lblAwayScore.UseMnemonic = false;
			lblAwayScore.Click += label2_Click;
			// 
			// btnAwayGoal
			// 
			resources.ApplyResources(btnAwayGoal, "btnAwayGoal");
			btnAwayGoal.Name = "btnAwayGoal";
			btnAwayGoal.UseVisualStyleBackColor = true;
			btnAwayGoal.Click += btnAwayGoal_Click;
			// 
			// btnReset
			// 
			resources.ApplyResources(btnReset, "btnReset");
			btnReset.Name = "btnReset";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += button3_Click;
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnReset);
			Controls.Add(btnAwayGoal);
			Controls.Add(lblAwayScore);
			Controls.Add(lblDash);
			Controls.Add(lblHomeScore);
			Controls.Add(btnHomeGoal);
			Name = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnHomeGoal;
		private Label lblHomeScore;
		private Label lblDash;
		private Label lblAwayScore;
		private Button btnAwayGoal;
		private Button btnReset;
	}
}
