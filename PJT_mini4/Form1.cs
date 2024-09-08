﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJT_mini4
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "일반수학1";
            txt3.Text = "디지털 공학 및 실험";
            txt4.Text = "자료구조";
            txt5.Text = "비주얼 프로그래밍";
            txt6.Text = "기업가 정신";

            crds = new ComboBox[] { crds1, crds2, crds3, crds4, crds5, crds6, crds7 };
            grds = new ComboBox[] { grds1, grds2, grds3, grds4, grds5, grds6, grds7 };
            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<String> lstGrade = new List<String> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach (var combo in crds)
            {
                foreach (var i in arrCredit)
                    combo.Items.Add(i);
                combo.SelectedItem = 3;
            }

            foreach (var cb in grds)
            {
                foreach (var gr in lstGrade)
                    cb.Items.Add(gr);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
                }
            }
            txtGrade.Text = (totalScore / totalCredits).ToString("0.00");
        }

        private double GetGrade(string text)
        {
            double grade = 0;

            if (text == "A+") grade = 4.5;
            else if (text == "A0") grade = 4.0;
            else if (text == "B+") grade = 3.5;
            else if (text == "B0") grade = 3.0;
            else if (text == "C+") grade = 2.5;
            else if (text == "C0") grade = 2.0;
            else if (text == "D+") grade = 1.5;
            else if (text == "D0") grade = 1.0;
            else grade = 0;

            return grade;
        }

       
    }
}
