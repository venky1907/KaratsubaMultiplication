using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KaratsubaMultiplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CallMul();
            
        }


        public void CallMul()
        {

            Multiplication mul = new Multiplication();
           double vaa=  mul.Karatsuba(123, 456, 4);

           Console.WriteLine("No of Single Digit multiplications is " + mul.val);
          //Till not the karastsuba multiplication is working fine but finer analysis is required for core understanding 

          //
        }
      
   


    }

    
}
