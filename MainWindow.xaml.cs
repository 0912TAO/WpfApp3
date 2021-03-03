using MaterialDesignThemes.Wpf;
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
using WpfApp3.View;
using WpfApp3.ViewModel;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var item5 = new ItemMenu("我的首页", null, PackIconKind.Regex);
            var menuRegister = new List<SubItem>
            {
                new SubItem("商品分类", new UserControlCustomers()),
                new SubItem("新增商品", new UserControlProviders()),
                new SubItem("商品列表", new GoodsControlProductList()),
                new SubItem("商品入库", new UserControlProviders()),
                new SubItem("商品出库", new LiveChartsControl()),
                new SubItem("库存列表", new UserControlProviders()),
                new SubItem("商品库存汇总", new UserControlCustomers()),
                new SubItem("出库入库明细", new UserControlProviders()),
                new SubItem("商品批量引入", new UserControlCustomers()),
                new SubItem("商品下架列表", new UserControlProviders())
            };
            var item6 = new ItemMenu("商品管理", menuRegister, PackIconKind.Shopping);
           

            var menuSchedule = new List<SubItem>
            {
                new SubItem("消费记录", new UserControlCustomers())
            };
            var item1 = new ItemMenu("记录明细", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>
            {
                new SubItem("店铺分析", new UserControlProviders()),
                new SubItem("商品销售", new UserControlCustomers())
            };
            var item2 = new ItemMenu("数据报表", menuReports, PackIconKind.FileReport);

            var menuExpenses = new List<SubItem>
            {
                new SubItem("店铺管理", new UserControlProviders()),
                new SubItem("角色管理", new UserControlCustomers()),
                new SubItem("用户管理", new UserControlProviders())
            };
            var item3 = new ItemMenu("门店管理", menuExpenses, PackIconKind.ShoppingBasket);

            var menuFinancial = new List<SubItem>
            {
                new SubItem("系统参数设置", new UserControlCustomers())
            };
            var item4 = new ItemMenu("系统管理", menuFinancial, PackIconKind.ScaleBalance);

            Menu.Children.Add(new UserControlMenuItem(item5, this));
            Menu.Children.Add(new UserControlMenuItem(item6, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
            Menu.Children.Add(new UserControlMenuItem(item4, this));
           
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }
    }
}
