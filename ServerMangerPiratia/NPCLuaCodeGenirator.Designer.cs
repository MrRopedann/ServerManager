namespace ServerManagerPiratia
{
    partial class NPCLuaCodeGenirator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCLuaCodeGenirator));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zeroitCodeTextBox1 = new Zeroit.Framework.CodeTextBox.ZeroitCodeTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeroitCodeTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сгенирировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 568);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.zeroitCodeTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(277, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 568);
            this.panel2.TabIndex = 9;
            // 
            // zeroitCodeTextBox1
            // 
            this.zeroitCodeTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.zeroitCodeTextBox1.AutoScrollMinSize = new System.Drawing.Size(171, 14);
            this.zeroitCodeTextBox1.BackBrush = null;
            this.zeroitCodeTextBox1.CharHeight = 14;
            this.zeroitCodeTextBox1.CharWidth = 8;
            this.zeroitCodeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.zeroitCodeTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.zeroitCodeTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroitCodeTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroitCodeTextBox1.IsReplaceMode = false;
            this.zeroitCodeTextBox1.Language = Zeroit.Framework.CodeTextBox.Language.Lua;
            this.zeroitCodeTextBox1.Location = new System.Drawing.Point(0, 0);
            this.zeroitCodeTextBox1.Name = "zeroitCodeTextBox1";
            this.zeroitCodeTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.zeroitCodeTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.zeroitCodeTextBox1.ServiceColors = ((Zeroit.Framework.CodeTextBox.ServiceColors)(resources.GetObject("zeroitCodeTextBox1.ServiceColors")));
            this.zeroitCodeTextBox1.Size = new System.Drawing.Size(723, 568);
            this.zeroitCodeTextBox1.TabIndex = 0;
            this.zeroitCodeTextBox1.Text = "zeroitCodeTextBox1";
            this.zeroitCodeTextBox1.Zoom = 100;
            // 
            // NPCLuaCodeGenirator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1000, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NPCLuaCodeGenirator";
            this.Text = "NPCLuaCodeGenirator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zeroitCodeTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Zeroit.Framework.CodeTextBox.ZeroitCodeTextBox zeroitCodeTextBox1;
    }
}