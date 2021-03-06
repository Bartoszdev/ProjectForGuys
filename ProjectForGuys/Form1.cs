﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForGuys
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
        }
        public Form1()
        {
            InitializeComponent();


            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy() { Cash = 100, Name = "Bob" };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bank += joe.GiveCash(15);
            UpdateForm();
        }

        private void bobGivesCashBank_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(20);
            UpdateForm();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            
            if (bob.Cash >= 10 && joe.Cash >= 10)
            {
                bank += bob.GiveCash(10);
                bank += joe.GiveCash(10);
                UpdateForm();

            }
         /*   else if(joe.Cash >= 10)
             {
                bank += joe.GiveCash(10);
                UpdateForm();
            }
            */
            else
            {
                MessageBox.Show("Joe bądź Bob nie mają wystarczającej ilości pieniędzy, by oddać do banku !");
            }
            
        }
    }
}
