namespace BinarySearchTree;

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
        btnEkleme = new Button();
        btnArama = new Button();
        btnMinBul = new Button();
        btnMaxBul = new Button();
        btnPreOrder = new Button();
        btnInOrder = new Button();
        btnPostOrder = new Button();
        textBoxEkleme = new TextBox();
        textBoxArama = new TextBox();
        textBoxMinBul = new TextBox();
        textBoxMaxBul = new TextBox();
        textBoxDolasmaSonucu = new TextBox();
        SuspendLayout();
        // 
        // btnEkleme
        // 
        btnEkleme.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnEkleme.Location = new Point(657, 65);
        btnEkleme.Name = "btnEkleme";
        btnEkleme.Size = new Size(94, 29);
        btnEkleme.TabIndex = 0;
        btnEkleme.Text = "Ekleme";
        btnEkleme.UseVisualStyleBackColor = true;
        btnEkleme.Click += btnEkleme_Click;
        // 
        // btnArama
        // 
        btnArama.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnArama.Location = new Point(657, 116);
        btnArama.Name = "btnArama";
        btnArama.Size = new Size(94, 29);
        btnArama.TabIndex = 1;
        btnArama.Text = "Arama";
        btnArama.UseVisualStyleBackColor = true;
        btnArama.Click += btnArama_Click;
        // 
        // btnMinBul
        // 
        btnMinBul.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnMinBul.Location = new Point(657, 164);
        btnMinBul.Name = "btnMinBul";
        btnMinBul.Size = new Size(94, 29);
        btnMinBul.TabIndex = 2;
        btnMinBul.Text = "Min Bul";
        btnMinBul.UseMnemonic = false;
        btnMinBul.UseVisualStyleBackColor = true;
        btnMinBul.Click += btnMinBul_Click;
        // 
        // btnMaxBul
        // 
        btnMaxBul.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnMaxBul.Location = new Point(657, 212);
        btnMaxBul.Name = "btnMaxBul";
        btnMaxBul.Size = new Size(94, 29);
        btnMaxBul.TabIndex = 3;
        btnMaxBul.Text = "Max Bul";
        btnMaxBul.UseVisualStyleBackColor = true;
        btnMaxBul.Click += btnMaxBul_Click;
        // 
        // btnPreOrder
        // 
        btnPreOrder.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnPreOrder.Location = new Point(30, 351);
        btnPreOrder.Name = "btnPreOrder";
        btnPreOrder.Size = new Size(94, 29);
        btnPreOrder.TabIndex = 4;
        btnPreOrder.Text = "PreOrder";
        btnPreOrder.UseVisualStyleBackColor = true;
        btnPreOrder.Click += btnPreOrder_Click;
        // 
        // btnInOrder
        // 
        btnInOrder.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnInOrder.Location = new Point(160, 351);
        btnInOrder.Name = "btnInOrder";
        btnInOrder.Size = new Size(94, 29);
        btnInOrder.TabIndex = 5;
        btnInOrder.Text = "InOrder";
        btnInOrder.UseVisualStyleBackColor = true;
        btnInOrder.Click += btnInOrder_Click;
        // 
        // btnPostOrder
        // 
        btnPostOrder.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnPostOrder.Location = new Point(290, 351);
        btnPostOrder.Name = "btnPostOrder";
        btnPostOrder.Size = new Size(106, 29);
        btnPostOrder.TabIndex = 6;
        btnPostOrder.Text = "PostOrder";
        btnPostOrder.UseVisualStyleBackColor = true;
        btnPostOrder.Click += btnPostOrder_Click;
        // 
        // textBoxEkleme
        // 
        textBoxEkleme.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxEkleme.Location = new Point(766, 66);
        textBoxEkleme.Name = "textBoxEkleme";
        textBoxEkleme.Size = new Size(125, 26);
        textBoxEkleme.TabIndex = 7;
        // 
        // textBoxArama
        // 
        textBoxArama.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxArama.Location = new Point(766, 116);
        textBoxArama.Name = "textBoxArama";
        textBoxArama.Size = new Size(125, 26);
        textBoxArama.TabIndex = 8;
        // 
        // textBoxMinBul
        // 
        textBoxMinBul.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxMinBul.Location = new Point(766, 166);
        textBoxMinBul.Name = "textBoxMinBul";
        textBoxMinBul.Size = new Size(125, 26);
        textBoxMinBul.TabIndex = 9;
        // 
        // textBoxMaxBul
        // 
        textBoxMaxBul.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxMaxBul.Location = new Point(766, 214);
        textBoxMaxBul.Name = "textBoxMaxBul";
        textBoxMaxBul.Size = new Size(125, 26);
        textBoxMaxBul.TabIndex = 10;
        // 
        // textBoxDolasmaSonucu
        // 
        textBoxDolasmaSonucu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
        textBoxDolasmaSonucu.Location = new Point(30, 404);
        textBoxDolasmaSonucu.Name = "textBoxDolasmaSonucu";
        textBoxDolasmaSonucu.Size = new Size(456, 26);
        textBoxDolasmaSonucu.TabIndex = 11;
        textBoxDolasmaSonucu.Text = "Aralarında boşluk ile dolaşma sonucunu yazdırın";
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Inherit;
        BackColor = Color.DodgerBlue;
        ClientSize = new Size(936, 464);
        Controls.Add(textBoxDolasmaSonucu);
        Controls.Add(textBoxMaxBul);
        Controls.Add(textBoxMinBul);
        Controls.Add(textBoxArama);
        Controls.Add(textBoxEkleme);
        Controls.Add(btnPostOrder);
        Controls.Add(btnInOrder);
        Controls.Add(btnPreOrder);
        Controls.Add(btnMaxBul);
        Controls.Add(btnMinBul);
        Controls.Add(btnArama);
        Controls.Add(btnEkleme);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnEkleme;
    private Button btnArama;
    private Button btnMinBul;
    private Button btnMaxBul;
    private Button btnPreOrder;
    private Button btnInOrder;
    private Button btnPostOrder;
    private TextBox textBoxEkleme;
    private TextBox textBoxArama;
    private TextBox textBoxMinBul;
    private TextBox textBoxMaxBul;
    private TextBox textBoxDolasmaSonucu;
}
