using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 04-05-2018 (Star Wars Day!!!!!!)
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - Find Max Value
 * This program randomly generates 10 numbers then adds them to an array. 
 * The function GetMaxValue then compares all of the number in the array to find the largest one.
*/

namespace FindMaxValueTivaR
{
    public partial class frmFindMaxValue : Form
    {
        public frmFindMaxValue()
        {
            InitializeComponent();
        }

        // Function: GetMaxValue
        // Input: int[] tmpArrayOfIntegers - assume all values in the array are greater than 0
        // Output: the max value in the array 
        // Description: This function accepts an array of integers,...
        // ... scans the array and returns the greatest value in the array.
        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            // Variables
            int tmpMaxValue = 0;
            const int MAX_ARRAY_SIZE = 10;

            // To cycle through array until it is all compared
            for (int counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                if (tmpMaxValue < tmpArrayOfIntegers[counter])
                {
                    // Set the max value to be equal to the current number
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }
            

            return tmpMaxValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants 
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

            // Clear list box
            this.lstNumberSet.Items.Clear();

            // To generate the numbers
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // Assign the random number to the cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                // add the random number to the list 
                this.lstNumberSet.Items.Add(randomNumber);

                // Refresh the form to display the new item in the list box
                this.Refresh();

                // To get the Max Value in the array
                maxValue = GetMaxValue(arrayOfIntegers);

                // Display the max value in the label
                this.lblMaxValue.Text = "The max value is: " + maxValue;
            }
        }
    }
}
