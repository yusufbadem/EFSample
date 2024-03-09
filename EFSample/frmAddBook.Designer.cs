namespace EFSample;

partial class frmAddBook
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
        lblName = new Label();
        txtName = new TextBox();
        txtWriter = new TextBox();
        label2 = new Label();
        btnAdd = new Button();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(78, 83);
        lblName.Name = "lblName";
        lblName.Size = new Size(56, 20);
        lblName.TabIndex = 0;
        lblName.Text = "Name :";
        // 
        // txtName
        // 
        txtName.Location = new Point(156, 82);
        txtName.Name = "txtName";
        txtName.Size = new Size(125, 27);
        txtName.TabIndex = 1;
        // 
        // txtWriter
        // 
        txtWriter.Location = new Point(156, 130);
        txtWriter.Name = "txtWriter";
        txtWriter.Size = new Size(125, 27);
        txtWriter.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(78, 131);
        label2.Name = "label2";
        label2.Size = new Size(57, 20);
        label2.TabIndex = 2;
        label2.Text = "Writer :";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(182, 181);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // frmAddBook
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnAdd);
        Controls.Add(txtWriter);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(lblName);
        Name = "frmAddBook";
        Text = "frmAddBook";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblName;
    private TextBox txtName;
    private TextBox txtWriter;
    private Label label2;
    private Button btnAdd;
}