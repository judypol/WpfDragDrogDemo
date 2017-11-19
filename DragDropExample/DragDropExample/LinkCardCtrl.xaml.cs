using GongSolutions.Wpf.DragDrop;
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

namespace DragDropExample
{
    /// <summary>
    /// LinkCardCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class LinkCardCtrl
    {
        public LinkCardCtrl()
        {
            InitializeComponent();
            this.DataContext = new LinkCard();
        }
    }
}
