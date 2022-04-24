namespace TareaSemanSanta2
{
    public partial class Form1 : Form
    {
        string[] nombres = { "Juan","Leon", "Estuardo","Ferando","Manuel","Sara","Raul","Andres","Gabriel",
                      "Saul","Nery", "Ana","Maria","Pablo","Jose","Felipe","Daniel","Joel","Ramon","Mariela"};
        string[] premiosArr = { "Vaca", "Cerdo sin pierna", "Pierna de cerdo" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = 0;
            n2 = nombres.Length - 1;
            int tombola1 = 0, tombola2 = 0, tombola3 = 0;

            Random r = new Random();
            
            string p1 = premiosArr[0], p2 = premiosArr[1], p3 = premiosArr[2];

            tombola1 = r.Next(n1, n2);
            tombola2 = r.Next(n1, n2);
            tombola3 = r.Next(n1, n2);

            while (tombola1 == tombola2)
            {
                tombola2 = r.Next(n1, n2);

            }
            while (tombola1 == tombola3)
            {
                tombola3 = r.Next(n1, n2);
            }
            while (tombola2 == tombola3)
            {
                tombola3 = r.Next(n1, n2);
            }
            label1.Text = $"Premio Numero 1 {p1}";
            label2.Text = $"Ganador : { nombres[tombola1]}";
            label3.Text = $"Premio Numero 2 {p2}";
            label4.Text = $"Ganador : { nombres[tombola2]}";
            label5.Text = $"Premio Numero 3 {p3}";
            label6.Text = $"Ganador : { nombres[tombola3]}";
        }
    }
}