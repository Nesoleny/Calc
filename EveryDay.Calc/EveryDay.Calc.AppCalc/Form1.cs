using EveryDay.Calc.Calculation.Interfaces;
using EveryDay.Calc.Calculation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveryDay.Calc.AppCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOper_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            CostylButton.Tag = button.Tag;

            var operation = button.Tag as IOperation;
            if (operation == null)
                return;

            var inputs = tbInput.Text.Split(' ');
            var args = inputs.Select(str => Helper.Str2Double(str));

            operation.Input = args.ToArray();

            try
            {
                var result = operation.GetResult();

                lblResult.ForeColor = Color.Black;
                lblResult.Text = string.Format("{0}", result);

                tbInput.Text = "";
                tbInput.Focus();
                

                var baseOper = operation as Operation;
                if (baseOper != null && !string.IsNullOrWhiteSpace(baseOper.Error))
                {
                    lblResult.ForeColor = Color.DarkGoldenrod;
                    lblResult.Text = baseOper.Error;
                }

                var sb = new StringBuilder();
                sb.AppendFormat("{0} ( ", operation.Name);
                foreach (var value in operation.Input)
                {
                    sb.Append(value);
                    sb.Append(" ");
                }
                sb.Append(") = ");
                sb.Append(lblResult.Text);
                sb.Append("\n");
                txtBoxHistory.AppendText(sb.ToString());
            }
            catch(Exception ex)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var operations = Helper.LoadOperations().ToList();
           
            this.boxOperations.SuspendLayout();
            var count = 0;
            foreach (var operation in operations)
            {
                var button = new System.Windows.Forms.Button();

                var y = 0;

                button.Location = new System.Drawing.Point(14 + count * 81, 30 + y * 42);
                button.Name = string.Format("button_oper_{0}", count);
                button.Size = new System.Drawing.Size(75, 36);
                button.TabIndex = 5 + count;
                button.Text = operation.Name;
                button.UseVisualStyleBackColor = true;

                button.Tag = operation;

                button.Click += new System.EventHandler(this.buttonOper_Click);

                var baseOper = operation as Operation;
                if (baseOper != null)
                {
                    this.toolTip.SetToolTip(button, baseOper.GetDescription());
                }

                this.boxOperations.Controls.Add(button);

                count++;
            }

            this.boxOperations.ResumeLayout(false);
        }

        private void boxOperations_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxHistory_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && CostylButton.Tag != null)
            {
                buttonOper_Click(CostylButton, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
