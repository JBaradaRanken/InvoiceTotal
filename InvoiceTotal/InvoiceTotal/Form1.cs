using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
public partial class Invoice : Form
{
    public Invoice()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        decimal subtotal;
        decimal discountPercent = 0.1M;
        decimal discountAmount;
        decimal discountTotal;

        subtotal = decimal.Parse(txtSubtotal.Text);
        discountAmount = subtotal * discountPercent;
        discountTotal = subtotal - discountAmount;

        txtDiscountPercent.Text = discountPercent.ToString("p");
        txtDiscountAmount.Text = discountAmount.ToString("c");
        txtTotal.Text = discountTotal.ToString("c");

    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDiscountAmount.Text  = "";
        txtDiscountPercent.Text = "";
        txtSubtotal.Text        = "";
        txtTotal.Text           = "";

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show(

        "Do You Really Want To Exit The Program?",

        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
        if (dialog == DialogResult.Yes)

        {

            Application.Exit();

        }
    }
}

    }
