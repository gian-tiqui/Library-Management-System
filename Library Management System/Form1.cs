using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    class Book
    {
        private string title;
        private string content;
        private string id;
        private int lastPage;

        public Book(string title, string content, string id)
        {
            this.title = title;
            this.content = content;
            this.id = id;
            this.lastPage = 0;
        }


    }

    class Library
    {
        private string id;
        ArrayList<Book> books;
        public Library() 
        {
            
        }
    }

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
