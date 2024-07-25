using System;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace user_login
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (!disposing || components == null)
            {
                return;
            }
            components.Dispose();
            class Program
        {
            static void Main()
            {
                string savedUsername = "admin";
                string savedPassword = "12345";

                Console.WriteLine("Kullanıcı Adı:");
                string username = Console.ReadLine();

                Console.WriteLine("Şifre:");
                string password = Console.ReadLine();

                if (username == savedUsername && password == savedPassword)
                {
                    Console.WriteLine("Giriş başarılı!");

                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre yanlış!");
                }

            }
        }
    }
}


