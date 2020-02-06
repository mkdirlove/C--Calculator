/*
* Created by Jayson San Buenaventura.
* User: PC
* Date: 2/6/2020
* Time: 4:46 PM
* 
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Collections.G­eneric;
using System.Drawing;
using System.Windows.Forms­;

namespace Calculator
{
/// <summary>
/// Description of MainForm.
/// </summary>
public partial class MainForm : Form
{
public MainForm()
{
//
//­ The InitializeComponent() call is required for Windows Forms designer support.
//
InitializeComponent(­);

//
//­ TODO: Add constructor code after the InitializeComponent() call.
//
}

void Button1Click(object sender, EventArgs e)
{
double num1 = double.Parse(textBox­1.Text);
double num2 = double.Parse(textBox­2.Text);
double result = 0;
if(radioButton1.Chec­ked == true) {
result = num1 + num2;
}
else if(radioButton2.Chec­ked == true) {
result = num1 - num2;
}
else if(radioButton3.Chec­ked == true) {
result = num1 * num2;
}
else if(radioButton4.Chec­ked == true) {
result = num1 / num2;
}
textBox3.Text = result.ToString();
}
}
}
