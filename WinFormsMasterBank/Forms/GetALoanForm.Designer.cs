namespace WinFormsMasterBank.Forms
{
    partial class GetALoanForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Get A Loan";

            // Title Label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 35);
            this.lblTitle.Text = "Get a Loan";

            // Loan Amount Label
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(20, 80);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.lblLoanAmount.Text = "Loan Amount:";

            // Loan Amount TextBox
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtLoanAmount.Location = new System.Drawing.Point(150, 80);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(200, 27);

            // Loan Term Label
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Location = new System.Drawing.Point(20, 120);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(84, 20);
            this.lblLoanTerm.Text = "Loan Term:";

            // Loan Term ComboBox
            this.cmbLoanTerm = new System.Windows.Forms.ComboBox();
            this.cmbLoanTerm.FormattingEnabled = true;
            this.cmbLoanTerm.Items.AddRange(new object[] { "6 months", "12 months", "24 months", "36 months" });
            this.cmbLoanTerm.Location = new System.Drawing.Point(150, 120);
            this.cmbLoanTerm.Name = "cmbLoanTerm";
            this.cmbLoanTerm.Size = new System.Drawing.Size(200, 28);

            // Interest Rate Label
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(20, 160);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(95, 20);
            this.lblInterestRate.Text = "Interest Rate:";

            // Interest Rate TextBox
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtInterestRate.Location = new System.Drawing.Point(150, 160);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(200, 27);

            // Submit Button
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSubmit.Location = new System.Drawing.Point(150, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Cancel Button
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancel.Location = new System.Drawing.Point(260, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Adding Controls to the Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.cmbLoanTerm);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
        }

        #endregion

        // Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.ComboBox cmbLoanTerm;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

        // Event Handlers
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle loan submission here (you can process the data)
            MessageBox.Show("Loan application submitted.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Handle cancellation of loan request
            this.Close();
        }
    }
}
