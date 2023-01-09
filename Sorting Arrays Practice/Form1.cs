namespace Sorting_Arrays_Practice
{
    public partial class Form1 : Form
    {
        int[] values = new int[5];
        Random random = new Random();
        int temp;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            for(int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(0,10);
                lstOutput.Items.Add(values[i]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < values.Length; i++)
            {
                for(int j = i; j < values.Length; j++)
                {
                    if (values[j] < values[i])
                    {
                        temp = values[j];
                        values[j] = values[i];
                        values[i] = temp;
                        lstOutput.Items.Clear();

                        for (int k = 0; k < values.Length; k++)
                        {
                            
                            lstOutput.Items.Add(values[k]);
                        }

                    }
                }
                

            }
        }
    }
}