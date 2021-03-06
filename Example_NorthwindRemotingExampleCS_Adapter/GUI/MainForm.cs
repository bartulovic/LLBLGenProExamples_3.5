using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL;

using SD.LLBLGen.Pro.ORMSupportClasses;
using Interfaces;

namespace Northwind.GUI
{
	/// <summary>
	/// Startup window for the northwind C# LLBLGen Pro example
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		#region Components
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button openCustomerManagerButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button openCustomersByProductButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox _mostOrdersCustomerTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button _editMostOrdersCustomerButton;
		private System.Windows.Forms.TextBox _mostOrdersPerCustomerTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _highestOrderCustomerTextBox;
		private System.Windows.Forms.TextBox _averageOrderPriceTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _highestOrderPriceTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _amountCustomersTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button _editHighestOrderCustomerButton;
		private System.ComponentModel.Container components = null;
		#endregion

		#region Statics
		/// <summary>
		/// Static field for the service object so calls don't have to obtain the service object over and over again.
		/// </summary>
		public static IService DalService;
		#endregion

		#region Class Member Declarations
		private CustomerEntity _customerWithMostOrders, _customerWithHighestOrder;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			
			this.MinimumSize = this.Size;

			_customerWithMostOrders = null;
			_customerWithHighestOrder = null;

