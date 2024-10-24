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
using TriangleApp;

namespace pr5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //вычисления периметра
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            double sideA = double.Parse(tb1.Text);
            double sideB = double.Parse(tb2.Text);
            double sideC = double.Parse(tb3.Text);
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            // Вычисление периметра и результат
            double perimeter = triangle.GetPerimeter();
            tbResult.Text = perimeter.ToString();
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            double sideA = double.Parse(tb1.Text);
            double sideB = double.Parse(tb2.Text);
            double sideC = double.Parse(tb3.Text);

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Увеличение треугольника в 2 раза
            triangle.SetParams(2);

            // Обновление
            tb1.Text = triangle.SideA.ToString();
            tb2.Text = triangle.SideB.ToString();
            tb3.Text = triangle.SideC.ToString();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина Екатерина";
            int job = 5;
            string task = "Создать класс Triangle (треугольник) с полями-сторонами. Создать необходимые \r\nметоды и свойства. Определить метод вычисления периметра. Создать \r\nперегруженные методы SetParams, для установки параметров объекта, в том числе \r\nувеличения размеров треугольника в 2 раза. ";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }

        // "Выход"
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
   