﻿using EFSample.Models.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSample;
public partial class frmAddBook : Form
{
    public frmAddBook()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        AkademiLibraryContext db = new AkademiLibraryContext();

        //instance of Book class
        Book book = new Book();
        book.Name=txtName.Text;
        book.PublisherName=txtWriter.Text;

        db.Books.Add(book);
        db.SaveChanges();

        MessageBox.Show("Book Added Succesfully");

    }
}