			// calculate statistics for northwind and show these in the form.
			CalculateStatistics();
		}


		/// <summary>
		/// Calculates the statistics for the Northwind database and shows them in the form, utilizing the remote service for the actual work.
		/// </summary>
		/// <remarks>No error checking is applied to this routine, it's for illustrating the framework functionality.</remarks>
		private void CalculateStatistics()
		{
			// use the service to obtain the information needed. 

			// get the # of customers in the database.
			_amountCustomersTextBox.Text = MainForm.DalService.GetNumberOfCustomers().ToString();

			// get highest order price, order id of order with highest price, average price.
			decimal averageOrderPrice = 0.0M;
			decimal highestOrderPrice = 0.0M;
			int orderIdWithHighestPrice = 0;
			int numberOfOrders = 0;
			MainForm.DalService.GetOrderStatistics(out averageOrderPrice, out highestOrderPrice, out numberOfOrders, out orderIdWithHighestPrice);
			_highestOrderPriceTextBox.Text = highestOrderPrice.ToString("C");
			_averageOrderPriceTextBox.Text = averageOrderPrice.ToString("C");

			// get order with highest price. Pull customer also in 1 go
			OrderEntity highestOrder = MainForm.DalService.GetOrderAndCustomerWithHighestPrice(orderIdWithHighestPrice);
			_customerWithHighestOrder = highestOrder.Customer;	// already loaded through prefetch path.
			_highestOrderCustomerTextBox.Text = _customerWithHighestOrder.CompanyName;

			// get customer with most orders. 
			int numberOfOrdersForTopCustomer = 0;
			_customerWithMostOrders = MainForm.DalService.GetCustomerWithMostOrdersAndNumberOfOrders(out numberOfOrdersForTopCustomer);
			_mostOrdersPerCustomerTextBox.Text = numberOfOrdersForTopCustomer.ToString();
			_mostOrdersCustomerTextBox.Text = _customerWithMostOrders.CompanyName;
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.openCustomerManagerButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.openCustomersByProductButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._mostOrdersCustomerTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this._editMostOrdersCustomerButton = new System.Windows.Forms.Button();
			this._mostOrdersPerCustomerTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this._highestOrderCustomerTextBox = new System.Windows.Forms.TextBox();
			this._averageOrderPriceTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._highestOrderPriceTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._amountCustomersTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._editHighestOrderCustomerButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select your option below";
			// 
			// openCustomerManagerButton
			// 
			this.openCustomerManagerButton.Location = new System.Drawing.Point(9, 39);
			this.openCustomerManagerButton.Name = "openCustomerManagerButton";
			this.openCustomerManagerButton.Size = new System.Drawing.Size(192, 23);
			this.openCustomerManagerButton.TabIndex = 1;
			this.openCustomerManagerButton.Text = "Open the Customer Manager";
			this.openCustomerManagerButton.Click += new System.EventHandler(this.openCustomerManagerButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(513, 249);
			this.exitButton.Name = "exitButton";
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// openCustomersByProductButton
			// 
			this.openCustomersByProductButton.Location = new System.Drawing.Point(9, 66);
			this.openCustomersByProductButton.Name = "openCustomersByProductButton";
			this.openCustomersByProductButton.Size = new System.Drawing.Size(192, 23);
			this.openCustomersByProductButton.TabIndex = 3;
			this.openCustomersByProductButton.Text = "Open Customers-by-product lister";
			this.openCustomersByProductButton.Click += new System.EventHandler(this.openCustomersByProductButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this._mostOrdersCustomerTextBox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this._editMostOrdersCustomerButton);
			this.groupBox1.Controls.Add(this._mostOrdersPerCustomerTextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this._highestOrderCustomerTextBox);
			this.groupBox1.Controls.Add(this._averageOrderPriceTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this._highestOrderPriceTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this._amountCustomersTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this._editHighestOrderCustomerButton);
			this.groupBox1.Location = new System.Drawing.Point(9, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(579, 135);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Northwind Statistics";
			// 
			// _mostOrdersCustomerTextBox
			// 
			this._mostOrdersCustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._mostOrdersCustomerTextBox.Location = new System.Drawing.Point(366, 99);
			this._mostOrdersCustomerTextBox.Name = "_mostOrdersCustomerTextBox";
			this._mostOrdersCustomerTextBox.ReadOnly = true;
			this._mostOrdersCustomerTextBox.Size = new System.Drawing.Size(159, 20);
			this._mostOrdersCustomerTextBox.TabIndex = 12;
			this._mostOrdersCustomerTextBox.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(252, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 18);
			this.label7.TabIndex = 11;
			this.label7.Text = "Ordered by customer ";
			// 
			// _editMostOrdersCustomerButton
			// 
			this._editMostOrdersCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._editMostOrdersCustomerButton.Location = new System.Drawing.Point(531, 99);
			this._editMostOrdersCustomerButton.Name = "_editMostOrdersCustomerButton";
			this._editMostOrdersCustomerButton.Size = new System.Drawing.Size(36, 21);
			this._editMostOrdersCustomerButton.TabIndex = 10;
			this._editMostOrdersCustomerButton.Text = "Edit";
			this._editMostOrdersCustomerButton.Click += new System.EventHandler(this._editMostOrdersCustomerButton_Click);
			// 
			// _mostOrdersPerCustomerTextBox
			// 
			this._mostOrdersPerCustomerTextBox.Location = new System.Drawing.Point(150, 99);
			this._mostOrdersPerCustomerTextBox.Name = "_mostOrdersPerCustomerTextBox";
			this._mostOrdersPerCustomerTextBox.ReadOnly = true;
			this._mostOrdersPerCustomerTextBox.Size = new System.Drawing.Size(87, 20);
			this._mostOrdersPerCustomerTextBox.TabIndex = 9;
			this._mostOrdersPerCustomerTextBox.Text = "";
			this._mostOrdersPerCustomerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 18);
			this.label6.TabIndex = 7;
			this.label6.Text = "Most orders per customer";
			// 
			// _highestOrderCustomerTextBox
			// 
			this._highestOrderCustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._highestOrderCustomerTextBox.Location = new System.Drawing.Point(366, 75);
			this._highestOrderCustomerTextBox.Name = "_highestOrderCustomerTextBox";
			this._highestOrderCustomerTextBox.ReadOnly = true;
			this._highestOrderCustomerTextBox.Size = new System.Drawing.Size(159, 20);
			this._highestOrderCustomerTextBox.TabIndex = 6;
			this._highestOrderCustomerTextBox.Text = "";
			// 
			// _averageOrderPriceTextBox
			// 
			this._averageOrderPriceTextBox.Location = new System.Drawing.Point(150, 51);
			this._averageOrderPriceTextBox.Name = "_averageOrderPriceTextBox";
			this._averageOrderPriceTextBox.ReadOnly = true;
			this._averageOrderPriceTextBox.Size = new System.Drawing.Size(87, 20);
			this._averageOrderPriceTextBox.TabIndex = 5;
			this._averageOrderPriceTextBox.Text = "";
			this._averageOrderPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Average order price";
			// 
			// _highestOrderPriceTextBox
			// 
			this._highestOrderPriceTextBox.Location = new System.Drawing.Point(150, 75);
			this._highestOrderPriceTextBox.Name = "_highestOrderPriceTextBox";
			this._highestOrderPriceTextBox.ReadOnly = true;
			this._highestOrderPriceTextBox.Size = new System.Drawing.Size(87, 20);
			this._highestOrderPriceTextBox.TabIndex = 3;
			this._highestOrderPriceTextBox.Text = "";
			this._highestOrderPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Highest order price";
			// 
			// _amountCustomersTextBox
			// 
			this._amountCustomersTextBox.Location = new System.Drawing.Point(150, 27);
			this._amountCustomersTextBox.Name = "_amountCustomersTextBox";
			this._amountCustomersTextBox.ReadOnly = true;
			this._amountCustomersTextBox.Size = new System.Drawing.Size(87, 20);
			this._amountCustomersTextBox.TabIndex = 1;
			this._amountCustomersTextBox.Text = "";
			this._amountCustomersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Number of customers";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(252, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ordered by customer ";
			// 
			// _editHighestOrderCustomerButton
			// 
			this._editHighestOrderCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._editHighestOrderCustomerButton.Location = new System.Drawing.Point(531, 75);
			this._editHighestOrderCustomerButton.Name = "_editHighestOrderCustomerButton";
			this._editHighestOrderCustomerButton.Size = new System.Drawing.Size(36, 21);
			this._editHighestOrderCustomerButton.TabIndex = 1;
			this._editHighestOrderCustomerButton.Text = "Edit";
			this._editHighestOrderCustomerButton.Click += new System.EventHandler(this._editHighestOrderCustomerButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(595, 278);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.openCustomersByProductButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.openCustomerManagerButton);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Northwind C# Example Main window";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void openCustomerManagerButton_Click(object sender, System.EventArgs e)
		{
			CustomerManager manager = new CustomerManager();
			manager.ShowDialog(this);
		}

		private void exitButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void openCustomersByProductButton_Click(object sender, System.EventArgs e)
		{
			CustomersByProduct lister = new CustomersByProduct();
			lister.ShowDialog(this);
		}

		private void _editHighestOrderCustomerButton_Click(object sender, System.EventArgs e)
		{
			CustomerManager manager = new CustomerManager(_customerWithHighestOrder);
			manager.ShowDialog(this);
		}

		private void _editMostOrdersCustomerButton_Click(object sender, System.EventArgs e)
		{
			CustomerManager manager = new CustomerManager(_customerWithMostOrders);
			manager.ShowDialog(this);
		}
	}
}
