using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Statistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            richTextBoxAdv.Load(@"..\..\Assets\Statistics.docx");
            richTextBoxAdv.SelectionChanged += RichTextBoxAdv_SelectionChanged;
        }

        private void RichTextBoxAdv_SelectionChanged(object obj, Syncfusion.Windows.Controls.RichTextBoxAdv.SelectionChangedEventArgs args)
        {
            int wordCount = richTextBoxAdv.WordCount;
            WordCount.Text = wordCount.ToString();
            int paragraphCount = richTextBoxAdv.ParagraphCount;
            ParagraphCount.Text = paragraphCount.ToString();
            int pageCount = richTextBoxAdv.PageCount;
            PageCount.Text = pageCount.ToString();
            int currentPageNumber = richTextBoxAdv.CurrentPageNumber;
            CurrentPageNumber.Text = currentPageNumber.ToString();
        }
    }
}
