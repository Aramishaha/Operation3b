
namespace Operation3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_nombre1 = new System.Windows.Forms.TextBox();
            this.tb_nombre2 = new System.Windows.Forms.TextBox();
            this.tbresultat = new System.Windows.Forms.TextBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_multiplier = new System.Windows.Forms.Button();
            this.bt_effacer = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.lb_operateur = new System.Windows.Forms.Label();
            this.lbresultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nombre1
            // 
            this.tb_nombre1.Location = new System.Drawing.Point(268, 128);
            this.tb_nombre1.Name = "tb_nombre1";
            this.tb_nombre1.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre1.TabIndex = 0;
            this.tb_nombre1.TextChanged += new System.EventHandler(this.tb_nombre1_TextChanged);
            // 
            // tb_nombre2
            // 
            this.tb_nombre2.Location = new System.Drawing.Point(268, 175);
            this.tb_nombre2.Name = "tb_nombre2";
            this.tb_nombre2.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre2.TabIndex = 1;
            // 
            // tbresultat
            // 
            this.tbresultat.Enabled = false;
            this.tbresultat.Location = new System.Drawing.Point(268, 279);
            this.tbresultat.Name = "tbresultat";
            this.tbresultat.Size = new System.Drawing.Size(100, 20);
            this.tbresultat.TabIndex = 2;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter.Location = new System.Drawing.Point(439, 135);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(60, 60);
            this.bt_ajouter.TabIndex = 3;
            this.bt_ajouter.Text = "+";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_multiplier
            // 
            this.bt_multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_multiplier.Location = new System.Drawing.Point(439, 239);
            this.bt_multiplier.Name = "bt_multiplier";
            this.bt_multiplier.Size = new System.Drawing.Size(60, 60);
            this.bt_multiplier.TabIndex = 4;
            this.bt_multiplier.Text = "X";
            this.bt_multiplier.UseVisualStyleBackColor = true;
            this.bt_multiplier.Click += new System.EventHandler(this.bt_multiplier_Click);
            // 
            // bt_effacer
            // 
            this.bt_effacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_effacer.BackgroundImage")));
            this.bt_effacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_effacer.Location = new System.Drawing.Point(557, 135);
            this.bt_effacer.MinimumSize = new System.Drawing.Size(60, 60);
            this.bt_effacer.Name = "bt_effacer";
            this.bt_effacer.Size = new System.Drawing.Size(60, 60);
            this.bt_effacer.TabIndex = 5;
            this.bt_effacer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_effacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_effacer.UseVisualStyleBackColor = true;
            this.bt_effacer.Click += new System.EventHandler(this.bt_effacer_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_quitter.BackgroundImage")));
            this.bt_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quitter.Location = new System.Drawing.Point(557, 239);
            this.bt_quitter.MaximumSize = new System.Drawing.Size(60, 60);
            this.bt_quitter.MinimumSize = new System.Drawing.Size(60, 60);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(60, 60);
            this.bt_quitter.TabIndex = 6;
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // lb_operateur
            // 
            this.lb_operateur.AutoSize = true;
            this.lb_operateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_operateur.Location = new System.Drawing.Point(146, 160);
            this.lb_operateur.Name = "lb_operateur";
            this.lb_operateur.Size = new System.Drawing.Size(36, 37);
            this.lb_operateur.TabIndex = 7;
            this.lb_operateur.Text = "+";
            // 
            // lbresultat
            // 
            this.lbresultat.AutoSize = true;
            this.lbresultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultat.Location = new System.Drawing.Point(146, 262);
            this.lbresultat.Name = "lbresultat";
            this.lbresultat.Size = new System.Drawing.Size(36, 37);
            this.lbresultat.TabIndex = 8;
            this.lbresultat.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbresultat);
            this.Controls.Add(this.lb_operateur);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_effacer);
            this.Controls.Add(this.bt_multiplier);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.tbresultat);
            this.Controls.Add(this.tb_nombre2);
            this.Controls.Add(this.tb_nombre1);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nombre1;
        private System.Windows.Forms.TextBox tb_nombre2;
        private System.Windows.Forms.TextBox tbresultat;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_multiplier;
        private System.Windows.Forms.Button bt_effacer;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.Label lb_operateur;
        private System.Windows.Forms.Label lbresultat;
    }
}

