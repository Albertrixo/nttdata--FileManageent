namespace NttData.FileMaagement.presentation.WinSIte
{
    partial class frmStudent
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSuname = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.btnsve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // lblN
            // 
            resources.ApplyResources(this.lblN, "lblN");
            this.lblN.Name = "lblN";
            this.lblN.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSurname
            // 
            resources.ApplyResources(this.LblSurname, "LblSurname");
            this.LblSurname.Name = "LblSurname";
            // 
            // lblBirthday
            // 
            resources.ApplyResources(this.lblBirthday, "lblBirthday");
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtSuname
            // 
            resources.ApplyResources(this.txtSuname, "txtSuname");
            this.txtSuname.Name = "txtSuname";
            // 
            // txtBirthday
            // 
            resources.ApplyResources(this.txtBirthday, "txtBirthday");
            this.txtBirthday.Name = "txtBirthday";
            // 
            // btnsve
            // 
            resources.ApplyResources(this.btnsve, "btnsve");
            this.btnsve.Name = "btnsve";
            this.btnsve.UseVisualStyleBackColor = true;
            this.btnsve.Click += new System.EventHandler(this.btnsve_Click);
            // 
            // frmStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsve);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtSuname);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtID);
            this.Name = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSuname;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Button btnsve;
    }
}

