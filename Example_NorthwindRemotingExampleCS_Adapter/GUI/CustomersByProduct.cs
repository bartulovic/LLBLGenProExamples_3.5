using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Northwind.DAL;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.GUI
{
	/// <summary>
	/// A general customer by product lister. It allows you to filter the customers based on a product.
	/// It uses the product to create a filter which spans multiple entities, illustrating filtering, relations and sorting.
	/// It also illustrates databinding and the usage of the collection classes.
	/// </summary>
	public class CustomersByProduct : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox productSelectComboBox;
		private System.Windows.Forms.DataGrid customersDataGrid;
		private System.Windows.Forms.Button closeButton;
		private System.ComponentModel.Container components = null;
		#endregion

		#region Class Member Declarations
		private System.Windows.Forms.TextBox _amountUnitsSoldTextBox;
		private System.Windows.Forms.Label label2;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public CustomersByProduct()
		{
			InitializeComponent();

			// load products, sort them on ProductName asc. We'll use the service for fetching the data, but we'll specify the sort expression here
			// to show the ability to distribute predicates/sorters etc. over the wire for flexibility.
			SortExpression productSorter = new SortExpression(ProductFields.ProductName | SortOperator.Ascending);
			EntityCollection<ProductEntity> products = MainForm.DalService.GetProductsSortedBySortExpression(productSorter);

			// bind it to the combo box
			productSelectComboBox.DataSource=products;
			productSelectComboBox.DisplayMember="ProductName";
			productSelectComboBox.SelectedIndex=0;
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.customersDataGrid = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.productSelectComboBox = new System.Windows.Forms.ComboBox();
			this.closeButton = new System.Windows.Forms.Button();
			this._amountUnitsSoldTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.customersDataGrid);
			this.groupBox1.Location = new System.Drawing.Point(6, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(621, 546);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customers who bought this product";
			// 
			// customersDataGrid
			// 
			this.customersDataGrid.AllowNavigation = false;
			this.customersDataGrid.CaptionText = "Customers who bought this product";
			this.customersDataGrid.DataMember = "";
			this.customersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.customersDataGrid.Location = new System.Drawing.Point(3, 16);
			this.customersDataGrid.Name = "customersDataGrid";
			this.customersDataGrid.Size = new System.Drawing.Size(615, 527);
			this.customersDataGrid.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select product to use as a filter";
			// 
			// productSelectComboBox
			// 
			this.productSelectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.productSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.productSelectComboBox.Location = new System.Drawing.Point(180, 9);
			this.productSelectComboBox.Name = "productSelectComboBox";
			this.productSelectComboBox.Size = new System.Drawing.Size(441, 21);
			this.productSelectComboBox.TabIndex = 2;
			this.productSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.productSelectComboBox_SelectedIndexChanged);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.closeButton.Location = new System.Drawing.Point(277, 615);
			this.closeButton.Name = "closeButton";
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "Close";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// _amountUnitsSoldTextBox
			// 
			this._amountUnitsSoldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._amountUnitsSoldTextBox.Location = new System.Drawing.Point(123, 588);
			this._amountUnitsSoldTextBox.Name = "_amountUnitsSoldTextBox";
			this._amountUnitsSoldTextBox.Size = new System.Drawing.Size(129, 20);
			this._amountUnitsSoldTextBox.TabIndex = 7;
			this._amountUnitsSoldTextBox.Text = "";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Location = new System.Drawing.Point(12, 591);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Number of units sold";
			// 
			// CustomersByProduct
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(631, 650);
			this.Controls.Add(this._amountUnitsSoldTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.productSelectComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "CustomersByProduct";
			this.Text = "CustomersByProduct";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void productSelectComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// get the selected product
			if(productSelectComboBox.SelectedItem==null)
			{
				return;
			}

			ProductEntity selectedProduct = (ProductEntity)productSelectComboBox.SelectedItem;
			EntityCollection<CustomerEntity> customers = MainForm.DalService.GetAllCustomersFilteredOnProduct(selectedProduct.ProductId);
			customers.AllowNew=false;

			// bind them
			customersDataGrid.DataSource=customers;
			_amountUnitsSoldTextBox.Text = MainForm.DalService.GetNumerOfTimesProductWasSold(selectedProduct.ProductId).ToString();
		}

		private void closeButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
