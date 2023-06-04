
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Operação_M_Adicionar = new System.Windows.Forms.Button();
            this.btn_Operação_Dividir = new System.Windows.Forms.Button();
            this.btn_Númerico_7 = new System.Windows.Forms.Button();
            this.btn_Númerico_8 = new System.Windows.Forms.Button();
            this.btn_Númerico_9 = new System.Windows.Forms.Button();
            this.btn_Operação_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Númerico_4 = new System.Windows.Forms.Button();
            this.btn_Númerico_5 = new System.Windows.Forms.Button();
            this.btn_Númerico_6 = new System.Windows.Forms.Button();
            this.btn_Operação_M_Subtrair = new System.Windows.Forms.Button();
            this.btn_Operação_Subtrair = new System.Windows.Forms.Button();
            this.btn_Númerico_0 = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_Operação_MC = new System.Windows.Forms.Button();
            this.btn_Operação_Raiz = new System.Windows.Forms.Button();
            this.btn_Operação_MS = new System.Windows.Forms.Button();
            this.btn_Númerico_00 = new System.Windows.Forms.Button();
            this.btn_Númerico_1 = new System.Windows.Forms.Button();
            this.btn_Númerico_2 = new System.Windows.Forms.Button();
            this.btn_Virgula = new System.Windows.Forms.Button();
            this.btn_Númerico_3 = new System.Windows.Forms.Button();
            this.btn_Operação_Resultado = new System.Windows.Forms.Button();
            this.btn_Operação_Adicionar = new System.Windows.Forms.Button();
            this.pnlTítulo = new System.Windows.Forms.Panel();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.btn_Operação_MR = new System.Windows.Forms.Button();
            this.pnlSair = new System.Windows.Forms.Panel();
            this.lbl_Sair = new System.Windows.Forms.Label();
            this.rb_PainelExibição = new System.Windows.Forms.TextBox();
            this.pnlTítulo.SuspendLayout();
            this.pnlSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Operação_M_Adicionar
            // 
            this.btn_Operação_M_Adicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_M_Adicionar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_M_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_M_Adicionar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_M_Adicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_M_Adicionar.Location = new System.Drawing.Point(25, 360);
            this.btn_Operação_M_Adicionar.Name = "btn_Operação_M_Adicionar";
            this.btn_Operação_M_Adicionar.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_M_Adicionar.TabIndex = 2;
            this.btn_Operação_M_Adicionar.Text = "M+";
            this.btn_Operação_M_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Operação_M_Adicionar.Click += new System.EventHandler(this.btn_Operação_M_Adicionar_Click);
            // 
            // btn_Operação_Dividir
            // 
            this.btn_Operação_Dividir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_Dividir.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_Dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_Dividir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_Dividir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_Dividir.Location = new System.Drawing.Point(285, 145);
            this.btn_Operação_Dividir.Name = "btn_Operação_Dividir";
            this.btn_Operação_Dividir.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_Dividir.TabIndex = 3;
            this.btn_Operação_Dividir.Text = "÷";
            this.btn_Operação_Dividir.UseVisualStyleBackColor = false;
            this.btn_Operação_Dividir.Click += new System.EventHandler(this.btn_Operação_Dividir_Click);
            // 
            // btn_Númerico_7
            // 
            this.btn_Númerico_7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_7.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_7.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_7.Location = new System.Drawing.Point(90, 199);
            this.btn_Númerico_7.Name = "btn_Númerico_7";
            this.btn_Númerico_7.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_7.TabIndex = 4;
            this.btn_Númerico_7.Text = "7";
            this.btn_Númerico_7.UseVisualStyleBackColor = false;
            this.btn_Númerico_7.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Númerico_8
            // 
            this.btn_Númerico_8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_8.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_8.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_8.Location = new System.Drawing.Point(155, 199);
            this.btn_Númerico_8.Name = "btn_Númerico_8";
            this.btn_Númerico_8.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_8.TabIndex = 5;
            this.btn_Númerico_8.Text = "8";
            this.btn_Númerico_8.UseVisualStyleBackColor = false;
            this.btn_Númerico_8.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Númerico_9
            // 
            this.btn_Númerico_9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_9.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_9.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_9.Location = new System.Drawing.Point(220, 199);
            this.btn_Númerico_9.Name = "btn_Númerico_9";
            this.btn_Númerico_9.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_9.TabIndex = 6;
            this.btn_Númerico_9.Text = "9";
            this.btn_Númerico_9.UseVisualStyleBackColor = false;
            this.btn_Númerico_9.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Operação_Multiplicar
            // 
            this.btn_Operação_Multiplicar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_Multiplicar.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_Multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_Multiplicar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_Multiplicar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_Multiplicar.Location = new System.Drawing.Point(285, 199);
            this.btn_Operação_Multiplicar.Name = "btn_Operação_Multiplicar";
            this.btn_Operação_Multiplicar.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_Multiplicar.TabIndex = 7;
            this.btn_Operação_Multiplicar.Text = "X";
            this.btn_Operação_Multiplicar.UseVisualStyleBackColor = false;
            this.btn_Operação_Multiplicar.Click += new System.EventHandler(this.btn_Operação_Multiplicar_Click);
            // 
            // btn_Númerico_4
            // 
            this.btn_Númerico_4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_4.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_4.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_4.Location = new System.Drawing.Point(90, 253);
            this.btn_Númerico_4.Name = "btn_Númerico_4";
            this.btn_Númerico_4.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_4.TabIndex = 8;
            this.btn_Númerico_4.Text = "4";
            this.btn_Númerico_4.UseVisualStyleBackColor = false;
            this.btn_Númerico_4.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Númerico_5
            // 
            this.btn_Númerico_5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_5.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_5.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_5.Location = new System.Drawing.Point(155, 253);
            this.btn_Númerico_5.Name = "btn_Númerico_5";
            this.btn_Númerico_5.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_5.TabIndex = 9;
            this.btn_Númerico_5.Text = "5";
            this.btn_Númerico_5.UseVisualStyleBackColor = false;
            this.btn_Númerico_5.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Númerico_6
            // 
            this.btn_Númerico_6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_6.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_6.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_6.Location = new System.Drawing.Point(220, 253);
            this.btn_Númerico_6.Name = "btn_Númerico_6";
            this.btn_Númerico_6.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_6.TabIndex = 10;
            this.btn_Númerico_6.Text = "6";
            this.btn_Númerico_6.UseVisualStyleBackColor = false;
            this.btn_Númerico_6.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Operação_M_Subtrair
            // 
            this.btn_Operação_M_Subtrair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_M_Subtrair.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_M_Subtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_M_Subtrair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_M_Subtrair.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_M_Subtrair.Location = new System.Drawing.Point(25, 306);
            this.btn_Operação_M_Subtrair.Name = "btn_Operação_M_Subtrair";
            this.btn_Operação_M_Subtrair.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_M_Subtrair.TabIndex = 11;
            this.btn_Operação_M_Subtrair.Text = "M-";
            this.btn_Operação_M_Subtrair.UseVisualStyleBackColor = false;
            this.btn_Operação_M_Subtrair.Click += new System.EventHandler(this.btn_Operação_M_Subtrair_Click);
            // 
            // btn_Operação_Subtrair
            // 
            this.btn_Operação_Subtrair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_Subtrair.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_Subtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_Subtrair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_Subtrair.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_Subtrair.Location = new System.Drawing.Point(285, 253);
            this.btn_Operação_Subtrair.Name = "btn_Operação_Subtrair";
            this.btn_Operação_Subtrair.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_Subtrair.TabIndex = 12;
            this.btn_Operação_Subtrair.Text = "-";
            this.btn_Operação_Subtrair.UseVisualStyleBackColor = false;
            this.btn_Operação_Subtrair.Click += new System.EventHandler(this.btn_Operação_Subtrair_Click);
            // 
            // btn_Númerico_0
            // 
            this.btn_Númerico_0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_0.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_0.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_0.Location = new System.Drawing.Point(155, 360);
            this.btn_Númerico_0.Name = "btn_Númerico_0";
            this.btn_Númerico_0.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_0.TabIndex = 13;
            this.btn_Númerico_0.Text = "0";
            this.btn_Númerico_0.UseVisualStyleBackColor = false;
            this.btn_Númerico_0.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CE.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CE.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CE.Location = new System.Drawing.Point(90, 145);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(55, 48);
            this.btn_CE.TabIndex = 14;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_Operação_MC
            // 
            this.btn_Operação_MC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_MC.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_MC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_MC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_MC.Location = new System.Drawing.Point(25, 199);
            this.btn_Operação_MC.Name = "btn_Operação_MC";
            this.btn_Operação_MC.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_MC.TabIndex = 15;
            this.btn_Operação_MC.Text = "MC";
            this.btn_Operação_MC.UseVisualStyleBackColor = false;
            this.btn_Operação_MC.Click += new System.EventHandler(this.btn_Operação_MC_Click);
            // 
            // btn_Operação_Raiz
            // 
            this.btn_Operação_Raiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_Raiz.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_Raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_Raiz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_Raiz.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_Raiz.Location = new System.Drawing.Point(220, 145);
            this.btn_Operação_Raiz.Name = "btn_Operação_Raiz";
            this.btn_Operação_Raiz.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_Raiz.TabIndex = 16;
            this.btn_Operação_Raiz.Text = "√";
            this.btn_Operação_Raiz.UseVisualStyleBackColor = false;
            this.btn_Operação_Raiz.Click += new System.EventHandler(this.btn_Operação_Raiz_Click);
            // 
            // btn_Operação_MS
            // 
            this.btn_Operação_MS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_MS.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_MS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_MS.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_MS.Location = new System.Drawing.Point(25, 145);
            this.btn_Operação_MS.Name = "btn_Operação_MS";
            this.btn_Operação_MS.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_MS.TabIndex = 17;
            this.btn_Operação_MS.Text = "MS";
            this.btn_Operação_MS.UseVisualStyleBackColor = false;
            this.btn_Operação_MS.Click += new System.EventHandler(this.btn_Operação_MS_Click);
            // 
            // btn_Númerico_00
            // 
            this.btn_Númerico_00.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_00.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_00.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_00.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_00.Location = new System.Drawing.Point(90, 360);
            this.btn_Númerico_00.Name = "btn_Númerico_00";
            this.btn_Númerico_00.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_00.TabIndex = 18;
            this.btn_Númerico_00.Text = "00";
            this.btn_Númerico_00.UseVisualStyleBackColor = false;
            this.btn_Númerico_00.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Númerico_1
            // 
            this.btn_Númerico_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_1.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_1.Location = new System.Drawing.Point(90, 306);
            this.btn_Númerico_1.Name = "btn_Númerico_1";
            this.btn_Númerico_1.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_1.TabIndex = 19;
            this.btn_Númerico_1.Text = "1";
            this.btn_Númerico_1.UseVisualStyleBackColor = false;
            this.btn_Númerico_1.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Númerico_2
            // 
            this.btn_Númerico_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_2.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_2.Location = new System.Drawing.Point(155, 306);
            this.btn_Númerico_2.Name = "btn_Númerico_2";
            this.btn_Númerico_2.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_2.TabIndex = 20;
            this.btn_Númerico_2.Text = "2";
            this.btn_Númerico_2.UseVisualStyleBackColor = false;
            this.btn_Númerico_2.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Virgula
            // 
            this.btn_Virgula.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Virgula.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Virgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Virgula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Virgula.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Virgula.Location = new System.Drawing.Point(155, 145);
            this.btn_Virgula.Name = "btn_Virgula";
            this.btn_Virgula.Size = new System.Drawing.Size(55, 48);
            this.btn_Virgula.TabIndex = 21;
            this.btn_Virgula.Text = ",";
            this.btn_Virgula.UseVisualStyleBackColor = false;
            this.btn_Virgula.Click += new System.EventHandler(this.btn_Virgula_Click);
            // 
            // btn_Númerico_3
            // 
            this.btn_Númerico_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Númerico_3.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Númerico_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Númerico_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Númerico_3.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Númerico_3.Location = new System.Drawing.Point(220, 306);
            this.btn_Númerico_3.Name = "btn_Númerico_3";
            this.btn_Númerico_3.Size = new System.Drawing.Size(55, 48);
            this.btn_Númerico_3.TabIndex = 22;
            this.btn_Númerico_3.Text = "3";
            this.btn_Númerico_3.UseVisualStyleBackColor = false;
            this.btn_Númerico_3.Click += new System.EventHandler(this.btn_Númerico_Click);
            // 
            // btn_Operação_Resultado
            // 
            this.btn_Operação_Resultado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_Resultado.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_Resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_Resultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_Resultado.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_Resultado.Location = new System.Drawing.Point(220, 360);
            this.btn_Operação_Resultado.Name = "btn_Operação_Resultado";
            this.btn_Operação_Resultado.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_Resultado.TabIndex = 23;
            this.btn_Operação_Resultado.Text = "=";
            this.btn_Operação_Resultado.UseVisualStyleBackColor = false;
            this.btn_Operação_Resultado.Click += new System.EventHandler(this.btn_Operação_Resultado_Click);
            // 
            // btn_Operação_Adicionar
            // 
            this.btn_Operação_Adicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_Adicionar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Operação_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_Adicionar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_Adicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_Adicionar.Location = new System.Drawing.Point(285, 306);
            this.btn_Operação_Adicionar.Name = "btn_Operação_Adicionar";
            this.btn_Operação_Adicionar.Size = new System.Drawing.Size(55, 102);
            this.btn_Operação_Adicionar.TabIndex = 25;
            this.btn_Operação_Adicionar.Text = "+";
            this.btn_Operação_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Operação_Adicionar.Click += new System.EventHandler(this.btn_Operação_Adicionar_Click);
            // 
            // pnlTítulo
            // 
            this.pnlTítulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTítulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTítulo.BackColor = System.Drawing.Color.Black;
            this.pnlTítulo.Controls.Add(this.lbl_Título);
            this.pnlTítulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTítulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTítulo.Name = "pnlTítulo";
            this.pnlTítulo.Size = new System.Drawing.Size(301, 64);
            this.pnlTítulo.TabIndex = 27;
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoEllipsis = true;
            this.lbl_Título.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Título.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Título.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Título.Location = new System.Drawing.Point(0, 0);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbl_Título.Size = new System.Drawing.Size(301, 64);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "Calculadora";
            this.lbl_Título.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Título.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Título_MouseDoubleClick);
            // 
            // btn_Operação_MR
            // 
            this.btn_Operação_MR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Operação_MR.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Operação_MR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operação_MR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operação_MR.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Operação_MR.Location = new System.Drawing.Point(25, 252);
            this.btn_Operação_MR.Name = "btn_Operação_MR";
            this.btn_Operação_MR.Size = new System.Drawing.Size(55, 48);
            this.btn_Operação_MR.TabIndex = 29;
            this.btn_Operação_MR.Text = "MR";
            this.btn_Operação_MR.UseVisualStyleBackColor = false;
            this.btn_Operação_MR.Click += new System.EventHandler(this.btn_Operação_MR_Click);
            // 
            // pnlSair
            // 
            this.pnlSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSair.BackColor = System.Drawing.Color.Black;
            this.pnlSair.Controls.Add(this.lbl_Sair);
            this.pnlSair.Location = new System.Drawing.Point(301, 0);
            this.pnlSair.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSair.Name = "pnlSair";
            this.pnlSair.Size = new System.Drawing.Size(61, 64);
            this.pnlSair.TabIndex = 30;
            // 
            // lbl_Sair
            // 
            this.lbl_Sair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Sair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sair.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Sair.Location = new System.Drawing.Point(0, 0);
            this.lbl_Sair.Name = "lbl_Sair";
            this.lbl_Sair.Size = new System.Drawing.Size(61, 64);
            this.lbl_Sair.TabIndex = 0;
            this.lbl_Sair.Text = "Sair";
            this.lbl_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Sair.Click += new System.EventHandler(this.lbl_Sair_Click);
            // 
            // rb_PainelExibição
            // 
            this.rb_PainelExibição.BackColor = System.Drawing.Color.White;
            this.rb_PainelExibição.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.rb_PainelExibição.ForeColor = System.Drawing.Color.Black;
            this.rb_PainelExibição.Location = new System.Drawing.Point(25, 77);
            this.rb_PainelExibição.Name = "rb_PainelExibição";
            this.rb_PainelExibição.Size = new System.Drawing.Size(315, 43);
            this.rb_PainelExibição.TabIndex = 31;
            this.rb_PainelExibição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rb_PainelExibição.TextChanged += new System.EventHandler(this.rb_PainelExibição_TextChanged);
            this.rb_PainelExibição.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_PainelExibição_KeyPress);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(363, 439);
            this.Controls.Add(this.pnlSair);
            this.Controls.Add(this.btn_Operação_MR);
            this.Controls.Add(this.pnlTítulo);
            this.Controls.Add(this.btn_Operação_Adicionar);
            this.Controls.Add(this.btn_Operação_Resultado);
            this.Controls.Add(this.btn_Númerico_3);
            this.Controls.Add(this.btn_Virgula);
            this.Controls.Add(this.btn_Númerico_2);
            this.Controls.Add(this.btn_Númerico_1);
            this.Controls.Add(this.btn_Númerico_00);
            this.Controls.Add(this.btn_Operação_MS);
            this.Controls.Add(this.btn_Operação_Raiz);
            this.Controls.Add(this.btn_Operação_MC);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_Númerico_0);
            this.Controls.Add(this.btn_Operação_Subtrair);
            this.Controls.Add(this.btn_Operação_M_Subtrair);
            this.Controls.Add(this.btn_Númerico_6);
            this.Controls.Add(this.btn_Númerico_5);
            this.Controls.Add(this.btn_Númerico_4);
            this.Controls.Add(this.btn_Operação_Multiplicar);
            this.Controls.Add(this.btn_Númerico_9);
            this.Controls.Add(this.btn_Númerico_8);
            this.Controls.Add(this.btn_Númerico_7);
            this.Controls.Add(this.btn_Operação_Dividir);
            this.Controls.Add(this.btn_Operação_M_Adicionar);
            this.Controls.Add(this.rb_PainelExibição);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::CalculadoraCientifica.Properties.Resources.calc;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculadora";
            this.pnlTítulo.ResumeLayout(false);
            this.pnlSair.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Operação_M_Adicionar;
        private System.Windows.Forms.Button btn_Operação_Dividir;
        private System.Windows.Forms.Button btn_Númerico_7;
        private System.Windows.Forms.Button btn_Númerico_8;
        private System.Windows.Forms.Button btn_Númerico_9;
        private System.Windows.Forms.Button btn_Operação_Multiplicar;
        private System.Windows.Forms.Button btn_Númerico_4;
        private System.Windows.Forms.Button btn_Númerico_5;
        private System.Windows.Forms.Button btn_Númerico_6;
        private System.Windows.Forms.Button btn_Operação_M_Subtrair;
        private System.Windows.Forms.Button btn_Operação_Subtrair;
        private System.Windows.Forms.Button btn_Númerico_0;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_Operação_MC;
        private System.Windows.Forms.Button btn_Operação_Raiz;
        private System.Windows.Forms.Button btn_Operação_MS;
        private System.Windows.Forms.Button btn_Númerico_00;
        private System.Windows.Forms.Button btn_Númerico_1;
        private System.Windows.Forms.Button btn_Númerico_2;
        private System.Windows.Forms.Button btn_Virgula;
        private System.Windows.Forms.Button btn_Númerico_3;
        private System.Windows.Forms.Button btn_Operação_Resultado;
        private System.Windows.Forms.Button btn_Operação_Adicionar;
        private System.Windows.Forms.Panel pnlTítulo;
        private System.Windows.Forms.Button btn_Operação_MR;
        private System.Windows.Forms.Panel pnlSair;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_Sair;
        private TextBox rb_PainelExibição;
    }
}

