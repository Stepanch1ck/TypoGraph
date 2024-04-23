namespace TypoGraph
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            inputrichTextBox = new RichTextBox();
            outbutrichTextBox = new RichTextBox();
            inputlabel = new Label();
            outputlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(inputlabel);
            splitContainer1.Panel1.Controls.Add(inputrichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(outputlabel);
            splitContainer1.Panel2.Controls.Add(outbutrichTextBox);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 398;
            splitContainer1.TabIndex = 0;
            // 
            // inputrichTextBox
            // 
            inputrichTextBox.Location = new Point(3, 32);
            inputrichTextBox.Name = "inputrichTextBox";
            inputrichTextBox.Size = new Size(381, 415);
            inputrichTextBox.TabIndex = 1;
            inputrichTextBox.Text = "";
            inputrichTextBox.TextChanged += inputrichTextBox_TextChanged;
            // 
            // outbutrichTextBox
            // 
            outbutrichTextBox.Location = new Point(16, 32);
            outbutrichTextBox.Name = "outbutrichTextBox";
            outbutrichTextBox.Size = new Size(379, 415);
            outbutrichTextBox.TabIndex = 1;
            outbutrichTextBox.Text = "";
            // 
            // inputlabel
            // 
            inputlabel.AutoSize = true;
            inputlabel.Location = new Point(133, 9);
            inputlabel.Name = "inputlabel";
            inputlabel.Size = new Size(98, 15);
            inputlabel.TabIndex = 2;
            inputlabel.Text = "Входящий текст:";
            // 
            // outputlabel
            // 
            outputlabel.AutoSize = true;
            outputlabel.Location = new Point(157, 9);
            outputlabel.Name = "outputlabel";
            outputlabel.Size = new Size(113, 15);
            outputlabel.TabIndex = 3;
            outputlabel.Text = "Изменённый текст:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox inputrichTextBox;
        private RichTextBox outbutrichTextBox;
        private Label inputlabel;
        private Label outputlabel;
    }
}
