namespace WinFormsMasterBank.Forms
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSendMoney = new System.Windows.Forms.Button();
            this.btnGetLoan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();

            // PanelTop
            this.panelTop.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 80);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Master Bank Panel";

            // PanelMenu
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.btnSendMoney);
            this.panelMenu.Controls.Add(this.btnGetLoan);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 370);
            this.panelMenu.TabIndex = 1;

            // btnSendMoney
            this.btnSendMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMoney.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendMoney.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSendMoney.Location = new System.Drawing.Point(10, 80);
            this.btnSendMoney.Name = "btnSendMoney";
            this.btnSendMoney.Size = new System.Drawing.Size(180, 40);
            this.btnSendMoney.TabIndex = 1;
            this.btnSendMoney.Text = "Send Money";
            this.btnSendMoney.UseVisualStyleBackColor = true;
            this.btnSendMoney.Click += new System.EventHandler(this.btnSendMoney_Click);

            // btnGetLoan
            this.btnGetLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLoan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetLoan.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGetLoan.Location = new System.Drawing.Point(10, 140);
            this.btnGetLoan.Name = "btnGetLoan";
            this.btnGetLoan.Size = new System.Drawing.Size(180, 40);
            this.btnGetLoan.TabIndex = 2;
            this.btnGetLoan.Text = "Get A Loan";
            this.btnGetLoan.UseVisualStyleBackColor = true;
            this.btnGetLoan.Click += new System.EventHandler(this.btnGetLoan_Click);

            // btnLogout
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(10, 200);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(250, 150);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(340, 40);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Dashboard";

            // HomeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSendMoney;
        private System.Windows.Forms.Button btnGetLoan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;

        // Event Handler for SendMoney button
        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            SendMoneyForm sendMoneyForm = new SendMoneyForm();
            sendMoneyForm.Show();
            this.Close(); // Close HomeForm after opening SendMoneyForm
        }

        // Event Handler for GetLoan button
        private void btnGetLoan_Click(object sender, EventArgs e)
        {
            GetALoanForm getALoanForm = new GetALoanForm();
            getALoanForm.Show();
            this.Close(); // Close HomeForm after opening GetALoanForm
        }

        // Event Handler for Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Create a new instance of the LoginForm
            loginForm.Show(); // Show the LoginForm
            this.Close(); // Close the current HomeForm
        }
    }
}
