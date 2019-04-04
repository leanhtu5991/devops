namespace EvalWinApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPparticipants = new System.Windows.Forms.TabPage();
            this.tbpFormations = new System.Windows.Forms.TabPage();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.tbpSessions = new System.Windows.Forms.TabPage();
            this.dgvFormations = new System.Windows.Forms.DataGridView();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInscritsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPparticipants.SuspendLayout();
            this.tbpFormations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.tbpSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantsToolStripMenuItem,
            this.sessionsToolStripMenuItem,
            this.formationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.listeDesInscritsToolStripMenuItem});
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.participantsToolStripMenuItem.Text = "Formations";
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleSessionToolStripMenuItem});
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            // 
            // formationsToolStripMenuItem
            // 
            this.formationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleFormationToolStripMenuItem});
            this.formationsToolStripMenuItem.Name = "formationsToolStripMenuItem";
            this.formationsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.formationsToolStripMenuItem.Text = "Participants";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPparticipants);
            this.tabControl1.Controls.Add(this.tbpFormations);
            this.tabControl1.Controls.Add(this.tbpSessions);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 207);
            this.tabControl1.TabIndex = 2;
            // 
            // tbPparticipants
            // 
            this.tbPparticipants.Controls.Add(this.dgvParticipants);
            this.tbPparticipants.Location = new System.Drawing.Point(4, 22);
            this.tbPparticipants.Name = "tbPparticipants";
            this.tbPparticipants.Padding = new System.Windows.Forms.Padding(3);
            this.tbPparticipants.Size = new System.Drawing.Size(532, 181);
            this.tbPparticipants.TabIndex = 0;
            this.tbPparticipants.Text = "Liste des Participants";
            this.tbPparticipants.UseVisualStyleBackColor = true;
            // 
            // tbpFormations
            // 
            this.tbpFormations.Controls.Add(this.dgvFormations);
            this.tbpFormations.Location = new System.Drawing.Point(4, 22);
            this.tbpFormations.Name = "tbpFormations";
            this.tbpFormations.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormations.Size = new System.Drawing.Size(532, 181);
            this.tbpFormations.TabIndex = 1;
            this.tbpFormations.Text = "Liste des formations";
            this.tbpFormations.UseVisualStyleBackColor = true;
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Location = new System.Drawing.Point(6, 6);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.Size = new System.Drawing.Size(520, 172);
            this.dgvParticipants.TabIndex = 0;
            // 
            // tbpSessions
            // 
            this.tbpSessions.Controls.Add(this.dgvSessions);
            this.tbpSessions.Location = new System.Drawing.Point(4, 22);
            this.tbpSessions.Name = "tbpSessions";
            this.tbpSessions.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSessions.Size = new System.Drawing.Size(532, 181);
            this.tbpSessions.TabIndex = 2;
            this.tbpSessions.Text = "Liste des Sessions";
            this.tbpSessions.UseVisualStyleBackColor = true;
            // 
            // dgvFormations
            // 
            this.dgvFormations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormations.Location = new System.Drawing.Point(6, 6);
            this.dgvFormations.Name = "dgvFormations";
            this.dgvFormations.Size = new System.Drawing.Size(520, 169);
            this.dgvFormations.TabIndex = 0;
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(3, 6);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(523, 172);
            this.dgvSessions.TabIndex = 0;
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nouveauToolStripMenuItem.Text = "Nouvelle";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // listeDesInscritsToolStripMenuItem
            // 
            this.listeDesInscritsToolStripMenuItem.Name = "listeDesInscritsToolStripMenuItem";
            this.listeDesInscritsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.listeDesInscritsToolStripMenuItem.Text = "Liste des inscrits";
            // 
            // nouvelleSessionToolStripMenuItem
            // 
            this.nouvelleSessionToolStripMenuItem.Name = "nouvelleSessionToolStripMenuItem";
            this.nouvelleSessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nouvelleSessionToolStripMenuItem.Text = "Nouvelle";
            // 
            // nouvelleFormationToolStripMenuItem
            // 
            this.nouvelleFormationToolStripMenuItem.Name = "nouvelleFormationToolStripMenuItem";
            this.nouvelleFormationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nouvelleFormationToolStripMenuItem.Text = "Nouveau";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 291);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPparticipants.ResumeLayout(false);
            this.tbpFormations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.tbpSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesInscritsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFormationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPparticipants;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.TabPage tbpFormations;
        private System.Windows.Forms.DataGridView dgvFormations;
        private System.Windows.Forms.TabPage tbpSessions;
        private System.Windows.Forms.DataGridView dgvSessions;
    }
}

