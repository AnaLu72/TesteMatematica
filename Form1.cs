using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMatematica
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        private Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        private int addend1; //Soma
        private int addend2; //Soma

        // These integer variables store the numbers 
        // for the subtraction problem. 
        private int minuend; //Subtração
        private int subtrahend; //Subtração

        // These integer variables store the numbers 
        // for the multiplication problem. 
        private int multiplicand;  //Multiplicação
        private int multiplier;    //Multiplicação

        // These integer variables store the numbers 
        // for the division problem. 
        private int dividend; //Divisão
        private int divisor;  //Divisão
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private object dividedRightLabel;
        private object soma;

        public Form1(object sum) => this.soma = (NumericUpDown)soma;

        private readonly object quociente;

        public Form1(object quotient, NumericUpDown quociente, NumericUpDown soma, NumericUpDown sum)
        {
            this.quotient = quociente;
            this.quotient = quociente;
            this.soma = soma;
            this.soma = sum;
        }

        public Form1(object quociente, object quotient, NumericUpDown sum = null)
        {
            this.quotient = (NumericUpDown)quociente;
            this.quotient = (NumericUpDown)quociente;
            this.soma = sum;
        }



        // This integer variable keeps track of the 
        // remaining time.
        private readonly int timeLeft;

        public object GetQuociente() => quotient;

        public object GetSoma()
        {
            return soma;
        }



        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz(object quociente, object soma)
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            soma = 0b0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            
            dividedRightLabel = divisor.ToString();
            quociente = 0;

        }

            /// <summary>
            /// Check the answers to see if the user got everything right.
            /// </summary>
            /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer(bool v)
        {
            if (!v)
                return true;
            else
                return false;
        }

       

        private void startButton_Click(object sender, EventArgs e)
        {
            // Iniciar o questionário
            StartTheQuiz(GetQuociente(), GetSoma());
            startButton.Enabled = false; // Desativa o botão para evitar múltiplos inícios
        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<object>.Default.Equals(this.soma, form.soma);
        }
    }
}

