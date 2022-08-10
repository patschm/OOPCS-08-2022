using System.Windows.Forms;

namespace Knoppen;

internal class Program
{
    static void Main(string[] args)
    {
        Form f1 = new Form();
        f1.Width = 800;
        f1.Height = 600;

        Button b1 = new Button();
        b1.Text = "Click me";
        b1.Location = new Point(100, 100);
        f1.Controls.Add(b1);

        b1.Click += DoeIets;


        f1.ShowDialog();
    }

    static void DoeIets(object? sender, EventArgs e)
    {
        (sender as Button)!.Parent.BackColor = Color.Red;
        Console.WriteLine("Klik!!!");
    }
}