using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class txb_usuario : Form
    {
        public txb_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string text = ""; 
            //  int numeroint = 9;
            // double numeroquebrado = 0.0;
            // bool validacao = false;


            string contaOn = tex_usuario.Text;
            string senhaConta = tex_senha.Text;

            if (contaOn == "edilsonBispo" && senhaConta == "1234") 
            {
                MessageBox.Show("Você entro na sua conta");
            }

            else if (contaOn != "edilsonBispo" && senhaConta == "1234")
            {
                MessageBox.Show(" Conta incorreta");
            }

            else if (contaOn == "edilsonBispo" && senhaConta != "1234")
            {
                MessageBox.Show(" Senha incorreta");
            }

            else
            {
                MessageBox.Show(" Usuario não encontrado");
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_loop_Click(object sender, EventArgs e)
        {
           // int contador = 35;


            //  for (int contador = 2 ; contador <= 15; contador = contador + 2 )
            //{

            //MessageBox.Show(contador.ToString());

            //}


            //Para fazer uma contagem decrescente em C#, você pode usar um loop while ou for.
            //Aqui está um exemplo de como fazer isso usando um loop while:


            //  int count = 10;
            //  while (count > 0)
            // {
            //     Console.WriteLine(count);
            //     count--;
            //}


           // do
           // {
            //    MessageBox.Show(contador.ToString());
              //  contador--;

           // } while (contador >= 6);


              for (int contador = 35 ; contador >= 6; contador -- ) {


                    if (contador % 2 == 0) {
                        MessageBox.Show(contador.ToString(contador + "   O numero é impar"));

                       // MessageBox.Show(contador.ToString("O numero é impar"));
                    }

                    else
                    {
                        MessageBox.Show(contador.ToString(contador + "   O numero é par"));
                        //MessageBox.Show(contador.ToString("O numero é par"));
                    }
              }



        }
    }
}
