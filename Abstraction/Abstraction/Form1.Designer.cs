namespace Abstraction
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
            btnTestAreaVolume = new Button();
            btnTestICloneable = new Button();
            btnTestICloneableAddr = new Button();
            btnTestIComparable = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTestAreaVolume
            // 
            btnTestAreaVolume.Location = new Point(241, 154);
            btnTestAreaVolume.Name = "btnTestAreaVolume";
            btnTestAreaVolume.Size = new Size(133, 23);
            btnTestAreaVolume.TabIndex = 0;
            btnTestAreaVolume.Text = "Test Area Volume";
            btnTestAreaVolume.UseVisualStyleBackColor = true;
            btnTestAreaVolume.Click += btnTestAreaVolume_Click;
            // 
            // btnTestICloneable
            // 
            btnTestICloneable.Location = new Point(241, 209);
            btnTestICloneable.Name = "btnTestICloneable";
            btnTestICloneable.Size = new Size(133, 23);
            btnTestICloneable.TabIndex = 1;
            btnTestICloneable.Text = "Test ICloneable";
            btnTestICloneable.UseVisualStyleBackColor = true;
            btnTestICloneable.Click += btnTestICloneable_Click;
            // 
            // btnTestICloneableAddr
            // 
            btnTestICloneableAddr.Location = new Point(241, 261);
            btnTestICloneableAddr.Name = "btnTestICloneableAddr";
            btnTestICloneableAddr.Size = new Size(131, 23);
            btnTestICloneableAddr.TabIndex = 2;
            btnTestICloneableAddr.Text = "Test ICloneable Addr";
            btnTestICloneableAddr.UseVisualStyleBackColor = true;
            btnTestICloneableAddr.Click += btnTestICloneableAddr_Click;
            // 
            // btnTestIComparable
            // 
            btnTestIComparable.Location = new Point(241, 309);
            btnTestIComparable.Name = "btnTestIComparable";
            btnTestIComparable.Size = new Size(131, 23);
            btnTestIComparable.TabIndex = 3;
            btnTestIComparable.Text = "Test ICompareable";
            btnTestIComparable.UseVisualStyleBackColor = true;
            btnTestIComparable.Click += btnTestIComparable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 362);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "- Build by Ashwin Raj";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnTestIComparable);
            Controls.Add(btnTestICloneableAddr);
            Controls.Add(btnTestICloneable);
            Controls.Add(btnTestAreaVolume);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestAreaVolume;
        private Button btnTestICloneable;
        private Button btnTestICloneableAddr;
        private Button btnTestIComparable;
        private Label label1;
    }
}